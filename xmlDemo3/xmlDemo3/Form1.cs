using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace xmlDemo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writeLog("Log");
        }


        /// <summary>
        /// Write a log into the xml file
        /// </summary>
        /// <param name="log"></param>
        public void writeLog(string log)
        {
            string xmlName = "record.xml";
            if (!System.IO.File.Exists(xmlName))
            {
                XmlTextWriter writer = new XmlTextWriter(xmlName, System.Text.Encoding.UTF8);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 2;

                writer.WriteStartElement("Record");
                writer.WriteEndElement();

                writer.WriteEndDocument();//End
                writer.Close();
            }
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlName);
            XmlElement root = doc.DocumentElement;
            XmlElement elementRecord = doc.CreateElement("record");
            XmlElement elementTime = doc.CreateElement("time");
            XmlElement elementEvent = doc.CreateElement("event");
            XmlText time = doc.CreateTextNode(getSystemTime());
            XmlText myevent = doc.CreateTextNode(log);
            elementRecord.AppendChild(elementTime);
            elementRecord.AppendChild(elementEvent);
            elementTime.AppendChild(time);
            elementEvent.AppendChild(myevent);
            root.InsertAfter(elementRecord, root.LastChild);
            doc.Save(xmlName);
        }
        private string getSystemTime()
        {
            //string strSystem = Environment.OSVersion.ToString();
            string strTime = System.DateTime.Now.ToString();
            return strTime;
        }



        /// <summary>
        /// (XmlNode)document.DocumentElement
        /// </summary>
        /// <param name="root"></param>
        /// <param name="indent"></param>
        /// <returns>StringBuilder Vector</returns>
        public StringBuilder RecurseXmlDocument(XmlNode root, int indent)
        {
            StringBuilder vector = new StringBuilder();
            // Make sure we don't do anything if the root is null  
            if (root == null)
                return vector;


            if (root is XmlElement) // Root is an XmlElement type  
            {
                // first, print the name  
                listBoxXmlNodes.Items.Add(root.Name.PadLeft(root.Name.Length + indent));
                vector.AppendLine(root.Name.PadLeft(root.Name.Length + indent));

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
                vector.AppendLine(text.PadLeft(text.Length + indent));
            }
            else if (root is XmlComment)
            {
                // Print text  
                string text = root.Value;
                listBoxXmlNodes.Items.Add(text.PadLeft(text.Length + indent));
                vector.AppendLine(text.PadLeft(text.Length + indent));

                // Then check if there are any child nodes and if there are, call this  
                // method again to print them  
                if (root.HasChildNodes)
                    RecurseXmlDocument(root.FirstChild, indent + 2);

                // Finally check to see if there are any siblings and if there are  
                // call this method again to have them printed  
                if (root.NextSibling != null)
                    RecurseXmlDocument(root.NextSibling, indent);
            }

            return vector;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string xmlName = "record.xml";
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlName);
            }
            catch (System.Exception ex)
            {
            	throw ex;
            }

            //StringBuilder vector = RecurseXmlDocument((XmlNode)doc.DocumentElement, 0);
            RecurseXmlDocument((XmlNode)doc.DocumentElement, 0);
        }


        public void modifyXml(string connstrtin, string provider)
        {
            string xmlName = "App.config";
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(xmlName);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            XmlNode xn = doc.SelectSingleNode("/configuration/connectionStrings/add");
            //xn.Attributes["connectionString"].Value = connstrtin;
            //xn.Attributes["providerName"].Value = provider;
            //XmlTextWriter xWriter = new XmlTextWriter(xmlName, null);
            //xWriter.Formatting = Formatting.Indented;
            //doc.WriteTo(xWriter);
            //xWriter.Close();
            XmlElement xe = (XmlElement)xn;   
            if (xe != null)
            {
                xe.SetAttribute("connectionString", connstrtin);
                xe.SetAttribute("providerName", provider);
            }
            doc.Save(xmlName);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connstrtin = "19919199191";
            string provider = "icecream";
            modifyXml(connstrtin, provider);
        }
    }
}
