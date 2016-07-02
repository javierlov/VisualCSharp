using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace LoginControl
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class Login : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label userNameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.TextBox userNameText;
		private System.Windows.Forms.TextBox passwordText;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.ErrorProvider loginError;

		public event System.EventHandler LoginSuccess;
		public event System.EventHandler LoginFail;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Login()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.userNameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.userNameText = new System.Windows.Forms.TextBox();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.loginError = new System.Windows.Forms.ErrorProvider();
			this.SuspendLayout();
			// 
			// userNameLabel
			// 
			this.userNameLabel.Location = new System.Drawing.Point(32, 48);
			this.userNameLabel.Name = "userNameLabel";
			this.userNameLabel.TabIndex = 0;
			this.userNameLabel.Text = "user name label";
			// 
			// passwordLabel
			// 
			this.passwordLabel.Location = new System.Drawing.Point(32, 128);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.TabIndex = 1;
			this.passwordLabel.Text = "password label";
			// 
			// userNameText
			// 
			this.userNameText.Location = new System.Drawing.Point(140, 48);
			this.userNameText.Name = "userNameText";
			this.userNameText.Size = new System.Drawing.Size(220, 20);
			this.userNameText.TabIndex = 2;
			this.userNameText.Text = "user name";
			// 
			// passwordText
			// 
			this.passwordText.Location = new System.Drawing.Point(140, 128);
			this.passwordText.Name = "passwordText";
			this.passwordText.PasswordChar = '*';
			this.passwordText.Size = new System.Drawing.Size(220, 20);
			this.passwordText.TabIndex = 3;
			this.passwordText.Text = "password";
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(150, 220);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(100, 36);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Login";
			this.loginButton.Click += new System.EventHandler(this.loginClick);
			// 
			// Login
			// 
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.loginButton,
																		  this.passwordText,
																		  this.userNameText,
																		  this.passwordLabel,
																		  this.userNameLabel});
			this.Name = "Login";
			this.Size = new System.Drawing.Size(400, 300);
			this.ResumeLayout(false);

		}
		#endregion

		private void loginClick(object sender, System.EventArgs e)
		{
			if (userNameText.Text.Length == 0)
			{
				loginError.SetError(userNameText, "Please enter a user name");
				return;
			}

			if (passwordText.Text.Length == 0)
			{
				loginError.SetError(passwordText, "Please enter a password");
				return;
			}

			if (userNameAndPasswordAreValid(userNameText.Text, passwordText.Text))
			{
				if (LoginSuccess != null)
				{
					LoginSuccess(this, new System.EventArgs());
				}
			}
			else
			{
				if (LoginFail != null)
				{
					LoginFail(this, new System.EventArgs());
				}
			}
		}

		private bool userNameAndPasswordAreValid(string userName, string password)
		{
			return password.Equals("TrustMe");
		}

		public string UserNameLabel
		{
			get
			{
				return userNameLabel.Text;
			}
			set
			{
				userNameLabel.Text = value;
			}
		}

		public string PasswordLabel
		{
			get
			{
				return passwordLabel.Text;
			}
			set
			{
				passwordLabel.Text = value;
			}
		}

		public string LoginButtonText
		{
			get
			{
				return loginButton.Text;
			}
			set
			{
				loginButton.Text = value;
			}
		}

		[Browsable(false)]
		public string UserName
		{
			set
			{
				userNameText.Text = value;
			}
		}

		[Browsable(false)]
		public string Password
		{
			set
			{
				passwordText.Text = value;
			}
		}
	}
}
