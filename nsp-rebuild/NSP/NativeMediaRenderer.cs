using System;
using System.Buffers.Binary;
using System.Diagnostics;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

namespace NSP;

internal static class NativeMediaRenderer
{
	internal const string ComponentResource = "NSP.Media.HalImage.qml";
	internal const string StockComponentHash = "32BAF88AC62D670E905BC30FD6C4DCB7ABDBFC4A9C3B248254B98FDD07F5C6FB";

	internal static readonly string[] RuntimeFiles =
	{
		"bin/Qt5Multimedia.dll",
		"bin/Qt5MultimediaQuick.dll",
		"bin/Qt5Widgets.dll",
		"qml/QtMultimedia/qmldir",
		"qml/QtMultimedia/Video.qml",
		"qml/QtMultimedia/declarative_multimedia.dll",
		"plugins/mediaservice/dsengine.dll",
		"plugins/imageformats/qgif.dll"
	};

	internal static void ValidateLibrary(string path)
	{
		using FileStream file = File.OpenRead(path);
		using PEReader pe = new PEReader(file);
		if (pe.PEHeaders.CoffHeader.Machine != Machine.I386 || pe.PEHeaders.PEHeader == null)
		{
			throw new InvalidDataException("Native media requires Windows x86 DLLs: " + path);
		}
		DirectoryEntry directory = pe.PEHeaders.PEHeader.ResourceTableDirectory;
		ReadOnlySpan<byte> resources = pe.GetSectionData(directory.RelativeVirtualAddress).GetContent(0, directory.Size).AsSpan();
		int versionType = ResourceEntry(resources, 0, 16);
		int versionName = ResourceEntry(resources, ResourceDirectory(versionType), null);
		int versionLanguage = ResourceEntry(resources, ResourceDirectory(versionName), null);
		if (versionLanguage < 0)
		{
			throw new InvalidDataException("Invalid Windows version resource: " + path);
		}
		int dataRva = BinaryPrimitives.ReadInt32LittleEndian(resources.Slice(versionLanguage, 4));
		int dataSize = BinaryPrimitives.ReadInt32LittleEndian(resources.Slice(versionLanguage + 4, 4));
		ReadOnlySpan<byte> version = pe.GetSectionData(dataRva).GetContent(0, dataSize).AsSpan();
		// VS_VERSIONINFO's fixed value follows its DWORD-aligned UTF-16 key.
		if (version.Length < 92
			|| BinaryPrimitives.ReadUInt32LittleEndian(version.Slice(40, 4)) != 0xFEEF04BD
			|| BinaryPrimitives.ReadUInt32LittleEndian(version.Slice(48, 4)) != 0x0005000B
			|| BinaryPrimitives.ReadUInt32LittleEndian(version.Slice(52, 4)) >> 16 != 3)
		{
			throw new InvalidDataException("Native media requires Qt 5.11.3 x86: " + path);
		}
	}

	private static int ResourceDirectory(int entry)
	{
		if (entry >= 0)
		{
			throw new InvalidDataException("Expected a Windows resource directory.");
		}
		return entry & int.MaxValue;
	}

	private static int ResourceEntry(ReadOnlySpan<byte> resources, int directory, int? id)
	{
		int count = BinaryPrimitives.ReadUInt16LittleEndian(resources.Slice(directory + 12, 2))
			+ BinaryPrimitives.ReadUInt16LittleEndian(resources.Slice(directory + 14, 2));
		for (int index = 0; index < count; index++)
		{
			int offset = directory + 16 + index * 8;
			if (id == null || BinaryPrimitives.ReadInt32LittleEndian(resources.Slice(offset, 4)) == id)
			{
				return BinaryPrimitives.ReadInt32LittleEndian(resources.Slice(offset + 4, 4));
			}
		}
		throw new InvalidDataException("The Qt DLL has no Windows version resource.");
	}

	internal static void InstallComponent(string runtimeDirectory)
	{
		string target = Path.Combine(runtimeDirectory, "qml_components_data", "qml", "user_components", "HalImage.qml");
		using Stream resource = typeof(NativeMediaRenderer).Assembly.GetManifestResourceStream(ComponentResource)
			?? throw new InvalidOperationException("The native media component is missing from NSP.dll.");
		using MemoryStream buffer = new MemoryStream();
		resource.CopyTo(buffer);
		byte[] component = buffer.ToArray();
		byte[] original = File.ReadAllBytes(target);
		string hash = Convert.ToHexString(SHA256.HashData(original));
		if (hash != StockComponentHash && hash != Convert.ToHexString(SHA256.HashData(component)))
		{
			throw new InvalidDataException("HalImage.qml differs from the verified iC-7 v2.36 component. No override was installed.");
		}
		// The HDEF re-extracts stock QML whenever a map is opened.
		if (!original.AsSpan().SequenceEqual(component))
		{
			File.WriteAllBytes(target, component);
		}
		File.Delete(target + "c");
	}

	internal static void Prepare(ProcessStartInfo startInfo, string addonDirectory)
	{
		string runtime = startInfo.WorkingDirectory;
		ValidateLibrary(Path.Combine(runtime, "Qt5Core.dll"));
		foreach (string relative in RuntimeFiles)
		{
			string source = Path.Combine(addonDirectory, relative);
			if (!File.Exists(source))
			{
				throw new FileNotFoundException("Native media runtime is incomplete. Run setup-native-media.ps1 from the matching bundle.", source);
			}
			if (relative.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
			{
				ValidateLibrary(source);
			}
		}
		foreach (string relative in RuntimeFiles)
		{
			string destination = relative.StartsWith("bin/", StringComparison.Ordinal)
				? Path.Combine(runtime, relative.Substring(4))
				: Path.Combine(runtime, "ic7-media-" + relative);
			Directory.CreateDirectory(Path.GetDirectoryName(destination));
			File.Copy(Path.Combine(addonDirectory, relative), destination, overwrite: true);
		}
		InstallComponent(runtime);
		PrependPath(startInfo, "QML2_IMPORT_PATH", Path.Combine(runtime, "ic7-media-qml"));
		PrependPath(startInfo, "QT_PLUGIN_PATH", Path.Combine(runtime, "ic7-media-plugins"));
	}

	private static void PrependPath(ProcessStartInfo info, string name, string path)
	{
		info.Environment.TryGetValue(name, out string existing);
		info.Environment[name] = string.IsNullOrEmpty(existing) ? path : path + Path.PathSeparator + existing;
	}
}
