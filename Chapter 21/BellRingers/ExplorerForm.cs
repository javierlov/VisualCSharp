using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;

namespace BellRingers
{
	/// <summary>
	/// Enumeration containing the different types of node in the tree view and list view controls
	/// </summary>
	public enum BellRingingInfo {Tower, Member, Method, Empty};

	/// <summary>
	/// Struct for holding member information
	/// </summary>
	public struct Member
	{
		public string Fname;	   // Nombre
		public string Lname;	   // Apellido
		public bool Captain;	   // ¿Capitan de la torre?
		public int Experience;	   // Años de experiencia
		public ArrayList Methods;  // Métodos que el miembro puede tocar

		// El método ToString se usa para convertir la estructura
		// su representación como string
		public override string ToString()
		{
			return Fname + " " + Lname;
		}
	}


	/// <summary>
	/// Form that provides an Explorer style interface for the Middleshire Bell Ringers Association
	/// </summary>
	public class ExplorerForm : System.Windows.Forms.Form
	{
		// Constants indicating which index to use in the image controls
		// for the various nodes in the Tree View
		private const int DISTRICTIMAGE = 0;
		private const int TOWERIMAGE = 1;
		private const int MEMBERIMAGE = 2;
		private const int METHODIMAGE = 3;

		// Constant holding the name of the XML data file.
		// Change this if you install the application in a different folder
		private const string DATAFILE = "C:\\Visual C# Step By Step\\Chapter 21\\BellRingers.XML";

		private System.Windows.Forms.ContextMenu listContextMenu;
		private System.Windows.Forms.MenuItem largeIconsItem;
		private System.Windows.Forms.MenuItem smallIconsItem;
		private System.Windows.Forms.MenuItem listItem;
		private System.Windows.Forms.MenuItem detailsItem;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem fileItem;
		private System.Windows.Forms.MenuItem exitItem;

		public ExplorerForm()
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
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.fileItem = new System.Windows.Forms.MenuItem();
			this.exitItem = new System.Windows.Forms.MenuItem();
			this.listItem = new System.Windows.Forms.MenuItem();
			this.listContextMenu = new System.Windows.Forms.ContextMenu();
			this.largeIconsItem = new System.Windows.Forms.MenuItem();
			this.smallIconsItem = new System.Windows.Forms.MenuItem();
			this.detailsItem = new System.Windows.Forms.MenuItem();
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.fileItem});
			// 
			// fileItem
			// 
			this.fileItem.Index = 0;
			this.fileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.exitItem});
			this.fileItem.Text = "&File";
			// 
			// exitItem
			// 
			this.exitItem.Index = 0;
			this.exitItem.Text = "E&xit";
			this.exitItem.Click += new System.EventHandler(this.exitItemClick);
			// 
			// listItem
			// 
			this.listItem.Index = 2;
			this.listItem.RadioCheck = true;
			this.listItem.Text = "List";
			this.listItem.Click += new System.EventHandler(this.listClick);
			// 
			// listContextMenu
			// 
			this.listContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.largeIconsItem,
																							this.smallIconsItem,
																							this.listItem,
																							this.detailsItem});
			// 
			// largeIconsItem
			// 
			this.largeIconsItem.Index = 0;
			this.largeIconsItem.RadioCheck = true;
			this.largeIconsItem.Text = "Large Icons";
			this.largeIconsItem.Click += new System.EventHandler(this.largeIconsClick);
			// 
			// smallIconsItem
			// 
			this.smallIconsItem.Index = 1;
			this.smallIconsItem.RadioCheck = true;
			this.smallIconsItem.Text = "Small Icons";
			this.smallIconsItem.Click += new System.EventHandler(this.smallIconsClick);
			// 
			// detailsItem
			// 
			this.detailsItem.Index = 3;
			this.detailsItem.RadioCheck = true;
			this.detailsItem.Text = "Details";
			this.detailsItem.Click += new System.EventHandler(this.detailsClick);
			// 
			// ExplorerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(696, 421);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu;
			this.Name = "ExplorerForm";
			this.Text = "Middleshire Bell Ringers Association - Explorer";
			this.Load += new System.EventHandler(this.explorerFormLoad);

		}
		#endregion
		public static void Main(string [] args)
		{
			Application.Run(new ExplorerForm());
		}

		// Private utility methods

		// Methods for reading and parsing the XML file
		// Create and open an XmlTextReader over the BellRingers XML file
		private XmlTextReader initializeXmlReader()
		{
			XmlTextReader reader = new XmlTextReader(DATAFILE);
			reader.WhitespaceHandling = WhitespaceHandling.None; // Ignore white space
			reader.MoveToContent(); // Move to the start of the real data (the first tower)
			return reader;
		}
			
		// Get the type of the next node in the XML stream
		private BellRingingInfo getInfoType(XmlTextReader reader)
		{
			if (reader.Read())
			{
				// What is the next node?
				while (!reader.HasAttributes)	// Ignore any "end" nodes
				{
					if (!reader.Read())			// Read the next node
					{
						break;					// If there are no more nodes then stop
					}
				}
				switch (reader.Name)
				{
					case "tower":	return BellRingingInfo.Tower;
									break;
					case "member":	return BellRingingInfo.Member;
									break;
					case "method":	return BellRingingInfo.Method;
									break;
					default:		return BellRingingInfo.Empty;
									break;
				}
			}
			else
			{
				// Nothing left in the stream, so return "empty"
				return BellRingingInfo.Empty;
			}
		}

		// Get the name of the bell tower from the current node in the XML stream
		private string getTowerName(XmlTextReader reader)
		{
			if (!reader.Name.Equals("tower"))
			{
				throw new Exception("Wrong type of data - expected a bell tower");
			}
			reader.MoveToAttribute(0); // Should be the tower name
			return reader.Value;
		}

		// Get the details of the member from the current node in the XML stream
		private Member getMemberDetails(XmlTextReader reader)
		{
			Member member = new Member();

			if (!reader.Name.Equals("member"))
			{
				throw new Exception("Wrong type of data - expected a member");
			}
			reader.MoveToAttribute(0); // Should be the first name
			member.Fname = reader.Value;
			reader.MoveToAttribute(1); // Last name
			member.Lname = reader.Value;
			reader.MoveToAttribute(2); // Captain
			member.Captain = (reader.Value.Equals("Y") || reader.Value.Equals("y"));
			reader.MoveToAttribute(3); // Experience
			member.Experience = Int32.Parse(reader.Value);
			return member;
		}

		// Get the name of the bell ringing method from the current node in the XML stream
		private string getMethodName(XmlTextReader reader)
		{
			if (!reader.Name.Equals("method"))
			{
				throw new Exception("Wrong type of data - expected a method");
			}
			reader.MoveToAttribute(0); // Should be the method name
			return reader.Value;
		}

		// Methods for populating the List View
		// Display a list of all the bell towers under the supplied TreeNode in the List View
		private void displayTowers(TreeNode node)
		{
			// Clear the List View
			// <INSERT 10TH BLOCK OF CODE HERE>

			// Create a column header (in case the list is being displayed in Details view)
			// <INSERT 11TH BLOCK OF CODE HERE>

			// Iterate through the towers under the node, create a List View Item for each one, and add it to the List View
			// <INSERT 12TH BLOCK OF CODE HERE>
		}

		// Display a list of all the members under the supplied TreeNode in the List View
		private void displayMembers(TreeNode node)
		{			
			// Clear the List View
			// <INSERT 18TH BLOCK OF CODE HERE>

			// Create column headers (in case the list is being displayed in Details view)
			// <INSERT 19TH BLOCK OF CODE HERE>
				
			// Iterate through the members under the node, create a List View Item for each one, and add it to the List View
			// <INSERT 20TH BLOCK OF CODE HERE>
		}

		// Display a list of all the methods under the supplied TreeNode in the List View
		private void displayMethods(TreeNode node)
		{
			// Clear the List View
			// <INSERT 21ST BLOCK OF CODE HERE>

			// Create a column header (in case the list is being displayed in Details view)
			// <INSERT 22ND BLOCK OF CODE HERE>

			// Iterate through the members under the node, create a List View Item for each one, and add it to the List View
			// <INSERT 23RD BLOCK OF CODE HERE>
		}

		// Display the single method listed under the supplied TreeNode in the List View
		private void displaySingleMethod(TreeNode node)
		{
			
			// Clear the List View
			// <INSERT 24TH BLOCK OF CODE HERE>

			// Create a column header (in case the list is being displayed in Details view)
			// <INSERT 25TH BLOCK OF CODE HERE>

			// Display the single method name held in the node
			// <INSERT 26TH BLOCK OF CODE HERE>
		}

		// Update the List View to display the data in the specified Tree View node
		private void updateListView(TreeNode node)
		{
			// What type of node is it?
			// The District, Tower, and Method nodes all have string tags
			// Member nodes have a Member tag
			if (node.Tag.GetType().Equals(typeof(System.String)))
			{
				// Must be the District, Tower, or Method
				switch((string)node.Tag)
				{
					case "District":// Display the Towers in the List View
						displayTowers(node);
						break;

					case "Tower":	// Display the Members in the List View
						displayMembers(node);
						break;

					case "Method":  // Display the current Method in the List View
						displaySingleMethod(node);
						break;

					default:		// Should never happen!			
						break;
				}
			}
			else
			{
				// Must be a Member - display Methods rung by this member in the List View
				displayMethods(node);
			}
		}

		// Event methods

		private void explorerFormLoad(object sender, System.EventArgs e)
		{
			// Populate the TreeView from the XML file - BellRingers.xml
			// XML will be covered in more detail later

			// Create the root node
			// <INSERT 1ST BLOCK OF CODE HERE>

			// Define tree nodes for holding tower, member, and method details
			// <INSERT 2ND BLOCK OF CODE HERE>

			// Define a variable for holding a member
			Member member = new Member();
			member.Methods = new ArrayList();

			// Iterate through the XML data and create the nodes for the tree view
			XmlTextReader reader = initializeXmlReader();
			BellRingingInfo infoType;
			while ((infoType = getInfoType(reader)) != BellRingingInfo.Empty)
			{
				if (infoType == BellRingingInfo.Tower)
				{
					// If we are starting a new tower, create a new node below the root
					// and add the tower information (and images)
					// <INSERT 3RD BLOCK OF CODE HERE>
					continue;
				}

				if (infoType == BellRingingInfo.Member)
				{
					// If this is a new member, create a new node and add it to the current bell tower
					// <INSERT 4TH BLOCK OF CODE HERE

					// The TreeNode just displays a text representation of the member
					// Store the real details in the Tag property in case we need it later
					// <INSERT 5TH BLOCK OF CODE HERE
					continue;
				}

				if (infoType == BellRingingInfo.Method)
				{
					// If this is a bell ringing method then add it to the current member
					// <INSERT 6TH BLOCK OF CODE HERE>

					// Also record the method in the current member struct in case we need it later
					// <INSERT 7TH BLOCK OF CODE HERE>
					continue;
				}			
			}

			// Set the default style for the List View
			largeIconsItem.Checked = true;
			smallIconsItem.Checked = false;
			listItem.Checked = false;
			detailsItem.Checked = false;
		}

		// When the user selected a node in the tree view display the path of the currently
		// selected node in the treeLabel control.
		// Also display the details of the node in the List View
		private void bellRingersTreeSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			// Work out which node the user has selected
			// INSERT 8TH BLOCK OF CODE HERE

			// Display the path of this node
			// INSERT 9TH BLOCK OF CODE HERE

			// Update the List View using this node
			// INSERT 13TH BLOCK OF CODE HERE
		}

		
		// Methods used by the List View context menu to change the view style
		// Need to refresh the List View each time (Details view displays different information)
		private void largeIconsClick(object sender, System.EventArgs e)
		{
			largeIconsItem.Checked = true;
			smallIconsItem.Checked = false;
			listItem.Checked = false;
			detailsItem.Checked = false;
			// INSERT 14TH BLOCK OF CODE HERE
		}

		private void smallIconsClick(object sender, System.EventArgs e)
		{
			largeIconsItem.Checked = false;
			smallIconsItem.Checked = true;
			listItem.Checked = false;
			detailsItem.Checked = false;
			// INSERT 15TH BLOCK OF CODE HERE
		}

		private void listClick(object sender, System.EventArgs e)
		{
			largeIconsItem.Checked = false;
			smallIconsItem.Checked = false;
			listItem.Checked = true;
			detailsItem.Checked = false;
			// INSERT 16TH BLOCK OF CODE HERE
		}

		private void detailsClick(object sender, System.EventArgs e)
		{
			largeIconsItem.Checked = false;
			smallIconsItem.Checked = false;
			listItem.Checked = false;
			detailsItem.Checked = true;
			// INSERT 17TH BLOCK OF CODE HERE
		}

		// Quit the application - close the form
		private void exitItemClick(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}