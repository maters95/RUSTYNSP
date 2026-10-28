using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Ionic.Zip;

namespace NexmapUnlock;

/// <summary>
/// Core logic for removing password protection from Haltech NSP .nexmap files.
///
/// A .nexmap is a ZIP archive whose every entry is encrypted with WinZip AES-256
/// using a single fixed, application-embedded password (identical for every file
/// NSP produces). The per-tuner "password protection" is NOT the ZIP password; it
/// lives inside the plaintext "_map" XML entry as three fields plus an integrity
/// hash:
///   * &lt;IsProtected id="8"&gt;      00 = open, 01 = protected
///   * &lt;Password id="1503"&gt;      MD5 of the tuner's chosen password (zeroed when open)
///   * &lt;G id="9496"&gt;            4096-byte bitmap of which settings are locked
///   * &lt;MD5&gt;                     integrity hash over the concatenated raw bytes
///                                  of every id-bearing setting element
///
/// Unlocking = reset the three protection fields to their "open" state and
/// recompute the integrity &lt;MD5&gt; so NSP accepts the file. The archive is then
/// repacked with the same fixed AES-256 password so NSP can read it normally.
/// </summary>
public static class NexmapUnlocker
{
    /// <summary>The single fixed password NSP uses for WinZip AES-256 on every entry.</summary>
    public static readonly string ArchivePassword = ComputeArchivePassword();

    private const string MapEntryName = "_map";

    // Regexes operate on the exact serialized XML so we preserve NSP's byte-for-byte
    // formatting (indentation, element order) and only touch the fields we must.
    private static readonly Regex IsProtectedRx =
        new("(<IsProtected id=\"8\" attrId=\"0\">)[0-9A-Fa-f]*(</IsProtected>)", RegexOptions.Compiled);
    private static readonly Regex PasswordRx =
        new("(<Password id=\"1503\" attrId=\"0\">)[0-9A-Fa-f]*(</Password>)", RegexOptions.Compiled);
    private static readonly Regex ProtectBitmapRx =
        new("(<G id=\"9496\" attrId=\"0\">)([0-9A-Fa-f]*)(</G>)", RegexOptions.Compiled);
    private static readonly Regex Md5Rx =
        new("(<MD5>)[0-9A-Fa-f]*(</MD5>)", RegexOptions.Compiled);
    private static readonly Regex IsProtectedValueRx =
        new("<IsProtected id=\"8\" attrId=\"0\">([0-9A-Fa-f]*)</IsProtected>", RegexOptions.Compiled);
    // Matches any setting element that carries an id attribute and a hex payload,
    // in document order. Used to rebuild the integrity hash exactly as NSP does.
    private static readonly Regex SettingRx =
        new("<([A-Za-z_][A-Za-z0-9_]*)\\s+id=\"\\d+\"[^>]*>([0-9A-Fa-f]*)</\\1>", RegexOptions.Compiled);

    public sealed record InspectResult(bool IsProtected, bool HasMap);

    public sealed record UnlockResult(bool WasProtected, string OutputPath);

    /// <summary>
    /// Reports whether the given .nexmap is currently password protected.
    /// </summary>
    public static InspectResult Inspect(string inputPath)
    {
        byte[] mapXml = ReadMapEntry(inputPath, out _);
        if (mapXml.Length == 0)
            return new InspectResult(false, false);

        string text = DecodeMapText(mapXml, out _);
        return new InspectResult(ReadIsProtected(text), true);
    }

    /// <summary>
    /// Produces an unlocked copy of the .nexmap at <paramref name="outputPath"/>.
    /// If the map is not protected the archive is still rewritten (a faithful copy),
    /// and <see cref="UnlockResult.WasProtected"/> is false.
    /// </summary>
    public static UnlockResult Unlock(string inputPath, string outputPath)
    {
        // Read and decrypt every entry with the fixed archive password.
        var entries = new List<(string Name, byte[] Data)>();
        bool wasProtected = false;

        using (var zip = ZipFile.Read(inputPath))
        {
            zip.Password = ArchivePassword;
            foreach (ZipEntry entry in zip)
            {
                if (entry.IsDirectory)
                    continue;

                byte[] data;
                using (var ms = new MemoryStream())
                {
                    entry.ExtractWithPassword(ms, ArchivePassword);
                    data = ms.ToArray();
                }

                if (string.Equals(entry.FileName, MapEntryName, StringComparison.Ordinal))
                    data = UnlockMapXml(data, out wasProtected);

                entries.Add((entry.FileName, data));
            }
        }

        // Repack with the same WinZip AES-256 password so NSP reads it normally.
        var outDir = Path.GetDirectoryName(Path.GetFullPath(outputPath));
        if (!string.IsNullOrEmpty(outDir))
            Directory.CreateDirectory(outDir);

        using (var zip = new ZipFile())
        {
            zip.Password = ArchivePassword;
            zip.Encryption = EncryptionAlgorithm.WinZipAes256;
            zip.EmitTimesInWindowsFormatWhenSaving = true;
            foreach (var (name, data) in entries)
                zip.AddEntry(name, data);

            // NSP stamps a fixed timestamp on entries; mirror that for a clean diff.
            var stamp = new DateTime(1982, 1, 24, 10, 23, 0, DateTimeKind.Unspecified);
            foreach (ZipEntry e in zip)
                e.SetEntryTimes(stamp, stamp, stamp);

            zip.Save(outputPath);
        }

        return new UnlockResult(wasProtected, outputPath);
    }

    /// <summary>
    /// Applies the unlock transform to the decrypted _map XML bytes:
    /// resets the protection fields and recomputes the integrity MD5.
    /// </summary>
    public static byte[] UnlockMapXml(byte[] mapXml, out bool wasProtected)
    {
        string text = DecodeMapText(mapXml, out bool hadBom);
        wasProtected = ReadIsProtected(text);

        text = PasswordRx.Replace(text, m => m.Groups[1].Value + new string('0', 32) + m.Groups[2].Value);
        text = IsProtectedRx.Replace(text, m => m.Groups[1].Value + "00" + m.Groups[2].Value);
        text = ProtectBitmapRx.Replace(text,
            m => m.Groups[1].Value + new string('0', m.Groups[2].Value.Length) + m.Groups[3].Value);

        // Recompute the integrity hash over the (now-modified) setting payloads.
        string integrity = ComputeIntegrityMd5(text);
        string integrityHex = ToHexAscii(integrity);
        text = Md5Rx.Replace(text, m => m.Groups[1].Value + integrityHex + m.Groups[2].Value, 1);

        var body = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false).GetBytes(text);
        if (!hadBom)
            return body;

        var withBom = new byte[body.Length + 3];
        withBom[0] = 0xEF; withBom[1] = 0xBB; withBom[2] = 0xBF;
        Buffer.BlockCopy(body, 0, withBom, 3, body.Length);
        return withBom;
    }

    private static bool ReadIsProtected(string mapText)
    {
        Match m = IsProtectedValueRx.Match(mapText);
        if (!m.Success)
            return false;
        string v = m.Groups[1].Value.TrimStart('0');
        return v.Length > 0; // any non-zero value means protected
    }

    /// <summary>
    /// NSP's integrity hash: MD5 over the concatenation of the raw bytes of every
    /// id-bearing setting element, in document order (uppercase hex string).
    /// </summary>
    private static string ComputeIntegrityMd5(string mapText)
    {
        using var buffer = new MemoryStream();
        foreach (Match m in SettingRx.Matches(mapText))
        {
            string hex = m.Groups[2].Value;
            if (hex.Length == 0 || (hex.Length & 1) != 0)
                continue;
            for (int i = 0; i < hex.Length; i += 2)
                buffer.WriteByte(Convert.ToByte(hex.Substring(i, 2), 16));
        }

        byte[] hash = MD5.HashData(buffer.ToArray());
        var sb = new StringBuilder(hash.Length * 2);
        foreach (byte b in hash)
            sb.AppendFormat("{0:X2}", b);
        return sb.ToString();
    }

    private static byte[] ReadMapEntry(string inputPath, out bool found)
    {
        using var zip = ZipFile.Read(inputPath);
        zip.Password = ArchivePassword;
        foreach (ZipEntry entry in zip)
        {
            if (!string.Equals(entry.FileName, MapEntryName, StringComparison.Ordinal))
                continue;
            using var ms = new MemoryStream();
            entry.ExtractWithPassword(ms, ArchivePassword);
            found = true;
            return ms.ToArray();
        }
        found = false;
        return Array.Empty<byte>();
    }

    private static string DecodeMapText(byte[] mapXml, out bool hadBom)
    {
        if (mapXml.Length >= 3 && mapXml[0] == 0xEF && mapXml[1] == 0xBB && mapXml[2] == 0xBF)
        {
            hadBom = true;
            return new UTF8Encoding(false).GetString(mapXml, 3, mapXml.Length - 3);
        }
        hadBom = false;
        return new UTF8Encoding(false).GetString(mapXml);
    }

    private static string ToHexAscii(string ascii)
    {
        var sb = new StringBuilder(ascii.Length * 2);
        foreach (char c in ascii)
            sb.AppendFormat("{0:X2}", (byte)c);
        return sb.ToString();
    }

    /// <summary>
    /// Derives the fixed WinZip AES password NSP embeds. It is the uppercase MD5
    /// hex of a constant string assembled from obfuscated literals in NSP
    /// (A.M.A()). The literals are reproduced here so no NSP binary is required.
    /// </summary>
    private static string ComputeArchivePassword()
    {
        const string p0 = "Incorrect";
        string seed = "Maybe" + $"{"Nissian" + p0}-{"Off by" + p0}-{"Toyota" + p0}";
        byte[] hash = MD5.HashData(Encoding.ASCII.GetBytes(seed));
        var sb = new StringBuilder(hash.Length * 2);
        foreach (byte b in hash)
            sb.AppendFormat("{0:X2}", b);
        return sb.ToString();
    }
}
