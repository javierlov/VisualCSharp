using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Properties
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox width;
		private System.Windows.Forms.TextBox height;
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
			resize();
			this.Resize += new System.EventHandler(resize);
		}

		private void resize(object sender, System.EventArgs e)
		{
			resize();
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
			this.width = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.height = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// width
			// 
			this.width.Enabled = false;
			this.width.Location = new System.Drawing.Point(40, 32);
			this.width.Name = "width";
			this.width.Size = new System.Drawing.Size(64, 20);
			this.width.TabIndex = 1;
			this.width.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(40, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "width";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(120, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "height";
			// 
			// height
			// 
			this.height.Enabled = false;
			this.height.Location = new System.Drawing.Point(120, 32);
			this.height.Name = "height";
			this.height.Size = new System.Drawing.Size(64, 20);
			this.height.TabIndex = 3;
			this.height.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(224, 69);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.height,
																		  this.label2,
																		  this.width,
																		  this.label1});
			this.Name = "Form1";
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

		private void resize()
		{
			int w = Size.Width;
			width.Text = w.ToString();
			int h = Size.Height;
			height.Text = h.ToString();
			string s = string.Format("({0}, {1})", w, h);
			Text = s;
		}
	}
}
