using System;

namespace DailyRate
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		static void Main(string[] args)
		{
			(new Class1()).run();
		}

		public void run()
		{
			double dailyRate = readDouble("Enter your daily rate: ");
			int noOfDays = readInt("Enter the number of days: ");
			writeFee(calculateFee(dailyRate, noOfDays));
		}

		public double readDouble(string prompt)
		{
			Console.Write(prompt);
			string line = Console.ReadLine();
			return double.Parse(line);
		}

		public int readInt(string prompt)
		{
			Console.Write(prompt);
			string line = Console.ReadLine();
			return int.Parse(line);
		}

		public double calculateFee(double dailyRate, int noOfDays)
		{
			return dailyRate * noOfDays;
		}

		public void writeFee(double fee)
		{
			Console.WriteLine("The consultant's fee is: {0}", fee * 1.1);
		}
	}
}
