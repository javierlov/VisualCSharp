using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace LoginTest
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private LoginControl.Login login1;
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
			this.login1 = new LoginControl.Login();
			this.SuspendLayout();
			// 
			// login1
			// 
			this.login1.Location = new System.Drawing.Point(20, 20);
			this.login1.LoginButtonText = "Validate";
			this.login1.Name = "login1";
			this.login1.PasswordLabel = "Password:";
			this.login1.Size = new System.Drawing.Size(400, 300);
			this.login1.TabIndex = 0;
			this.login1.UserNameLabel = "Name:";
			this.login1.LoginFail += new System.EventHandler(this.loginFail);
			this.login1.LoginSuccess += new System.EventHandler(this.loginSuccess);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(448, 326);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.login1});
			this.ForeColor = System.Drawing.Color.LightGray;
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

		private void loginFail(object sender, System.EventArgs e)
		{
			MessageBox.Show("Login failed", "Fail");
		}

		private void loginSuccess(object sender, System.EventArgs e)
		{
			MessageBox.Show("Login succeeded", "Success");
		}
	}
}
