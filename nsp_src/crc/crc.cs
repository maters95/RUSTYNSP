using System;
using System.Runtime.CompilerServices;

namespace crc;

public class crc
{
	private static uint[,] E;

	private bool e;

	private bool F;

	private bool f;

	public crc()
		: this(reflect_in: true, reflect_out: true, invert: true)
	{
	}

	public crc(bool reflect_in, bool reflect_out, bool invert)
	{
		e = reflect_in;
		F = reflect_out;
		f = invert;
	}

	public uint crc_process(byte[] data, uint start_index, uint num_bytes, uint init, bool partial)
	{
		uint num = init;
		for (uint num2 = 0u; num2 < num_bytes; num2++)
		{
			byte b = (byte)(a(data[start_index + num2]) ^ (num & 0xFFu));
			num = E[0, b] ^ (num >> 8);
		}
		if (!partial)
		{
			num = B(C(num));
		}
		return num;
	}

	private byte A(byte P_0)
	{
		int num = 8;
		int num2 = -1;
		while ((num >>= 1) > 0)
		{
			num2 ^= num2 << num;
			P_0 = (byte)(((P_0 >> num) & num2) | ((P_0 << num) & ~num2));
		}
		return P_0;
	}

	private uint A(uint P_0)
	{
		int num = 32;
		int num2 = -1;
		while ((num >>= 1) > 0)
		{
			num2 ^= num2 << num;
			P_0 = (uint)(((P_0 >> num) & num2) | ((P_0 << num) & ~num2));
		}
		return P_0;
	}

	private uint a(uint P_0)
	{
		uint num = 0u;
		for (int i = 0; i < 4; i++)
		{
			num |= (uint)(A((byte)((P_0 >> i * 8) & 0xFFu)) << i * 8);
		}
		return num;
	}

	private uint B(uint P_0)
	{
		if (f)
		{
			P_0 ^= 0xFFFFFFFFu;
		}
		return P_0;
	}

	private uint b(uint P_0)
	{
		if (!e)
		{
			P_0 = a(P_0);
		}
		return P_0;
	}

	private byte a(byte P_0)
	{
		if (!e)
		{
			P_0 = A(P_0);
		}
		return P_0;
	}

	private uint C(uint P_0)
	{
		if (!F)
		{
			P_0 = A(P_0);
		}
		return P_0;
	}

	static crc()
	{
		uint[,] array = new uint[4, 256];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		E = array;
	}
}
