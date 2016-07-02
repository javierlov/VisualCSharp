using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Data;

namespace whileStatement
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button openFile;
		private System.Windows.Forms.TextBox filename;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.RichTextBox source;
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
			this.openFile = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.filename = new System.Windows.Forms.TextBox();
			this.source = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// openFile
			// 
			this.openFile.Location = new System.Drawing.Point(16, 32);
			this.openFile.Name = "openFile";
			this.openFile.TabIndex = 0;
			this.openFile.Text = "Open File";
			this.openFile.Click += new System.EventHandler(this.openFile_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(104, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 2;
			this.label1.Text = "Current File";
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// filename
			// 
			this.filename.BackColor = System.Drawing.Color.White;
			this.filename.Enabled = false;
			this.filename.Location = new System.Drawing.Point(104, 32);
			this.filename.Name = "filename";
			this.filename.Size = new System.Drawing.Size(232, 20);
			this.filename.TabIndex = 1;
			this.filename.Text = "";
			// 
			// source
			// 
			this.source.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.source.Location = new System.Drawing.Point(16, 72);
			this.source.Name = "source";
			this.source.ReadOnly = true;
			this.source.Size = new System.Drawing.Size(416, 320);
			this.source.TabIndex = 3;
			this.source.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(456, 413);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.source,
																		  this.label1,
																		  this.filename,
																		  this.openFile});
			this.Name = "Form1";
			this.Text = "while Statement";
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

		private void openFile_Click(object sender, System.EventArgs e)
		{
			openFileDialog.ShowDialog();
		}

		private void openFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string fullPathname = openFileDialog.FileName;
			FileInfo src = new FileInfo(fullPathname);
			filename.Text = src.Name;
			source.Text = "";
			TextReader reader = src.OpenText();
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				source.Text += line + "\n";
			}
			reader.Close();
		}
	}
}
