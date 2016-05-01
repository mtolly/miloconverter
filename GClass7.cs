using System;
using System.Collections.Generic;
using System.IO;

public class GClass7
{
	public Stream stream_0;

	public Stream stream_1;

	public Stream stream_2;

	public Stream stream_3;

	public Stream stream_4;

	public Stream stream_5;

	public Stream stream_6;

	public List<string> list_0;

	public GClass7()
	{
		this.list_0 = new List<string>();
	}

	public GClass7(Stream stream_7) : this()
	{
		GClass1 gClass = new GClass1(stream_7);
		if (gClass.vmethod_0() != 1179861586)
		{
			throw new NotSupportedException();
		}
		if (gClass.vmethod_0() != 3)
		{
			throw new NotSupportedException();
		}
		int num = 7;
		uint[] array = new uint[7];
		uint[] array2 = new uint[7];
		for (int i = 0; i < num; i++)
		{
			array[i] = gClass.vmethod_1();
		}
		for (int j = 0; j < num; j++)
		{
			array2[j] = gClass.vmethod_1();
		}
		gClass.method_3(160);
		string text = string.Empty;
		while (gClass.method_5() < (long)((ulong)array[0]))
		{
			byte b = gClass.method_0();
			if (b == 0)
			{
				this.list_0.Add(text);
				text = string.Empty;
			}
			else
			{
				text += (char)b;
			}
		}
		this.stream_0 = new GStream1(gClass.stream_0, (long)((ulong)array[0]), (long)((ulong)array2[0]));
		this.stream_1 = new GStream1(gClass.stream_0, (long)((ulong)array[1]), (long)((ulong)array2[1]));
		this.stream_2 = new GStream1(gClass.stream_0, (long)((ulong)array[2]), (long)((ulong)array2[2]));
		this.stream_3 = new GStream1(gClass.stream_0, (long)((ulong)array[3]), (long)((ulong)array2[3]));
		this.stream_4 = new GStream1(gClass.stream_0, (long)((ulong)array[4]), (long)((ulong)array2[4]));
		this.stream_5 = new GStream1(gClass.stream_0, (long)((ulong)array[5]), (long)((ulong)array2[5]));
		this.stream_6 = new GStream1(gClass.stream_0, (long)((ulong)array[6]), (long)((ulong)array2[6]));
	}
}
