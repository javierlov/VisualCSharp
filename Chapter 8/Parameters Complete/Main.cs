using System;

namespace Parameters
{
	class Application
	{
		static void Entrance()
		{
			int i = 0;
			Console.WriteLine(i);
			Pass.Value(ref i);
			Console.WriteLine(i);

			WrappedInt wi = new WrappedInt();
			Console.WriteLine(wi.Number);
			Pass.Reference(wi);
			Console.WriteLine(wi.Number);
		}

		static void Main(string[] args)
		{
			try
			{
				Entrance();
			}
			catch (Exception caught)
			{
				Console.WriteLine(caught.Message);
			}
		}
	}
}
