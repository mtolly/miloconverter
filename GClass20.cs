using System;

public class GClass20
{
	private short[] short_0;

	public static GClass20 gclass20_0;

	public static GClass20 gclass20_1;

	static GClass20()
	{
		try
		{
			byte[] array = new byte[288];
			int i = 0;
			while (i < 144)
			{
				array[i++] = 8;
			}
			while (i < 256)
			{
				array[i++] = 9;
			}
			while (i < 280)
			{
				array[i++] = 7;
			}
			while (i < 288)
			{
				array[i++] = 8;
			}
			GClass20.gclass20_0 = new GClass20(array);
			array = new byte[32];
			i = 0;
			while (i < 32)
			{
				array[i++] = 5;
			}
			GClass20.gclass20_1 = new GClass20(array);
		}
		catch (Exception)
		{
			throw new GException0("InflaterHuffmanTree: static tree length illegal");
		}
	}

	public GClass20(byte[] byte_0)
	{
		this.method_0(byte_0);
	}

	private void method_0(byte[] byte_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		for (int i = 0; i < byte_0.Length; i++)
		{
			int num = (int)byte_0[i];
			if (num > 0)
			{
				array[num]++;
			}
		}
		int num2 = 0;
		int num3 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num2;
			num2 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num4 = array2[j] & 130944;
				int num5 = num2 & 130944;
				num3 += num5 - num4 >> 16 - j;
			}
		}
		this.short_0 = new short[num3];
		int num6 = 512;
		for (int k = 15; k >= 10; k--)
		{
			int num7 = num2 & 130944;
			num2 -= array[k] << 16 - k;
			int num8 = num2 & 130944;
			for (int l = num8; l < num7; l += 128)
			{
				this.short_0[(int)GClass16.smethod_0(l)] = (short)(-num6 << 4 | k);
				num6 += 1 << k - 9;
			}
		}
		for (int m = 0; m < byte_0.Length; m++)
		{
			int num9 = (int)byte_0[m];
			if (num9 != 0)
			{
				num2 = array2[num9];
				int num10 = (int)GClass16.smethod_0(num2);
				if (num9 <= 9)
				{
					do
					{
						this.short_0[num10] = (short)(m << 4 | num9);
						num10 += 1 << num9;
					}
					while (num10 < 512);
				}
				else
				{
					int num11 = (int)this.short_0[num10 & 511];
					int num12 = 1 << (num11 & 15);
					num11 = -(num11 >> 4);
					do
					{
						this.short_0[num11 | num10 >> 9] = (short)(m << 4 | num9);
						num10 += 1 << num9;
					}
					while (num10 < num12);
				}
				array2[num9] = num2 + (1 << 16 - num9);
			}
		}
	}

	public int method_1(GClass12 gclass12_0)
	{
		int num;
		if ((num = gclass12_0.method_0(9)) >= 0)
		{
			int num2;
			if ((num2 = (int)this.short_0[num]) >= 0)
			{
				gclass12_0.method_1(num2 & 15);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 15;
			if ((num = gclass12_0.method_0(int_)) >= 0)
			{
				num2 = (int)this.short_0[num3 | num >> 9];
				gclass12_0.method_1(num2 & 15);
				return num2 >> 4;
			}
			int num4 = gclass12_0.method_2();
			num = gclass12_0.method_0(num4);
			num2 = (int)this.short_0[num3 | num >> 9];
			if ((num2 & 15) <= num4)
			{
				gclass12_0.method_1(num2 & 15);
				return num2 >> 4;
			}
			return -1;
		}
		else
		{
			int num5 = gclass12_0.method_2();
			num = gclass12_0.method_0(num5);
			int num2 = (int)this.short_0[num];
			if (num2 >= 0 && (num2 & 15) <= num5)
			{
				gclass12_0.method_1(num2 & 15);
				return num2 >> 4;
			}
			return -1;
		}
	}
}
