using System;
using System.IO;

namespace NSP;

internal static class ResourceUpload
{
	internal static void Send(byte[] payload, int chunkSize, Action<uint, byte[]> write,
		Action<long, long> progress = null, Func<bool> cancelled = null)
	{
		if (chunkSize <= 0)
			throw new IOException("The device did not advertise a usable resource transfer size.");
		long offset = 0;
		progress?.Invoke(0, payload.LongLength);
		do
		{
			if (cancelled?.Invoke() == true)
				throw new OperationCanceledException("Resource upload cancelled.");
			int count = (int)Math.Min(chunkSize, payload.LongLength - offset);
			byte[] fragment = new byte[count];
			Array.Copy(payload, offset, fragment, 0L, count);
			write(checked((uint)offset), fragment);
			offset += count;
			progress?.Invoke(offset, payload.LongLength);
		}
		while (offset < payload.LongLength);
	}
}
