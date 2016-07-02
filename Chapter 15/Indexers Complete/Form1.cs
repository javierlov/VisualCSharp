using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Indexers
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox phoneNumber;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button findPhone;
		private System.Windows.Forms.Button findName;
		private System.Windows.Forms.Button add;
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
			this.name = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.findPhone = new System.Windows.Forms.Button();
			this.phoneNumber = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.findName = new System.Windows.Forms.Button();
			this.add = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// name
			// 
			this.name.Location = new System.Drawing.Point(24, 48);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(144, 20);
			this.name.TabIndex = 0;
			this.name.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "name";
			// 
			// findPhone
			// 
			this.findPhone.Location = new System.Drawing.Point(184, 32);
			this.findPhone.Name = "findPhone";
			this.findPhone.Size = new System.Drawing.Size(72, 23);
			this.findPhone.TabIndex = 2;
			this.findPhone.Text = "Search -->";
			this.findPhone.Click += new System.EventHandler(this.findPhone_Click);
			// 
			// phoneNumber
			// 
			this.phoneNumber.Location = new System.Drawing.Point(272, 48);
			this.phoneNumber.Name = "phoneNumber";
			this.phoneNumber.Size = new System.Drawing.Size(144, 20);
			this.phoneNumber.TabIndex = 3;
			this.phoneNumber.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(272, 24);
			this.label2.Name = "label2";
			this.label2.TabIndex = 4;
			this.label2.Text = "phone number";
			// 
			// findName
			// 
			this.findName.Location = new System.Drawing.Point(184, 56);
			this.findName.Name = "findName";
			this.findName.Size = new System.Drawing.Size(72, 24);
			this.findName.TabIndex = 5;
			this.findName.Text = "<-- Search";
			this.findName.Click += new System.EventHandler(this.findName_Click);
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(24, 80);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(56, 24);
			this.add.TabIndex = 6;
			this.add.Text = "Add";
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(432, 117);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.add,
																		  this.findName,
																		  this.label2,
																		  this.phoneNumber,
																		  this.findPhone,
																		  this.label1,
																		  this.name});
			this.Name = "Form1";
			this.Text = "Phone Book";
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

		private void findPhone_Click(object sender, System.EventArgs e)
		{
			string text = name.Text;
			if (text != "")
			{
				phoneNumber.Text = phoneBook[new Name(text)].Text;
			}
		}

		private void findName_Click(object sender, System.EventArgs e)
		{
			string text = phoneNumber.Text;
			if (text != "")
			{
				name.Text = phoneBook[new PhoneNumber(text)].Text;
			}
		}

		private void add_Click(object sender, System.EventArgs e)
		{
			if (name.Text != "" && phoneNumber.Text != "")
			{
				phoneBook.Add(new Name(name.Text), 
							  new PhoneNumber(phoneNumber.Text));
				name.Text = "";
				phoneNumber.Text = "";
			}
		}

		private PhoneBook phoneBook = new PhoneBook();
	}
}
