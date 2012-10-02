using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Demo2;

namespace Demo2
{
    public partial class MainMenu : Form
    {
       
        public MainMenu()
        {
            //studentlist = new StudentList();   
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddStudent AddStudentDlg = new AddStudent();
            AddStudentDlg.Show();
            
        }

        private void buttonFinsh_Click(object sender, EventArgs e)
        {
            ShowRequireInfo ShowRequireInfoDlg = new ShowRequireInfo();
            ShowRequireInfoDlg.Show();
        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string SubName;
            SubName = Convert.ToString(textBoxSubName.Text);
            if (SubName == "")
            {
                MessageBox.Show("Please input name:)");
            } 
            else
            {
                int k = StudentList.Search(SubName);
                if (k == -1)
                {
                    MessageBox.Show("Not Found!");
                }
                else
                {
                    ShowStudnet ShowStudnetDlg = new ShowStudnet(k);
                    ShowStudnetDlg.Show();
                }
            }
            
        }
    }
}
