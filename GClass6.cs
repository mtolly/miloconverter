using System;
using System.Collections.Generic;
using System.IO;

public class GClass6
{
	public bool bool_0;

	public int int_0;

	public List<Stream> list_0;

	private void method_0(Stream stream_0, Stream stream_1)
	{
		GStream2 gStream = new GStream2(stream_0, new GClass19(true), 1024);
		GClass3.smethod_1(stream_1, gStream, 9223372036854775807L);
		gStream.Flush();
	}

	private int method_1(Stream stream_0, Stream stream_1)
	{
		GStream3 gStream = new GStream3(stream_1, new GClass13(9, true), 1024);
		int result = (int)GClass3.smethod_0(gStream, stream_0);
		gStream.method_0(false);
		gStream.Close();
		return result;
	}

	public GClass6()
	{
		this.list_0 = new List<Stream>();
	}

	public GClass6(Stream stream_0) : this(new GClass1(stream_0))
	{
	}

	public GClass6(GClass0 gclass0_0) : this()
	{
		uint num = new GClass2(gclass0_0.stream_0).vmethod_1();
		if (num == 2950610635u)
		{
			this.bool_0 = true;
		}
		else
		{
			if (num != 2950610634u)
			{
				throw new NotSupportedException();
			}
			this.bool_0 = false;
		}
		this.int_0 = gclass0_0.vmethod_0();
		int num2 = gclass0_0.vmethod_0();
		gclass0_0.vmethod_0();
		int num3 = this.int_0;
		for (int i = 0; i < num2; i++)
		{
			int num4 = gclass0_0.vmethod_0();
			Stream stream = new GStream1(gclass0_0.stream_0, (long)num3, (long)num4);
			num3 += num4;
			if (this.bool_0)
			{
				Stream stream_ = stream;
				stream = new GStream0();
				this.method_0(stream_, stream);
				stream.Position = 0L;
			}
			this.list_0.Add(stream);
		}
	}

	public void method_2(Stream stream_0)
	{
		new GClass2(stream_0).vmethod_3(this.bool_0 ? 2950610635u : 2950610634u);
		GClass1 gClass = new GClass1(stream_0);
		gClass.vmethod_2(this.int_0);
		gClass.vmethod_2(this.list_0.Count);
		long long_ = gClass.method_5();
		gClass.method_8((long)this.int_0);
		MemoryStream memoryStream = new MemoryStream();
		GClass1 gClass2 = new GClass1(memoryStream);
		int num = 0;
		foreach (Stream current in this.list_0)
		{
			current.Position = 0L;
			long position = stream_0.Position;
			int num2;
			if (this.bool_0)
			{
				num2 = this.method_1(current, stream_0);
			}
			else
			{
				num2 = (int)GClass3.smethod_0(stream_0, current);
			}
			gClass2.vmethod_2((int)(stream_0.Position - position));
			num += num2;
		}
		gClass.method_6(long_);
		gClass.vmethod_2(num);
		memoryStream.Position = 0L;
		GClass3.smethod_0(gClass.stream_0, memoryStream);
	}
}
