using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace LogWriter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class EventLogForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox logEntry;
		private System.Windows.Forms.Button writeLog;
		private System.Diagnostics.EventLog eventLog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EventLogForm()
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
			this.logEntry = new System.Windows.Forms.TextBox();
			this.writeLog = new System.Windows.Forms.Button();
			this.eventLog1 = new System.Diagnostics.EventLog();
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
			this.SuspendLayout();
			// 
			// logEntry
			// 
			this.logEntry.Location = new System.Drawing.Point(16, 24);
			this.logEntry.Name = "logEntry";
			this.logEntry.Size = new System.Drawing.Size(432, 20);
			this.logEntry.TabIndex = 0;
			this.logEntry.Text = "";
			// 
			// writeLog
			// 
			this.writeLog.Location = new System.Drawing.Point(192, 72);
			this.writeLog.Name = "writeLog";
			this.writeLog.TabIndex = 1;
			this.writeLog.Text = "Write Log";
			this.writeLog.Click += new System.EventHandler(this.writeLogClick);
			// 
			// eventLog1
			// 
			this.eventLog1.Log = "Application";
			this.eventLog1.MachineName = "mockturtle";
			this.eventLog1.SynchronizingObject = this;
			// 
			// EventLogForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 126);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.writeLog,
																		  this.logEntry});
			this.Name = "EventLogForm";
			this.Text = "Event Log Writer";
			((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new EventLogForm());
		}

		private void writeLogClick(object sender, System.EventArgs e)
		{
			eventLog1.Source = "LogWriter";
			eventLog1.WriteEntry(logEntry.Text, EventLogEntryType.Information);
		}
	}
}
