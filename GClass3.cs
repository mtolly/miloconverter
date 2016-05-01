using System;
using System.IO;
using System.Text;

public static class GClass3
{
	public static readonly Encoding encoding_0 = Encoding.GetEncoding(28591);

	public static long smethod_0(Stream stream_0, Stream stream_1)
	{
		long long_ = 9223372036854775807L;
		try
		{
			long_ = stream_1.Length;
		}
		catch
		{
		}
		return GClass3.smethod_1(stream_0, stream_1, long_);
	}

	public static long smethod_1(Stream stream_0, Stream stream_1, long long_0)
	{
		byte[] array = new byte[2097152];
		long num = 0L;
		while (num < long_0)
		{
			int num2 = stream_1.Read(array, 0, array.Length);
			num += (long)num2;
			if (num > long_0)
			{
				num2 -= (int)(num - long_0);
			}
			if (num2 == 0)
			{
				break;
			}
			stream_0.Write(array, 0, num2);
			if (num2 < array.Length)
			{
				break;
			}
		}
		return num;
	}
}
