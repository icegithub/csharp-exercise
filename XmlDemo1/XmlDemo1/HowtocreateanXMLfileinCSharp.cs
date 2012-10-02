using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

////Click_button9
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;

namespace XmlDemo1
{
    public partial class HowtocreateanXMLfileinCSharp : Form
    {
        DataTable dt; //button3_Click use it
        public HowtocreateanXMLfileinCSharp()
        {
            InitializeComponent();
        }


        /// <summary>
        /// How to create an XML file in C#
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("product1.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;//Indented 缩进
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", "Product 1", "1000", writer);
            createNode("2", "Product 2", "2000", writer);
            createNode("3", "Product 3", "3000", writer);
            createNode("4", "Product 4", "4000", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            MessageBox.Show("XML File created ! ");
        }
        private void createNode(string pID, string pName, string pPrice, XmlTextWriter writer)
        {
            writer.WriteStartElement("Product");
            writer.WriteStartElement("Product_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Product_name");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("Product_price");
            writer.WriteString(pPrice);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }


        /// <summary>
        /// How to open and read an XML file in C#
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string str = null;
            FileStream fs = new FileStream("product.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("Product");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                //xmlnode[i].ChildNodes.Item(0).InnerText.Trim();
                str = xmlnode[i].ChildNodes.Item(0).InnerText.Trim() + " | " + xmlnode[i].ChildNodes.Item(1).InnerText.Trim() + " | " + xmlnode[i].ChildNodes.Item(2).InnerText.Trim();
                MessageBox.Show(str);
            }
        }


        /// <summary>
        /// How to create XML file from Dataset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            dt = new DataTable();
            dt.Columns.Add(new DataColumn("Product_ID", Type.GetType("System.Int32")));
            dt.Columns.Add(new DataColumn("Product_Name", Type.GetType("System.String")));
            dt.Columns.Add(new DataColumn("product_Price", Type.GetType("System.Int32")));
            fillRows(1, "product1", 1111);
            fillRows(2, "product2", 2222);
            fillRows(3, "product3", 3333);
            fillRows(4, "product4", 4444);
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "product";
            ds.WriteXml("Product2.xml");
            MessageBox.Show("Done");
        }
        private void fillRows(int pID, string pName, int pPrice)
        {
            DataRow dr;
            dr = dt.NewRow();
            dr["Product_ID"] = pID;
            dr["Product_Name"] = pName;
            dr["product_Price"] = pPrice;
            dt.Rows.Add(dr);
        }


        /// <summary>
        /// How to search in a XML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);

            dv = new DataView(ds.Tables[0]);
            dv.Sort = "Product_Name";
            int index = dv.Find("Product2");

            if (index == -1)
            {
                MessageBox.Show("Item Not Found");
            }
            else
            {
                MessageBox.Show(dv[index]["Product_Name"].ToString() + " " + dv[index]["Product_Price"].ToString());

            }
        }


        /// <summary>
        /// How to filter in a XML file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            XmlReader xmlFile;
            xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());
            DataSet ds = new DataSet();
            DataView dv;
            ds.ReadXml(xmlFile);
            dv = new DataView(ds.Tables[0], "Product_price > = 3000", "Product_Name", DataViewRowState.CurrentRows);
            dv.ToTable().WriteXml("Result.xml");
            MessageBox.Show("Done");
        }


        /// <summary>
        /// How to create Excel file from XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            DataSet ds = new DataSet();
            XmlReader xmlFile;
            int i = 0;
            int j = 0;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xmlFile = XmlReader.Create("Product.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);

            for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            {
                for (j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                }
            }

            xlWorkBook.SaveAs("D:\\Codes\\C#\\XmlDemo1\\XmlDemo1\\bin\\Debug\\xml2excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlApp);
            releaseObject(xlWorkBook);
            releaseObject(xlWorkSheet);

            MessageBox.Show("Done .. ");
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }

        }


        /// <summary>
        /// How to create XML file from Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.DataSet ds;
                System.Data.OleDb.OleDbDataAdapter MyCommand;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='D:\\Codes\\C#\\XmlDemo1\\XmlDemo1\\bin\\Debug\\xl2xml.xls';Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "Product");
                ds = new System.Data.DataSet();
                MyCommand.Fill(ds);
                MyConnection.Close();
                ds.WriteXml("Product.xml");
                MessageBox.Show("Ok!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            } 
        }

        /// <summary>
        /// How to create a TreeView from XML File
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNode xmlnode;
            FileStream fs = new FileStream("tree.xml", FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.ChildNodes[1];
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(xmldoc.DocumentElement.Name));
            TreeNode tNode;
            tNode = treeView1.Nodes[0];
            AddNode(xmlnode, tNode);
        }
        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i = 0;
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.InnerText.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load("PUT CRYSTAL REPORT PATH HERE\\CrystalReport1.rpt");
            //crystalReportViewer1.ReportSource = cryRpt;
            //crystalReportViewer1.Refresh();
        }
    }
}
