using System;
using System.IO;

public class GStream1 : Stream
{
	public Stream stream_0;

	public long long_0;

	private long long_1;

	private long long_2;

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
			return this.stream_0.CanSeek;
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
			return this.long_1;
		}
	}

	public override long Position
	{
		get
		{
			return this.long_2;
		}
		set
		{
			this.long_2 = value;
		}
	}

	public GStream1(Stream stream_1, long long_3, long long_4)
	{
		if (!stream_1.CanSeek)
		{
			throw new NotSupportedException("Substream must be seekable.");
		}
		this.stream_0 = stream_1;
		this.long_0 = long_3;
		this.long_1 = long_4;
		this.long_2 = 0L;
	}

	public override void Flush()
	{
		this.stream_0.Flush();
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (this.long_2 + (long)count > this.Length)
		{
			count = (int)(this.Length - this.long_2);
		}
		this.stream_0.Position = this.long_0 + this.long_2;
		int num = this.stream_0.Read(buffer, offset, count);
		this.long_2 += (long)num;
		return num;
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		switch (origin)
		{
		case SeekOrigin.Begin:
			this.long_2 = offset;
			break;
		case SeekOrigin.Current:
			this.long_2 += offset;
			break;
		case SeekOrigin.End:
			this.long_2 = this.Length + offset;
			break;
		}
		return this.long_2;
	}

	public override void SetLength(long value)
	{
		this.long_1 = value;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		this.stream_0.Position = this.long_0 + this.long_2;
		this.stream_0.Write(buffer, offset, count);
	}
}
