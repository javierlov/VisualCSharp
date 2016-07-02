using System;

namespace StructsAndEnums
{
	struct Date
	{
		public Date(int ccyy, Month nm, int dd)
		{
			year = ccyy - 1900;
			month = nm;
			day = dd - 1;
		}

		public void Write()
		{
			Console.Write(month);
			Console.Write(" ");
			Console.Write(day + 1);
			Console.Write(" ");
			Console.Write(year + 1900);
		}

		private int year;
		private Month month;
		private int day;
	}
}