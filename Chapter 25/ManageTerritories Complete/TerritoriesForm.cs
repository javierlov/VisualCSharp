using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace ManageTerritories
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TerritoriesForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.DataGrid territoriesGrid;
		private System.Windows.Forms.Button queryButton;
		private System.Windows.Forms.Button saveButton;
		private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		private System.Data.SqlClient.SqlConnection territoriesConnection;
		private System.Data.SqlClient.SqlDataAdapter territoriesAdapter;
		private ManageTerritories.territoriesDataset territoriesDataset1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TerritoriesForm()
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
			this.territoriesConnection = new System.Data.SqlClient.SqlConnection();
			this.saveButton = new System.Windows.Forms.Button();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.queryButton = new System.Windows.Forms.Button();
			this.territoriesAdapter = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.territoriesGrid = new System.Windows.Forms.DataGrid();
			this.territoriesDataset1 = new ManageTerritories.territoriesDataset();
			((System.ComponentModel.ISupportInitialize)(this.territoriesGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.territoriesDataset1)).BeginInit();
			this.SuspendLayout();
			// 
			// territoriesConnection
			// 
			this.territoriesConnection.ConnectionString = "data source=CHESHIRECAT;initial catalog=Northwind;integrated security=SSPI;persis" +
				"t security info=False;workstation id=CHESHIRECAT;packet size=4096";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(176, 344);
			this.saveButton.Name = "saveButton";
			this.saveButton.TabIndex = 2;
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.saveClick);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT TerritoryID, TerritoryDescription, RegionID FROM Territories";
			this.sqlSelectCommand1.Connection = this.territoriesConnection;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO Territories(TerritoryID, TerritoryDescription, RegionID) VALUES (@Ter" +
				"ritoryID, @TerritoryDescription, @RegionID); SELECT TerritoryID, TerritoryDescri" +
				"ption, RegionID FROM Territories WHERE (TerritoryID = @Select_TerritoryID)";
			this.sqlInsertCommand1.Connection = this.territoriesConnection;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryID", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TerritoryDescription", System.Data.SqlDbType.NChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryDescription", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RegionID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RegionID", System.Data.DataRowVersion.Current, null));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Select_TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryID", System.Data.DataRowVersion.Current, null));
			// 
			// queryButton
			// 
			this.queryButton.Location = new System.Drawing.Point(48, 344);
			this.queryButton.Name = "queryButton";
			this.queryButton.TabIndex = 1;
			this.queryButton.Text = "Query";
			this.queryButton.Click += new System.EventHandler(this.queryClick);
			// 
			// territoriesAdapter
			// 
			this.territoriesAdapter.DeleteCommand = this.sqlDeleteCommand1;
			this.territoriesAdapter.InsertCommand = this.sqlInsertCommand1;
			this.territoriesAdapter.SelectCommand = this.sqlSelectCommand1;
			this.territoriesAdapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																										 new System.Data.Common.DataTableMapping("Table", "Territories", new System.Data.Common.DataColumnMapping[] {
																																																						new System.Data.Common.DataColumnMapping("TerritoryID", "TerritoryID"),
																																																						new System.Data.Common.DataColumnMapping("TerritoryDescription", "TerritoryDescription"),
																																																						new System.Data.Common.DataColumnMapping("RegionID", "RegionID")})});
			this.territoriesAdapter.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM Territories WHERE (TerritoryID = @TerritoryID) AND (RegionID = @Regio" +
				"nID) AND (TerritoryDescription = @TerritoryDescription)";
			this.sqlDeleteCommand1.Connection = this.territoriesConnection;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RegionID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RegionID", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TerritoryDescription", System.Data.SqlDbType.NChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryDescription", System.Data.DataRowVersion.Original, null));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE Territories SET TerritoryID = @TerritoryID, TerritoryDescription = @TerritoryDescription, RegionID = @RegionID WHERE (TerritoryID = @Original_TerritoryID) AND (RegionID = @Original_RegionID) AND (TerritoryDescription = @Original_TerritoryDescription); SELECT TerritoryID, TerritoryDescription, RegionID FROM Territories WHERE (TerritoryID = @Select_TerritoryID)";
			this.sqlUpdateCommand1.Connection = this.territoriesConnection;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryID", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@TerritoryDescription", System.Data.SqlDbType.NChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryDescription", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@RegionID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RegionID", System.Data.DataRowVersion.Current, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_RegionID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "RegionID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_TerritoryDescription", System.Data.SqlDbType.NChar, 50, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryDescription", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Select_TerritoryID", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "TerritoryID", System.Data.DataRowVersion.Current, null));
			// 
			// territoriesGrid
			// 
			this.territoriesGrid.DataMember = "";
			this.territoriesGrid.DataSource = this.territoriesDataset1.Territories;
			this.territoriesGrid.Location = new System.Drawing.Point(8, 8);
			this.territoriesGrid.Name = "territoriesGrid";
			this.territoriesGrid.Size = new System.Drawing.Size(280, 328);
			this.territoriesGrid.TabIndex = 0;
			// 
			// territoriesDataset1
			// 
			this.territoriesDataset1.DataSetName = "territoriesDataset";
			this.territoriesDataset1.Locale = new System.Globalization.CultureInfo("en-US");
			this.territoriesDataset1.Namespace = "http://www.tempuri.org/territoriesDataset.xsd";
			// 
			// TerritoriesForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(296, 381);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.saveButton,
																		  this.queryButton,
																		  this.territoriesGrid});
			this.Name = "TerritoriesForm";
			this.Text = "Manage Territories";
			((System.ComponentModel.ISupportInitialize)(this.territoriesGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.territoriesDataset1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new TerritoriesForm());
		}

		private void queryClick(object sender, System.EventArgs e)
		{
			try
			{
				territoriesConnection.Open();
				territoriesAdapter.Fill(territoriesDataset1);
				territoriesConnection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void saveClick(object sender, System.EventArgs e)
		{
			try
			{
				// Find the rows that have changed and create a new DataSet
				DataSet changes = territoriesDataset1.GetChanges();
				if (changes == null)
				{
					// No changes - do nothing
					return;
				}

				// Check for errors
				DataTable dt = changes.Tables[0];
				DataRow [] badRows = dt.GetErrors();

				if (badRows.Length == 0)
				{
					// No errors - update the database
					territoriesConnection.Open();
					int numRows = territoriesAdapter.Update(changes);
					territoriesConnection.Close();
					MessageBox.Show("Updated " + numRows + " rows", "Success");
					territoriesDataset1.AcceptChanges();
				}
				else
				{
					// Errors - tell the user
					string errorMsg = null;
					foreach(DataRow row in badRows)
					{
						foreach(DataColumn col in row.GetColumnsInError())
						{
							errorMsg += row.GetColumnError(col) + "\n";
						}
					}

					MessageBox.Show("Errors in data: " + errorMsg, "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
				territoriesDataset1.RejectChanges();
				territoriesConnection.Close();
			}
		}
	}
}
