using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Delegates
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox digital;
		private System.Windows.Forms.Button start;
		private System.Windows.Forms.Button stop;
        private System.Windows.Forms.TextBox digital2;
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

            clock = new Clock(digital);
            clock2 = new Clock(digital2);
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
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.digital = new System.Windows.Forms.TextBox();
            this.digital2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(72, 72);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(56, 23);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(144, 72);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(48, 23);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // digital
            // 
            this.digital.Enabled = false;
            this.digital.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digital.Location = new System.Drawing.Point(56, 24);
            this.digital.Name = "digital";
            this.digital.Size = new System.Drawing.Size(152, 38);
            this.digital.TabIndex = 0;
            this.digital.Text = "04:11:34";
            this.digital.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // digital2
            // 
            this.digital2.Enabled = false;
            this.digital2.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digital2.Location = new System.Drawing.Point(56, 112);
            this.digital2.Name = "digital2";
            this.digital2.Size = new System.Drawing.Size(152, 38);
            this.digital2.TabIndex = 3;
            this.digital2.Text = "04:11:34";
            this.digital2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(264, 179);
            this.Controls.Add(this.digital2);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.digital);
            this.Name = "Form1";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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

		private void start_Click(object sender, System.EventArgs e)
		{
			clock.Start();
            clock2.Stop();
		}

		private void stop_Click(object sender, System.EventArgs e)
		{
			clock.Stop();
            clock2.Start();
		}

        private Clock clock;
        private Clock clock2;

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        delegate void SetTextCallback2(string text);

        private void SetText2(string text)
        {
            if (this.digital.InvokeRequired)
            {
                SetTextCallback2 d = new SetTextCallback2(SetText2);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.digital.Text = text;
            }
        }

	}
}
