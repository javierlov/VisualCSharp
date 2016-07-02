using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.Security;

namespace CustomerInfo
{
	/// <summary>
	/// Summary description for LoginForm.
	/// </summary>
	public class LoginForm : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox UserName;
		protected System.Web.UI.WebControls.TextBox Password;
		protected System.Web.UI.WebControls.Label Message;
		protected System.Web.UI.WebControls.Button Login;
	
		public LoginForm()
		{
			Page.Init += new System.EventHandler(Page_Init);
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
		}

		private void Page_Init(object sender, EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
		}

		#region Web Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Login.Click += new System.EventHandler(this.loginClick);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void loginClick(object sender, System.EventArgs e)
		{
			if (UserName.Text.Equals("John") && Password.Text.Equals("JohnsPassword"))
			{
				Message.Text = "";
				FormsAuthentication.RedirectFromLoginPage(UserName.Text, true);
			}
			else
			{
				Message.Text = "Invalid user name or password";
			}
		}
	}
}
