using System;

namespace ParamsArrays
{
	class Program
	{
		static void Entrance()
		{
			Console.WriteLine(Util.Min(10, 9, 8, 7, 6, 5, 4, 3, 2, 1));		
		}

		static void Main()
		{
			try
			{
				Entrance();
			}
			catch (Exception caught)
			{
				Console.WriteLine("Exception: {0}", caught.Message);
			}
		}
	}
}
