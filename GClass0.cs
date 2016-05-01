using System;
using System.IO;

public class GClass0
{
	public Stream stream_0;

	public GClass0(Stream stream_1)
	{
		this.stream_0 = stream_1;
	}

	public virtual int vmethod_0()
	{
		throw new NotImplementedException();
	}

	public virtual uint vmethod_1()
	{
		throw new NotImplementedException();
	}

	public virtual void vmethod_2(int int_0)
	{
		throw new NotImplementedException();
	}

	public virtual void vmethod_3(uint uint_0)
	{
		throw new NotImplementedException();
	}

	public byte method_0()
	{
		return (byte)this.stream_0.ReadByte();
	}

	public void method_1(byte byte_0)
	{
		this.stream_0.WriteByte(byte_0);
	}

	public void method_2(byte[] byte_0)
	{
		this.stream_0.Write(byte_0, 0, byte_0.Length);
	}

	public byte[] method_3(int int_0)
	{
		byte[] array = new byte[int_0];
		this.stream_0.Read(array, 0, int_0);
		return array;
	}

	public void method_4(byte[] byte_0, int int_0, int int_1)
	{
		this.stream_0.Write(byte_0, int_0, int_1);
	}

	public long method_5()
	{
		return this.stream_0.Position;
	}

	public void method_6(long long_0)
	{
		this.stream_0.Position = long_0;
	}

	public void method_7(long long_0)
	{
		byte[] byte_ = new byte[256];
		while (long_0 > 0L)
		{
			int num = (int)Math.Min(256L, long_0);
			this.method_4(byte_, 0, num);
			long_0 -= (long)num;
		}
	}

	public void method_8(long long_0)
	{
		if (long_0 < this.method_5())
		{
			throw new ArgumentException();
		}
		this.method_7(long_0 - this.method_5());
	}
}
