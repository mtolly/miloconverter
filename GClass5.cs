using System;

public class GClass5
{
	public static byte[] smethod_0(int int_0)
	{
		byte[] bytes = BitConverter.GetBytes(int_0);
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(bytes);
		}
		return bytes;
	}

	public static int smethod_1(byte[] byte_0)
	{
		if (BitConverter.IsLittleEndian)
		{
			Array.Reverse(byte_0);
		}
		return BitConverter.ToInt32(byte_0, 0);
	}
}
