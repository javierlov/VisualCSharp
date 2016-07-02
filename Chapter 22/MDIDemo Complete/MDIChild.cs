using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace MDIDemo
{
	/// <summary>
	/// Summary description for MDIChild.
	/// </summary>
	public class MDIChild : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox editData;
		private System.Windows.Forms.MainMenu childMenu;
		private System.Windows.Forms.MenuItem fileItem;
		private System.Windows.Forms.MenuItem saveItem;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MDIChild()
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
				if(components != null)
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
			this.editData = new System.Windows.Forms.TextBox();
			this.childMenu = new System.Windows.Forms.MainMenu();
			this.fileItem = new System.Windows.Forms.MenuItem();
			this.saveItem = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// editData
			// 
			this.editData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editData.Multiline = true;
			this.editData.Name = "editData";
			this.editData.Size = new System.Drawing.Size(292, 266);
			this.editData.TabIndex = 0;
			this.editData.Text = "";
			// 
			// childMenu
			// 
			this.childMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.fileItem});
			// 
			// fileItem
			// 
			this.fileItem.Index = 0;
			this.fileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.saveItem,
																					 this.menuItem2});
			this.fileItem.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			this.fileItem.Text = "&File";
			// 
			// saveItem
			// 
			this.saveItem.Index = 0;
			this.saveItem.MergeOrder = 1;
			this.saveItem.Text = "&Save";
			this.saveItem.Click += new System.EventHandler(this.saveItemClick);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 1;
			this.menuItem2.MergeOrder = 1;
			this.menuItem2.Text = "-";
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "txt";
			this.saveFileDialog.InitialDirectory = "C:\\";
			this.saveFileDialog.Title = "MDI Text Editor";
			// 
			// MDIChild
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editData});
			this.Menu = this.childMenu;
			this.Name = "MDIChild";
			this.Text = "MDIChild";
			this.ResumeLayout(false);

		}
		#endregion

		private void saveItemClick(object sender, System.EventArgs e)
		{
			DialogResult buttonClicked = saveFileDialog.ShowDialog();
			if (buttonClicked.Equals(DialogResult.OK))
			{
				Stream saveStream = saveFileDialog.OpenFile();
				StreamWriter saveWriter = new StreamWriter(saveStream);
				foreach (string line in editData.Lines)
				{
					saveWriter.WriteLine(line);
				}
				saveWriter.Close();
			}
		}
	}
}
