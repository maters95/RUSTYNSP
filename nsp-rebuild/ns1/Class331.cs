using System;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using crc;
using ns0;
using ns7;

namespace ns1;

internal class Class331
{
	private const uint BEA = uint.MaxValue;

	private const int BEa = 1000;

	private const int BEB = 10;

	private const int BEb = 1000;

	private string BEC;

	private NamedPipeServerStream BEc;

	private Mutex BED = new Mutex();

	private bool BEd;

	internal bool method_0()
	{
		if (BEd && BEc != null)
		{
			return BEc.IsConnected;
		}
		return false;
	}

	internal Class331(string string_0)
	{
		BEC = string_0;
	}

	~Class331()
	{
		method_3();
	}

	internal void method_1()
	{
		method_2();
	}

	internal void method_2()
	{
		try
		{
			if (BEc != null)
			{
				BEc.Close();
				BEc = null;
			}
			BEc = new NamedPipeServerStream(BEC, PipeDirection.InOut, 1, PipeTransmissionMode.Byte, PipeOptions.Asynchronous);
			if (BEc != null && !BEc.IsConnected)
			{
				BEc.WaitForConnectionAsync().Wait(1000);
				BEd = BEc != null && BEc.IsConnected;
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.azH() + ex.Message);
		}
	}

	internal void method_3()
	{
		if (BEc != null)
		{
			try
			{
				if (BEc.IsConnected)
				{
					BEc.Flush();
				}
			}
			catch (Exception ex)
			{
				Class23.smethod_3(Class333.azh() + ex.Message);
			}
			try
			{
				BEc.Close();
			}
			catch (Exception ex2)
			{
				Class23.smethod_3(Class333.azh() + ex2.Message);
			}
		}
		BEc = null;
		BEd = false;
	}

	internal bool method_4(byte[] byte_0, int int_0, int int_1, int int_2, bool bool_0 = false)
	{
		int millisecondsTimeout = (bool_0 ? 1000 : 10);
		bool result = false;
		try
		{
			if (BED.WaitOne(millisecondsTimeout))
			{
				if (BEc != null && BEc.IsConnected && byte_0.Length != 0)
				{
					byte[] array = new byte[Class329.BdW];
					array[0] = 1;
					array[1] = 0;
					array[2] = 0;
					array[3] = 0;
					byte[] bytes = BitConverter.GetBytes(int_2 + int_0);
					Array.Reverse(bytes);
					array[4] = (byte)(bytes[0] & 0xFF);
					array[5] = (byte)(bytes[1] & 0xFF);
					array[6] = (byte)(bytes[2] & 0xFF);
					array[7] = (byte)(bytes[3] & 0xFF);
					byte[] bytes2 = BitConverter.GetBytes(int_1);
					Array.Reverse(bytes2);
					array[8] = (byte)(bytes2[0] & 0xFF);
					array[9] = (byte)(bytes2[1] & 0xFF);
					array[10] = (byte)(bytes2[2] & 0xFF);
					array[11] = (byte)(bytes2[3] & 0xFF);
					Array.Copy(byte_0, int_0, array, 12, int_1);
					int num = 12 + int_1;
					byte[] bytes3 = BitConverter.GetBytes(new global::crc.crc().crc_process(array, 0u, (uint)num, uint.MaxValue, partial: false));
					Array.Reverse(bytes3);
					array[num++] = (byte)(bytes3[0] & 0xFF);
					array[num++] = (byte)(bytes3[1] & 0xFF);
					array[num++] = (byte)(bytes3[2] & 0xFF);
					array[num++] = (byte)(bytes3[3] & 0xFF);
					BEc.Write(array, 0, num);
					BEc.Flush();
					BEc.WaitForPipeDrain();
					result = method_5();
				}
				BED.ReleaseMutex();
			}
		}
		catch (Exception ex)
		{
			BED.ReleaseMutex();
			Class23.smethod_3(Class333.azI() + ex.Message);
		}
		return result;
	}

	internal bool method_5()
	{
		bool flag = true;
		try
		{
			if (BEc != null && BEc.IsConnected)
			{
				byte[] array = new byte[16];
				Task<int> task = BEc.ReadAsync(array, 0, 16);
				if (Task.WhenAny(task, Task.Delay(1000)).Result == task)
				{
					uint num = new global::crc.crc().crc_process(array, 0u, 12u, uint.MaxValue, partial: false);
					uint num2 = (uint)((array[12] << 24) | (array[13] << 16) | (array[14] << 8) | array[15]);
					flag = (flag &= num == num2) & ((array[0] & 0x80) == 0);
					if (num2 != num)
					{
						DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
						defaultInterpolatedStringHandler.AppendLiteral(Class333.azi());
						defaultInterpolatedStringHandler.AppendFormatted(num2);
						defaultInterpolatedStringHandler.AppendLiteral(Class333.azJ());
						defaultInterpolatedStringHandler.AppendFormatted(num);
						Class23.smethod_3(defaultInterpolatedStringHandler.ToStringAndClear());
					}
				}
				else
				{
					int millisecond = DateTime.Now.Millisecond;
					task.Wait();
					int num3 = DateTime.Now.Millisecond - millisecond;
					flag = false;
					Class23.smethod_3(Class333.azj() + num3);
				}
			}
		}
		catch (Exception ex)
		{
			Class23.smethod_3(Class333.azK() + ex.Message);
		}
		return flag;
	}

	internal bool method_6()
	{
		uint num = 3u;
		bool result = false;
		while (num != 0)
		{
			byte[] array = new byte[2] { 0, 19 };
			if (result = method_4(array, 0, array.Length, 0, bool_0: true))
			{
				break;
			}
			num--;
		}
		return result;
	}

	internal bool method_7()
	{
		uint num = 3u;
		bool result = false;
		byte b = 22;
		while (num != 0 && BEc != null && BEc.IsConnected)
		{
			byte[] array = new byte[2] { 0, b };
			if (result = method_4(array, 0, array.Length, 0, bool_0: true))
			{
				break;
			}
			num--;
		}
		return result;
	}

	internal bool method_8()
	{
		uint num = 3u;
		bool result = false;
		byte b = 23;
		while (num != 0 && BEc != null && BEc.IsConnected)
		{
			byte[] array = new byte[2] { 0, b };
			if (result = method_4(array, 0, array.Length, 0, bool_0: true))
			{
				break;
			}
			num--;
		}
		return result;
	}
}
