using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using Tools;
using System.Collections.Specialized;

namespace XmlHelperDemo
{
	/// <summary>
	/// Summary description for Demo2Controls.
	/// </summary>
	public class Demo2Controls : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.TextBox txtXmlData;
		private System.Windows.Forms.Button btnCreateDoc;
		private System.Windows.Forms.Button btnModifyNodes;
		private System.Windows.Forms.Button btnQueryScalar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtXPath;
		private System.Windows.Forms.TextBox txtField;
		private System.Windows.Forms.RadioButton rbQueryScalar;
		private System.Windows.Forms.RadioButton rbQuery;
		private System.Windows.Forms.RadioButton rbQueryField;
		private System.Windows.Forms.DataGrid grdResult;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.ListBox lstResult;
		private System.Windows.Forms.GroupBox grpQuery;
		private System.Windows.Forms.TextBox txtXPathToDelete;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label4;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Demo2Controls()
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
			this.txtXmlData = new System.Windows.Forms.TextBox();
			this.btnCreateDoc = new System.Windows.Forms.Button();
			this.btnModifyNodes = new System.Windows.Forms.Button();
			this.btnQueryScalar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtXPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtField = new System.Windows.Forms.TextBox();
			this.rbQueryScalar = new System.Windows.Forms.RadioButton();
			this.rbQuery = new System.Windows.Forms.RadioButton();
			this.rbQueryField = new System.Windows.Forms.RadioButton();
			this.grdResult = new System.Windows.Forms.DataGrid();
			this.grpQuery = new System.Windows.Forms.GroupBox();
			this.lstResult = new System.Windows.Forms.ListBox();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtXPathToDelete = new System.Windows.Forms.TextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
			this.grpQuery.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtXmlData
			// 
			this.txtXmlData.Location = new System.Drawing.Point(0, 32);
			this.txtXmlData.Multiline = true;
			this.txtXmlData.Name = "txtXmlData";
			this.txtXmlData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtXmlData.Size = new System.Drawing.Size(360, 232);
			this.txtXmlData.TabIndex = 33;
			this.txtXmlData.Text = "";
			this.txtXmlData.WordWrap = false;
			// 
			// btnCreateDoc
			// 
			this.btnCreateDoc.Location = new System.Drawing.Point(8, 0);
			this.btnCreateDoc.Name = "btnCreateDoc";
			this.btnCreateDoc.Size = new System.Drawing.Size(144, 24);
			this.btnCreateDoc.TabIndex = 32;
			this.btnCreateDoc.Text = "Create Xml Document";
			this.btnCreateDoc.Click += new System.EventHandler(this.btnCreateDoc_Click);
			// 
			// btnModifyNodes
			// 
			this.btnModifyNodes.Enabled = false;
			this.btnModifyNodes.Location = new System.Drawing.Point(168, 0);
			this.btnModifyNodes.Name = "btnModifyNodes";
			this.btnModifyNodes.Size = new System.Drawing.Size(88, 24);
			this.btnModifyNodes.TabIndex = 38;
			this.btnModifyNodes.Text = "Modify Nodes";
			this.btnModifyNodes.Click += new System.EventHandler(this.btnModifyNodes_Click);
			// 
			// btnQueryScalar
			// 
			this.btnQueryScalar.Location = new System.Drawing.Point(16, 120);
			this.btnQueryScalar.Name = "btnQueryScalar";
			this.btnQueryScalar.Size = new System.Drawing.Size(56, 64);
			this.btnQueryScalar.TabIndex = 39;
			this.btnQueryScalar.Text = "Execute Query";
			this.btnQueryScalar.Click += new System.EventHandler(this.btnExecuteQuery);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 16);
			this.label1.TabIndex = 40;
			this.label1.Text = "XPath Query";
			// 
			// txtXPath
			// 
			this.txtXPath.Location = new System.Drawing.Point(80, 40);
			this.txtXPath.Name = "txtXPath";
			this.txtXPath.Size = new System.Drawing.Size(288, 20);
			this.txtXPath.TabIndex = 41;
			this.txtXPath.Text = "ZooTable";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(40, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 42;
			this.label2.Text = "Field";
			// 
			// txtField
			// 
			this.txtField.Location = new System.Drawing.Point(80, 64);
			this.txtField.Name = "txtField";
			this.txtField.TabIndex = 43;
			this.txtField.Text = "City";
			this.txtField.Visible = false;
			// 
			// rbQueryScalar
			// 
			this.rbQueryScalar.Location = new System.Drawing.Point(168, 8);
			this.rbQueryScalar.Name = "rbQueryScalar";
			this.rbQueryScalar.Size = new System.Drawing.Size(88, 24);
			this.rbQueryScalar.TabIndex = 46;
			this.rbQueryScalar.Text = "Query Scalar";
			this.rbQueryScalar.CheckedChanged += new System.EventHandler(this.rbQuery_CheckedChanged);
			// 
			// rbQuery
			// 
			this.rbQuery.Checked = true;
			this.rbQuery.Location = new System.Drawing.Point(80, 8);
			this.rbQuery.Name = "rbQuery";
			this.rbQuery.Size = new System.Drawing.Size(64, 24);
			this.rbQuery.TabIndex = 47;
			this.rbQuery.TabStop = true;
			this.rbQuery.Text = "Query";
			this.rbQuery.CheckedChanged += new System.EventHandler(this.rbQuery_CheckedChanged);
			// 
			// rbQueryField
			// 
			this.rbQueryField.Location = new System.Drawing.Point(272, 8);
			this.rbQueryField.Name = "rbQueryField";
			this.rbQueryField.Size = new System.Drawing.Size(88, 24);
			this.rbQueryField.TabIndex = 48;
			this.rbQueryField.Text = "Query Field";
			this.rbQueryField.CheckedChanged += new System.EventHandler(this.rbQuery_CheckedChanged);
			// 
			// grdResult
			// 
			this.grdResult.AlternatingBackColor = System.Drawing.Color.Lavender;
			this.grdResult.BackColor = System.Drawing.Color.WhiteSmoke;
			this.grdResult.BackgroundColor = System.Drawing.Color.LightGray;
			this.grdResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.grdResult.CaptionBackColor = System.Drawing.Color.LightSteelBlue;
			this.grdResult.CaptionForeColor = System.Drawing.Color.MidnightBlue;
			this.grdResult.CaptionVisible = false;
			this.grdResult.DataMember = "";
			this.grdResult.FlatMode = true;
			this.grdResult.Font = new System.Drawing.Font("Tahoma", 8F);
			this.grdResult.ForeColor = System.Drawing.Color.MidnightBlue;
			this.grdResult.GridLineColor = System.Drawing.Color.Gainsboro;
			this.grdResult.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
			this.grdResult.HeaderBackColor = System.Drawing.Color.MidnightBlue;
			this.grdResult.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.grdResult.HeaderForeColor = System.Drawing.Color.WhiteSmoke;
			this.grdResult.LinkColor = System.Drawing.Color.Teal;
			this.grdResult.Location = new System.Drawing.Point(80, 88);
			this.grdResult.Name = "grdResult";
			this.grdResult.ParentRowsBackColor = System.Drawing.Color.Gainsboro;
			this.grdResult.ParentRowsForeColor = System.Drawing.Color.MidnightBlue;
			this.grdResult.RowHeadersVisible = false;
			this.grdResult.RowHeaderWidth = 15;
			this.grdResult.SelectionBackColor = System.Drawing.Color.CadetBlue;
			this.grdResult.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
			this.grdResult.Size = new System.Drawing.Size(288, 144);
			this.grdResult.TabIndex = 49;
			// 
			// grpQuery
			// 
			this.grpQuery.Controls.Add(this.lstResult);
			this.grpQuery.Controls.Add(this.txtResult);
			this.grpQuery.Controls.Add(this.label3);
			this.grpQuery.Controls.Add(this.label1);
			this.grpQuery.Controls.Add(this.txtXPath);
			this.grpQuery.Controls.Add(this.rbQueryField);
			this.grpQuery.Controls.Add(this.rbQuery);
			this.grpQuery.Controls.Add(this.grdResult);
			this.grpQuery.Controls.Add(this.txtField);
			this.grpQuery.Controls.Add(this.label2);
			this.grpQuery.Controls.Add(this.btnQueryScalar);
			this.grpQuery.Controls.Add(this.rbQueryScalar);
			this.grpQuery.Enabled = false;
			this.grpQuery.Location = new System.Drawing.Point(368, 0);
			this.grpQuery.Name = "grpQuery";
			this.grpQuery.Size = new System.Drawing.Size(376, 264);
			this.grpQuery.TabIndex = 50;
			this.grpQuery.TabStop = false;
			this.grpQuery.Text = "Query";
			// 
			// lstResult
			// 
			this.lstResult.Location = new System.Drawing.Point(80, 88);
			this.lstResult.Name = "lstResult";
			this.lstResult.Size = new System.Drawing.Size(288, 147);
			this.lstResult.TabIndex = 52;
			this.lstResult.Visible = false;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(80, 88);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResult.Size = new System.Drawing.Size(288, 40);
			this.txtResult.TabIndex = 51;
			this.txtResult.Text = "";
			this.txtResult.Visible = false;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(32, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 16);
			this.label3.TabIndex = 50;
			this.label3.Text = "Result";
			// 
			// txtXPathToDelete
			// 
			this.txtXPathToDelete.Enabled = false;
			this.txtXPathToDelete.Location = new System.Drawing.Point(32, 272);
			this.txtXPathToDelete.Name = "txtXPathToDelete";
			this.txtXPathToDelete.Size = new System.Drawing.Size(256, 20);
			this.txtXPathToDelete.TabIndex = 51;
			this.txtXPathToDelete.Text = "ZooTable[@Name=\'Hungry Zoo\']";
			// 
			// btnDelete
			// 
			this.btnDelete.Enabled = false;
			this.btnDelete.Location = new System.Drawing.Point(296, 270);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(64, 24);
			this.btnDelete.TabIndex = 52;
			this.btnDelete.Text = "Delete";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 274);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 16);
			this.label4.TabIndex = 53;
			this.label4.Text = "XPath";
			// 
			// Demo2Controls
			// 
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.txtXPathToDelete);
			this.Controls.Add(this.grpQuery);
			this.Controls.Add(this.btnModifyNodes);
			this.Controls.Add(this.txtXmlData);
			this.Controls.Add(this.btnCreateDoc);
			this.Controls.Add(this.label4);
			this.Name = "Demo2Controls";
			this.Size = new System.Drawing.Size(752, 296);
			((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
			this.grpQuery.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private XmlDocument doc;

		private void btnCreateDoc_Click(object sender, System.EventArgs e)
		{
			///
			/// Create the XmlDocument and specify name of the root node
			///
			doc = XmlHelper.CreateXmlDocument("ZooRoot");

			///
			/// First Row
			/// 
			string[] fields = new string[] {"Name", "Address", "City", "State", "Zip"};
			string[] values = new string[] {"Crazy Zoo", "32 Turtle Lane", "Austin", "TX", "12345"};
			XmlHelper.Insert(doc, "ZooTable", fields, values);

			///
			/// Second Row (Zip is missing)
			/// 
			string[] fields2 = new string[] {"Name", "Address", "City", "State"};
			values = new string[]{"Chicago Zoo", "23 Zebra Ave", "Chicago", "IL"};
			XmlHelper.Insert(doc, "ZooTable", fields2, values);

			///
			/// Third Row
			/// 
			values = new string[] {"Hungry Zoo", "45 Lion st", "Miami", "FL", "33122"};
			XmlHelper.Insert(doc, "ZooTable", fields, values);

			///
			/// Insert Classification Data
			/// 
			values = new string[]{"Reptiles", "Birds", "Primates"};
			XmlHelper.Insert(doc, "ZooTable[@Name='Crazy Zoo']/Classification", "Type", values);

			values = new string[] {"Fish", "Mammals", "Primates"};
			XmlHelper.Insert(doc, "ZooTable[@Name='Chicago Zoo']/Classification", "Type", values);

			values = new string[] {"Arachnids", "Rodents"};
			XmlHelper.Insert(doc, "ZooTable[@Name='Hungry Zoo']/Classification", "Type", values);

			this.txtXmlData.Text = XmlHelper.DocumentToString(doc);

			///
			///Update controls
			///
			this.btnModifyNodes.Enabled = true;
			this.grpQuery.Enabled = true;
			this.txtXPathToDelete.Enabled = true;
			this.btnDelete.Enabled = true;
		}

		private void btnModifyNodes_Click(object sender, System.EventArgs e)
		{
			XmlHelper.Update(doc, "ZooTable/Classification[@Type='Primates']", "Type", "Monkeys");

			this.txtXmlData.Text = XmlHelper.DocumentToString(doc);
		}

		
	
		private void btnExecuteQuery(object sender, System.EventArgs e)
		{
			if (rbQueryScalar.Checked)
			{
				string result = XmlHelper.QueryScalar(doc, this.txtXPath.Text, this.txtField.Text);
				if (result == null) 
					txtResult.Text = "no data returned";
				else
					txtResult.Text = result;
			}

			if (rbQuery.Checked)
			{
				grdResult.DataSource = XmlHelper.Query(doc, txtXPath.Text);
			}

			if (rbQueryField.Checked)
			{
				lstResult.DataSource = XmlHelper.QueryField(doc, txtXPath.Text, txtField.Text);
			}
		}




		private void rbQuery_CheckedChanged(object sender, System.EventArgs e)
		{
			RadioButton rb = (RadioButton) sender;
			switch (rb.Name)
			{
				case "rbQueryScalar":
					txtField.Visible = true;
					lstResult.Visible = false;
					grdResult.Visible = false;
					txtResult.Visible = true;
					break;
				case "rbQuery":
					txtField.Visible = false;
					lstResult.Visible = false;
					grdResult.Visible = true;
					txtResult.Visible = false;
					break;
				case "rbQueryField":
					txtField.Visible = true;
					lstResult.Visible = true;
					grdResult.Visible = false;
					txtResult.Visible = false;
					break;
			}
			txtResult.Text = "";
			lstResult.DataSource = null;
			grdResult.DataSource = null;
		}

		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			if (txtXPathToDelete.Text.Length > 0)
			{
				XmlHelper.Delete(doc, txtXPathToDelete.Text);
			}

			this.txtXmlData.Text = XmlHelper.DocumentToString(doc);
		}
	}
}
