using System;

public class GClass19
{
	private static readonly int[] int_0 = new int[]
	{
		3,
		4,
		5,
		6,
		7,
		8,
		9,
		10,
		11,
		13,
		15,
		17,
		19,
		23,
		27,
		31,
		35,
		43,
		51,
		59,
		67,
		83,
		99,
		115,
		131,
		163,
		195,
		227,
		258
	};

	private static readonly int[] int_1 = new int[]
	{
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		1,
		1,
		1,
		1,
		2,
		2,
		2,
		2,
		3,
		3,
		3,
		3,
		4,
		4,
		4,
		4,
		5,
		5,
		5,
		5,
		0
	};

	private static readonly int[] int_2 = new int[]
	{
		1,
		2,
		3,
		4,
		5,
		7,
		9,
		13,
		17,
		25,
		33,
		49,
		65,
		97,
		129,
		193,
		257,
		385,
		513,
		769,
		1025,
		1537,
		2049,
		3073,
		4097,
		6145,
		8193,
		12289,
		16385,
		24577
	};

	private static readonly int[] int_3 = new int[]
	{
		0,
		0,
		0,
		0,
		1,
		1,
		2,
		2,
		3,
		3,
		4,
		4,
		5,
		5,
		6,
		6,
		7,
		7,
		8,
		8,
		9,
		9,
		10,
		10,
		11,
		11,
		12,
		12,
		13,
		13
	};

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private bool bool_0;

	private long long_0;

	private long long_1;

	private bool bool_1;

	private GClass12 gclass12_0;

	private GClass11 gclass11_0;

	private Class4 class4_0;

	private GClass20 gclass20_0;

	private GClass20 gclass20_1;

	private GClass9 gclass9_0;

	public GClass19(bool bool_2)
	{
		this.bool_1 = bool_2;
		this.gclass9_0 = new GClass9();
		this.gclass12_0 = new GClass12();
		this.gclass11_0 = new GClass11();
		this.int_4 = (bool_2 ? 2 : 0);
	}

	private bool method_0()
	{
		int num = this.gclass12_0.method_0(16);
		if (num < 0)
		{
			return false;
		}
		this.gclass12_0.method_1(16);
		num = ((num << 8 | num >> 8) & 65535);
		if (num % 31 != 0)
		{
			throw new GException0("Header checksum illegal");
		}
		if ((num & 3840) != 2048)
		{
			throw new GException0("Compression Method unknown");
		}
		if ((num & 32) == 0)
		{
			this.int_4 = 2;
		}
		else
		{
			this.int_4 = 1;
			this.int_6 = 32;
		}
		return true;
	}

	private bool method_1()
	{
		while (this.int_6 > 0)
		{
			int num = this.gclass12_0.method_0(8);
			if (num < 0)
			{
				return false;
			}
			this.gclass12_0.method_1(8);
			this.int_5 = (this.int_5 << 8 | num);
			this.int_6 -= 8;
		}
		return false;
	}

	private bool method_2()
	{
		int i = this.gclass11_0.method_4();
		while (i >= 258)
		{
			int num;
			switch (this.int_4)
			{
			case 7:
				while (((num = this.gclass20_0.method_1(this.gclass12_0)) & -256) == 0)
				{
					this.gclass11_0.method_0(num);
					if (--i < 258)
					{
						return true;
					}
				}
				if (num >= 257)
				{
					try
					{
						this.int_7 = GClass19.int_0[num - 257];
						this.int_6 = GClass19.int_1[num - 257];
					}
					catch (Exception)
					{
						throw new GException0("Illegal rep length code");
					}
					goto IL_B2;
				}
				if (num < 0)
				{
					return false;
				}
				this.gclass20_1 = null;
				this.gclass20_0 = null;
				this.int_4 = 2;
				return true;
			case 8:
				goto IL_B2;
			case 9:
				goto IL_102;
			case 10:
				break;
			default:
				throw new GException0("Inflater unknown mode");
			}
			IL_143:
			if (this.int_6 > 0)
			{
				this.int_4 = 10;
				int num2 = this.gclass12_0.method_0(this.int_6);
				if (num2 < 0)
				{
					return false;
				}
				this.gclass12_0.method_1(this.int_6);
				this.int_8 += num2;
			}
			this.gclass11_0.method_2(this.int_7, this.int_8);
			i -= this.int_7;
			this.int_4 = 7;
			continue;
			IL_102:
			num = this.gclass20_1.method_1(this.gclass12_0);
			if (num >= 0)
			{
				try
				{
					this.int_8 = GClass19.int_2[num];
					this.int_6 = GClass19.int_3[num];
				}
				catch (Exception)
				{
					throw new GException0("Illegal rep dist code");
				}
				goto IL_143;
			}
			return false;
			IL_B2:
			if (this.int_6 > 0)
			{
				this.int_4 = 8;
				int num3 = this.gclass12_0.method_0(this.int_6);
				if (num3 < 0)
				{
					return false;
				}
				this.gclass12_0.method_1(this.int_6);
				this.int_7 += num3;
			}
			this.int_4 = 9;
			goto IL_102;
		}
		return true;
	}

	private bool method_3()
	{
		while (this.int_6 > 0)
		{
			int num = this.gclass12_0.method_0(8);
			if (num < 0)
			{
				return false;
			}
			this.gclass12_0.method_1(8);
			this.int_5 = (this.int_5 << 8 | num);
			this.int_6 -= 8;
		}
		if ((int)this.gclass9_0.vmethod_0() != this.int_5)
		{
			throw new GException0(string.Concat(new object[]
			{
				"Adler chksum doesn't match: ",
				(int)this.gclass9_0.vmethod_0(),
				" vs. ",
				this.int_5
			}));
		}
		this.int_4 = 12;
		return false;
	}

	private bool method_4()
	{
		switch (this.int_4)
		{
		case 0:
			return this.method_0();
		case 1:
			return this.method_1();
		case 2:
			if (this.bool_0)
			{
				if (this.bool_1)
				{
					this.int_4 = 12;
					return false;
				}
				this.gclass12_0.method_4();
				this.int_6 = 32;
				this.int_4 = 11;
				return true;
			}
			else
			{
				int num = this.gclass12_0.method_0(3);
				if (num < 0)
				{
					return false;
				}
				this.gclass12_0.method_1(3);
				if ((num & 1) != 0)
				{
					this.bool_0 = true;
				}
				switch (num >> 1)
				{
				case 0:
					this.gclass12_0.method_4();
					this.int_4 = 3;
					break;
				case 1:
					this.gclass20_0 = GClass20.gclass20_0;
					this.gclass20_1 = GClass20.gclass20_1;
					this.int_4 = 7;
					break;
				case 2:
					this.class4_0 = new Class4();
					this.int_4 = 6;
					break;
				default:
					throw new GException0("Unknown block type " + num);
				}
				return true;
			}
			break;
		case 3:
			if ((this.int_9 = this.gclass12_0.method_0(16)) < 0)
			{
				return false;
			}
			this.gclass12_0.method_1(16);
			this.int_4 = 4;
			break;
		case 4:
			break;
		case 5:
			goto IL_1AD;
		case 6:
			if (!this.class4_0.method_0(this.gclass12_0))
			{
				return false;
			}
			this.gclass20_0 = this.class4_0.method_1();
			this.gclass20_1 = this.class4_0.method_2();
			this.int_4 = 7;
			goto IL_233;
		case 7:
		case 8:
		case 9:
		case 10:
			goto IL_233;
		case 11:
			return this.method_3();
		case 12:
			return false;
		default:
			throw new GException0("Inflater.Decode unknown mode");
		}
		int num2 = this.gclass12_0.method_0(16);
		if (num2 < 0)
		{
			return false;
		}
		this.gclass12_0.method_1(16);
		if (num2 != (this.int_9 ^ 65535))
		{
			throw new GException0("broken uncompressed block");
		}
		this.int_4 = 5;
		IL_1AD:
		int num3 = this.gclass11_0.method_3(this.gclass12_0, this.int_9);
		this.int_9 -= num3;
		if (this.int_9 == 0)
		{
			this.int_4 = 2;
			return true;
		}
		return !this.gclass12_0.method_5();
		IL_233:
		return this.method_2();
	}

	public void method_5(byte[] byte_0, int int_10, int int_11)
	{
		this.gclass12_0.method_7(byte_0, int_10, int_11);
		this.long_1 += (long)int_11;
	}

	public int method_6(byte[] byte_0, int int_10, int int_11)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (int_11 < 0)
		{
			throw new ArgumentOutOfRangeException("count", "count cannot be negative");
		}
		if (int_10 < 0)
		{
			throw new ArgumentOutOfRangeException("offset", "offset cannot be negative");
		}
		if (int_10 + int_11 > byte_0.Length)
		{
			throw new ArgumentException("count exceeds buffer bounds");
		}
		if (int_11 == 0)
		{
			if (!this.method_9())
			{
				this.method_4();
			}
			return 0;
		}
		int num = 0;
		while (true)
		{
			if (this.int_4 != 11)
			{
				int num2 = this.gclass11_0.method_6(byte_0, int_10, int_11);
				if (num2 > 0)
				{
					this.gclass9_0.vmethod_2(byte_0, int_10, num2);
					int_10 += num2;
					num += num2;
					this.long_0 += (long)num2;
					int_11 -= num2;
					if (int_11 == 0)
					{
						return num;
					}
				}
			}
			if (!this.method_4())
			{
				if (this.gclass11_0.method_5() <= 0)
				{
					break;
				}
				if (this.int_4 == 11)
				{
					break;
				}
			}
		}
		return num;
	}

	public bool method_7()
	{
		return this.gclass12_0.method_5();
	}

	public bool method_8()
	{
		return this.int_4 == 1 && this.int_6 == 0;
	}

	public bool method_9()
	{
		return this.int_4 == 12 && this.gclass11_0.method_5() == 0;
	}
}
