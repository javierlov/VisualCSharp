using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BellRingers
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MemberForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox firstName;
		private System.Windows.Forms.TextBox lastName;
		private System.Windows.Forms.ComboBox tower;
		private System.Windows.Forms.CheckBox captain;
		private System.Windows.Forms.DateTimePicker memberSince;
		private System.Windows.Forms.GroupBox experience;
		private System.Windows.Forms.RadioButton novice;
		private System.Windows.Forms.RadioButton intermediate;
		private System.Windows.Forms.RadioButton experienced;
		private System.Windows.Forms.RadioButton accomplished;
		private System.Windows.Forms.CheckedListBox methods;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem fileItem;
		private System.Windows.Forms.MenuItem newItem;
		private System.Windows.Forms.MenuItem openItem;
		private System.Windows.Forms.MenuItem saveItem;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem printItem;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem exitItem;
		private System.Windows.Forms.ContextMenu textBoxMenu;
		private System.Windows.Forms.MenuItem textBoxClearItem;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MemberForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			Reset();
			MenuItem[] formMenuItemList = new MenuItem[2];
			formMenuItemList[0] = saveItem.CloneMenu();
			MenuItem clearItem = new MenuItem("&Clear",
				                       new System.EventHandler(clearClicked));
			formMenuItemList[1] = clearItem;
			ContextMenu formMenu = new ContextMenu(formMenuItemList);
			this.ContextMenu = formMenu;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MemberForm));
			this.label1 = new System.Windows.Forms.Label();
			this.firstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lastName = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tower = new System.Windows.Forms.ComboBox();
			this.captain = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.memberSince = new System.Windows.Forms.DateTimePicker();
			this.experience = new System.Windows.Forms.GroupBox();
			this.accomplished = new System.Windows.Forms.RadioButton();
			this.experienced = new System.Windows.Forms.RadioButton();
			this.intermediate = new System.Windows.Forms.RadioButton();
			this.novice = new System.Windows.Forms.RadioButton();
			this.methods = new System.Windows.Forms.CheckedListBox();
			this.add = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.fileItem = new System.Windows.Forms.MenuItem();
			this.newItem = new System.Windows.Forms.MenuItem();
			this.openItem = new System.Windows.Forms.MenuItem();
			this.saveItem = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.printItem = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.exitItem = new System.Windows.Forms.MenuItem();
			this.textBoxMenu = new System.Windows.Forms.ContextMenu();
			this.textBoxClearItem = new System.Windows.Forms.MenuItem();
			this.experience.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 20);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "First Name";
			// 
			// firstName
			// 
			this.firstName.ContextMenu = this.textBoxMenu;
			this.firstName.Location = new System.Drawing.Point(120, 20);
			this.firstName.Name = "firstName";
			this.firstName.Size = new System.Drawing.Size(170, 26);
			this.firstName.TabIndex = 1;
			this.firstName.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(300, 20);
			this.label2.Name = "label2";
			this.label2.TabIndex = 2;
			this.label2.Text = "Last Name";
			// 
			// lastName
			// 
			this.lastName.ContextMenu = this.textBoxMenu;
			this.lastName.Location = new System.Drawing.Point(400, 20);
			this.lastName.Name = "lastName";
			this.lastName.Size = new System.Drawing.Size(170, 26);
			this.lastName.TabIndex = 3;
			this.lastName.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 4;
			this.label3.Text = "Tower";
			// 
			// tower
			// 
			this.tower.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tower.Location = new System.Drawing.Point(120, 72);
			this.tower.Name = "tower";
			this.tower.Size = new System.Drawing.Size(260, 28);
			this.tower.TabIndex = 5;
			// 
			// captain
			// 
			this.captain.Location = new System.Drawing.Point(400, 72);
			this.captain.Name = "captain";
			this.captain.Size = new System.Drawing.Size(100, 26);
			this.captain.TabIndex = 6;
			this.captain.Text = "Captain";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Member Since";
			// 
			// memberSince
			// 
			this.memberSince.Location = new System.Drawing.Point(140, 128);
			this.memberSince.Name = "memberSince";
			this.memberSince.TabIndex = 8;
			// 
			// experience
			// 
			this.experience.Controls.AddRange(new System.Windows.Forms.Control[] {
																					 this.accomplished,
																					 this.experienced,
																					 this.intermediate,
																					 this.novice});
			this.experience.Location = new System.Drawing.Point(10, 184);
			this.experience.Name = "experience";
			this.experience.Size = new System.Drawing.Size(260, 160);
			this.experience.TabIndex = 9;
			this.experience.TabStop = false;
			this.experience.Text = "Experience";
			// 
			// accomplished
			// 
			this.accomplished.Location = new System.Drawing.Point(16, 128);
			this.accomplished.Name = "accomplished";
			this.accomplished.Size = new System.Drawing.Size(220, 24);
			this.accomplished.TabIndex = 3;
			this.accomplished.Text = "10 or more years";
			// 
			// experienced
			// 
			this.experienced.Location = new System.Drawing.Point(16, 96);
			this.experienced.Name = "experienced";
			this.experienced.Size = new System.Drawing.Size(220, 24);
			this.experienced.TabIndex = 2;
			this.experienced.Text = "5 to 9 years";
			// 
			// intermediate
			// 
			this.intermediate.Location = new System.Drawing.Point(16, 64);
			this.intermediate.Name = "intermediate";
			this.intermediate.Size = new System.Drawing.Size(220, 24);
			this.intermediate.TabIndex = 1;
			this.intermediate.Text = "1 to 4 years";
			// 
			// novice
			// 
			this.novice.Location = new System.Drawing.Point(16, 32);
			this.novice.Name = "novice";
			this.novice.Size = new System.Drawing.Size(220, 24);
			this.novice.TabIndex = 0;
			this.novice.Text = "Up to 1 year";
			// 
			// methods
			// 
			this.methods.Location = new System.Drawing.Point(300, 192);
			this.methods.Name = "methods";
			this.methods.Size = new System.Drawing.Size(270, 151);
			this.methods.Sorted = true;
			this.methods.TabIndex = 10;
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(190, 368);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(75, 40);
			this.add.TabIndex = 11;
			this.add.Text = "Add";
			this.add.Click += new System.EventHandler(this.addClick);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(335, 368);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(75, 40);
			this.clear.TabIndex = 12;
			this.clear.Text = "Clear";
			this.clear.Click += new System.EventHandler(this.clearClicked);
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.fileItem});
			// 
			// fileItem
			// 
			this.fileItem.Index = 0;
			this.fileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.newItem,
																					 this.openItem,
																					 this.saveItem,
																					 this.menuItem5,
																					 this.printItem,
																					 this.menuItem7,
																					 this.exitItem});
			this.fileItem.Text = "&File";
			// 
			// newItem
			// 
			this.newItem.Index = 0;
			this.newItem.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.newItem.Text = "&New";
			this.newItem.Click += new System.EventHandler(this.newClick);
			// 
			// openItem
			// 
			this.openItem.Index = 1;
			this.openItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.openItem.Text = "&Open";
			// 
			// saveItem
			// 
			this.saveItem.Index = 2;
			this.saveItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.saveItem.Text = "&Save Member";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "-";
			// 
			// printItem
			// 
			this.printItem.Enabled = false;
			this.printItem.Index = 4;
			this.printItem.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
			this.printItem.Text = "&Print";
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// exitItem
			// 
			this.exitItem.Index = 6;
			this.exitItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
			this.exitItem.Text = "E&xit";
			this.exitItem.Click += new System.EventHandler(this.exitClick);
			// 
			// textBoxMenu
			// 
			this.textBoxMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						this.textBoxClearItem});
			// 
			// textBoxClearItem
			// 
			this.textBoxClearItem.Index = 0;
			this.textBoxClearItem.Text = "Clear Text";
			this.textBoxClearItem.Click += new System.EventHandler(this.textBoxClearClick);
			// 
			// MemberForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(592, 416);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.clear,
																		  this.add,
																		  this.methods,
																		  this.experience,
																		  this.memberSince,
																		  this.label4,
																		  this.captain,
																		  this.tower,
																		  this.label3,
																		  this.lastName,
																		  this.label2,
																		  this.firstName,
																		  this.label1});
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu1;
			this.Name = "MemberForm";
			this.Text = "Middleshire Bell Ringers Association - Members";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.memberFormClosing);
			this.experience.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MemberForm());
		}

		public void Reset()
		{
			firstName.Text = "";
			lastName.Text = "";
			tower.Items.Clear();
			tower.Items.Add("Great Shevington");
			tower.Items.Add("Little Mudford");
			tower.Items.Add("Upper Gumtree");
			tower.Items.Add("Downley Hatch");
			memberSince.Value = DateTime.Today;
			captain.Checked = false;
			novice.Checked = true;
			methods.Items.Clear();
			methods.Items.Add("Andover Bob Minor");
			methods.Items.Add("Antelope Place Doubles");
			methods.Items.Add("Hayfield Royal");
			methods.Items.Add("West Chiltington Doubles");
			methods.Items.Add("Brandon Parva Maximus");
			methods.Items.Add("Buckfast Abbey Triples");
			methods.Items.Add("Skelwith Bridge Minor");
			methods.Items.Add("Acton Trussel Bob Royal");
		}

		private void clearClicked(object sender, System.EventArgs e)
		{
			Reset();
		}

		private void addClick(object sender, System.EventArgs e)
		{
			string details;
			details = "Member name " + firstName.Text + " " + lastName.Text +
				      " from the tower at " + tower.Text;
			MessageBox.Show(details, "Member Information");
		}

		private void memberFormClosing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			DialogResult key = MessageBox.Show("Are you sure you want to quit",
				                               "Confirm",
				                               MessageBoxButtons.YesNo,
				                               MessageBoxIcon.Question);
			e.Cancel = (key == DialogResult.No);
		}

		private void newClick(object sender, System.EventArgs e)
		{
			Reset();
			printItem.Enabled = true;
		}

		private void exitClick(object sender, System.EventArgs e)
		{
			Close();
		}

		private void textBoxClearClick(object sender, System.EventArgs e)
		{
			if (textBoxMenu.SourceControl.Equals(firstName))
			{
				firstName.Clear();
			}
			else
			{
				lastName.Clear();
			}
		}
	}
}
