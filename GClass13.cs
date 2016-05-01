using System;

public class GClass13
{
	private int int_0;

	private bool bool_0;

	private int int_1;

	private long long_0;

	private GClass18 gclass18_0;

	private GClass15 gclass15_0;

	public GClass13(int int_2, bool bool_1)
	{
		if (int_2 == -1)
		{
			int_2 = 6;
		}
		else if (int_2 < 0 || int_2 > 9)
		{
			throw new ArgumentOutOfRangeException("level");
		}
		this.gclass18_0 = new GClass18();
		this.gclass15_0 = new GClass15(this.gclass18_0);
		this.bool_0 = bool_1;
		this.method_7(GEnum0.const_0);
		this.method_6(int_2);
		this.method_0();
	}

	public void method_0()
	{
		this.int_1 = (this.bool_0 ? 16 : 0);
		this.long_0 = 0L;
		this.gclass18_0.method_0();
		this.gclass15_0.method_3();
	}

	public void method_1()
	{
		this.int_1 |= 4;
	}

	public void method_2()
	{
		this.int_1 |= 12;
	}

	public bool method_3()
	{
		return this.int_1 == 30 && this.gclass18_0.method_7();
	}

	public bool method_4()
	{
		return this.gclass15_0.method_2();
	}

	public void method_5(byte[] byte_0, int int_2, int int_3)
	{
		if ((this.int_1 & 8) != 0)
		{
			throw new InvalidOperationException("Finish() already called");
		}
		this.gclass15_0.method_1(byte_0, int_2, int_3);
	}

	public void method_6(int int_2)
	{
		if (int_2 == -1)
		{
			int_2 = 6;
		}
		else if (int_2 < 0 || int_2 > 9)
		{
			throw new ArgumentOutOfRangeException("level");
		}
		if (this.int_0 != int_2)
		{
			this.int_0 = int_2;
			this.gclass15_0.method_7(int_2);
		}
	}

	public void method_7(GEnum0 genum0_0)
	{
		this.gclass15_0.method_6(genum0_0);
	}

	public int method_8(byte[] byte_0, int int_2, int int_3)
	{
		int num = int_3;
		if (this.int_1 == 127)
		{
			throw new InvalidOperationException("Deflater closed");
		}
		if (this.int_1 < 16)
		{
			int num2 = 30720;
			int num3 = this.int_0 - 1 >> 1;
			if (num3 < 0 || num3 > 3)
			{
				num3 = 3;
			}
			num2 |= num3 << 6;
			if ((this.int_1 & 1) != 0)
			{
				num2 |= 32;
			}
			num2 += 31 - num2 % 31;
			this.gclass18_0.method_6(num2);
			if ((this.int_1 & 1) != 0)
			{
				int num4 = this.gclass15_0.method_5();
				this.gclass15_0.method_4();
				this.gclass18_0.method_6(num4 >> 16);
				this.gclass18_0.method_6(num4 & 65535);
			}
			this.int_1 = (16 | (this.int_1 & 12));
		}
		while (true)
		{
			int num5 = this.gclass18_0.method_8(byte_0, int_2, int_3);
			int_2 += num5;
			this.long_0 += (long)num5;
			int_3 -= num5;
			if (int_3 == 0 || this.int_1 == 30)
			{
				goto IL_1F0;
			}
			if (!this.gclass15_0.method_0((this.int_1 & 4) != 0, (this.int_1 & 8) != 0))
			{
				if (this.int_1 == 16)
				{
					break;
				}
				if (this.int_1 == 20)
				{
					if (this.int_0 != 0)
					{
						for (int i = 8 + (-this.gclass18_0.method_3() & 7); i > 0; i -= 10)
						{
							this.gclass18_0.method_5(2, 10);
						}
					}
					this.int_1 = 16;
				}
				else if (this.int_1 == 28)
				{
					this.gclass18_0.method_4();
					if (!this.bool_0)
					{
						int num6 = this.gclass15_0.method_5();
						this.gclass18_0.method_6(num6 >> 16);
						this.gclass18_0.method_6(num6 & 65535);
					}
					this.int_1 = 30;
				}
			}
		}
		return num - int_3;
		IL_1F0:
		return num - int_3;
	}
}
