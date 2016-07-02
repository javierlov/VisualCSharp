using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CompanyForm
{
	/// <summary>
	/// Summary description for Standard.
	/// </summary>
	public class Standard : System.Windows.Forms.Form
	{
		private EventHandler loading;
		private EventHandler closing;
		private System.Windows.Forms.Timer formTimer;
		private System.ComponentModel.IContainer components;

		public Standard()
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
				if(components != null)
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Standard));
			this.formTimer = new System.Windows.Forms.Timer(this.components);
			// 
			// formTimer
			// 
			this.formTimer.Interval = 50;
			// 
			// Standard
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
			this.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(442, 303);
			this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Standard";
			this.Text = "Standard";

		}
		#endregion

		
		private void fadeIn(object sender, EventArgs e)
		{
			if (this.Opacity < 1.0)
			{
				this.Opacity += 0.1;
				formTimer.Enabled = true;
			}
			else
			{
				formTimer.Tick -= loading;
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.Opacity = 0;
			loading = new EventHandler(this.fadeIn);
			formTimer.Tick += loading;
			formTimer.Enabled = true;
		}

		private void fadeOut(object sender, EventArgs e)
		{
			if (this.Opacity > 0)
			{
				this.Opacity -= 0.1;
				formTimer.Enabled = true;
			}
			else
			{
				formTimer.Tick -= closing;
				this.Close();
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			if (Opacity > 0)
			{
				closing = new EventHandler(this.fadeOut);
				formTimer.Tick += closing;
				formTimer.Enabled = true;
				e.Cancel = true;
			}
		}
	}
}
