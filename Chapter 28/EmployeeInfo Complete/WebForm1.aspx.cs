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

namespace EmployeeInfo
{
	/// <summary>
	/// Summary description for WebForm1.
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.TextBox FirstName;
		protected System.Web.UI.WebControls.TextBox LastName;
		protected System.Web.UI.WebControls.TextBox EmployeeId;
		protected System.Web.UI.WebControls.RadioButton WorkerButton;
		protected System.Web.UI.WebControls.RadioButton BossButton;
		protected System.Web.UI.WebControls.RadioButton VPButton;
		protected System.Web.UI.WebControls.RadioButton PresidentButton;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.DropDownList PositionRole;
		protected System.Web.UI.WebControls.Label InfoLabel;
		protected System.Web.UI.WebControls.Button SaveButton;
		protected System.Web.UI.WebControls.Button ClearButton;
		protected System.Web.UI.WebControls.Label Label5;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
			if (!IsPostBack)
				initPositionRole();
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.PresidentButton.CheckedChanged += new System.EventHandler(this.PresidentChecked);
			this.VPButton.CheckedChanged += new System.EventHandler(this.VPChecked);
			this.BossButton.CheckedChanged += new System.EventHandler(this.BossChecked);
			this.WorkerButton.CheckedChanged += new System.EventHandler(this.WorkerChecked);
			this.SaveButton.Click += new System.EventHandler(this.SaveClick);
			this.ClearButton.Click += new System.EventHandler(this.ClearClick);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	
		private void initPositionRole()
		{
			PositionRole.Items.Clear();
			PositionRole.Enabled = true;
			PositionRole.Items.Add("Analyst");
			PositionRole.Items.Add("Designer");
			PositionRole.Items.Add("Developer");
		}

		private void WorkerChecked(object sender, System.EventArgs e)
		{
			initPositionRole();
		}

		private void BossChecked(object sender, System.EventArgs e)
		{
			PositionRole.Items.Clear();
			PositionRole.Enabled = true;
			PositionRole.Items.Add("General Manager");
			PositionRole.Items.Add("Project Manager");
		}

		private void VPChecked(object sender, System.EventArgs e)
		{
			PositionRole.Items.Clear();
			PositionRole.Enabled = true;
			PositionRole.Items.Add("VP Sales");
			PositionRole.Items.Add("VP Marketing");
			PositionRole.Items.Add("VP Production");
			PositionRole.Items.Add("VP Human Resources");
		}

		private void PresidentChecked(object sender, System.EventArgs e)
		{
			PositionRole.Items.Clear();
			PositionRole.Enabled = false;
		}

		private void SaveClick(object sender, System.EventArgs e)
		{
			string position = "";

			if (WorkerButton.Checked)
				position = "Worker";
			if (BossButton.Checked)
				position = "Manager";
			if (VPButton.Checked)
				position = "Vice President";
			if (PresidentButton.Checked)
				position = "President";

			InfoLabel.Text = "Employee:&nbsp" + FirstName.Text + "&nbsp" + LastName.Text + "&nbsp&nbsp&nbsp&nbspId&nbsp" + EmployeeId.Text + "&nbsp&nbsp&nbsp&nbspPosition&nbsp" + position;
		}

		private void ClearClick(object sender, System.EventArgs e)
		{
			FirstName.Text = "";
			LastName.Text = "";
			EmployeeId.Text = "";
			WorkerButton.Checked = true;
			initPositionRole();
			InfoLabel.Text = "";
		}
	}
}
