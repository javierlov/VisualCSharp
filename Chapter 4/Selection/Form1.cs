using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Selection
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button quit;
		private System.Windows.Forms.DateTimePicker first;
		private System.Windows.Forms.Button compare;
		private System.Windows.Forms.DateTimePicker second;
		private System.Windows.Forms.TextBox info;
		private System.Windows.Forms.Label label2;
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
			this.quit = new System.Windows.Forms.Button();
			this.compare = new System.Windows.Forms.Button();
			this.info = new System.Windows.Forms.TextBox();
			this.first = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.second = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// quit
			// 
			this.quit.Location = new System.Drawing.Point(240, 208);
			this.quit.Name = "quit";
			this.quit.Size = new System.Drawing.Size(40, 23);
			this.quit.TabIndex = 4;
			this.quit.Text = "Quit";
			this.quit.Click += new System.EventHandler(this.quit_Click);
			// 
			// compare
			// 
			this.compare.Location = new System.Drawing.Point(16, 80);
			this.compare.Name = "compare";
			this.compare.Size = new System.Drawing.Size(72, 24);
			this.compare.TabIndex = 2;
			this.compare.Text = "Compare";
			this.compare.Click += new System.EventHandler(this.compare_Click);
			// 
			// info
			// 
			this.info.Enabled = false;
			this.info.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.info.Location = new System.Drawing.Point(16, 120);
			this.info.Multiline = true;
			this.info.Name = "info";
			this.info.Size = new System.Drawing.Size(208, 112);
			this.info.TabIndex = 3;
			this.info.Text = "";
			// 
			// first
			// 
			this.first.Location = new System.Drawing.Point(72, 24);
			this.first.Name = "first";
			this.first.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "first";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "second";
			// 
			// second
			// 
			this.second.Location = new System.Drawing.Point(72, 48);
			this.second.Name = "second";
			this.second.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 245);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.second,
																		  this.quit,
																		  this.info,
																		  this.compare,
																		  this.label1,
																		  this.first});
			this.Name = "Form1";
			this.Text = "Dates";
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

		private void quit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void compare_Click(object sender, System.EventArgs e)
		{
			int diff = dateCompare(first.Value, second.Value);
			info.Text = "";
			show("first == second", diff == 0);
			show("first != second", diff != 0);
			show("first <  second", diff <  0);
			show("first <= second", diff <= 0);
			show("first >  second", diff >  0);
			show("first >= second", diff >= 0);
		}

		private void show(string exp, bool result)
		{
			info.Text += exp;
			info.Text += " : " + result.ToString();
			info.Text += "\r\n";
		}

		private int dateCompare(DateTime lhs, DateTime rhs)
		{
			// TO DO
			return 42;
		}
	}
}
	