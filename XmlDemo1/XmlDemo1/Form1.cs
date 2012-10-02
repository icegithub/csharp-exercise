using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XmlDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Add a node
        private void button1_Click(object sender, EventArgs e)
        {
            //Load the XML document
            XmlDocument document = new XmlDocument();
            document.Load("../../Books.xml");

            //Get the root element
            XmlElement root = document.DocumentElement;


            //Create the new nodes
            XmlElement newBook = document.CreateElement("book");
            XmlElement newTitle = document.CreateElement("title");
            XmlElement newAuthor = document.CreateElement("author");
            XmlElement newCode = document.CreateElement("code");
            XmlText title = document.CreateTextNode("Beginning Visual C# 3rd Edition");  
            XmlText author = document.CreateTextNode("Karli Watson C# 3rd Edition");
            XmlText code = document.CreateTextNode("1234567890");
            XmlComment comment = document.CreateComment("This book is the book you are reading");

            //Insert the elements
            newBook.AppendChild(comment);
            newBook.AppendChild(newTitle);
            newBook.AppendChild(newAuthor);
            newBook.AppendChild(newCode);
            newTitle.AppendChild(title);
            newAuthor.AppendChild(author);
            newCode.AppendChild(code);
            root.InsertAfter(newBook, root.LastChild);

            document.Save("../../Books.xml");

            listBoxXmlNodes.Items.Clear();
            RecurseXmlDocument((XmlNode)document.DocumentElement, 0);  
        }

        //在一个ListBox中显示文档的所有节点名称以及文本节点的内容  
        private void RecurseXmlDocument(XmlNode root, int indent)
        {
            // Make sure we don't do anything if the root is null  
            if (root == null)
                return;


            if (root is XmlElement) // Root is an XmlElement type  
            {
                // first, print the name  
                listBoxXmlNodes.Items.Add(root.Name.PadLeft(root.Name.Length + indent));


                // Then check if there are any child nodes and if there are, call this  
                // method again to print them  
                if (root.HasChildNodes)
                    RecurseXmlDocument(root.FirstChild, indent + 2);


                // Finally check to see if there are any siblings and if there are  
                // call this method again to have them printed  
                if (root.NextSibling != null)
                    RecurseXmlDocument(root.NextSibling, indent);
            }
            else if (root is XmlText)
            {
                // Print the text  
                string text = ((XmlText)root).Value;
                listBoxXmlNodes.Items.Add(text.PadLeft(text.Length + indent));
            }
            else if (root is XmlComment)
            {
                // Print text  
                string text = root.Value;
                listBoxXmlNodes.Items.Add(text.PadLeft(text.Length + indent));


                // Then check if there are any child nodes and if there are, call this  
                // method again to print them  
                if (root.HasChildNodes)
                    RecurseXmlDocument(root.FirstChild, indent + 2);


                // Finally check to see if there are any siblings and if there are  
                // call this method again to have them printed  
                if (root.NextSibling != null)
                    RecurseXmlDocument(root.NextSibling, indent);
            }
        }

        //Delete a node
        private void button2_Click(object sender, EventArgs e)
        {
            // Load the XML document  
            XmlDocument document = new XmlDocument();
            document.Load("../../Books.xml");


            // Get the root element  
            XmlElement root = document.DocumentElement;


            // Find the node. root is the < books> tag, so its last child which will be the  
            // last < book> node  
            if (root.HasChildNodes)
            {
                XmlNode book = root.LastChild;


                // Delete the child  
                root.RemoveChild(book);


                // Save the document back to disk  
                document.Save("../../Books.xml");
                listBoxXmlNodes.Items.Clear();


                RecurseXmlDocument((XmlNode)document.DocumentElement, 0);
            }  
        }
        //Query a node
        private void button3_Click(object sender, EventArgs e)
        {
            // Load the XML document  
            XmlDocument document = new XmlDocument();
            //document.Load(@filePath);
            document.Load("../../Books.xml");

            // Get the root element  
            XmlElement root = document.DocumentElement;


            string queryStr = textBoxQueryText.Text;


            XmlNodeList nodeList = root.SelectNodes(queryStr);
            listBoxXmlNodes.Items.Clear();


            foreach (XmlNode n in nodeList)
            {
                RecurseXmlDocument(n, 0);
            }  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CourseType ct = new CourseType();
            ct.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //转换一个XML文件(本地\网络均可)为一个DataSet#region 转换一个XML文件(本地\网络均可)为一个DataSet
            //http://news.baidu.com/n?cmd=1&class=sportnews&tn=rss
            //F:\study\001CSharp_Study\002Source\XmlDesign\XmlDesign\Save_Plan.xml
            ds = XmlDatasetConvert.ConvertXMLFileToDataSet(@"http://news.baidu.com/n?cmd=1&class=sportnews&tn=rss%22");
            Console.WriteLine("数据集名为\"{0}\",包含{1}个表", ds.DataSetName, ds.Tables.Count);
            foreach(DataTable dt in ds.Tables)
            {
                PrintTableName(dt.TableName);
            };
            //#endregion
            //构造一个DataSet,并转换为XML字符串#region 构造一个DataSet,并转换为XML字符串
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            dt1.TableName = "test";
            dt1.Columns.Add("id");
            dt1.Columns.Add("name");
            dt1.Rows.Add("i001", "hekui");
            dt1.Rows.Add("i002", "liyang");
            DataTable dt2 = new DataTable();
            dt2.TableName = "test1";
            dt2.Columns.Add("bookid");
            dt2.Columns.Add("bookname");
            dt2.Rows.Add("b001", "书本1");
            dt2.Rows.Add("b002", "书本2");
            ds1.Tables.Add(dt1);
            ds1.Tables.Add(dt2);
            ds1.DataSetName = "方案";
            string xmlOut = XmlDatasetConvert.ConvertDataSetToXML(ds1);
            //#endregion
            //转换一个XML字符串为一个DataSet#region 转换一个XML字符串为一个DataSet
            DataSet ds2 = new DataSet();
            ds2 = XmlDatasetConvert.ConvertXMLToDataSet(xmlOut);
            Console.WriteLine("数据集名为\"{0}\",包含{1}个表", ds2.DataSetName, ds2.Tables.Count);
            foreach (DataTable dt in ds2.Tables)
            {
                PrintTableName(dt.TableName);
            };
            //#endregion
            //转换一个Dataset为一个XML文件#region 转换一个Dataset为一个XML文件
            XmlDatasetConvert.ConvertDataSetToXMLFile(ds2, "../../adadsda1.xml");
            //#endregion
            
            Console.ReadLine();
        }
        private static void PrintTableName(string tableName)
        {
            Console.WriteLine(tableName);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HowtocreateanXMLfileinCSharp f = new HowtocreateanXMLfileinCSharp();
            f.Show();
        }
    }
}
