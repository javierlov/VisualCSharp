using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace NorthwindServices
{
	/// <summary>
	/// Summary description for Service1.
	/// </summary>
	[WebService (Namespace="http://contentmaster.com/NorthwindServices")]
	public class ProductService : System.Web.Services.WebService
	{
		public ProductService()
		{
			//CODEGEN: This call is required by the ASP.NET Web Services Designer
			InitializeComponent();
		}
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
		}
		#endregion
		
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
		}

		[WebMethod]
		public decimal HowMuchWillItCost(string productName, int howMany)
		{
			try
			{
				SqlConnection sqlConn = new SqlConnection("data source=MOCKTURTLE\\NetSDK;initial catalog=Northwind;integrated security=true");
				SqlCommand sqlCmd = new SqlCommand();
				sqlCmd.CommandText = "SELECT UnitPrice FROM Products WHERE ProductName = '" + productName + "'";
				sqlCmd.Connection = sqlConn;
				sqlConn.Open();
				decimal price = (decimal)sqlCmd.ExecuteScalar();
				sqlConn.Close();
				return price * howMany;
			}
			catch (Exception e)
			{
				throw new Exception("Error calculating cost: " + e.Message);
			}
		}

		[WebMethod]
		public Product GetProductInfo(string productName)
		{
			Product product = new Product();
			try
			{
				SqlConnection sqlConn = new SqlConnection("data source=MOCKTURTLE\\NetSDK;initial catalog=Northwind;integrated security=true");;
				SqlCommand sqlCmd = new SqlCommand();
				sqlCmd.CommandText = "SELECT * FROM Products WHERE ProductName = '" + productName + "'";
				sqlCmd.Connection = sqlConn;
				sqlConn.Open();
				SqlDataReader productData = sqlCmd.ExecuteReader();
				if (productData.Read())
				{
					product.ProductID = productData.GetInt32(0);
					product.ProductName = productData.GetString(1);
					product.SupplierID = productData.GetInt32(2);
					product.CategoryID = productData.GetInt32(3);
					product.QuantityPerUnit = productData.GetString(4);
					product.UnitPrice = productData.GetDecimal(5);
					product.UnitsInStock = productData.GetInt16(6);
					product.UnitsOnOrder = productData.GetInt16(7);
					product.ReorderLevel = productData.GetInt16(8);
					product.Discontinued = productData.GetBoolean(9);
				}
				else
				{
					throw new Exception ("Product " + productName + " not found");
				}
				productData.Close();
				sqlConn.Close();
				return product;
			}
			catch(Exception e)
			{
				throw new Exception("Error finding product: " + e.Message);
			}
		}
	}
}
