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
            comboBoxShow.Items.Add("The Top of Three");
            //comboBoxShow.Items.Add("Failing");
            comboBoxShow.Items.Add("Analysis Chinese");
            comboBoxShow.Items.Add("Analysis Math");
            comboBoxShow.Items.Add("Analysis English");


            //listBox中展示所有学生成绩
            for (int k = 0; k < StudentList.i; k++)
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
            //求总分平均数模块
            if (StudentList.Average() != 0)
                textBoxAvarage.Text = Convert.ToString(StudentList.Average());

            //labelShow.Text = Convert.ToString(STU.STRNAME + "      " +
            //    "      " + STU.STRID + "      " + STU.STRCLASS + "      " +
            //    "      " + STU.CHINESE + "      " + STU.MATH + "      " +
            //    "      " + STU.ENGLISH + "      " + STU.ALL);

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
                    {
                        listBox8.Items.Clear();
                        if (StudentList.SortByScore() == 1)
                        {
                            label.Text = "Name" + "    " + "ID" + "    " + "Class" + "    " + "Chinese" + "    " + "Math" + "    " + "English" + "    " + "All";
                            listBox8.Items.Add(Convert.ToString(Convert.ToString(StudentList.STU[0].STRNAME) + '\t' + Convert.ToString(StudentList.STU[0].ENGLISH) + '\t'
                                    + Convert.ToString(StudentList.STU[0].STRID) + '\t' + Convert.ToString(StudentList.STU[0].STRCLASS) + '\t' + Convert.ToString(StudentList.STU[0].CHINESE)
                                    + '\t' + Convert.ToString(StudentList.STU[0].MATH) + '\t' + Convert.ToString(StudentList.STU[0].ALL)));
                        }
                        else
                        {
                            for (int k = 0; k < 3 && k < StudentList.i; k++)
                            {
                                label.Text = "Name" + "    " + "ID" + "    " + "Class" + "    " + "Chinese" + "    " + "Math" + "    " + "English" + "    " + "All";
                                listBox8.Items.Add(Convert.ToString(Convert.ToString(StudentList.STU[k].STRNAME) + '\t'
                                    + Convert.ToString(StudentList.STU[k].STRID) + '\t' + Convert.ToString(StudentList.STU[k].STRCLASS) + '\t'
                                    + Convert.ToString(StudentList.STU[k].CHINESE) + '\t' + Convert.ToString(StudentList.STU[k].MATH) + '\t'
                                    + Convert.ToString(StudentList.STU[k].ENGLISH) + "\t" + Convert.ToString(StudentList.STU[k].ALL)));
                            }

                        }
                        break;
                    }
                case "Analysis Chinese":
                    {
                        listBox8.Items.Clear();
                        float[] ChineseAnalyzie = new float[6] { 0, 0, 0, 0, 0, 0 };
                        ChineseAnalyzie = StudentList.PercentageOfChinese();
                        label.Text = "Chinese Analysis";
                        int ChineseSection = 100;
                        listBox8.Items.Add("The top is :" + ChineseAnalyzie[5]);
                        for (int k = 0; (k < 5) && (StudentList.i != 0); k++)
                        {
                            listBox8.Items.Add(Convert.ToString(ChineseSection) + "-"
                                + Convert.ToString(ChineseSection - 10) + "  :    "
                                + "Number:" + Convert.ToString(ChineseAnalyzie[k])
                                + "\t" + "Percentage:"
                                + Convert.ToString(ChineseAnalyzie[k] / StudentList.i * 100) + "%");
                            ChineseSection -= 10;
                        }
                        listBox8.Items.Add("Fail:");
                        label.Text = "Name" + "    " + "ID" + "    " + "Class" + "    " + "Chinese" + "    " + "Math" + "    " + "English" + "    " + "All";
                        for (int k = 0; k < StudentList.i; k++)
                        {
                            if (StudentList.STU[k].CHINESE < 60)
                            {
                                listBox8.Items.Add(Convert.ToString(
                                    Convert.ToString(StudentList.STU[k].STRNAME) + '\t'
                                   + Convert.ToString(StudentList.STU[k].STRID) + '\t'
                                   + Convert.ToString(StudentList.STU[k].STRCLASS) + '\t'
                                   + Convert.ToString(StudentList.STU[k].CHINESE) + '\t'
                                   + Convert.ToString(StudentList.STU[k].MATH) + '\t'
                                   + Convert.ToString(StudentList.STU[k].ENGLISH) + '\t'
                                   + Convert.ToString(StudentList.STU[k].ALL)));
                            }
                        }
                        break;
                    }
                case "Analysis Math":
                    {


                        listBox8.Items.Clear();
                        float[] MathAnalyzie = new float[6];
                        MathAnalyzie = StudentList.PercentageOfChinese();
                        label.Text = "Math Analysis";
                        int MathSection = 100;
                        listBox8.Items.Add("The top is :" + MathAnalyzie[5]);
                        for (int k = 0; (k < 5) && (StudentList.i != 0); k++)
                        {
                            listBox8.Items.Add(Convert.ToString(MathSection) + "-"
                            + Convert.ToString(MathSection - 10) + "  :    "
                            + "Number:" + Convert.ToString(MathAnalyzie[k])
                            + "\t" + "Percentage:"
                            + Convert.ToString(MathAnalyzie[k] / StudentList.i * 100) + "%");
                            MathSection -= 10;
                        }
                        listBox8.Items.Add("Fail:");
                        label.Text = "Name" + "    " + "ID" + "    " + "Class" + "    " + "Chinese" + "    " + "Math" + "    " + "English" + "    " + "All";
                        for (int k = 0; k < StudentList.i; k++)
                        {
                            if (StudentList.STU[k].MATH < 60)
                            {
                                listBox8.Items.Add(
                                    Convert.ToString(Convert.ToString(StudentList.STU[k].STRNAME) + '\t'
                                     + Convert.ToString(StudentList.STU[k].STRID) + '\t'
                                     + Convert.ToString(StudentList.STU[k].STRCLASS) + '\t'
                                     + Convert.ToString(StudentList.STU[k].CHINESE) + '\t'
                                     + Convert.ToString(StudentList.STU[k].MATH) + '\t'
                                     + Convert.ToString(StudentList.STU[k].ENGLISH) + '\t'
                                     + Convert.ToString(StudentList.STU[k].ALL)));
                            }

                        }
                        break;
                    }
                case "Analysis English":
                    {
                        listBox8.Items.Clear();
                        float[] EnglishAnalyzie = new float[6];
                        EnglishAnalyzie = StudentList.PercentageOfChinese();
                        label.Text = "English Analysis";
                        int EnglishSection = 100;
                        listBox8.Items.Add("The top is :" + EnglishAnalyzie[5]);
                        for (int k = 0; (k < 5) && (StudentList.i != 0); k++)
                        {
                            listBox8.Items.Add(Convert.ToString(EnglishSection) + "-"
                           + Convert.ToString(EnglishSection - 10) + "  :    "
                           + "Number:" + Convert.ToString(EnglishAnalyzie[k])
                           + "\t" + "Percentage:"
                           + Convert.ToString(EnglishAnalyzie[k] / StudentList.i * 100) + "%");
                            EnglishSection -= 10;
                        }
                        listBox8.Items.Add("Fail:");
                        label.Text = "Name" + "    " + "ID" + "    " + "Class" + "    " + "Chinese" + "    " + "Math" + "    " + "English" + "    " + "All";
                        for (int k = 0; k < StudentList.i; k++)
                        {
                            if (StudentList.STU[k].ENGLISH < 60)
                            {
                                listBox8.Items.Add(Convert.ToString(
                                Convert.ToString(StudentList.STU[k].STRNAME) + '\t'
                                + Convert.ToString(StudentList.STU[k].STRID) + '\t'
                                + Convert.ToString(StudentList.STU[k].STRCLASS) + '\t'
                                + Convert.ToString(StudentList.STU[k].CHINESE) + '\t'
                                + Convert.ToString(StudentList.STU[k].MATH) + '\t'
                                + Convert.ToString(StudentList.STU[k].ENGLISH) + '\t'
                                + Convert.ToString(StudentList.STU[k].ALL)));
                            }
                        }
                        break;
                    }
            }



        }


    }
}
