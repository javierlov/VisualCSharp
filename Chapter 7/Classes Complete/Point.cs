using System;

namespace Classes
{
	/// <summary>
	/// Summary description for Point.
	/// </summary>
	class Point
	{
		public static int ObjectCount()
		{
			return objectCount;
		}

		public Point()
		{
			x = 0;
			y = 0;
			objectCount++;
		}

		public Point(int initialX, int initialY)
		{
			x = initialX;
			y = initialY;
			objectCount++;
		}

		public double DistanceTo(Point other)
		{
			int xDiff = x - other.x;
			int yDiff = y - other.y;
			return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
		}

		private int x, y;
		private static int objectCount = 0;
	}

	class Application
	{
		static void Entrance()
		{
			Point origin = new Point();
			Point bottomRight = new Point(600, 800);
			double distance = origin.DistanceTo(bottomRight);
			Console.WriteLine("Distance is :{0}", distance);
			Console.WriteLine("No of Point objects :{0}", Point.ObjectCount());
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
