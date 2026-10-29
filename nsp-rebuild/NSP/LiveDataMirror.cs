using System;
using System.IO.MemoryMappedFiles;
using System.Threading;

namespace NSP;

// Publishes the exact live-data block NSP sends to its own dash renderer (device data, or the
// Simulate panel's values) so a local iC-7 emulator renderer can show the same alarms and gauges.
// Read-only for consumers; nothing is sent to a dash.
internal static class LiveDataMirror
{
	internal const string MappingName = "Local\\HaltechNSP_iC7_LiveData";
	internal const int Magic = 0x4C374349; // "IC7L"
	internal const int HeaderSize = 32;
	internal const int MaximumPayload = 65536;
	private static readonly object Gate = new object();
	private static MemoryMappedFile mapping;
	private static MemoryMappedViewAccessor view;
	private static int sequence;
	private static bool unavailable;

	internal static void Publish(int address, byte[] block, int length, bool simulating)
	{
		if (block == null || length <= 0 || length > block.Length || length > MaximumPayload || unavailable)
			return;
		lock (Gate)
		{
			try
			{
				if (view == null)
				{
					mapping = MemoryMappedFile.CreateOrOpen(MappingName, HeaderSize + MaximumPayload);
					view = mapping.CreateViewAccessor(0, HeaderSize + MaximumPayload);
					view.Write(0, Magic);
					view.Write(4, 1);
				}
				// Sequence lock: odd while writing, even when the block is complete.
				view.Write(8, sequence + 1);
				Thread.MemoryBarrier();
				view.Write(12, address);
				view.Write(16, length);
				view.Write(20, simulating ? 1 : 0);
				view.Write(24, DateTime.UtcNow.Ticks);
				view.WriteArray(HeaderSize, block, 0, length);
				Thread.MemoryBarrier();
				sequence += 2;
				view.Write(8, sequence);
			}
			catch (Exception error)
			{
				unavailable = true;
				ns0.Class23.smethod_3("iC-7 live-data mirror disabled: " + error.Message, bool_1: false);
			}
		}
	}
}
