using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Operators
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox time;
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
			ticker.tick += new Tick(tock);
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
			this.time = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// time
			// 
			this.time.Enabled = false;
			this.time.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.time.Location = new System.Drawing.Point(32, 16);
			this.time.Name = "time";
			this.time.Size = new System.Drawing.Size(144, 38);
			this.time.TabIndex = 0;
			this.time.Text = "12:12:12";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(200, 69);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.time});
			this.Name = "Form1";
			this.Text = "Digital Clock";
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

		private void tock()
		{
			time.Text = string.Format("{0:D2}:{1:D2}:{2:D2}",
				digital.Hour,
				digital.Minute,
				digital.Second);
		}

		private Ticker ticker = new Ticker();
		private Clock digital = new Clock();
	}
}
