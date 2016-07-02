using System;
using System.IO;
using System.Xml;
using System.Xml.Schema;

namespace AnalyzeTimesheets
{
	class Analyze
	{
		static void Main(string[] args)
		{
			if (args.Length < 1)
			{
				Console.WriteLine("Usage: AnalyzeTimesheets <XML file>");
				return;
			}

			try
			{
				// Code to read and validate XML goes here
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception analyzing timesheet: " + e);
			}
		}

		private static void valHandler(Object sender, ValidationEventArgs e)
		{
			Console.WriteLine("Validation failed: " + e.Message);
		}
	}
}
