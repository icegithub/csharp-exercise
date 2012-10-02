using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2
{
    public partial class ShowRequireInfo : Form
    {

        public ShowRequireInfo()
        {
            InitializeComponent();

        }

        private void ShowRequireInfo_Load(object sender, EventArgs e)
        {
            //labelShow.Text="Name    Secore";
            //if (ShowSelect.flag[])
            {
                for (int k = 0; k < StudentList.studentNum; k++)
                {
                    Student STU = new Student();
                    STU = StudentList.ShowAllStudent(k);
                    listBox1.Items.Add(Convert.ToString(STU.STRNAME));
                    listBox2.Items.Add(Convert.ToString(STU.STRID));
                    listBox3.Items.Add(Convert.ToString(STU.STRCLASS));
                    listBox4.Items.Add(Convert.ToString(STU.CHINESE));
                    listBox5.Items.Add(Convert.ToString(STU.MATH));
                    listBox6.Items.Add(Convert.ToString(STU.ENGLISH));
                    listBox7.Items.Add(Convert.ToString(STU.ALL));
                    
                    //labelShow.Text = Convert.ToString(STU.STRNAME + "      " +
                    //    "      " + STU.STRID + "      " + STU.STRCLASS + "      " +
                    //    "      " + STU.CHINESE + "      " + STU.MATH + "      " +
                    //    "      " + STU.ENGLISH + "      " + STU.ALL);
                }
                if (StudentList.Average() != 0)
                    textBoxAvarage.Text = Convert.ToString(StudentList.Average());
              
                   
            }

            //ShowSelect ShowSelectDlg = new ShowSelect();
            //if (ShowSelectDlg.)
            //{
            //}

            //if (Convert.ToBoolean(comboBoxShow.Items.Add("sss")))
            //    labelShow.Text = "ssdfdfadf";
            labelShow.Text = "Hello";
            comboBoxShow.Items.Add("The Top of Three");
            comboBoxShow.Items.Add("Failing");
            comboBoxShow.Items.Add("Analysis Chinese");
            comboBoxShow.Items.Add("Analysis Math");
            comboBoxShow.Items.Add("Analysis English");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void comboBoxShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxShow.Text)
            {
                case "The Top of Three":
                    if (StudentList.SortByScore() == 1)
                    {
                        //Student[] STU = new Student[3];
                        for (int k = 0; k < 3; k++)
                        {
                            StudentList.STU[k] = new Student();
                            label.Text = "The top of three\n\r"+"First:"+StudentList.STU[k].STRNAME + " " +
                      StudentList.STU[k].STRID + " " + StudentList.STU[k].STRCLASS + " " + StudentList.STU[k].CHINESE + "  " + StudentList.STU[k].MATH + "  " +
                       " " + StudentList.STU[k].ENGLISH + " " + StudentList.STU[k].ALL + "\n\r";
                            
                        }

                    }
                    label.Text = "Heee";
            	    break;
                case "Failing":
                    break;
                case "Analysis Chinese":
                    float[] ChineseSection=new float[6];
                    ChineseSection = StudentList.PercentageOfChinese();
                    label.Text = Convert.ToString(ChineseSection[5]);
                    break;
                case "Analysis Math":
                    break;
                case "Analysis English":
                    break;
            }
            
            //label1.Text = StudentList.total.ToString();
            //comboBoxShow.DataSource = StudentList.i;
        }
    }
}
