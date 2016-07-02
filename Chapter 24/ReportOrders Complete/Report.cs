using System;
using System.Data.SqlClient;

namespace ReportOrders
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Report
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: Add code to start application here
			//
			try
			{
				SqlConnection dataConnection = new SqlConnection();
				dataConnection.ConnectionString = "Integrated Security=true;Initial Catalog=Northwind;Data Source=MOCKTURTLE\\NetSDK";
				dataConnection.Open();
				Console.WriteLine("Please enter a CustomerID (6 characters): ");
				string customerId = Console.ReadLine();
				SqlCommand dataCommand = new SqlCommand();
				dataCommand.Connection = dataConnection;
				dataCommand.CommandText = "SELECT OrderID, OrderDate, ShippedDate, ShipName, ShipAddress, ShipCity, ShipCountry ";
				dataCommand.CommandText += "FROM Orders WHERE CustomerID='" + customerId + "'";
				Console.WriteLine("About to execute: " + dataCommand.CommandText);
				SqlDataReader dataReader = dataCommand.ExecuteReader();
				while (dataReader.Read())
				{
					int orderId = dataReader.GetInt32(0);
					if (dataReader.IsDBNull(2))
					{
						Console.WriteLine("Order {0} not yet shipped\n\n", orderId);
					}
					else
					{
						DateTime orderDate = dataReader.GetDateTime(1);
						DateTime shipDate = dataReader.GetDateTime(2);
						string shipName = dataReader.GetString(3);
						string shipAddress = dataReader.GetString(4);
						string shipCity = dataReader.GetString(5);
						string shipCountry = dataReader.GetString(6);
						Console.WriteLine("Order {0}\nPlaced {1}\nShipped {2}\nTo Address {3}\n{4}\n{5}\n{6}\n\n", orderId, orderDate, shipDate, shipName, shipAddress, shipCity, shipCountry);
					}
				}
				dataReader.Close();
				dataConnection.Close();
			}
			catch(Exception e)
			{
				Console.WriteLine("An error occurred accessing the database: " + e.Message);
			}
		}
	}
}
