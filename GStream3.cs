using System;
using System.IO;
using System.Security.Cryptography;

public class GStream3 : Stream
{
	private ICryptoTransform icryptoTransform_0;

	private byte[] byte_0;

	protected GClass13 gclass13_0;

	protected Stream stream_0;

	private bool bool_0;

	private bool bool_1 = true;

	public override bool CanRead
	{
		get
		{
			return false;
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
			return this.stream_0.CanWrite;
		}
	}

	public override long Length
	{
		get
		{
			return this.stream_0.Length;
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
			throw new NotSupportedException("Position property not supported");
		}
	}

	public GStream3(Stream stream_1, GClass13 gclass13_1, int int_0)
	{
		if (stream_1 == null)
		{
			throw new ArgumentNullException("baseOutputStream");
		}
		if (!stream_1.CanWrite)
		{
			throw new ArgumentException("Must support writing", "baseOutputStream");
		}
		if (gclass13_1 == null)
		{
			throw new ArgumentNullException("deflater");
		}
		if (int_0 <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferSize");
		}
		this.stream_0 = stream_1;
		this.byte_0 = new byte[int_0];
		this.gclass13_0 = gclass13_1;
	}

	public virtual void vmethod_0()
	{
		this.gclass13_0.method_2();
		while (!this.gclass13_0.method_3())
		{
			int num = this.gclass13_0.method_8(this.byte_0, 0, this.byte_0.Length);
			if (num <= 0)
			{
				break;
			}
			if (this.icryptoTransform_0 != null)
			{
				this.method_1(this.byte_0, 0, num);
			}
			this.stream_0.Write(this.byte_0, 0, num);
		}
		if (!this.gclass13_0.method_3())
		{
			throw new GException0("Can't deflate all input?");
		}
		this.stream_0.Flush();
		if (this.icryptoTransform_0 != null)
		{
			this.icryptoTransform_0.Dispose();
			this.icryptoTransform_0 = null;
		}
	}

	public void method_0(bool bool_2)
	{
		this.bool_1 = bool_2;
	}

	protected void method_1(byte[] byte_1, int int_0, int int_1)
	{
		this.icryptoTransform_0.TransformBlock(byte_1, 0, int_1, byte_1, 0);
	}

	protected void method_2()
	{
		while (!this.gclass13_0.method_4())
		{
			int num = this.gclass13_0.method_8(this.byte_0, 0, this.byte_0.Length);
			if (num <= 0)
			{
				break;
			}
			if (this.icryptoTransform_0 != null)
			{
				this.method_1(this.byte_0, 0, num);
			}
			this.stream_0.Write(this.byte_0, 0, num);
		}
		if (!this.gclass13_0.method_4())
		{
			throw new GException0("DeflaterOutputStream can't deflate all input?");
		}
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("DeflaterOutputStream Seek not supported");
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException("DeflaterOutputStream SetLength not supported");
	}

	public override int ReadByte()
	{
		throw new NotSupportedException("DeflaterOutputStream ReadByte not supported");
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("DeflaterOutputStream Read not supported");
	}

	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException("DeflaterOutputStream BeginRead not currently supported");
	}

	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
	{
		throw new NotSupportedException("BeginWrite is not supported");
	}

	public override void Flush()
	{
		this.gclass13_0.method_1();
		this.method_2();
		this.stream_0.Flush();
	}

	public override void Close()
	{
		if (!this.bool_0)
		{
			this.bool_0 = true;
			try
			{
				this.vmethod_0();
				if (this.icryptoTransform_0 != null)
				{
					this.icryptoTransform_0.Dispose();
					this.icryptoTransform_0 = null;
				}
			}
			finally
			{
				if (this.bool_1)
				{
					this.stream_0.Close();
				}
			}
		}
	}

	public override void WriteByte(byte value)
	{
		this.Write(new byte[]
		{
			value
		}, 0, 1);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		this.gclass13_0.method_5(buffer, offset, count);
		this.method_2();
	}
}
