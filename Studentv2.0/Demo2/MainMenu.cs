using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
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
         
            //ShowSelect ShowSelectDlg = new ShowSelect();
            //ShowSelectDlg.Show();
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (StudentList.i==0)
            {
                MessageBox.Show("There is no student to save.\n\rPlease input Data");
                
            }
            else
            {
                for (int k = 0; k < StudentList.i; k++)
                {
                    System.IO.File.AppendAllText("StudentInfo.txt",Convert.ToString(Convert.ToString(StudentList.STU[k].STRNAME) + '\t'
                  + Convert.ToString(StudentList.STU[k].STRID) + '\t'
                  + Convert.ToString(StudentList.STU[k].STRCLASS) + '\t'
                  + Convert.ToString(StudentList.STU[k].CHINESE) + '\t'
                  + Convert.ToString(StudentList.STU[k].MATH) + '\t'
                  + Convert.ToString(StudentList.STU[k].ENGLISH) + '\t'
                  + Convert.ToString(StudentList.STU[k].ALL)));
                }

                MessageBox.Show("Save Successfully!");
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (StudentList.i == 0)
            {
                MessageBox.Show("There is no student to save.\n\rPlease input Data FIRST!");

            }
            else
            {
                for (int k = 0; k < StudentList.i; k++)
                {
                    string context=Convert.ToString(Convert.ToString(StudentList.STU[k].STRNAME) + '\t'
                  + Convert.ToString(StudentList.STU[k].STRID) + '\t'
                  + Convert.ToString(StudentList.STU[k].STRCLASS) + '\t'
                  + Convert.ToString(StudentList.STU[k].CHINESE) + '\t'
                  + Convert.ToString(StudentList.STU[k].MATH) + '\t'
                  + Convert.ToString(StudentList.STU[k].ENGLISH) + '\t'
                  + Convert.ToString(StudentList.STU[k].ALL)+" \n");
                    System.IO.File.AppendAllText("StudentInfo.txt", context);
                }

                MessageBox.Show("Save Successfully!");
            }
        }
    }
}
