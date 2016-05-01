using System;
using System.IO;

public class GClass1 : GClass0
{
	public GClass1(Stream stream_1) : base(stream_1)
	{
	}

	public override int vmethod_0()
	{
		return GClass4.smethod_1(base.method_3(4));
	}

	public override uint vmethod_1()
	{
		return (uint)this.vmethod_0();
	}

	public override void vmethod_2(int int_0)
	{
		base.method_2(GClass4.smethod_0(int_0));
	}

	public override void vmethod_3(uint uint_0)
	{
		this.vmethod_2((int)uint_0);
	}
}
