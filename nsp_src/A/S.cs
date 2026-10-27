using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using _003CPrivateImplementationDetails_003E_007BFC4AF036_002D6EEB_002D4D18_002DBB86_002D111E4ADA7E6E_007D;
using Microsoft.Win32;

namespace A;

internal static class S
{
	private static byte[] DJ;

	internal static byte[] Dj;

	internal static void A(byte[] P_0, string P_1, Stream P_2, byte[] P_3)
	{
		P_2.Write(DJ, 0, DJ.Length);
		r.A(P_0, P_1, P_2, P_3);
	}

	internal static void A(string P_0, string P_1)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (!File.Exists(P_0))
		{
			return;
		}
		string text = Path.GetFileNameWithoutExtension(P_0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CA() + Path.GetExtension(P_0);
		string text2 = Path.GetDirectoryName(P_0) + D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.bj() + text;
		FileStream val = null;
		try
		{
			val = new FileStream(text2, (FileMode)2, (FileAccess)2);
			((Stream)val).Write(DJ, 0, DJ.Length);
			r.A(File.ReadAllBytes(P_0), P_1, (Stream)(object)val, Dj);
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Ca() + ex.Message, true);
		}
		finally
		{
			if (val != null)
			{
				((Stream)val).Close();
				((Stream)val).Dispose();
			}
		}
		if (File.Exists(text2))
		{
			File.Delete(P_0);
			File.Move(text2, P_0);
		}
	}

	internal static bool A(string P_0)
	{
		byte[] array = File.ReadAllBytes(P_0);
		if (array != null && array.Length != 0)
		{
			return A(array);
		}
		return false;
	}

	internal static bool A(byte[] P_0)
	{
		int num = 0;
		for (num = 0; num < DJ.Length && num < P_0.Length; num++)
		{
			if (P_0[num] != DJ[num])
			{
				return false;
			}
		}
		return num == DJ.Length;
	}

	internal static bool A(Stream P_0)
	{
		long position = P_0.Position;
		P_0.Seek(0L, (SeekOrigin)0);
		bool result = true;
		for (int num = 0; num < DJ.Length; num++)
		{
			if (P_0.ReadByte() != DJ[num])
			{
				result = false;
				break;
			}
		}
		P_0.Seek(position, (SeekOrigin)0);
		return result;
	}

	internal static void A(byte[] P_0, string P_1, Stream P_2)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		if (!A(P_0))
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CB());
		}
		r.A((Stream)new MemoryStream(P_0)
		{
			Position = DJ.Length
		}, P_1, P_2);
	}

	internal static void A(Stream P_0, string P_1, Stream P_2)
	{
		if (!A(P_0))
		{
			throw new System.Exception(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CB());
		}
		P_0.Position = DJ.Length;
		r.A(P_0, P_1, P_2);
	}

	internal static MemoryStream a(string P_0, string P_1)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		byte[] array = File.ReadAllBytes(P_0);
		MemoryStream val = null;
		if (A(array))
		{
			val = new MemoryStream(array.Length);
			A(array, P_1, (Stream)(object)val);
		}
		else
		{
			val = new MemoryStream(array);
		}
		return val;
	}

	internal static Stream A(Stream P_0, string P_1)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		Stream val = P_0;
		if (A(P_0))
		{
			val = (Stream)new MemoryStream();
			A(P_0, P_1, val);
		}
		return val;
	}

	static S()
	{
		byte[] array = new byte[5];
		RuntimeHelpers.InitializeArray((System.Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		DJ = array;
		byte[] array2 = new byte[16];
		RuntimeHelpers.InitializeArray((System.Array)array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		Dj = array2;
	}
}
internal class s
{
	public enum A
	{
		BHd,
		BHE
	}

	public static A DL;

	public static void A()
	{
		int? num = a();
		if (num.HasValue)
		{
			DL = (A)num.Value;
			return;
		}
		if (RegionInfo.CurrentRegion.IsMetric)
		{
			DL = s.A.BHd;
		}
		else
		{
			DL = s.A.BHE;
		}
		A(DL);
	}

	private static int? a()
	{
		int? result = null;
		try
		{
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.OpenSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb());
				try
				{
					if (val2 != null)
					{
						object value = val2.GetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CC());
						if (value != null && value.GetType() == typeof(int))
						{
							result = (int)value;
							return result;
						}
						return result;
					}
					N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cc(), true);
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CD() + ex.Message, true);
		}
		return result;
	}

	private static void A(A P_0)
	{
		try
		{
			RegistryKey val = RegistryKey.OpenBaseKey((RegistryHive)(-2147483647), (RegistryView)0);
			try
			{
				RegistryKey val2 = val.CreateSubKey(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cb(), true);
				try
				{
					if (val2 != null)
					{
						val2.SetValue(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CC(), (object)(int)P_0);
					}
					else
					{
						N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.Cd(), true);
					}
				}
				finally
				{
					((System.IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)val)?.Dispose();
			}
		}
		catch (System.Exception ex)
		{
			N.A(D2194834_002DF190_002D4B4E_002D8906_002D0A2F9B069A77.CE() + ex.Message, true);
		}
	}
}
