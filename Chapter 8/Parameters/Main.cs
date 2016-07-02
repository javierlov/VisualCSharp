using System;

namespace Parameters
{
	class Application
	{
		static void Entrance()
		{
			// to do
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
