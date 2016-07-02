using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ToggleButtonTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private SubclassedControls.ToggleButton toggleButton1;
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
			this.toggleButton1 = new SubclassedControls.ToggleButton();
			this.SuspendLayout();
			// 
			// toggleButton1
			// 
			this.toggleButton1.Appearance = System.Windows.Forms.Appearance.Button;
			this.toggleButton1.BackColor = System.Drawing.Color.Green;
			this.toggleButton1.CheckedColor = System.Drawing.Color.Red;
			this.toggleButton1.CheckedText = "On";
			this.toggleButton1.ForeColor = System.Drawing.Color.White;
			this.toggleButton1.Location = new System.Drawing.Point(96, 112);
			this.toggleButton1.Name = "toggleButton1";
			this.toggleButton1.TabIndex = 0;
			this.toggleButton1.Text = "Off";
			this.toggleButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toggleButton1.UncheckedColor = System.Drawing.Color.Green;
			this.toggleButton1.UncheckedText = "Off";
			this.toggleButton1.Click += new System.EventHandler(this.toggleClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.toggleButton1});
			this.Name = "Form1";
			this.Text = "Form1";
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

		private void toggleClick(object sender, System.EventArgs e)
		{
			MessageBox.Show("Changing state", "Changing");
		}
	}
}
