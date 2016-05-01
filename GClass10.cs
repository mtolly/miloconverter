using System;
using System.IO;
using System.Security.Cryptography;

public class GClass10
{
	private int int_0;

	private byte[] byte_0;

	private int int_1;

	private byte[] byte_1;

	private int int_2;

	private ICryptoTransform icryptoTransform_0;

	private Stream stream_0;

	public GClass10(Stream stream_1, int int_3)
	{
		this.stream_0 = stream_1;
		if (int_3 < 1024)
		{
			int_3 = 1024;
		}
		this.byte_0 = new byte[int_3];
		this.byte_1 = this.byte_0;
	}

	public int method_0()
	{
		return this.int_0;
	}

	public void method_1(GClass19 gclass19_0)
	{
		if (this.int_2 > 0)
		{
			gclass19_0.method_5(this.byte_1, this.int_1 - this.int_2, this.int_2);
			this.int_2 = 0;
		}
	}

	public void method_2()
	{
		this.int_0 = 0;
		int i = this.byte_0.Length;
		while (i > 0)
		{
			int num = this.stream_0.Read(this.byte_0, this.int_0, i);
			if (num > 0)
			{
				this.int_0 += num;
				i -= num;
			}
			else
			{
				if (this.int_0 == 0)
				{
					throw new GException0("Unexpected EOF");
				}
				IL_60:
				if (this.icryptoTransform_0 != null)
				{
					this.int_1 = this.icryptoTransform_0.TransformBlock(this.byte_0, 0, this.int_0, this.byte_1, 0);
				}
				else
				{
					this.int_1 = this.int_0;
				}
				this.int_2 = this.int_1;
				return;
			}
		}
		// goto IL_60;
		if (this.icryptoTransform_0 != null)
		{
			this.int_1 = this.icryptoTransform_0.TransformBlock(this.byte_0, 0, this.int_0, this.byte_1, 0);
		}
		else
		{
			this.int_1 = this.int_0;
		}
		this.int_2 = this.int_1;
		return;
	}
}
