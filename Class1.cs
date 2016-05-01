using System;
using System.IO;

internal class Class1
{
	private static void Main(string[] args)
	{
		if (args.Length != 1)
		{
			Console.WriteLine("You must specify an input file.");
			return;
		}
		string path = args[0];
		string path2 = Path.Combine(Path.GetDirectoryName(path), Path.GetFileNameWithoutExtension(path) + ".milo_wii");
		Stream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
		GClass6 gClass = null;
		try
		{
			GClass7 gClass2 = new GClass7(stream);
			gClass = new GClass6(gClass2.stream_3);
		}
		catch
		{
			stream.Position = 0L;
			gClass = new GClass6(stream);
		}
		GClass8 gClass3 = new GClass8(new GClass2(gClass.list_0[0]));
		GStream0 gStream = new GStream0();
		gClass3.method_0(new GClass1(gStream));
		gClass.list_0[0] = gStream;
		Stream stream2 = new FileStream(path2, FileMode.Create, FileAccess.Write);
		gClass.bool_0 = true;
		gClass.method_2(stream2);
		gStream.Close();
		stream.Close();
		stream2.Close();
	}
}
