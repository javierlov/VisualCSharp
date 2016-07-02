using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Threading;

namespace ExceptionMonitor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ExceptionForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox counterText;
		private System.Windows.Forms.Button monitorTotalButton;
		private System.Diagnostics.PerformanceCounter exceptionCounterTotal;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox rateText;
		private System.Windows.Forms.Button monitorRateButton;
		private System.Windows.Forms.NumericUpDown numberSecs;
		private System.Diagnostics.PerformanceCounter exceptionCounterRate;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			this.label1 = new System.Windows.Forms.Label();
			this.counterText = new System.Windows.Forms.TextBox();
			this.monitorTotalButton = new System.Windows.Forms.Button();
			this.exceptionCounterTotal = new System.Diagnostics.PerformanceCounter();
			this.label2 = new System.Windows.Forms.Label();
			this.rateText = new System.Windows.Forms.TextBox();
			this.monitorRateButton = new System.Windows.Forms.Button();
			this.numberSecs = new System.Windows.Forms.NumericUpDown();
			this.exceptionCounterRate = new System.Diagnostics.PerformanceCounter();
			((System.ComponentModel.ISupportInitialize)(this.exceptionCounterTotal)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberSecs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.exceptionCounterRate)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(160, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Total number of exceptions";
			// 
			// counterText
			// 
			this.counterText.Location = new System.Drawing.Point(176, 32);
			this.counterText.Name = "counterText";
			this.counterText.Size = new System.Drawing.Size(80, 20);
			this.counterText.TabIndex = 1;
			this.counterText.Text = "";
			// 
			// monitorTotalButton
			// 
			this.monitorTotalButton.Location = new System.Drawing.Point(16, 64);
			this.monitorTotalButton.Name = "monitorTotalButton";
			this.monitorTotalButton.Size = new System.Drawing.Size(120, 23);
			this.monitorTotalButton.TabIndex = 2;
			this.monitorTotalButton.Text = "Total # Exceptions";
			this.monitorTotalButton.Click += new System.EventHandler(this.totalButtonClick);
			// 
			// exceptionCounterTotal
			// 
			this.exceptionCounterTotal.CategoryName = ".NET CLR Exceptions";
			this.exceptionCounterTotal.CounterName = "# of Exceps Thrown";
			this.exceptionCounterTotal.InstanceName = "_Global_";
			this.exceptionCounterTotal.MachineName = "mockturtle";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Number of exceptions/sec";
			// 
			// rateText
			// 
			this.rateText.Location = new System.Drawing.Point(176, 112);
			this.rateText.Name = "rateText";
			this.rateText.Size = new System.Drawing.Size(80, 20);
			this.rateText.TabIndex = 4;
			this.rateText.Text = "";
			// 
			// monitorRateButton
			// 
			this.monitorRateButton.Location = new System.Drawing.Point(16, 152);
			this.monitorRateButton.Name = "monitorRateButton";
			this.monitorRateButton.Size = new System.Drawing.Size(120, 23);
			this.monitorRateButton.TabIndex = 5;
			this.monitorRateButton.Text = "Rate of Exceptions";
			this.monitorRateButton.Click += new System.EventHandler(this.rateButtonClick);
			// 
			// numberSecs
			// 
			this.numberSecs.Location = new System.Drawing.Point(176, 152);
			this.numberSecs.Minimum = new System.Decimal(new int[] {
																	   1,
																	   0,
																	   0,
																	   0});
			this.numberSecs.Name = "numberSecs";
			this.numberSecs.Size = new System.Drawing.Size(40, 20);
			this.numberSecs.TabIndex = 6;
			this.numberSecs.Value = new System.Decimal(new int[] {
																	 1,
																	 0,
																	 0,
																	 0});
			// 
			// exceptionCounterRate
			// 
			this.exceptionCounterRate.CategoryName = ".NET CLR Exceptions";
			this.exceptionCounterRate.CounterName = "# of Exceps Thrown";
			this.exceptionCounterRate.InstanceName = "_Global_";
			this.exceptionCounterRate.MachineName = "mockturtle";
			// 
			// ExceptionForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(272, 198);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.numberSecs,
																		  this.monitorRateButton,
																		  this.rateText,
																		  this.label2,
																		  this.monitorTotalButton,
																		  this.counterText,
																		  this.label1});
			this.Name = "ExceptionForm";
			this.Text = "Monitor Exceptions";
			((System.ComponentModel.ISupportInitialize)(this.exceptionCounterTotal)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberSecs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.exceptionCounterRate)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ExceptionForm());
		}

		private void totalButtonClick(object sender, System.EventArgs e)
		{
			counterText.Text = exceptionCounterTotal.NextValue().ToString();
		}

		private void rateButtonClick(object sender, System.EventArgs e)
		{
			CounterSample firstSample = exceptionCounterRate.NextSample();
			Cursor curr = Cursor.Current;
			Cursor.Current = Cursors.WaitCursor;
			Thread.Sleep(Int32.Parse(numberSecs.Text) * 1000);
			Cursor.Current = curr;
			CounterSample secondSample = exceptionCounterRate.NextSample();
			float rate = CounterSample.Calculate(firstSample, secondSample);
			rateText.Text = rate.ToString();
		}
	}
}
