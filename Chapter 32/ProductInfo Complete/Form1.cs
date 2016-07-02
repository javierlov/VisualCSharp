using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using ProductInfo.localhost;

namespace ProductInfo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox productName;
		private System.Windows.Forms.TextBox productID;
		private System.Windows.Forms.TextBox supplierID;
		private System.Windows.Forms.TextBox categoryID;
		private System.Windows.Forms.TextBox quantityPerUnit;
		private System.Windows.Forms.TextBox unitPrice;
		private System.Windows.Forms.TextBox unitsInStock;
		private System.Windows.Forms.TextBox unitsOnOrder;
		private System.Windows.Forms.TextBox reorderLevel;
		private System.Windows.Forms.CheckBox discontinued;
		private System.Windows.Forms.Button getButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.productName = new System.Windows.Forms.TextBox();
			this.productID = new System.Windows.Forms.TextBox();
			this.supplierID = new System.Windows.Forms.TextBox();
			this.categoryID = new System.Windows.Forms.TextBox();
			this.quantityPerUnit = new System.Windows.Forms.TextBox();
			this.unitPrice = new System.Windows.Forms.TextBox();
			this.unitsInStock = new System.Windows.Forms.TextBox();
			this.unitsOnOrder = new System.Windows.Forms.TextBox();
			this.reorderLevel = new System.Windows.Forms.TextBox();
			this.discontinued = new System.Windows.Forms.CheckBox();
			this.getButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 24);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Product Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 58);
			this.label2.Name = "label2";
			this.label2.TabIndex = 0;
			this.label2.Text = "Product ID";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 92);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			this.label3.Text = "Supplier ID";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(32, 126);
			this.label4.Name = "label4";
			this.label4.TabIndex = 0;
			this.label4.Text = "Category ID";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(32, 160);
			this.label5.Name = "label5";
			this.label5.TabIndex = 0;
			this.label5.Text = "Quantity Per Unit";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(32, 194);
			this.label6.Name = "label6";
			this.label6.TabIndex = 0;
			this.label6.Text = "Unit Price";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(32, 228);
			this.label7.Name = "label7";
			this.label7.TabIndex = 0;
			this.label7.Text = "Units In Stock";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(32, 262);
			this.label8.Name = "label8";
			this.label8.TabIndex = 0;
			this.label8.Text = "Units On Order";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(32, 296);
			this.label9.Name = "label9";
			this.label9.TabIndex = 0;
			this.label9.Text = "Reorder Level";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(32, 330);
			this.label10.Name = "label10";
			this.label10.TabIndex = 0;
			this.label10.Text = "Discontinued";
			// 
			// productName
			// 
			this.productName.Location = new System.Drawing.Point(152, 24);
			this.productName.Name = "productName";
			this.productName.TabIndex = 1;
			this.productName.Text = "";
			// 
			// productID
			// 
			this.productID.Location = new System.Drawing.Point(152, 58);
			this.productID.Name = "productID";
			this.productID.TabIndex = 1;
			this.productID.Text = "";
			// 
			// supplierID
			// 
			this.supplierID.Location = new System.Drawing.Point(152, 92);
			this.supplierID.Name = "supplierID";
			this.supplierID.TabIndex = 1;
			this.supplierID.Text = "";
			// 
			// categoryID
			// 
			this.categoryID.Location = new System.Drawing.Point(152, 126);
			this.categoryID.Name = "categoryID";
			this.categoryID.TabIndex = 1;
			this.categoryID.Text = "";
			// 
			// quantityPerUnit
			// 
			this.quantityPerUnit.Location = new System.Drawing.Point(152, 160);
			this.quantityPerUnit.Name = "quantityPerUnit";
			this.quantityPerUnit.TabIndex = 1;
			this.quantityPerUnit.Text = "";
			// 
			// unitPrice
			// 
			this.unitPrice.Location = new System.Drawing.Point(152, 194);
			this.unitPrice.Name = "unitPrice";
			this.unitPrice.TabIndex = 1;
			this.unitPrice.Text = "";
			// 
			// unitsInStock
			// 
			this.unitsInStock.Location = new System.Drawing.Point(152, 228);
			this.unitsInStock.Name = "unitsInStock";
			this.unitsInStock.TabIndex = 1;
			this.unitsInStock.Text = "";
			// 
			// unitsOnOrder
			// 
			this.unitsOnOrder.Location = new System.Drawing.Point(152, 262);
			this.unitsOnOrder.Name = "unitsOnOrder";
			this.unitsOnOrder.TabIndex = 1;
			this.unitsOnOrder.Text = "";
			// 
			// reorderLevel
			// 
			this.reorderLevel.Location = new System.Drawing.Point(152, 296);
			this.reorderLevel.Name = "reorderLevel";
			this.reorderLevel.TabIndex = 1;
			this.reorderLevel.Text = "";
			// 
			// discontinued
			// 
			this.discontinued.Location = new System.Drawing.Point(152, 336);
			this.discontinued.Name = "discontinued";
			this.discontinued.TabIndex = 2;
			// 
			// getButton
			// 
			this.getButton.Location = new System.Drawing.Point(272, 24);
			this.getButton.Name = "getButton";
			this.getButton.TabIndex = 3;
			this.getButton.Text = "Get";
			this.getButton.Click += new System.EventHandler(this.getButtonClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(384, 373);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.getButton,
																		  this.discontinued,
																		  this.reorderLevel,
																		  this.unitsOnOrder,
																		  this.unitsInStock,
																		  this.unitPrice,
																		  this.quantityPerUnit,
																		  this.categoryID,
																		  this.supplierID,
																		  this.productID,
																		  this.productName,
																		  this.label10,
																		  this.label9,
																		  this.label8,
																		  this.label7,
																		  this.label6,
																		  this.label5,
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "Product Details";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void getButtonClick(object sender, System.EventArgs e)
		{
			ProductService productService = new ProductService();
			try
			{
				Product prod = productService.GetProductInfo(productName.Text);
				productID.Text = prod.ProductID.ToString();
				supplierID.Text = prod.SupplierID.ToString();
				categoryID.Text = prod.CategoryID.ToString();
				quantityPerUnit.Text = prod.QuantityPerUnit;
				unitPrice.Text = prod.UnitPrice.ToString();
				unitsInStock.Text = prod.UnitsInStock.ToString();
				unitsOnOrder.Text = prod.UnitsOnOrder.ToString();
				reorderLevel.Text = prod.ReorderLevel.ToString();
				discontinued.Checked = prod.Discontinued;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error fetching product details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
