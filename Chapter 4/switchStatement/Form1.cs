using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace switchStatement
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox source;
		private System.Windows.Forms.TextBox target;
		private System.Windows.Forms.Button copy;
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
			this.copy = new System.Windows.Forms.Button();
			this.source = new System.Windows.Forms.TextBox();
			this.target = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// copy
			// 
			this.copy.Location = new System.Drawing.Point(128, 80);
			this.copy.Name = "copy";
			this.copy.Size = new System.Drawing.Size(48, 32);
			this.copy.TabIndex = 1;
			this.copy.Text = "Copy";
			this.copy.Click += new System.EventHandler(this.copy_Click);
			// 
			// source
			// 
			this.source.Location = new System.Drawing.Point(8, 16);
			this.source.Multiline = true;
			this.source.Name = "source";
			this.source.Size = new System.Drawing.Size(280, 48);
			this.source.TabIndex = 0;
			this.source.Text = "";
			// 
			// target
			// 
			this.target.Enabled = false;
			this.target.Location = new System.Drawing.Point(8, 128);
			this.target.Multiline = true;
			this.target.Name = "target";
			this.target.Size = new System.Drawing.Size(280, 48);
			this.target.TabIndex = 2;
			this.target.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(304, 189);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.target,
																		  this.copy,
																		  this.source});
			this.Name = "Form1";
			this.Text = "switch Statement";
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

		private void copy_Click(object sender, System.EventArgs e)
		{
			target.Text = "";
			string from = source.Text;
			for (int i = 0; i != from.Length; i++)
			{
				char current = from[i];
				copyOne(current);
			}
		}

		private void copyOne(char current)
		{
			switch (current) 
			{				
				default :
					if (current < 127) 
						target.Text += current;
					else 
					{
						target.Text += "&#";
						string code = ((int)current).ToString();
						target.Text += code;
						target.Text += ";";
					}
					break;                
			}
		}
	}
}

	
/*
case '<' :
	target.Text += "&lt;";
	break;
case '>' :
	target.Text += "&gt;";
	break;
case '&' :
	target.Text += "&amp;";
	break;
case '\"' :
	target.Text +=  "&#34;";
	break;
case '\'' :
	target.Text += "&#39;";
	break;		
*/

