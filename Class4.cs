using System;

internal class Class4
{
	private static readonly int[] int_0 = new int[]
	{
		3,
		3,
		11
	};

	private static readonly int[] int_1 = new int[]
	{
		2,
		3,
		7
	};

	private static readonly int[] int_2 = new int[]
	{
		16,
		17,
		18,
		0,
		8,
		7,
		9,
		6,
		10,
		5,
		11,
		4,
		12,
		3,
		13,
		2,
		14,
		1,
		15
	};

	private byte[] byte_0;

	private byte[] byte_1;

	private GClass20 gclass20_0;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private byte byte_2;

	private int int_9;

	public bool method_0(GClass12 gclass12_0)
	{
		while (true)
		{
			switch (this.int_3)
			{
			case 0:
				this.int_4 = gclass12_0.method_0(5);
				if (this.int_4 >= 0)
				{
					this.int_4 += 257;
					gclass12_0.method_1(5);
					this.int_3 = 1;
					goto IL_1FE;
				}
				return false;
			case 1:
				goto IL_1FE;
			case 2:
				goto IL_1B0;
			case 3:
				goto IL_177;
			case 4:
				break;
			case 5:
				goto IL_2A;
			default:
				continue;
			}
			IL_F2:
			int num;
			while (((num = this.gclass20_0.method_1(gclass12_0)) & -16) == 0)
			{
				this.byte_1[this.int_9++] = (this.byte_2 = (byte)num);
				if (this.int_9 == this.int_7)
				{
					return true;
				}
			}
			if (num >= 0)
			{
				if (num >= 17)
				{
					this.byte_2 = 0;
				}
				else if (this.int_9 == 0)
				{
					goto IL_2A7;
				}
				this.int_8 = num - 16;
				this.int_3 = 5;
				goto IL_2A;
			}
			return false;
			IL_177:
			while (this.int_9 < this.int_6)
			{
				int num2 = gclass12_0.method_0(3);
				if (num2 < 0)
				{
					return false;
				}
				gclass12_0.method_1(3);
				this.byte_0[Class4.int_2[this.int_9]] = (byte)num2;
				this.int_9++;
			}
			this.gclass20_0 = new GClass20(this.byte_0);
			this.byte_0 = null;
			this.int_9 = 0;
			this.int_3 = 4;
			goto IL_F2;
			IL_2A:
			int num3 = Class4.int_1[this.int_8];
			int num4 = gclass12_0.method_0(num3);
			if (num4 < 0)
			{
				return false;
			}
			gclass12_0.method_1(num3);
			num4 += Class4.int_0[this.int_8];
			if (this.int_9 + num4 > this.int_7)
			{
				break;
			}
			while (num4-- > 0)
			{
				this.byte_1[this.int_9++] = this.byte_2;
			}
			if (this.int_9 == this.int_7)
			{
				return true;
			}
			this.int_3 = 4;
			continue;
			IL_1B0:
			this.int_6 = gclass12_0.method_0(4);
			if (this.int_6 >= 0)
			{
				this.int_6 += 4;
				gclass12_0.method_1(4);
				this.byte_0 = new byte[19];
				this.int_9 = 0;
				this.int_3 = 3;
				goto IL_177;
			}
			return false;
			IL_1FE:
			this.int_5 = gclass12_0.method_0(5);
			if (this.int_5 >= 0)
			{
				this.int_5++;
				gclass12_0.method_1(5);
				this.int_7 = this.int_4 + this.int_5;
				this.byte_1 = new byte[this.int_7];
				this.int_3 = 2;
				goto IL_1B0;
			}
			return false;
		}
		throw new GException0();
		IL_2A7:
		throw new GException0();
	}

	public GClass20 method_1()
	{
		byte[] destinationArray = new byte[this.int_4];
		Array.Copy(this.byte_1, 0, destinationArray, 0, this.int_4);
		return new GClass20(destinationArray);
	}

	public GClass20 method_2()
	{
		byte[] destinationArray = new byte[this.int_5];
		Array.Copy(this.byte_1, this.int_4, destinationArray, 0, this.int_5);
		return new GClass20(destinationArray);
	}
}
