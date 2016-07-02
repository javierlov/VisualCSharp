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

		private System.Windows.Forms.TreeView bellRingersTree;
		private System.Windows.Forms.ListView bellRingersList;
		private System.Windows.Forms.Label treeLabel;
		private System.Windows.Forms.ContextMenu listContextMenu;
		private System.Windows.Forms.MenuItem largeIconsItem;
		private System.Windows.Forms.MenuItem smallIconsItem;
		private System.Windows.Forms.MenuItem listItem;
		private System.Windows.Forms.MenuItem detailsItem;
		private System.Windows.Forms.ImageList largeImageList;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Splitter splitter;
		private System.Windows.Forms.ImageList treeViewImageList;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem fileItem;
		private System.Windows.Forms.MenuItem exitItem;
		private System.Windows.Forms.Panel panel;
		
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ExplorerForm));
			this.listItem = new System.Windows.Forms.MenuItem();
			this.largeIconsItem = new System.Windows.Forms.MenuItem();
			this.listContextMenu = new System.Windows.Forms.ContextMenu();
			this.smallIconsItem = new System.Windows.Forms.MenuItem();
			this.detailsItem = new System.Windows.Forms.MenuItem();
			this.bellRingersList = new System.Windows.Forms.ListView();
			this.largeImageList = new System.Windows.Forms.ImageList(this.components);
			this.treeViewImageList = new System.Windows.Forms.ImageList(this.components);
			this.panel = new System.Windows.Forms.Panel();
			this.treeLabel = new System.Windows.Forms.Label();
			this.bellRingersTree = new System.Windows.Forms.TreeView();
			this.fileItem = new System.Windows.Forms.MenuItem();
			this.exitItem = new System.Windows.Forms.MenuItem();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.splitter = new System.Windows.Forms.Splitter();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// listItem
			// 
			this.listItem.Index = 2;
			this.listItem.RadioCheck = true;
			this.listItem.Text = "List";
			this.listItem.Click += new System.EventHandler(this.listClick);
			// 
			// largeIconsItem
			// 
			this.largeIconsItem.Index = 0;
			this.largeIconsItem.RadioCheck = true;
			this.largeIconsItem.Text = "Large Icons";
			this.largeIconsItem.Click += new System.EventHandler(this.largeIconsClick);
			// 
			// listContextMenu
			// 
			this.listContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.largeIconsItem,
																							this.smallIconsItem,
																							this.listItem,
																							this.detailsItem});
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
			// bellRingersList
			// 
			this.bellRingersList.ContextMenu = this.listContextMenu;
			this.bellRingersList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bellRingersList.LargeImageList = this.largeImageList;
			this.bellRingersList.Location = new System.Drawing.Point(235, 32);
			this.bellRingersList.MultiSelect = false;
			this.bellRingersList.Name = "bellRingersList";
			this.bellRingersList.Size = new System.Drawing.Size(461, 389);
			this.bellRingersList.SmallImageList = this.treeViewImageList;
			this.bellRingersList.TabIndex = 3;
			this.bellRingersList.ItemActivate += new System.EventHandler(this.bellRingersListActivate);
			// 
			// largeImageList
			// 
			this.largeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.largeImageList.ImageSize = new System.Drawing.Size(48, 48);
			this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
			this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// treeViewImageList
			// 
			this.treeViewImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.treeViewImageList.ImageSize = new System.Drawing.Size(16, 16);
			this.treeViewImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeViewImageList.ImageStream")));
			this.treeViewImageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel
			// 
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.AddRange(new System.Windows.Forms.Control[] {
																				this.treeLabel});
			this.panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(696, 32);
			this.panel.TabIndex = 2;
			// 
			// treeLabel
			// 
			this.treeLabel.Location = new System.Drawing.Point(0, 5);
			this.treeLabel.Name = "treeLabel";
			this.treeLabel.Size = new System.Drawing.Size(680, 23);
			this.treeLabel.TabIndex = 1;
			this.treeLabel.Text = "Path:";
			// 
			// bellRingersTree
			// 
			this.bellRingersTree.Dock = System.Windows.Forms.DockStyle.Left;
			this.bellRingersTree.ImageList = this.treeViewImageList;
			this.bellRingersTree.Location = new System.Drawing.Point(0, 32);
			this.bellRingersTree.Name = "bellRingersTree";
			this.bellRingersTree.Size = new System.Drawing.Size(232, 389);
			this.bellRingersTree.TabIndex = 0;
			this.bellRingersTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.bellRingersTreeSelect);
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
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.fileItem});
			// 
			// splitter
			// 
			this.splitter.BackColor = System.Drawing.SystemColors.Control;
			this.splitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitter.Location = new System.Drawing.Point(232, 32);
			this.splitter.Name = "splitter";
			this.splitter.Size = new System.Drawing.Size(3, 389);
			this.splitter.TabIndex = 1;
			this.splitter.TabStop = false;
			// 
			// ExplorerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
			this.ClientSize = new System.Drawing.Size(696, 421);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.bellRingersList,
																		  this.splitter,
																		  this.bellRingersTree,
																		  this.panel});
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Menu = this.mainMenu;
			this.Name = "ExplorerForm";
			this.Text = "Middleshire Bell Ringers Association - Explorer";
			this.Load += new System.EventHandler(this.explorerFormLoad);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		public static void Main(string [] args)
		{
			Application.Run(new ExplorerForm());
		}

		// Private utility methods

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

		// Display a list of all the bell towers under the supplied TreeNode in the List View
		private void displayTowers(TreeNode node)
		{
			// Clear the List View
			bellRingersList.Clear();

			// Create a column header (in case the list is being displayed in Details view)
			bellRingersList.Columns.Add("Tower", bellRingersList.Width - 4, HorizontalAlignment.Left);

			// Iterate through the towers under the node, create a List View Item for each one, and add it to the List View
			foreach (TreeNode child in node.Nodes)
			{
				ListViewItem item = new ListViewItem(child.Text, TOWERIMAGE);
				bellRingersList.Items.Add(item);
			}
		}

		// Display a list of all the members under the supplied TreeNode in the List View
		private void displayMembers(TreeNode node)
		{			
			// Clear the List View
			bellRingersList.Clear();

			// Create column headers (in case the list is being displayed in Details view)
			bellRingersList.Columns.Add("First Name", (bellRingersList.Width - 4)/3, HorizontalAlignment.Left);
			bellRingersList.Columns.Add("Last Name", (bellRingersList.Width - 4)/3, HorizontalAlignment.Left);
			bellRingersList.Columns.Add("Captain", (bellRingersList.Width - 4)/6, HorizontalAlignment.Left);
			bellRingersList.Columns.Add("Years", (bellRingersList.Width - 4)/6, HorizontalAlignment.Right);
				
			// Iterate through the members under the node, create a List View Item for each one, and add it to the List View
			foreach (TreeNode child in node.Nodes)
			{
				ListViewItem item;
				
				if (bellRingersList.View == View.Details)
				{
					// Si el List View muestra detalles
					// se extrae la información completa de miembro
					// del Tag del nodo hijo
					Member member = (Member)child.Tag;
					item = new ListViewItem(member.Fname, MEMBERIMAGE);
					item.SubItems.Add(member.Lname);
					item.SubItems.Add(member.Captain.ToString());
					item.SubItems.Add(member.Experience.ToString());
				}
				else
				{
					// Sino, se muestra la información abreviada
					// del miembro (sólo el nombre)
					item = new ListViewItem(child.Text, MEMBERIMAGE);
				}
				bellRingersList.Items.Add(item);
			}
		}

		// Display a list of all the methods under the supplied TreeNode in the List View
		private void displayMethods(TreeNode node)
		{
			// Clear the List View
			bellRingersList.Clear();

			// Create a column header (in case the list is being displayed in Details view)
			bellRingersList.Columns.Add("Method", bellRingersList.Width - 4, HorizontalAlignment.Left);
		
			// Iterate through the members under the node, create a List View Item for each one, and add it to the List View
			foreach (string methodName in ((Member)node.Tag).Methods)
			{
				ListViewItem item = new ListViewItem(methodName, METHODIMAGE);
				bellRingersList.Items.Add(item);
			}
		}

		// Display the single method listed under the supplied TreeNode in the List View
		private void displaySingleMethod(TreeNode node)
		{
			
			// Clear the List View
			bellRingersList.Clear();

			// Create a column header (in case the list is being displayed in Details view)
			bellRingersList.Columns.Add("Method", bellRingersList.Width - 4, HorizontalAlignment.Left);

			// Display the single method name held in the node
			ListViewItem item = new ListViewItem(node.Text, METHODIMAGE);
			bellRingersList.Items.Add(item);
		}

		// Update the List View to display the data in the specified Tree View node
		private void updateListView(TreeNode node)
		{
			// What type of node is it?
			// The District, Tower, and Method nodes all have string tags
			// Member nodes have a Member tag
			if (node.Tag.GetType().Equals(typeof(System.String)))
			{
				// Debe ser District, Tower o Method
				switch((string)node.Tag)
				{
					case "District":// Muestra las torres en el List View
						displayTowers(node);
						break;

					case "Tower":	// Muestra los miembros en el List View
						displayMembers(node);
						break;

					case "Method":  // Muestra el método actual en el List View
						displaySingleMethod(node);
						break;

					default:		// ¡No debería ocurrir nunca!			
						break;
				}
			}
			else
			{
				// Debe ser un miembro
				displayMethods(node);
			}
		}

		// Event methods

		private void explorerFormLoad(object sender, System.EventArgs e)
		{
			// Populate the TreeView from the XML file - BellRingers.xml
			// XML will be covered in more detail later

			// Create the root node
			TreeNode rootNode = new TreeNode("Middleshire District", DISTRICTIMAGE, DISTRICTIMAGE);
			rootNode.Tag = "District";
			bellRingersTree.Nodes.Add(rootNode);

			// Define tree nodes for holding tower, member, and method details
			TreeNode towerNode = null, memberNode = null, methodNode = null;

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
					string towerName = getTowerName(reader);
					towerNode = new TreeNode(towerName, TOWERIMAGE, TOWERIMAGE);
					towerNode.Tag = "Tower";
					rootNode.Nodes.Add(towerNode);
					continue;
				}

				if (infoType == BellRingingInfo.Member)
				{
					// If this is a new member, create a new node and add it to the current bell tower
					member = getMemberDetails(reader);
					memberNode = new TreeNode(member.ToString(), MEMBERIMAGE, MEMBERIMAGE);
					towerNode.Nodes.Add(memberNode);

					// The TreeNode just displays a text representation of the member
					// Store the real details in the Tag property in case we need it later
					member.Methods = new ArrayList();
					memberNode.Tag = member;
					continue;
				}

				if (infoType == BellRingingInfo.Method)
				{
					// If this is a bell ringing method then add it to the current member
					string methodName = getMethodName(reader);
					methodNode = new TreeNode(methodName, METHODIMAGE, METHODIMAGE);
					methodNode.Tag = "Method";
					memberNode.Nodes.Add(methodNode);

					// Also record the method in the current member struct in case we need it later
					member.Methods.Add(methodName);
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
			TreeNode selectedNode = e.Node;

			// Display the path of this node
			treeLabel.Text = "Path: " + selectedNode.FullPath;

			// Update the List View using this node
			updateListView(selectedNode);
		}

		
		// Methods used by the List View context menu to change the view style
		// Need to refresh the List View each time (Details view displays different information)
		private void largeIconsClick(object sender, System.EventArgs e)
		{
			largeIconsItem.Checked = true;
			smallIconsItem.Checked = false;
			listItem.Checked = false;
			detailsItem.Checked = false;
			bellRingersList.View = View.LargeIcon;
			TreeNode node = bellRingersTree.SelectedNode;
			updateListView(node);
		}

		private void smallIconsClick(object sender, System.EventArgs e)
		{
			largeIconsItem.Checked = false;
			smallIconsItem.Checked = true;
			listItem.Checked = false;
			detailsItem.Checked = false;
			bellRingersList.View = View.SmallIcon;
			TreeNode node = bellRingersTree.SelectedNode;
			updateListView(node);
		}

		private void listClick(object sender, System.EventArgs e)
		{
			largeIconsItem.Checked = false;
			smallIconsItem.Checked = false;
			listItem.Checked = true;
			detailsItem.Checked = false;
			bellRingersList.View = View.List;
			TreeNode node = bellRingersTree.SelectedNode;
			updateListView(node);
		}

		private void detailsClick(object sender, System.EventArgs e)
		{
			largeIconsItem.Checked = false;
			smallIconsItem.Checked = false;
			listItem.Checked = false;
			detailsItem.Checked = true;
			bellRingersList.View = View.Details;
			TreeNode node = bellRingersTree.SelectedNode;
			updateListView(node);
		}

		// When the user double-clicks an item in the List View it should be expanded
		// and the Tree View synchronized
		private void bellRingersListActivate(object sender, System.EventArgs e)
		{
			// This list view control only allows one item to be selected at a time
			// so the itemList variable will contain a single element only
			ListView.SelectedListViewItemCollection itemList = bellRingersList.SelectedItems;
			ListViewItem item = itemList[0];

			// Locate and expand the node in the tree view containing this item (if it is not already expanded)
			TreeNode selectedNode = bellRingersTree.SelectedNode;
			selectedNode.Expand();

			// Find the node in the tree view that corresponds to the activated item in the list view, 
			// select it, and expand it. It must be located under selectedNode

			foreach (TreeNode searchNode in selectedNode.Nodes)
			{
				// Can you spot the potential problem with the next line?
				// Hint: what does item.Text contain when the List View is displaying the Details view?
				if (searchNode.Text.Equals(item.Text))
				{
					// Found it - select and expand the node in the Tree View
					bellRingersTree.SelectedNode = searchNode;
					searchNode.Expand();

					// Synchronize the List View
					updateListView(searchNode);
					break;
				}
			}
		}
		
		// Quit the application - close the form
		private void exitItemClick(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}