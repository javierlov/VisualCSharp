using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Methods
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox lhsOperand;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox rhsOperand;
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox expression;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox result;
		private System.Windows.Forms.Button quit;
		private System.Windows.Forms.RadioButton addition;
		private System.Windows.Forms.RadioButton subtraction;
		private System.Windows.Forms.RadioButton multiplication;
		private System.Windows.Forms.RadioButton division;
		private System.Windows.Forms.RadioButton remainder;
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
			this.calculate = new System.Windows.Forms.Button();
			this.remainder = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.expression = new System.Windows.Forms.TextBox();
			this.result = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.addition = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.division = new System.Windows.Forms.RadioButton();
			this.multiplication = new System.Windows.Forms.RadioButton();
			this.subtraction = new System.Windows.Forms.RadioButton();
			this.quit = new System.Windows.Forms.Button();
			this.rhsOperand = new System.Windows.Forms.TextBox();
			this.lhsOperand = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(16, 200);
			this.calculate.Name = "calculate";
			this.calculate.TabIndex = 5;
			this.calculate.Text = "Calculate";
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// remainder
			// 
			this.remainder.Location = new System.Drawing.Point(16, 104);
			this.remainder.Name = "remainder";
			this.remainder.Size = new System.Drawing.Size(104, 16);
			this.remainder.TabIndex = 4;
			this.remainder.Text = "% Remainder";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 232);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 16);
			this.label4.TabIndex = 8;
			this.label4.Text = "Result";
			// 
			// expression
			// 
			this.expression.Enabled = false;
			this.expression.Location = new System.Drawing.Point(136, 200);
			this.expression.Name = "expression";
			this.expression.Size = new System.Drawing.Size(176, 20);
			this.expression.TabIndex = 7;
			this.expression.Text = "";
			// 
			// result
			// 
			this.result.Enabled = false;
			this.result.Location = new System.Drawing.Point(16, 248);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(296, 20);
			this.result.TabIndex = 9;
			this.result.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "left operand";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(280, 32);
			this.label2.Name = "label2";
			this.label2.TabIndex = 3;
			this.label2.Text = "right operand";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(136, 184);
			this.label3.Name = "label3";
			this.label3.TabIndex = 6;
			this.label3.Text = "Expression";
			// 
			// addition
			// 
			this.addition.Location = new System.Drawing.Point(16, 24);
			this.addition.Name = "addition";
			this.addition.Size = new System.Drawing.Size(104, 16);
			this.addition.TabIndex = 0;
			this.addition.Text = "+ Addition";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.AddRange(new System.Windows.Forms.Control[] {
																					this.remainder,
																					this.division,
																					this.multiplication,
																					this.subtraction,
																					this.addition});
			this.groupBox1.Location = new System.Drawing.Point(136, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(128, 128);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operators";
			// 
			// division
			// 
			this.division.Location = new System.Drawing.Point(16, 84);
			this.division.Name = "division";
			this.division.Size = new System.Drawing.Size(104, 16);
			this.division.TabIndex = 3;
			this.division.Text = "/ Division";
			// 
			// multiplication
			// 
			this.multiplication.Location = new System.Drawing.Point(16, 64);
			this.multiplication.Name = "multiplication";
			this.multiplication.Size = new System.Drawing.Size(104, 16);
			this.multiplication.TabIndex = 2;
			this.multiplication.Text = "* Multiplication";
			// 
			// subtraction
			// 
			this.subtraction.Location = new System.Drawing.Point(16, 44);
			this.subtraction.Name = "subtraction";
			this.subtraction.Size = new System.Drawing.Size(104, 16);
			this.subtraction.TabIndex = 1;
			this.subtraction.Text = "- Subtraction";
			// 
			// quit
			// 
			this.quit.Location = new System.Drawing.Point(320, 248);
			this.quit.Name = "quit";
			this.quit.Size = new System.Drawing.Size(56, 23);
			this.quit.TabIndex = 10;
			this.quit.Text = "Quit";
			this.quit.Click += new System.EventHandler(this.quit_Click);
			// 
			// rhsOperand
			// 
			this.rhsOperand.Location = new System.Drawing.Point(280, 48);
			this.rhsOperand.Name = "rhsOperand";
			this.rhsOperand.TabIndex = 4;
			this.rhsOperand.Text = "";
			// 
			// lhsOperand
			// 
			this.lhsOperand.Location = new System.Drawing.Point(16, 48);
			this.lhsOperand.Name = "lhsOperand";
			this.lhsOperand.TabIndex = 1;
			this.lhsOperand.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(392, 277);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.quit,
																		  this.result,
																		  this.label4,
																		  this.expression,
																		  this.label3,
																		  this.calculate,
																		  this.rhsOperand,
																		  this.label2,
																		  this.groupBox1,
																		  this.lhsOperand,
																		  this.label1});
			this.Name = "Form1";
			this.Text = "Exceptions";
			this.groupBox1.ResumeLayout(false);
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

		private void calculate_Click(object sender, System.EventArgs e)
		{
			try
			{
				int lhs = System.Int32.Parse(lhsOperand.Text);		
				int rhs = System.Int32.Parse(rhsOperand.Text);
				int answer = doCalculation(lhs, rhs);	
				result.Text = answer.ToString();
			}
			catch (System.Exception caught)
			{
				result.Text = caught.Message;
			}
		}	

		private int doCalculation(int lhs, int rhs)
		{
			int result = 0;

			if (addition.Checked) 
				result = addValues(lhs, rhs);
			else if (subtraction.Checked)
				result = subtractValues(lhs, rhs);
			else if (multiplication.Checked)
				result = multiplyValues(lhs, rhs);
			else if (division.Checked)
				result = divideValues(lhs, rhs);
			else if (remainder.Checked)
				result = remainderValues(lhs, rhs);
			else
				throw new InvalidOperationException("no operator selected");

			return result;
		}		

		private int addValues(int lhs, int rhs)
		{	
			expression.Text = lhs.ToString() + " + " + rhs.ToString();
			return lhs + rhs;
		}

		private int subtractValues(int lhs, int rhs)	
		{
			expression.Text = lhs.ToString() + " - " + rhs.ToString();
			return lhs - rhs;
		}

		private int multiplyValues(int lhs, int rhs)	
		{
			expression.Text = lhs.ToString() + " * " + rhs.ToString();
			return checked(lhs * rhs);	
		}

		private int divideValues(int lhs, int rhs)	
		{
			expression.Text = lhs.ToString() + " / " + rhs.ToString();
			return lhs / rhs;
		}

		private int remainderValues(int lhs, int rhs)	
		{
			expression.Text = lhs.ToString() + " % " + rhs.ToString();
			return lhs % rhs;
		}

		private void quit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
