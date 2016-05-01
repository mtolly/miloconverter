using System;
using System.IO;

public class GStream0 : Stream
{
	protected Stream stream_0;

	protected string string_0;

	public override bool CanRead
	{
		get
		{
			return true;
		}
	}

	public override bool CanSeek
	{
		get
		{
			return true;
		}
	}

	public override bool CanWrite
	{
		get
		{
			return true;
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
			this.stream_0.Position = value;
		}
	}

	public override void Close()
	{
		this.stream_0.Close();
		File.Delete(this.string_0);
	}

	public GStream0()
	{
		this.string_0 = Path.GetTempFileName();
		this.stream_0 = new FileStream(this.string_0, FileMode.Create, FileAccess.ReadWrite);
	}

	public override void Flush()
	{
		this.stream_0.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		return this.stream_0.Read(buffer, offset, count);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return this.stream_0.Seek(offset, origin);
	}

	public override void SetLength(long value)
	{
		this.stream_0.SetLength(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		this.stream_0.Write(buffer, offset, count);
	}
}
