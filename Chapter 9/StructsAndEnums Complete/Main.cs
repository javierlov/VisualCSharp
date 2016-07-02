using System;

namespace StructsAndEnums
{
	class Application
	{
		static void Entrance()
		{
			Month first = Month.January;
			Console.WriteLine(first);
			Date defaultDate = new Date();
			defaultDate.Write();
			Console.WriteLine();
			Date halloween = new Date(2001, Month.October, 31);
			halloween.Write();
			Console.WriteLine();
		}

		static void Main()
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
