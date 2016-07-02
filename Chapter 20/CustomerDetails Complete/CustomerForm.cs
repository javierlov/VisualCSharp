using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace CustomerDetails
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class CustomerForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox title;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox foreName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox lastName;
		private System.Windows.Forms.GroupBox gender;
		private System.Windows.Forms.RadioButton male;
		private System.Windows.Forms.RadioButton female;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.ComponentModel.IContainer components;

		public CustomerForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			title.Text = "Mr";
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
			this.gender = new System.Windows.Forms.GroupBox();
			this.female = new System.Windows.Forms.RadioButton();
			this.male = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.title = new System.Windows.Forms.ComboBox();
			this.lastName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.foreName = new System.Windows.Forms.TextBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider();
			this.gender.SuspendLayout();
			this.SuspendLayout();
			// 
			// gender
			// 
			this.gender.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.female,
																				 this.male});
			this.gender.Location = new System.Drawing.Point(72, 136);
			this.gender.Name = "gender";
			this.gender.Size = new System.Drawing.Size(144, 100);
			this.gender.TabIndex = 5;
			this.gender.TabStop = false;
			this.gender.Text = "Gender";
			// 
			// female
			// 
			this.female.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.female.Location = new System.Drawing.Point(16, 64);
			this.female.Name = "female";
			this.female.TabIndex = 7;
			this.female.Text = "Female";
			// 
			// male
			// 
			this.male.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.male.Checked = true;
			this.male.Location = new System.Drawing.Point(16, 32);
			this.male.Name = "male";
			this.male.TabIndex = 6;
			this.male.TabStop = true;
			this.male.Text = "Male";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			// 
			// title
			// 
			this.title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.title.DropDownWidth = 72;
			this.title.Items.AddRange(new object[] {
													   "Mr",
													   "Mrs",
													   "Miss",
													   "Ms"});
			this.title.Location = new System.Drawing.Point(72, 40);
			this.title.Name = "title";
			this.title.Size = new System.Drawing.Size(72, 28);
			this.title.TabIndex = 1;
			// 
			// lastName
			// 
			this.lastName.Location = new System.Drawing.Point(232, 88);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(144, 26);
			this.lastName.TabIndex = 4;
			this.lastName.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Name";
			// 
			// foreName
			// 
			this.foreName.Location = new System.Drawing.Point(72, 88);
			this.foreName.Name = "foreName";
			this.foreName.Size = new System.Drawing.Size(144, 26);
			this.foreName.TabIndex = 3;
			this.foreName.Text = "";
			// 
			// errorProvider
			// 
			this.errorProvider.DataMember = null;
			// 
			// CustomerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(384, 245);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.gender,
																		  this.lastName,
																		  this.label2,
																		  this.foreName,
																		  this.label1,
																		  this.title});
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "CustomerForm";
			this.Text = "Customer Details";
			this.gender.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		// Comprobación cruzada del género y el título para asegurarse
		// de que se corresponden
		public bool checkTitleAndGender()
		{
			if (title.Text == "Mr")
			{
				// Comprueba que el género vale Male
				if (!male.Checked)
				{
					errorProvider.SetError(gender, "If the title is Mr the gender must be male");
					errorProvider.SetError(title, "If the gender must be female the title must be Mrs, Miss, or Ms");
					return false;
				}
			}
			else
			{
				// Comprueba que el género vale Female
				if (!female.Checked)
				{
					errorProvider.SetError(gender, "If the title is Mrs, Miss, or Ms the gender must be female");
					errorProvider.SetError(title, "If the gender is male the title must be Mr");
					return false;
				}
			}

			// Título y genero casan – borrar los errores
			errorProvider.SetError(gender, "");
			errorProvider.SetError(title, "");
			return true;
		}
	}
}
