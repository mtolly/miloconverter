using System;
using System.Collections.Generic;
using System.IO;

public class GClass8
{
	private List<string> list_0;

	private List<int> list_1;

	private List<string> list_2;

	private List<int> list_3;

	private byte[] byte_0;

	private List<int> list_4;

	private List<int> list_5;

	private List<int> list_6;

	private List<string> list_7;

	private List<int> list_8;

	private Stream stream_0;

	public GClass8()
	{
		this.list_0 = new List<string>();
		this.list_2 = new List<string>();
		this.list_7 = new List<string>();
		this.list_1 = new List<int>();
		this.list_3 = new List<int>();
		this.list_4 = new List<int>();
		this.list_5 = new List<int>();
		this.list_6 = new List<int>();
		this.list_8 = new List<int>();
	}

	public GClass8(GClass0 gclass0_0) : this()
	{
		if (gclass0_0.vmethod_0() != 25)
		{
			throw new NotSupportedException();
		}
		for (int i = 0; i < 2; i++)
		{
			this.list_0.Add(this.method_2(gclass0_0));
		}
		for (int j = 0; j < 3; j++)
		{
			this.list_1.Add(gclass0_0.vmethod_0());
		}
		for (int k = 0; k < 2; k++)
		{
			this.list_2.Add(this.method_2(gclass0_0));
		}
		for (int l = 0; l < 86; l++)
		{
			this.list_3.Add(gclass0_0.vmethod_0());
		}
		this.byte_0 = gclass0_0.method_3(5);
		for (int m = 0; m < 7; m++)
		{
			this.list_4.Add(gclass0_0.vmethod_0());
		}
		if (gclass0_0.method_0() != 0)
		{
			throw new NotSupportedException();
		}
		byte[] array = gclass0_0.method_3(4);
		if (array[0] == 173 && array[1] == 222 && array[2] == 173)
		{
			if (array[3] == 222)
			{
				for (int n = 0; n < 2; n++)
				{
					this.list_5.Add(gclass0_0.vmethod_0());
				}
				if (gclass0_0.method_0() != 0)
				{
					throw new NotSupportedException();
				}
				for (int num = 0; num < 2; num++)
				{
					this.list_6.Add(gclass0_0.vmethod_0());
				}
				int num2 = gclass0_0.vmethod_0();
				for (int num3 = 0; num3 < num2; num3++)
				{
					this.list_7.Add(this.method_2(gclass0_0));
				}
				for (int num4 = 0; num4 < 2; num4++)
				{
					this.list_8.Add(gclass0_0.vmethod_0());
				}
				this.stream_0 = new GStream1(gclass0_0.stream_0, gclass0_0.method_5(), gclass0_0.stream_0.Length - gclass0_0.method_5());
				return;
			}
		}
		throw new NotSupportedException();
	}

	public void method_0(GClass0 gclass0_0)
	{
		gclass0_0.vmethod_2(25);
		foreach (string current in this.list_0)
		{
			this.method_1(current, gclass0_0);
		}
		foreach (int current2 in this.list_1)
		{
			gclass0_0.vmethod_2(current2);
		}
		foreach (string current3 in this.list_2)
		{
			this.method_1(current3, gclass0_0);
		}
		foreach (int current4 in this.list_3)
		{
			gclass0_0.vmethod_2(current4);
		}
		gclass0_0.method_2(this.byte_0);
		foreach (int current5 in this.list_4)
		{
			gclass0_0.vmethod_2(current5);
		}
		gclass0_0.method_1(0);
		gclass0_0.method_1(173);
		gclass0_0.method_1(222);
		gclass0_0.method_1(173);
		gclass0_0.method_1(222);
		foreach (int current6 in this.list_5)
		{
			gclass0_0.vmethod_2(current6);
		}
		gclass0_0.method_1(0);
		foreach (int current7 in this.list_6)
		{
			gclass0_0.vmethod_2(current7);
		}
		gclass0_0.vmethod_2(this.list_7.Count);
		foreach (string current8 in this.list_7)
		{
			this.method_1(current8, gclass0_0);
		}
		foreach (int current9 in this.list_8)
		{
			gclass0_0.vmethod_2(current9);
		}
		this.stream_0.Position = 0L;
		GClass3.smethod_0(gclass0_0.stream_0, this.stream_0);
	}

	private void method_1(string string_0, GClass0 gclass0_0)
	{
		gclass0_0.vmethod_2(string_0.Length);
		gclass0_0.method_2(GClass3.encoding_0.GetBytes(string_0));
	}

	private string method_2(GClass0 gclass0_0)
	{
		int num = gclass0_0.vmethod_0();
		string text = string.Empty;
		for (int i = 0; i < num; i++)
		{
			text += (char)gclass0_0.method_0();
		}
		return text;
	}
}
