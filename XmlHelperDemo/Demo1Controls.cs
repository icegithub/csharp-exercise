using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using Tools;
using System.Collections.Specialized;


namespace XmlHelperDemo
{
	/// <summary>
	/// Summary description for Demo1Controls.
	/// </summary>
	public class Demo1Controls : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Button btnSelectNodes;
		private System.Windows.Forms.Button btnImportNodes;
		private System.Windows.Forms.Button btnUpdateXmlDocument;
		private System.Windows.Forms.Button btnFillDataGridWithPrimaryKey;
		private System.Windows.Forms.Button btnFillDataGrid;
		private System.Windows.Forms.Button btnFillListBox;
		private System.Windows.Forms.DataGrid grdZoos;
		private System.Windows.Forms.ListBox lstZoos;
		private System.Windows.Forms.Button btnCopyNodes2;
		private System.Windows.Forms.Button btnCopyNodes;
		private System.Windows.Forms.Button btnModifyNodes;
		private System.Windows.Forms.TextBox txtQueryResults;
		private System.Windows.Forms.Button btnSelectSingleNode;
		private System.Windows.Forms.TextBox txtXPathQuery;
		private System.Windows.Forms.TextBox txtXmlData;
		private System.Windows.Forms.Button btnCreateDoc;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Demo1Controls()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnSelectNodes = new System.Windows.Forms.Button();
			this.btnImportNodes = new System.Windows.Forms.Button();
			this.btnUpdateXmlDocument = new System.Windows.Forms.Button();
			this.btnFillDataGridWithPrimaryKey = new System.Windows.Forms.Button();
			this.btnFillDataGrid = new System.Windows.Forms.Button();
			this.btnFillListBox = new System.Windows.Forms.Button();
			this.grdZoos = new System.Windows.Forms.DataGrid();
			this.lstZoos = new System.Windows.Forms.ListBox();
			this.btnCopyNodes2 = new System.Windows.Forms.Button();
			this.btnCopyNodes = new System.Windows.Forms.Button();
			this.btnModifyNodes = new System.Windows.Forms.Button();
			this.txtQueryResults = new System.Windows.Forms.TextBox();
			this.btnSelectSingleNode = new System.Windows.Forms.Button();
			this.txtXPathQuery = new System.Windows.Forms.TextBox();
			this.txtXmlData = new System.Windows.Forms.TextBox();
			this.btnCreateDoc = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdZoos)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSelectNodes
			// 
			this.btnSelectNodes.Enabled = false;
			this.btnSelectNodes.Location = new System.Drawing.Point(476, 8);
			this.btnSelectNodes.Name = "btnSelectNodes";
			this.btnSelectNodes.Size = new System.Drawing.Size(88, 32);
			this.btnSelectNodes.TabIndex = 31;
			this.btnSelectNodes.Text = "Select Nodes";
			this.btnSelectNodes.Click += new System.EventHandler(this.btnSelectNodes_Click);
			// 
			// btnImportNodes
			// 
			this.btnImportNodes.Enabled = false;
			this.btnImportNodes.Location = new System.Drawing.Point(580, 376);
			this.btnImportNodes.Name = "btnImportNodes";
			this.btnImportNodes.Size = new System.Drawing.Size(88, 56);
			this.btnImportNodes.TabIndex = 30;
			this.btnImportNodes.Text = "Import Nodes";
			this.btnImportNodes.Click += new System.EventHandler(this.btnImportNodes_Click);
			// 
			// btnUpdateXmlDocument
			// 
			this.btnUpdateXmlDocument.Enabled = false;
			this.btnUpdateXmlDocument.Location = new System.Drawing.Point(436, 312);
			this.btnUpdateXmlDocument.Name = "btnUpdateXmlDocument";
			this.btnUpdateXmlDocument.Size = new System.Drawing.Size(96, 32);
			this.btnUpdateXmlDocument.TabIndex = 29;
			this.btnUpdateXmlDocument.Text = "Update Xml Document";
			this.btnUpdateXmlDocument.Click += new System.EventHandler(this.btnUpdateXmlDocument_Click);
			// 
			// btnFillDataGridWithPrimaryKey
			// 
			this.btnFillDataGridWithPrimaryKey.Enabled = false;
			this.btnFillDataGridWithPrimaryKey.Location = new System.Drawing.Point(276, 312);
			this.btnFillDataGridWithPrimaryKey.Name = "btnFillDataGridWithPrimaryKey";
			this.btnFillDataGridWithPrimaryKey.Size = new System.Drawing.Size(152, 32);
			this.btnFillDataGridWithPrimaryKey.TabIndex = 28;
			this.btnFillDataGridWithPrimaryKey.Text = "Fill DataGrid with Primary Key Column";
			this.btnFillDataGridWithPrimaryKey.Click += new System.EventHandler(this.btnFillDataGridWithPrimaryKey_Click);
			// 
			// btnFillDataGrid
			// 
			this.btnFillDataGrid.Enabled = false;
			this.btnFillDataGrid.Location = new System.Drawing.Point(172, 320);
			this.btnFillDataGrid.Name = "btnFillDataGrid";
			this.btnFillDataGrid.Size = new System.Drawing.Size(96, 24);
			this.btnFillDataGrid.TabIndex = 27;
			this.btnFillDataGrid.Text = "Fill DataGrid";
			this.btnFillDataGrid.Click += new System.EventHandler(this.btnFillDataGrid_Click);
			// 
			// btnFillListBox
			// 
			this.btnFillListBox.Enabled = false;
			this.btnFillListBox.Location = new System.Drawing.Point(12, 320);
			this.btnFillListBox.Name = "btnFillListBox";
			this.btnFillListBox.Size = new System.Drawing.Size(96, 24);
			this.btnFillListBox.TabIndex = 26;
			this.btnFillListBox.Text = "Fill Listbox";
			this.btnFillListBox.Click += new System.EventHandler(this.btnFillListBox_Click);
			// 
			// grdZoos
			// 
			this.grdZoos.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.grdZoos.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grdZoos.BackgroundColor = System.Drawing.Color.LightGray;
			this.grdZoos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.grdZoos.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.grdZoos.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.grdZoos.CaptionVisible = false;
			this.grdZoos.DataMember = "";
			this.grdZoos.Enabled = false;
			this.grdZoos.FlatMode = true;
			this.grdZoos.Font = new System.Drawing.Font("Tahoma", 8F);
			this.grdZoos.ForeColor = System.Drawing.Color.MidnightBlue;
			this.grdZoos.GridLineColor = System.Drawing.Color.Gainsboro;
			this.grdZoos.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.grdZoos.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.grdZoos.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.grdZoos.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.grdZoos.LinkColor = System.Drawing.Color.Teal;
			this.grdZoos.Location = new System.Drawing.Point(172, 344);
			this.grdZoos.Name = "grdZoos";
			this.grdZoos.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.grdZoos.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.grdZoos.RowHeaderWidth = 15;
			this.grdZoos.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.grdZoos.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.grdZoos.Size = new System.Drawing.Size(376, 152);
			this.grdZoos.TabIndex = 25;
			// 
			// lstZoos
			// 
			this.lstZoos.Enabled = false;
			this.lstZoos.Location = new System.Drawing.Point(12, 344);
			this.lstZoos.Name = "lstZoos";
			this.lstZoos.Size = new System.Drawing.Size(152, 147);
			this.lstZoos.TabIndex = 24;
			// 
			// btnCopyNodes2
			// 
			this.btnCopyNodes2.Enabled = false;
			this.btnCopyNodes2.Location = new System.Drawing.Point(196, 272);
			this.btnCopyNodes2.Name = "btnCopyNodes2";
			this.btnCopyNodes2.Size = new System.Drawing.Size(80, 32);
			this.btnCopyNodes2.TabIndex = 23;
			this.btnCopyNodes2.Text = "Copy Nodes2";
			this.btnCopyNodes2.Click += new System.EventHandler(this.btnCopyNodes2_Click);
			// 
			// btnCopyNodes
			// 
			this.btnCopyNodes.Enabled = false;
			this.btnCopyNodes.Location = new System.Drawing.Point(108, 272);
			this.btnCopyNodes.Name = "btnCopyNodes";
			this.btnCopyNodes.Size = new System.Drawing.Size(80, 32);
			this.btnCopyNodes.TabIndex = 22;
			this.btnCopyNodes.Text = "Copy Nodes";
			this.btnCopyNodes.Click += new System.EventHandler(this.btnCopyNodes_Click);
			// 
			// btnModifyNodes
			// 
			this.btnModifyNodes.Enabled = false;
			this.btnModifyNodes.Location = new System.Drawing.Point(12, 272);
			this.btnModifyNodes.Name = "btnModifyNodes";
			this.btnModifyNodes.Size = new System.Drawing.Size(88, 32);
			this.btnModifyNodes.TabIndex = 21;
			this.btnModifyNodes.Text = "Modify Nodes";
			this.btnModifyNodes.Click += new System.EventHandler(this.btnModifyNodes_Click);
			// 
			// txtQueryResults
			// 
			this.txtQueryResults.Enabled = false;
			this.txtQueryResults.Location = new System.Drawing.Point(380, 64);
			this.txtQueryResults.Multiline = true;
			this.txtQueryResults.Name = "txtQueryResults";
			this.txtQueryResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtQueryResults.Size = new System.Drawing.Size(360, 200);
			this.txtQueryResults.TabIndex = 20;
			this.txtQueryResults.Text = "";
			this.txtQueryResults.WordWrap = false;
			// 
			// btnSelectSingleNode
			// 
			this.btnSelectSingleNode.Enabled = false;
			this.btnSelectSingleNode.Location = new System.Drawing.Point(380, 8);
			this.btnSelectSingleNode.Name = "btnSelectSingleNode";
			this.btnSelectSingleNode.Size = new System.Drawing.Size(88, 32);
			this.btnSelectSingleNode.TabIndex = 19;
			this.btnSelectSingleNode.Text = "Select Single Node";
			this.btnSelectSingleNode.Click += new System.EventHandler(this.btnSelectSingleNode_Click);
			// 
			// txtXPathQuery
			// 
			this.txtXPathQuery.Enabled = false;
			this.txtXPathQuery.Location = new System.Drawing.Point(380, 40);
			this.txtXPathQuery.Name = "txtXPathQuery";
			this.txtXPathQuery.Size = new System.Drawing.Size(360, 20);
			this.txtXPathQuery.TabIndex = 18;
			this.txtXPathQuery.Text = "/ZooRoot/ZooTable[@Name=\'Crazy Zoo\']";
			// 
			// txtXmlData
			// 
			this.txtXmlData.Location = new System.Drawing.Point(12, 64);
			this.txtXmlData.Multiline = true;
			this.txtXmlData.Name = "txtXmlData";
			this.txtXmlData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtXmlData.Size = new System.Drawing.Size(360, 200);
			this.txtXmlData.TabIndex = 17;
			this.txtXmlData.Text = "";
			this.txtXmlData.WordWrap = false;
			// 
			// btnCreateDoc
			// 
			this.btnCreateDoc.Location = new System.Drawing.Point(20, 32);
			this.btnCreateDoc.Name = "btnCreateDoc";
			this.btnCreateDoc.Size = new System.Drawing.Size(144, 24);
			this.btnCreateDoc.TabIndex = 16;
			this.btnCreateDoc.Text = "Create Xml Document";
			this.btnCreateDoc.Click += new System.EventHandler(this.btnCreateDoc_Click);
			// 
			// Demo1Controls
			// 
			this.Controls.Add(this.btnSelectNodes);
			this.Controls.Add(this.btnImportNodes);
			this.Controls.Add(this.btnUpdateXmlDocument);
			this.Controls.Add(this.btnFillDataGridWithPrimaryKey);
			this.Controls.Add(this.btnFillDataGrid);
			this.Controls.Add(this.btnFillListBox);
			this.Controls.Add(this.grdZoos);
			this.Controls.Add(this.lstZoos);
			this.Controls.Add(this.btnCopyNodes2);
			this.Controls.Add(this.btnCopyNodes);
			this.Controls.Add(this.btnModifyNodes);
			this.Controls.Add(this.txtQueryResults);
			this.Controls.Add(this.btnSelectSingleNode);
			this.Controls.Add(this.txtXPathQuery);
			this.Controls.Add(this.txtXmlData);
			this.Controls.Add(this.btnCreateDoc);
			this.Name = "Demo1Controls";
			this.Size = new System.Drawing.Size(752, 504);
			((System.ComponentModel.ISupportInitialize)(this.grdZoos)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private XmlDocument doc;
		private void btnCreateDoc_Click(object sender, System.EventArgs e)
		{
			doc = XmlHelper.CreateXmlDocument();

			XmlNode newNode = doc.CreateElement("ZooRoot");
			XmlNode rootNode = doc.AppendChild(newNode);

			///
			/// First Row
			/// 
			newNode = doc.CreateElement("ZooTable");
			XmlHelper.CreateAttribute(newNode, "Name", "Crazy Zoo");
			XmlHelper.CreateAttribute(newNode, "Address", "32 Turtle Lane");
			XmlHelper.CreateAttribute(newNode, "City", "Austin");
			XmlHelper.CreateAttribute(newNode, "State", "TX");
			XmlHelper.CreateAttribute(newNode, "Zip", "12345");

			rootNode.AppendChild(newNode);

			///
			/// Second Row
			/// 
			newNode = doc.CreateElement("ZooTable");
			XmlHelper.CreateAttribute(newNode, "Name", "Chicago Zoo");
			XmlHelper.CreateAttribute(newNode, "Address", "23 Zebra Ave");
			XmlHelper.CreateAttribute(newNode, "City", "Chicago");
			XmlHelper.CreateAttribute(newNode, "State", "IL");

			rootNode.AppendChild(newNode);

			///
			/// Third Row
			/// 
			newNode = doc.CreateElement("ZooTable");
			XmlHelper.CreateAttribute(newNode, "Name", "Hungry Zoo");
			XmlHelper.CreateAttribute(newNode, "Address", "45 Lion st");
			XmlHelper.CreateAttribute(newNode, "City", "Miami");
			XmlHelper.CreateAttribute(newNode, "State", "FL");
			XmlHelper.CreateAttribute(newNode, "Zip", "33122");

			rootNode.AppendChild(newNode);

			///
			/// Create data needed for the Classification nodes
			/// 
			StringCollection firstRow = new StringCollection();
			firstRow.AddRange(new string[] {"Reptiles", "Birds", "Primates"});
			
			StringCollection secondRow = new StringCollection();
			secondRow.AddRange(new string[] {"Fish", "Mammals", "Primates"});

			StringCollection thirdRow = new StringCollection();
			thirdRow.AddRange(new string[] {"Arachnids", "Rodents"});

			StringCollection[] classificationData = new StringCollection[]{firstRow, secondRow, thirdRow};

			//Create a query that selects all the "ZooTable" nodes:
			string xpathQuery = "/ZooRoot/ZooTable";
			XmlNodeList nodeList = doc.SelectNodes(xpathQuery);
			int index = 0;
			foreach (XmlNode nodeFromList in nodeList)
			{
				///
				/// each 'nodeFromList' is going to be the parent node to which
				/// we need to add the 'Classification' child nodes
				/// 
				foreach (string classificationName in classificationData[index])
				{
					newNode = doc.CreateElement("Classification");
					XmlHelper.CreateAttribute(newNode, "Type", classificationName);
					nodeFromList.AppendChild(newNode);
				}
				index++;
			}
			this.txtXmlData.Text = XmlHelper.DocumentToString(doc);

			///
			///Update controls
			///
			btnSelectSingleNode.Enabled = true;
			btnSelectNodes.Enabled = true;
			txtXPathQuery.Enabled = true;
			txtQueryResults.Enabled = true;
			btnModifyNodes.Enabled = true;
		}

		private void btnSelectSingleNode_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.txtQueryResults.Text = XmlHelper.NodeToString(doc.SelectSingleNode(this.txtXPathQuery.Text));
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error in XPath query");
			}
		}

		private void btnSelectNodes_Click(object sender, System.EventArgs e)
		{
			try
			{
				XmlNodeList nodeList = doc.SelectNodes(this.txtXPathQuery.Text);
				if (nodeList != null)
				{
					System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
					foreach (XmlNode  node in nodeList)
					{
						strBuilder.Append(XmlHelper.NodeToString(node));
					}
					this.txtQueryResults.Text = strBuilder.ToString();
				}
				else
					this.txtQueryResults.Text = "No data returned";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error in XPath query");
			}
		}

		private void btnModifyNodes_Click(object sender, System.EventArgs e)
		{
			XmlNodeList nodeList = doc.SelectNodes("/ZooRoot/ZooTable/Classification[@Type='Primates']");
			foreach (XmlNode node in nodeList)
			{
				XmlHelper.SetAttributeValue(node, "Type", "Monkeys");
			}
			this.txtXmlData.Text = XmlHelper.DocumentToString(doc);

			btnCopyNodes.Enabled = true;
			btnCopyNodes2.Enabled = true;
		}

		private void btnCopyNodes_Click(object sender, System.EventArgs e)
		{
			///
			/// Get Access to the node that we need to copy
			/// 
			XmlNode nodeToCopy = doc.SelectSingleNode("/ZooRoot/ZooTable[@Name='Chicago Zoo']");
			
			///
			/// Copy the node
			/// 
			XmlNode newNode = doc.ImportNode(nodeToCopy, true);  //true means that child nodes will be copied as well

			///
			/// Set attributes that are different
			/// 
			XmlHelper.SetAttributeValue(newNode, "Name", "New York Zoo");
			XmlHelper.SetAttributeValue(newNode, "Address", "235 Congestion Ave");
			XmlHelper.SetAttributeValue(newNode, "City", "New York");
			XmlHelper.SetAttributeValue(newNode, "State", "NY");
			XmlHelper.SetAttributeValue(newNode, "Zip", "44444");

			///
			/// Add child node. Note that the new node shares the same parent as the node
			/// we are copying from, so we might as well access the parent node from the node
			/// that we are copying from.
			/// 
			nodeToCopy.ParentNode.AppendChild(newNode);

			this.txtXmlData.Text = XmlHelper.DocumentToString(doc);

			btnFillListBox.Enabled = true;
		}

		private void btnCopyNodes2_Click(object sender, System.EventArgs e)
		{
			///
			/// To avoid duplicating nodes, first re-create the xml document
			///
			this.btnCreateDoc_Click(sender, e);
			
			/// 
			/// Create a new node and set its attributes
			///
			XmlNode newNode = doc.CreateElement("ZooTable");
			XmlHelper.CreateAttribute(newNode, "Name", "New York Zoo");
			XmlHelper.CreateAttribute(newNode, "Address", "235 Congestion Ave");
			XmlHelper.CreateAttribute(newNode, "City", "New York");
			XmlHelper.CreateAttribute(newNode, "State", "NY");
			XmlHelper.CreateAttribute(newNode, "Zip", "44444");

			/// Get Access to the node that we need to copy
			/// 
			XmlNode nodeToCopy = doc.SelectSingleNode("/ZooRoot/ZooTable[@Name='Chicago Zoo']");

			///
			/// Copy all the attributes of the child nodes
			/// 
			foreach (XmlNode childNode in nodeToCopy.ChildNodes)
			{
				XmlNode newChildNode = doc.CreateElement("Classification");
				XmlHelper.CreateAttribute(newChildNode, "Type", "");
				XmlHelper.CopyAttribute(childNode, newChildNode, "Type");
				newNode.AppendChild(newChildNode);
			}

			///
			/// Add child node. Note that the new node shares the same parent as the node
			/// we are copying from, so we might as well access the parent node from the node
			/// that we are copying from.
			/// 
			nodeToCopy.ParentNode.AppendChild(newNode);

			this.txtXmlData.Text = XmlHelper.DocumentToString(doc);

			btnFillListBox.Enabled = true;
			lstZoos.Enabled = true;
		}

		private void btnFillListBox_Click(object sender, System.EventArgs e)
		{
			XmlNodeList nodeList = doc.SelectNodes("/ZooRoot/ZooTable");
			this.lstZoos.DataSource = XmlHelper.GetAttributeArray(nodeList, "Name");

			btnFillDataGrid.Enabled = true;
			grdZoos.Enabled = true;
		}

		private void btnFillDataGrid_Click(object sender, System.EventArgs e)
		{
			XmlNodeList nodeList = doc.SelectNodes("/ZooRoot/ZooTable");
			this.grdZoos.DataSource = XmlHelper.GetDataTable(nodeList);

			btnFillDataGridWithPrimaryKey.Enabled = true;
		}

		private void btnFillDataGridWithPrimaryKey_Click(object sender, System.EventArgs e)
		{
			XmlNodeList nodeList = doc.SelectNodes("/ZooRoot/ZooTable");
			this.grdZoos.DataSource = XmlHelper.GetDataTable(nodeList, "Name", false);

			btnUpdateXmlDocument.Enabled = true;
		}

		private void btnUpdateXmlDocument_Click(object sender, System.EventArgs e)
		{
			///
			/// Get access to the DataTable that was modified in DataGrid
			/// 
			DataTable table = (DataTable)this.grdZoos.DataSource;

			///
			/// Get access to the parent node whose child are part of the datatable
			/// 
			XmlNode parentNode = doc.SelectSingleNode("/ZooRoot");

			///
			/// Update the XmlDocument with changes made on DataGrid
			/// 
			XmlHelper.UpdateChildNodesWithDataTable(parentNode, table, "Name");

			this.txtXmlData.Text = XmlHelper.DocumentToString(doc);

			btnImportNodes.Enabled = true;
		}

		private void btnImportNodes_Click(object sender, System.EventArgs e)
		{
			///
			/// Create a XmlDocument that will organize data by Country
			/// 
			XmlDocument docMaster = XmlHelper.CreateXmlDocument();
			XmlNode newNode = docMaster.CreateElement("root");
			XmlNode rootNode = docMaster.AppendChild(newNode);

			newNode = docMaster.CreateElement("Country");
			XmlHelper.CreateAttribute(newNode, "Name", "USA");
			XmlNode usaRoot = rootNode.AppendChild(newNode);

			///
			/// Select the nodes to be imported
			/// 
			XmlNodeList nodeList = doc.SelectNodes("/ZooRoot/ZooTable");

			///
			/// Import nodes
			/// 
			foreach (XmlNode sourceNode in nodeList)
			{
				newNode = docMaster.ImportNode(sourceNode, true);
				usaRoot.AppendChild(newNode);
			}
			
			this.txtQueryResults.Text = XmlHelper.DocumentToString(docMaster);
		}
	}
}
