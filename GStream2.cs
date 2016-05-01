using System;
using System.IO;

public class GStream2 : Stream
{
	protected GClass19 gclass19_0;

	protected GClass10 gclass10_0;

	protected Stream stream_0;

	private bool bool_0;

	private bool bool_1 = true;

	public override bool CanRead
	{
		get
		{
			return this.stream_0.CanRead;
		}
	}

	public override bool CanSeek
	{
		get
		{
			return false;
		}
	}

	public override bool CanWrite
	{
		get
		{
			return false;
		}
	}

	public override long Length
	{
		get
		{
			return (long)this.gclass10_0.method_0();
		}
	}

	public override long Position
	{
		get
		{
			return this.stream_0.Position;
		}
		set
		{
			throw new NotSupportedException("InflaterInputStream Position not supported");
		}
	}

	public GStream2(Stream stream_1, GClass19 gclass19_1, int int_0)
	{
		if (stream_1 == null)
		{
			throw new ArgumentNullException("baseInputStream");
		}
		if (gclass19_1 == null)
		{
			throw new ArgumentNullException("inflater");
		}
		if (int_0 <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize");
		}
		this.stream_0 = stream_1;
		this.gclass19_0 = gclass19_1;
		this.gclass10_0 = new GClass10(stream_1, int_0);
	}

	protected void method_0()
	{
		this.gclass10_0.method_2();
		this.gclass10_0.method_1(this.gclass19_0);
	}

	public override void Flush()
	{
		this.stream_0.Flush();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("Seek not supported");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("InflaterInputStream SetLength not supported");
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("InflaterInputStream Write not supported");
	}

	public override void WriteByte(byte value)
	{
		throw new NotSupportedException("InflaterInputStream WriteByte not supported");
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException("InflaterInputStream BeginWrite not supported");
	}

	public override void Close()
	{
		if (!this.bool_0)
		{
			this.bool_0 = true;
			if (this.bool_1)
			{
				this.stream_0.Close();
			}
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (this.gclass19_0.method_8())
		{
			throw new GException0("Need a dictionary");
		}
		int num = count;
		while (true)
		{
			int num2 = this.gclass19_0.method_6(buffer, offset, num);
			offset += num2;
			num -= num2;
			if (num == 0 || this.gclass19_0.method_9())
			{
				goto IL_6F;
			}
			if (this.gclass19_0.method_7())
			{
				this.method_0();
			}
			else if (num2 == 0)
			{
				break;
			}
		}
		throw new GException1("Dont know what to do");
		IL_6F:
		return count - num;
	}
}
