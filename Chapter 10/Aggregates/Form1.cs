using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Aggregates
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button Deal;
		private System.Windows.Forms.Button returnToPack;
		private System.Windows.Forms.TextBox north;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox south;
		private System.Windows.Forms.TextBox west;
		private System.Windows.Forms.TextBox east;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Deal = new System.Windows.Forms.Button();
			this.west = new System.Windows.Forms.TextBox();
			this.east = new System.Windows.Forms.TextBox();
			this.returnToPack = new System.Windows.Forms.Button();
			this.south = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.north = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "North";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(144, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "South";
			// 
			// Deal
			// 
			this.Deal.Location = new System.Drawing.Point(152, 232);
			this.Deal.Name = "Deal";
			this.Deal.Size = new System.Drawing.Size(64, 23);
			this.Deal.TabIndex = 0;
			this.Deal.Text = "Deal";
			this.Deal.Click += new System.EventHandler(this.Deal_Click);
			// 
			// west
			// 
			this.west.Location = new System.Drawing.Point(256, 24);
			this.west.Multiline = true;
			this.west.Name = "west";
			this.west.Size = new System.Drawing.Size(96, 184);
			this.west.TabIndex = 2;
			this.west.Text = "";
			// 
			// east
			// 
			this.east.Location = new System.Drawing.Point(368, 24);
			this.east.Multiline = true;
			this.east.Name = "east";
			this.east.Size = new System.Drawing.Size(96, 184);
			this.east.TabIndex = 2;
			this.east.Text = "";
			// 
			// returnToPack
			// 
			this.returnToPack.Location = new System.Drawing.Point(240, 232);
			this.returnToPack.Name = "returnToPack";
			this.returnToPack.Size = new System.Drawing.Size(104, 23);
			this.returnToPack.TabIndex = 1;
			this.returnToPack.Text = "Return to pack";
			this.returnToPack.Click += new System.EventHandler(this.returnToPack_Click);
			// 
			// south
			// 
			this.south.Location = new System.Drawing.Point(144, 24);
			this.south.Multiline = true;
			this.south.Name = "south";
			this.south.Size = new System.Drawing.Size(96, 184);
			this.south.TabIndex = 2;
			this.south.Text = "";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(368, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "East";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(256, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "West";
			// 
			// north
			// 
			this.north.Location = new System.Drawing.Point(24, 24);
			this.north.Multiline = true;
			this.north.Name = "north";
			this.north.Size = new System.Drawing.Size(96, 184);
			this.north.TabIndex = 2;
			this.north.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label4,
																		  this.label3,
																		  this.label2,
																		  this.east,
																		  this.west,
																		  this.south,
																		  this.label1,
																		  this.north,
																		  this.returnToPack,
																		  this.Deal});
			this.Name = "Form1";
			this.Text = "Card Game";
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

		private Pack pack = new Pack();
		private Game game = new Game();

		private void Deal_Click(object sender, System.EventArgs e)
		{
			pack.Shuffle();
			Dealer.Deal(pack, game);
			DoRefresh();
		}

		private void returnToPack_Click(object sender, System.EventArgs e)
		{
			game.ReturnHandsTo(pack);
			DoRefresh();
		}

		private void DoRefresh()
		{
			north.Text = game.North().ToString();
			south.Text = game.South().ToString();
			west.Text = game.West().ToString();
			east.Text = game.East().ToString();
		}

		private void shuffle_Click(object sender, System.EventArgs e)
		{
			pack.Shuffle();
		}

	}
}
