using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.ServiceProcess;

namespace ServiceHandler
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ServiceForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox state;
		private System.ServiceProcess.ServiceController aspStateController;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button stopButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ServiceForm()
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
			this.label1 = new System.Windows.Forms.Label();
			this.state = new System.Windows.Forms.TextBox();
			this.aspStateController = new System.ServiceProcess.ServiceController();
			this.startButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "ASP.NET State Service";
			// 
			// state
			// 
			this.state.Location = new System.Drawing.Point(136, 24);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(80, 20);
			this.state.TabIndex = 1;
			this.state.Text = "";
			// 
			// aspStateController
			// 
			this.aspStateController.MachineName = "mockturtle";
			this.aspStateController.ServiceName = "aspnet_state";
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(24, 80);
			this.startButton.Name = "startButton";
			this.startButton.TabIndex = 2;
			this.startButton.Text = "Start";
			this.startButton.Click += new System.EventHandler(this.startButtonClick);
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(120, 80);
			this.stopButton.Name = "stopButton";
			this.stopButton.TabIndex = 3;
			this.stopButton.Text = "Stop";
			this.stopButton.Click += new System.EventHandler(this.stopButtonClick);
			// 
			// ServiceForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(224, 126);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.stopButton,
																		  this.startButton,
																		  this.state,
																		  this.label1});
			this.Name = "ServiceForm";
			this.Text = "Service Handler";
			this.Load += new System.EventHandler(this.serviceFormLoad);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ServiceForm());
		}

		private void serviceFormLoad(object sender, System.EventArgs e)
		{
			ServiceControllerStatus status = aspStateController.Status;
			state.Text = status.ToString();
		}

		private void startButtonClick(object sender, System.EventArgs e)
		{
			ServiceControllerStatus status = aspStateController.Status;
			if (status == ServiceControllerStatus.Stopped)
			{
				Cursor curs = Cursor.Current;
				Cursor.Current = Cursors.WaitCursor;
				aspStateController.Start();
				aspStateController.WaitForStatus(ServiceControllerStatus.Running);
				status = aspStateController.Status;
				state.Text = status.ToString();
				Cursor.Current = curs;
			}
		}

		private void stopButtonClick(object sender, System.EventArgs e)
		{
			if (aspStateController.CanStop)
			{
				Cursor curs = Cursor.Current;
				Cursor.Current = Cursors.WaitCursor;
				aspStateController.Stop();
				aspStateController.WaitForStatus(ServiceControllerStatus.Stopped);
				ServiceControllerStatus status = aspStateController.Status;
				state.Text = status.ToString();
				Cursor.Current = curs;
			}
		}
	}
}
