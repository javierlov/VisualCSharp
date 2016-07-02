using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace doStatement
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox number;
		private System.Windows.Forms.Button showSteps;
		private System.Windows.Forms.TextBox steps;
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
			this.number = new System.Windows.Forms.TextBox();
			this.showSteps = new System.Windows.Forms.Button();
			this.steps = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter number";
			// 
			// number
			// 
			this.number.Location = new System.Drawing.Point(16, 40);
			this.number.Name = "number";
			this.number.Size = new System.Drawing.Size(112, 20);
			this.number.TabIndex = 1;
			this.number.Text = "";
			// 
			// showSteps
			// 
			this.showSteps.Location = new System.Drawing.Point(16, 72);
			this.showSteps.Name = "showSteps";
			this.showSteps.TabIndex = 2;
			this.showSteps.Text = "Show Steps";
			this.showSteps.Click += new System.EventHandler(this.showSteps_Click);
			// 
			// steps
			// 
			this.steps.Enabled = false;
			this.steps.Location = new System.Drawing.Point(16, 104);
			this.steps.Multiline = true;
			this.steps.Name = "steps";
			this.steps.Size = new System.Drawing.Size(136, 184);
			this.steps.TabIndex = 3;
			this.steps.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(168, 301);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.steps,
																		  this.showSteps,
																		  this.number,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "do Statement";
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

		private void showSteps_Click(object sender, System.EventArgs e)
		{
			int amount = System.Int32.Parse(number.Text);

			steps.Text = "";
			string current = "";
			do
			{
				int digitCode = '0' + amount % 10;
				char digit = Convert.ToChar(digitCode);
				current = digit + current;
				steps.Text += current + "\r\n";
				amount /= 10;
			}	
			while (amount != 0);
		}
	}
}
