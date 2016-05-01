using System;

public class GClass15 : GClass14
{
	private int int_6;

	private short[] short_0;

	private short[] short_1;

	private int int_7;

	private int int_8;

	private bool bool_0;

	private int int_9;

	private int int_10;

	private int int_11;

	private byte[] byte_0;

	private GEnum0 genum0_0;

	private int int_12;

	private int int_13;

	private int int_14;

	private int int_15;

	private int int_16;

	private byte[] byte_1;

	private long long_0;

	private int int_17;

	private int int_18;

	private GClass18 gclass18_0;

	private GClass16 gclass16_0;

	private GClass9 gclass9_0;

	public GClass15(GClass18 gclass18_1)
	{
		this.gclass18_0 = gclass18_1;
		this.gclass16_0 = new GClass16(gclass18_1);
		this.gclass9_0 = new GClass9();
		this.byte_0 = new byte[65536];
		this.short_0 = new short[32768];
		this.short_1 = new short[32768];
		this.int_10 = 1;
		this.int_9 = 1;
	}

	public bool method_0(bool bool_1, bool bool_2)
	{
		while (true)
		{
			this.method_8();
			bool bool_3 = bool_1 && this.int_17 == this.int_18;
			bool flag;
			switch (this.int_16)
			{
			case 0:
				flag = this.method_13(bool_3, bool_2);
				goto IL_44;
			case 1:
				flag = this.method_14(bool_3, bool_2);
				goto IL_44;
			case 2:
				flag = this.method_15(bool_3, bool_2);
				goto IL_44;
			}
			break;
			IL_44:
			if (!this.gclass18_0.method_7())
			{
				return flag;
			}
			if (!flag)
			{
				return flag;
			}
		}
		throw new InvalidOperationException("unknown compressionFunction");
	}

	public void method_1(byte[] byte_2, int int_19, int int_20)
	{
		if (byte_2 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (int_19 < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (int_20 < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (this.int_17 < this.int_18)
		{
			throw new InvalidOperationException("Old input was not completely processed");
		}
		int num = int_19 + int_20;
		if (int_19 > num || num > byte_2.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		this.byte_1 = byte_2;
		this.int_17 = int_19;
		this.int_18 = num;
	}

	public bool method_2()
	{
		return this.int_18 == this.int_17;
	}

	public void method_3()
	{
		this.gclass16_0.method_0();
		this.gclass9_0.vmethod_1();
		this.int_10 = 1;
		this.int_9 = 1;
		this.int_11 = 0;
		this.long_0 = 0L;
		this.bool_0 = false;
		this.int_8 = 2;
		for (int i = 0; i < 32768; i++)
		{
			this.short_0[i] = 0;
		}
		for (int j = 0; j < 32768; j++)
		{
			this.short_1[j] = 0;
		}
	}

	public void method_4()
	{
		this.gclass9_0.vmethod_1();
	}

	public int method_5()
	{
		return (int)this.gclass9_0.vmethod_0();
	}

	public void method_6(GEnum0 genum0_1)
	{
		this.genum0_0 = genum0_1;
	}

	public void method_7(int int_19)
	{
		if (int_19 >= 0 && int_19 <= 9)
		{
			this.int_15 = GClass14.int_1[int_19];
			this.int_13 = GClass14.int_2[int_19];
			this.int_14 = GClass14.int_3[int_19];
			this.int_12 = GClass14.int_4[int_19];
			if (GClass14.int_5[int_19] != this.int_16)
			{
				switch (this.int_16)
				{
				case 0:
					if (this.int_10 > this.int_9)
					{
						this.gclass16_0.method_3(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
						this.int_9 = this.int_10;
					}
					this.method_9();
					break;
				case 1:
					if (this.int_10 > this.int_9)
					{
						this.gclass16_0.method_4(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
						this.int_9 = this.int_10;
					}
					break;
				case 2:
					if (this.bool_0)
					{
						this.gclass16_0.method_6((int)(this.byte_0[this.int_10 - 1] & 255));
					}
					if (this.int_10 > this.int_9)
					{
						this.gclass16_0.method_4(this.byte_0, this.int_9, this.int_10 - this.int_9, false);
						this.int_9 = this.int_10;
					}
					this.bool_0 = false;
					this.int_8 = 2;
					break;
				}
				this.int_16 = GClass14.int_5[int_19];
			}
			return;
		}
		throw new ArgumentOutOfRangeException("level");
	}

	public void method_8()
	{
		if (this.int_10 >= 65274)
		{
			this.method_11();
		}
		while (this.int_11 < 262 && this.int_17 < this.int_18)
		{
			int num = 65536 - this.int_11 - this.int_10;
			if (num > this.int_18 - this.int_17)
			{
				num = this.int_18 - this.int_17;
			}
			Array.Copy(this.byte_1, this.int_17, this.byte_0, this.int_10 + this.int_11, num);
			this.gclass9_0.vmethod_2(this.byte_1, this.int_17, num);
			this.int_17 += num;
			this.long_0 += (long)num;
			this.int_11 += num;
		}
		if (this.int_11 >= 3)
		{
			this.method_9();
		}
	}

	private void method_9()
	{
		this.int_6 = ((int)this.byte_0[this.int_10] << 5 ^ (int)this.byte_0[this.int_10 + 1]);
	}

	private int method_10()
	{
		int num = (this.int_6 << 5 ^ (int)this.byte_0[this.int_10 + 2]) & 32767;
		short num2 = this.short_1[this.int_10 & 32767] = this.short_0[num];
		this.short_0[num] = (short)this.int_10;
		this.int_6 = num;
		return (int)num2 & 65535;
	}

	private void method_11()
	{
		Array.Copy(this.byte_0, 32768, this.byte_0, 0, 32768);
		this.int_7 -= 32768;
		this.int_10 -= 32768;
		this.int_9 -= 32768;
		for (int i = 0; i < 32768; i++)
		{
			int num = (int)this.short_0[i] & 65535;
			this.short_0[i] = (short)((num >= 32768) ? (num - 32768) : 0);
		}
		for (int j = 0; j < 32768; j++)
		{
			int num2 = (int)this.short_1[j] & 65535;
			this.short_1[j] = (short)((num2 >= 32768) ? (num2 - 32768) : 0);
		}
	}

	private bool method_12(int int_19)
	{
		int num = this.int_12;
		int num2 = this.int_14;
		short[] array = this.short_1;
		int num3 = this.int_10;
		int num4 = this.int_10 + this.int_8;
		int num5 = Math.Max(this.int_8, 2);
		int num6 = Math.Max(this.int_10 - 32506, 0);
		int num7 = this.int_10 + 258 - 1;
		byte b = this.byte_0[num4 - 1];
		byte b2 = this.byte_0[num4];
		if (num5 >= this.int_15)
		{
			num >>= 2;
		}
		if (num2 > this.int_11)
		{
			num2 = this.int_11;
		}
		do
		{
			if (this.byte_0[int_19 + num5] == b2 && this.byte_0[int_19 + num5 - 1] == b && this.byte_0[int_19] == this.byte_0[num3] && this.byte_0[int_19 + 1] == this.byte_0[num3 + 1])
			{
				int num8 = int_19 + 2;
				num3 += 2;
				while (this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && this.byte_0[++num3] == this.byte_0[++num8] && num3 < num7)
				{
				}
				if (num3 > num4)
				{
					this.int_7 = int_19;
					num4 = num3;
					num5 = num3 - this.int_10;
					if (num5 >= num2)
					{
						break;
					}
					b = this.byte_0[num4 - 1];
					b2 = this.byte_0[num4];
				}
				num3 = this.int_10;
			}
			if ((int_19 = ((int)array[int_19 & 32767] & 65535)) <= num6)
			{
				break;
			}
		}
		while (--num != 0);
		this.int_8 = Math.Min(num5, this.int_11);
		return this.int_8 >= 3;
	}

	private bool method_13(bool bool_1, bool bool_2)
	{
		if (!bool_1 && this.int_11 == 0)
		{
			return false;
		}
		this.int_10 += this.int_11;
		this.int_11 = 0;
		int num = this.int_10 - this.int_9;
		if (num < GClass14.int_0 && (this.int_9 >= 32768 || num < 32506) && !bool_1)
		{
			return true;
		}
		bool flag = bool_2;
		if (num > GClass14.int_0)
		{
			num = GClass14.int_0;
			flag = false;
		}
		this.gclass16_0.method_3(this.byte_0, this.int_9, num, flag);
		this.int_9 += num;
		return !flag;
	}

	private bool method_14(bool bool_1, bool bool_2)
	{
		if (this.int_11 < 262 && !bool_1)
		{
			return false;
		}
		while (this.int_11 >= 262 || bool_1)
		{
			if (this.int_11 == 0)
			{
				this.gclass16_0.method_4(this.byte_0, this.int_9, this.int_10 - this.int_9, bool_2);
				this.int_9 = this.int_10;
				return false;
			}
			if (this.int_10 > 65274)
			{
				this.method_11();
			}
			int num;
			if (this.int_11 >= 3 && (num = this.method_10()) != 0 && this.genum0_0 != GEnum0.const_2 && this.int_10 - num <= 32506 && this.method_12(num))
			{
				bool flag = this.gclass16_0.method_7(this.int_10 - this.int_7, this.int_8);
				this.int_11 -= this.int_8;
				if (this.int_8 <= this.int_13 && this.int_11 >= 3)
				{
					while (--this.int_8 > 0)
					{
						this.int_10++;
						this.method_10();
					}
					this.int_10++;
				}
				else
				{
					this.int_10 += this.int_8;
					if (this.int_11 >= 2)
					{
						this.method_9();
					}
				}
				this.int_8 = 2;
				if (!flag)
				{
					continue;
				}
			}
			else
			{
				this.gclass16_0.method_6((int)(this.byte_0[this.int_10] & 255));
				this.int_10++;
				this.int_11--;
			}
			if (this.gclass16_0.method_5())
			{
				bool flag2 = bool_2 && this.int_11 == 0;
				this.gclass16_0.method_4(this.byte_0, this.int_9, this.int_10 - this.int_9, flag2);
				this.int_9 = this.int_10;
				return !flag2;
			}
		}
		return true;
	}

	private bool method_15(bool bool_1, bool bool_2)
	{
		if (this.int_11 < 262 && !bool_1)
		{
			return false;
		}
		while (this.int_11 >= 262 || bool_1)
		{
			if (this.int_11 == 0)
			{
				if (this.bool_0)
				{
					this.gclass16_0.method_6((int)(this.byte_0[this.int_10 - 1] & 255));
				}
				this.bool_0 = false;
				this.gclass16_0.method_4(this.byte_0, this.int_9, this.int_10 - this.int_9, bool_2);
				this.int_9 = this.int_10;
				return false;
			}
			if (this.int_10 >= 65274)
			{
				this.method_11();
			}
			int num = this.int_7;
			int num2 = this.int_8;
			if (this.int_11 >= 3)
			{
				int num3 = this.method_10();
				if (this.genum0_0 != GEnum0.const_2 && num3 != 0 && this.int_10 - num3 <= 32506 && this.method_12(num3) && this.int_8 <= 5 && (this.genum0_0 == GEnum0.const_1 || (this.int_8 == 3 && this.int_10 - this.int_7 > 4096)))
				{
					this.int_8 = 2;
				}
			}
			if (num2 >= 3 && this.int_8 <= num2)
			{
				this.gclass16_0.method_7(this.int_10 - 1 - num, num2);
				num2 -= 2;
				do
				{
					this.int_10++;
					this.int_11--;
					if (this.int_11 >= 3)
					{
						this.method_10();
					}
				}
				while (--num2 > 0);
				this.int_10++;
				this.int_11--;
				this.bool_0 = false;
				this.int_8 = 2;
			}
			else
			{
				if (this.bool_0)
				{
					this.gclass16_0.method_6((int)(this.byte_0[this.int_10 - 1] & 255));
				}
				this.bool_0 = true;
				this.int_10++;
				this.int_11--;
			}
			if (this.gclass16_0.method_5())
			{
				int num4 = this.int_10 - this.int_9;
				if (this.bool_0)
				{
					num4--;
				}
				bool flag = bool_2 && this.int_11 == 0 && !this.bool_0;
				this.gclass16_0.method_4(this.byte_0, this.int_9, num4, flag);
				this.int_9 += num4;
				return !flag;
			}
		}
		return true;
	}
}
