using System;

namespace StructsAndEnums
{
	class Application
	{
		static void Entrance()
		{
			// to do
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
