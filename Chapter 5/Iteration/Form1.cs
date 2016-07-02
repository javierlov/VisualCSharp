using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Iteration
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton For;
		private System.Windows.Forms.RadioButton While;
		private System.Windows.Forms.RadioButton Do;
		private System.Windows.Forms.TextBox code;
		private System.Windows.Forms.TextBox outcome;
		private System.Windows.Forms.Button quit;
		private System.Windows.Forms.RadioButton Break;
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
			this.For = new System.Windows.Forms.RadioButton();
			this.code = new System.Windows.Forms.TextBox();
			this.Break = new System.Windows.Forms.RadioButton();
			this.outcome = new System.Windows.Forms.TextBox();
			this.While = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Do = new System.Windows.Forms.RadioButton();
			this.quit = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// For
			// 
			this.For.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.For.Location = new System.Drawing.Point(16, 48);
			this.For.Name = "For";
			this.For.Size = new System.Drawing.Size(80, 16);
			this.For.TabIndex = 0;
			this.For.Text = "for";
			this.For.CheckedChanged += new System.EventHandler(this.For_CheckedChanged);
			// 
			// code
			// 
			this.code.BackColor = System.Drawing.Color.White;
			this.code.Enabled = false;
			this.code.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.code.ForeColor = System.Drawing.Color.Black;
			this.code.Location = new System.Drawing.Point(8, 40);
			this.code.Multiline = true;
			this.code.Name = "code";
			this.code.Size = new System.Drawing.Size(320, 160);
			this.code.TabIndex = 3;
			this.code.Text = "";
			// 
			// Break
			// 
			this.Break.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Break.Location = new System.Drawing.Point(16, 96);
			this.Break.Name = "Break";
			this.Break.Size = new System.Drawing.Size(136, 16);
			this.Break.TabIndex = 5;
			this.Break.Text = "continue/break";
			this.Break.CheckedChanged += new System.EventHandler(this.Break_CheckedChanged);
			// 
			// outcome
			// 
			this.outcome.BackColor = System.Drawing.Color.White;
			this.outcome.Enabled = false;
			this.outcome.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.outcome.ForeColor = System.Drawing.Color.Black;
			this.outcome.Location = new System.Drawing.Point(8, 224);
			this.outcome.Multiline = true;
			this.outcome.Name = "outcome";
			this.outcome.Size = new System.Drawing.Size(136, 168);
			this.outcome.TabIndex = 6;
			this.outcome.Text = "";
			// 
			// While
			// 
			this.While.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.While.Location = new System.Drawing.Point(16, 24);
			this.While.Name = "While";
			this.While.Size = new System.Drawing.Size(80, 16);
			this.While.TabIndex = 1;
			this.While.Text = "while";
			this.While.CheckedChanged += new System.EventHandler(this.While_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Iteration Statements";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Code";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 208);
			this.label3.Name = "label3";
			this.label3.TabIndex = 5;
			this.label3.Text = "Outcome";
			// 
			// Do
			// 
			this.Do.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Do.Location = new System.Drawing.Point(16, 72);
			this.Do.Name = "Do";
			this.Do.Size = new System.Drawing.Size(64, 16);
			this.Do.TabIndex = 2;
			this.Do.Text = "do";
			this.Do.CheckedChanged += new System.EventHandler(this.Do_CheckedChanged);
			// 
			// quit
			// 
			this.quit.Location = new System.Drawing.Point(272, 368);
			this.quit.Name = "quit";
			this.quit.Size = new System.Drawing.Size(56, 24);
			this.quit.TabIndex = 7;
			this.quit.Text = "Quit";
			this.quit.Click += new System.EventHandler(this.quit_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.Break,
																					this.Do,
																					this.While,
																					this.For});
			this.groupBox1.Location = new System.Drawing.Point(160, 232);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(168, 128);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Keywords";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 397);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.quit,
																		  this.outcome,
																		  this.label3,
																		  this.label2,
																		  this.code,
																		  this.groupBox1,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "Iteration";
			this.groupBox1.ResumeLayout(false);
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

		private void Break_CheckedChanged(object sender, System.EventArgs e)
		{
			if (Break.Checked)
			{
				code.Text =
@"int i = 0;
while (true)
{
    Console.WriteLine(""continue"" + i);
    i++;
    if (i != 10)
        continue;
    else
        break;
}";

				outcome.Text = "";
				int i = 0;
				while (true)
				{
					string line = "continue " + i;
					outcome.Text += line + "\r\n";
					i++;
					if (i != 10)
						continue;
					else
						break;
				}
			}
		}

		private void While_CheckedChanged(object sender, System.EventArgs e)
		{
			if (While.Checked)
			{
				code.Text = 
@"int i = 0;
while (i != 10)
{
    Console.WriteLine(""while "" + i);
    i++;
}";

				outcome.Text = "";
				int i = 0;
				while (i != 10) 
				{
					string line = "while " + i;
					outcome.Text += line + "\r\n";
					i++;
				}
			}
		}

		private void Do_CheckedChanged(object sender, System.EventArgs e)
		{
			if (Do.Checked)
			{
				code.Text = 
@"int i = 0;
do
{
    Console.WriteLine(""do "" + i);
    i++;
}
while (i != 10);";

				outcome.Text = "";
				int i = 0; 
				do
				{
					string line = "do " + i;
					outcome.Text += line + "\r\n";
					i++;
				}
				while (i != 10);
			}
		}

		private void For_CheckedChanged(object sender, System.EventArgs e)
		{
			if (For.Checked)
			{
				code.Text = 
@"for (int i = 0; i != 10; i++)
{
    Console.WriteLine(""for "" + i);
}";

				outcome.Text = "";
				for (int i = 0; i != 10; i++) 
				{
					string line = "for " + i;
					outcome.Text += line + "\r\n";
				}
			}
		}

		private void quit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
