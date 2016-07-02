using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PrimitiveDataTypes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox value;
		private System.Windows.Forms.Button quit;
		private System.Windows.Forms.ListBox type;
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
			this.type = new System.Windows.Forms.ListBox();
			this.quit = new System.Windows.Forms.Button();
			this.value = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// type
			// 
			this.type.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.type.ItemHeight = 16;
			this.type.Items.AddRange(new object[] {
													  "int",
													  "long",
													  "float",
													  "double",
													  "decimal",
													  "string",
													  "char",
													  "bool"});
			this.type.Location = new System.Drawing.Point(24, 72);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(120, 148);
			this.type.TabIndex = 6;
			this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
			// 
			// quit
			// 
			this.quit.Location = new System.Drawing.Point(200, 200);
			this.quit.Name = "quit";
			this.quit.TabIndex = 5;
			this.quit.Text = "Quit";
			this.quit.Click += new System.EventHandler(this.quit_Click);
			// 
			// value
			// 
			this.value.Enabled = false;
			this.value.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.value.Location = new System.Drawing.Point(176, 72);
			this.value.Name = "value";
			this.value.TabIndex = 4;
			this.value.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(56, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Primitive Data Types";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Choose a data type";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(176, 48);
			this.label3.Name = "label3";
			this.label3.TabIndex = 3;
			this.label3.Text = "Sample value";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 237);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.type,
																		  this.quit,
																		  this.value,
																		  this.label3,
																		  this.label2,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "Data Test";
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

		private void type_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch (type.Text)
			{
				case "int" :
					showIntValue();
					break;
				case "long" :
					showLongValue();
					break;
				case "float" :
					showFloatValue();
					break;
				case "double" :
					showDoubleValue();
					break;
				case "decimal" :
					showDecimalValue();
					break;
				case "string" :
					showStringValue();
					break;
				case "char" :
					showCharValue();
					break;
				case "bool" :
					showBoolValue();
					break;
			}
		}

		private void showIntValue()
		{
			int var;
			var = 42;
			value.Text = "42";
		}

		private void showLongValue()
		{
			long var;
			var = 42L;
			value.Text = "42L";
		}

		private void showFloatValue()
		{
			float var;
			var = 0.42F;
			value.Text = "0.42F";
		}

		private void showDoubleValue()
		{
			double var;
			var = 0.42;
			value.Text = "0.42";
		}

		private void showDecimalValue()
		{
			decimal var;
			var = 0.42M;
			value.Text = "0.42M";
		}

		private void showStringValue()
		{
			string var;
			var = "42";
			value.Text = "\"42\"";
		}

		private void showCharValue()
		{
			char var;
			var = '4';
			value.Text = "'4'";
		}

		private void showBoolValue()
		{
			bool var;
			var = false;
			value.Text = "false";
		}

		private void quit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
