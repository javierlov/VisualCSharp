using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CSharp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.RichTextBox codeText;
		private System.Windows.Forms.Button Open;
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
			this.Open = new System.Windows.Forms.Button();
			this.codeText = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// Open
			// 
			this.Open.Location = new System.Drawing.Point(200, 248);
			this.Open.Name = "Open";
			this.Open.TabIndex = 1;
			this.Open.Text = "Open";
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// codeText
			// 
			this.codeText.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.codeText.Location = new System.Drawing.Point(8, 16);
			this.codeText.Name = "codeText";
			this.codeText.Size = new System.Drawing.Size(480, 224);
			this.codeText.TabIndex = 0;
			this.codeText.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(496, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.Open,
																		  this.codeText});
			this.Name = "Form1";
			this.Text = "Color Syntax";
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

		private void Open_Click(object sender, System.EventArgs e)
		{
			// to do
		}
	}
}
