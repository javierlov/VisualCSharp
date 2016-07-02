using System;

namespace NorthwindServices
{
	/// <summary>
	/// Summary description for Product.
	/// </summary>
	public class Product
	{
		private int productID;
		private string productName;
		private int supplierID;
		private int categoryID;
		private string quantityPerUnit;
		private decimal unitPrice;
		private short unitsInStock;
		private short unitsOnOrder;
		private short reorderLevel;
		private bool discontinued;

		public Product()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public int ProductID
		{
			get
			{
				return this.productID;
			}

			set
			{
				this.productID = value;
			}
		}

		public string ProductName
		{
			get
			{
				return this.productName;
			}

			set
			{
				this.productName = value;
			}
		}

		public int SupplierID
		{
			get
			{
				return this.supplierID;
			}

			set
			{
				this.supplierID = value;
			}
		}

		public int CategoryID
		{
			get
			{
				return this.categoryID;
			}

			set
			{
				this.categoryID = value;
			}
		}

		public string QuantityPerUnit
		{
			get
			{
				return this.quantityPerUnit;
			}

			set
			{
				this.quantityPerUnit = value;
			}
		}

		public decimal UnitPrice
		{
			get
			{
				return this.unitPrice;
			}

			set
			{
				this.unitPrice = value;
			}
		}

		public short UnitsInStock
		{
			get
			{
				return this.unitsInStock;
			}

			set
			{
				this.unitsInStock = value;
			}
		}

		public short UnitsOnOrder
		{
			get
			{
				return this.unitsOnOrder;
			}

			set
			{
				this.unitsOnOrder = value;
			}
		}

		public short ReorderLevel
		{
			get
			{
				return this.reorderLevel;
			}

			set
			{
				this.reorderLevel = value;
			}
		}

		public bool Discontinued
		{
			get
			{
				return this.discontinued;
			}

			set
			{
				this.discontinued = value;
			}
		}
	}
}
