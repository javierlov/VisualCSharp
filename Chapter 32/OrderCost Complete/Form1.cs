using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using OrderCost.localhost;

namespace OrderCost
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox productName;
		private System.Windows.Forms.TextBox totalCost;
		private System.Windows.Forms.NumericUpDown numberRequired;
		private System.Windows.Forms.Button howMuchButton;
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
			this.productName = new System.Windows.Forms.TextBox();
			this.totalCost = new System.Windows.Forms.TextBox();
			this.numberRequired = new System.Windows.Forms.NumericUpDown();
			this.howMuchButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numberRequired)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Product Name";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 0;
			this.label2.Text = "Number Required";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 200);
			this.label3.Name = "label3";
			this.label3.TabIndex = 0;
			this.label3.Text = "Total Cost";
			// 
			// productName
			// 
			this.productName.Location = new System.Drawing.Point(128, 40);
			this.productName.Name = "productName";
			this.productName.TabIndex = 1;
			this.productName.Text = "";
			// 
			// totalCost
			// 
			this.totalCost.Location = new System.Drawing.Point(128, 200);
			this.totalCost.Name = "totalCost";
			this.totalCost.TabIndex = 1;
			this.totalCost.Text = "";
			// 
			// numberRequired
			// 
			this.numberRequired.Location = new System.Drawing.Point(128, 80);
			this.numberRequired.Name = "numberRequired";
			this.numberRequired.Size = new System.Drawing.Size(104, 20);
			this.numberRequired.TabIndex = 2;
			// 
			// howMuchButton
			// 
			this.howMuchButton.Location = new System.Drawing.Point(16, 136);
			this.howMuchButton.Name = "howMuchButton";
			this.howMuchButton.TabIndex = 3;
			this.howMuchButton.Text = "How Much";
			this.howMuchButton.Click += new System.EventHandler(this.howMuchClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.howMuchButton,
																		  this.numberRequired,
																		  this.totalCost,
																		  this.productName,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "Order Cost";
			((System.ComponentModel.ISupportInitialize)(this.numberRequired)).EndInit();
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

		private void howMuchCallback(IAsyncResult ar)
		{
			try
			{
				ProductService productService = (ProductService)ar.AsyncState;
				decimal totCost = productService.EndHowMuchWillItCost(ar);
				totalCost.Text = totCost.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error getting response: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void howMuchClick(object sender, System.EventArgs e)
		{
			ProductService productService = new ProductService();
			try
			{
				AsyncCallback callback = new AsyncCallback(howMuchCallback);
				IAsyncResult running = productService.BeginHowMuchWillItCost(productName.Text, Int32.Parse(numberRequired.Text), callback, productService);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error sending request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
