using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;

namespace ExceptionGenerator
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ExceptionForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button stopButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private Thread exceptionThread;

		public ExceptionForm()
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
			this.startButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(24, 16);
			this.startButton.Name = "startButton";
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Start";
			this.startButton.Click += new System.EventHandler(this.startButtonClick);
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(24, 56);
			this.stopButton.Name = "stopButton";
			this.stopButton.TabIndex = 1;
			this.stopButton.Text = "Stop";
			this.stopButton.Click += new System.EventHandler(this.stopButtonClick);
			// 
			// ExceptionForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(128, 93);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.stopButton,
																		  this.startButton});
			this.Name = "ExceptionForm";
			this.Text = "Exceptions";
			this.ResumeLayout(false);

		}
		#endregion


		private void generateExceptions()
		{
			while(true)
			{
				try 
				{
					doFail();
				}
				catch
				{
				}
			}
		}

		private void doFail()
		{
			throw new Exception("Intended exception");
		}
		
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ExceptionForm());
		}


		private void startButtonClick(object sender, System.EventArgs e)
		{
			exceptionThread = new Thread(new ThreadStart(generateExceptions));
			exceptionThread.Start();
		}

		private void stopButtonClick(object sender, System.EventArgs e)
		{
			exceptionThread.Abort();
		}
	}
}
