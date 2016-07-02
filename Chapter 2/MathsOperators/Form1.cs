using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MathsOperators
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lhs;
		private System.Windows.Forms.Label rhs;
		private System.Windows.Forms.Button quit;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.TextBox result;				
		private System.Windows.Forms.Button calculate;
		private System.Windows.Forms.Label expressionLabel;
		private System.Windows.Forms.TextBox expression;
		private System.Windows.Forms.RadioButton division;
		private System.Windows.Forms.RadioButton multiplication;
		private System.Windows.Forms.RadioButton subtraction;
		private System.Windows.Forms.RadioButton addition;
		private System.Windows.Forms.TextBox lhsOperand;
		private System.Windows.Forms.TextBox rhsOperand;
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
			this.lhs = new System.Windows.Forms.Label();
			this.calculate = new System.Windows.Forms.Button();
			this.remainder = new System.Windows.Forms.RadioButton();
			this.result = new System.Windows.Forms.TextBox();
			this.expression = new System.Windows.Forms.TextBox();
			this.expressionLabel = new System.Windows.Forms.Label();
			this.addition = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.division = new System.Windows.Forms.RadioButton();
			this.multiplication = new System.Windows.Forms.RadioButton();
			this.subtraction = new System.Windows.Forms.RadioButton();
			this.resultLabel = new System.Windows.Forms.Label();
			this.quit = new System.Windows.Forms.Button();
			this.rhs = new System.Windows.Forms.Label();
			this.rhsOperand = new System.Windows.Forms.TextBox();
			this.lhsOperand = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lhs
			// 
			this.lhs.Location = new System.Drawing.Point(16, 32);
			this.lhs.Name = "lhs";
			this.lhs.TabIndex = 0;
			this.lhs.Text = "left operand";
			// 
			// calculate
			// 
			this.calculate.Location = new System.Drawing.Point(16, 200);
			this.calculate.Name = "calculate";
			this.calculate.TabIndex = 7;
			this.calculate.Text = "Calculate";
			this.calculate.Click += new System.EventHandler(this.calculate_Click);
			// 
			// remainder
			// 
			this.remainder.Location = new System.Drawing.Point(16, 112);
			this.remainder.Name = "remainder";
			this.remainder.Size = new System.Drawing.Size(104, 16);
			this.remainder.TabIndex = 4;
			this.remainder.Text = "% Remainder";
			// 
			// result
			// 
			this.result.Location = new System.Drawing.Point(16, 248);
			this.result.Name = "result";
			this.result.ReadOnly = true;
			this.result.Size = new System.Drawing.Size(264, 20);
			this.result.TabIndex = 6;
			this.result.Text = "";
			// 
			// expression
			// 
			this.expression.Location = new System.Drawing.Point(112, 200);
			this.expression.Name = "expression";
			this.expression.ReadOnly = true;
			this.expression.Size = new System.Drawing.Size(168, 20);
			this.expression.TabIndex = 10;
			this.expression.Text = "";
			// 
			// expressionLabel
			// 
			this.expressionLabel.Location = new System.Drawing.Point(112, 184);
			this.expressionLabel.Name = "expressionLabel";
			this.expressionLabel.Size = new System.Drawing.Size(64, 23);
			this.expressionLabel.TabIndex = 9;
			this.expressionLabel.Text = "Expression";
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
			this.groupBox1.Location = new System.Drawing.Point(112, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(136, 136);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Operator";
			// 
			// division
			// 
			this.division.Location = new System.Drawing.Point(16, 90);
			this.division.Name = "division";
			this.division.Size = new System.Drawing.Size(104, 16);
			this.division.TabIndex = 3;
			this.division.Text = "/ Division";
			// 
			// multiplication
			// 
			this.multiplication.Location = new System.Drawing.Point(16, 68);
			this.multiplication.Name = "multiplication";
			this.multiplication.Size = new System.Drawing.Size(104, 16);
			this.multiplication.TabIndex = 2;
			this.multiplication.Text = "* Multiplication";
			// 
			// subtraction
			// 
			this.subtraction.Location = new System.Drawing.Point(16, 46);
			this.subtraction.Name = "subtraction";
			this.subtraction.Size = new System.Drawing.Size(104, 16);
			this.subtraction.TabIndex = 1;
			this.subtraction.Text = "- Subtraction";
			// 
			// resultLabel
			// 
			this.resultLabel.Location = new System.Drawing.Point(16, 232);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.TabIndex = 5;
			this.resultLabel.Text = "Result";
			// 
			// quit
			// 
			this.quit.Location = new System.Drawing.Point(296, 248);
			this.quit.Name = "quit";
			this.quit.Size = new System.Drawing.Size(40, 23);
			this.quit.TabIndex = 8;
			this.quit.Text = "Quit";
			this.quit.Click += new System.EventHandler(this.quit_Click);
			// 
			// rhs
			// 
			this.rhs.Location = new System.Drawing.Point(256, 32);
			this.rhs.Name = "rhs";
			this.rhs.TabIndex = 2;
			this.rhs.Text = "right operand";
			// 
			// rhsOperand
			// 
			this.rhsOperand.Location = new System.Drawing.Point(256, 48);
			this.rhsOperand.Name = "rhsOperand";
			this.rhsOperand.Size = new System.Drawing.Size(80, 20);
			this.rhsOperand.TabIndex = 3;
			this.rhsOperand.Text = "";
			// 
			// lhsOperand
			// 
			this.lhsOperand.Location = new System.Drawing.Point(16, 48);
			this.lhsOperand.Name = "lhsOperand";
			this.lhsOperand.Size = new System.Drawing.Size(80, 20);
			this.lhsOperand.TabIndex = 1;
			this.lhsOperand.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(352, 285);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.expression,
																		  this.expressionLabel,
																		  this.quit,
																		  this.calculate,
																		  this.result,
																		  this.resultLabel,
																		  this.groupBox1,
																		  this.rhsOperand,
																		  this.rhs,
																		  this.lhsOperand,
																		  this.lhs});
			this.Name = "Form1";
			this.Text = "Maths Operators";
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
				if (addition.Checked) 
					addValues();
				else if (subtraction.Checked)
					subtractValues();
				else if (multiplication.Checked)
					multiplyValues();
				else if (division.Checked)
					divideValues();
				else if (remainder.Checked)
					remainderValues();
			}
			catch (Exception caught)
			{
				expression.Text = "";
				result.Text = caught.Message;
			}
		}

		private void addValues()
		{	
			int lhs = int.Parse(lhsOperand.Text);		
			int rhs = int.Parse(rhsOperand.Text);
			int outcome;
			outcome = lhs + rhs;
			expression.Text = lhsOperand.Text + " + " + rhsOperand.Text;
			result.Text = outcome.ToString();
		}

		private void subtractValues()	
		{
			int lhs = int.Parse(lhsOperand.Text);		
			int rhs = int.Parse(rhsOperand.Text);
			int outcome;
			outcome = lhs - rhs;
			expression.Text = lhsOperand.Text + " - " + rhsOperand.Text;
			result.Text = outcome.ToString();
		}

		private void multiplyValues()
		{
			int lhs = int.Parse(lhsOperand.Text);		
			int rhs = int.Parse(rhsOperand.Text);
			int outcome;
			outcome = lhs * rhs;
			expression.Text = lhsOperand.Text + " * " + rhsOperand.Text;
			result.Text = outcome.ToString();
		}

		private void divideValues()
		{
			int lhs = int.Parse(lhsOperand.Text);		
			int rhs = int.Parse(rhsOperand.Text);
			int outcome;
			outcome = lhs / rhs;
			expression.Text = lhsOperand.Text + " / " + rhsOperand.Text;
			result.Text = outcome.ToString();
		}

		private void remainderValues()
		{
			int lhs = int.Parse(lhsOperand.Text);		
			int rhs = int.Parse(rhsOperand.Text);
			int outcome;
			outcome = lhs % rhs;
			expression.Text = lhsOperand.Text + " % " + rhsOperand.Text;
			result.Text = outcome.ToString();
		}

		private void quit_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}
	}
}
