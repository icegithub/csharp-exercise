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
    public partial class CourseType : Form
    {
        public CourseType()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            //Load xml document
            XmlDocument document = new XmlDocument();
            document.Load("../../Courseinfo.xml");

            //Get the root element
            XmlElement root = document.DocumentElement;

            string cno = textBoxCNO.Text.ToString().Trim();
            string cname = textBoxCNAME.Text.ToString().Trim();
            string cprise = textBoxCP.Text.ToString().Trim();
            string ctno = textBoxCTNO.Text.ToString().Trim();
            string ctname = textBoxCTNAME.Text.ToString().Trim();

            XmlElement newCourse = document.CreateElement("course");
            XmlElement newCno = document.CreateElement("cno");
            XmlElement newCname = document.CreateElement("cname");
            XmlElement newCprise = document.CreateElement("cprise");
            XmlElement newCtno = document.CreateElement("ctno");
            XmlElement newCtname = document.CreateElement("ctname");

            XmlText cnotext = document.CreateTextNode(cno);
            XmlText cnametext = document.CreateTextNode(cname);
            XmlText cprisetext = document.CreateTextNode(cprise);
            XmlText ctnotext = document.CreateTextNode(ctno);
            XmlText ctnametext = document.CreateTextNode(ctname);

            newCourse.AppendChild(newCno);
            newCourse.AppendChild(newCname);
            newCourse.AppendChild(newCprise);
            newCourse.AppendChild(newCtno);
            newCourse.AppendChild(newCtname);

            newCno.AppendChild(cnotext);
            newCname.AppendChild(cnametext);
            newCprise.AppendChild(cprisetext);
            newCtno.AppendChild(ctnotext);
            newCtname.AppendChild(ctnametext);

            root.InsertAfter(newCourse, root.LastChild);
            document.Save("../../Courseinfo.xml");

            textBoxCNO.Text = null;
            textBoxCNAME.Text = null;
            textBoxCP.Text = null;
            textBoxCTNO.Text = null;
            textBoxCTNAME.Text = null;
 
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet set = new DataSet();
                set.ReadXml("../../Courseinfo.xml");
                dataGridView1.DataSource = set.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../Courseinfo.xml");

            //Get the root element
            XmlElement root = document.DocumentElement;

            DataSet set = new DataSet();
            //set.ReadXml("../../Courseinfo.xml");
            try
            {
                set.WriteXml("../../Courseinfo.xml");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            document.Save("../../Courseinfo.xml");
        }
    }
}
