using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace T2
{
    public partial class FormMain : Form
    {
        Classroom[] classList = new Classroom[10];
        Classroom classInUse;
        Student studentInUse;
        public FormMain()
        {
            classList[0] = new Classroom("网络一班");
            classInUse=classList[0];
            //studentInUse = new Student("090810108", "高翔", 60, 61, 59, classList[0]);
            InitializeComponent();
            refreshClassList(classList);
            refreshStudentList(classList[0]);
            showStudentInfo(studentInUse);
            showSortMode();
        }

        /// <summary>
        /// 刷新班级列表
        /// </summary>
        /// <param name="classList">用于刷新的班级数组</param>
        void refreshClassList(params Classroom[] classList)
        {
            listBoxClassList.Items.Clear();
            int index;
            for (index = 0; index < 10; index++)
            {
                if (classList[index] != null)
                    listBoxClassList.Items.Add(classList[index].ClassName);
            }
            if(classList[9]==null)
                listBoxClassList.Items.Add("添加新班级");
        }

        /// <summary>
        /// 刷新学生列表
        /// </summary>
        /// <param name="targetClass">目标班级对象</param>
        void refreshStudentList(Classroom targetClass)
        {
            listBoxStuList.Items.Clear();
            if (targetClass.StudentNum <= 0) ;
            else
            {
                int index;
                for (index = 1; targetClass.getStudent(index) != null; index++)
                {
                        listBoxStuList.Items.Add(targetClass.getStudent(index).NAME);
                }
            }
            if(targetClass.StudentNum<Classroom.maxNum)
                listBoxStuList.Items.Add("添加新学生");
        }

        void showStudentInfo(Student stu)
        {
            if (stu != null)
            {
                textBoxName.Text = stu.NAME;
                textBoxNum.Text = stu.NUM;
                textBoxClass.Text = stu.MyClass.ClassName;

                textBoxChinese.Text = Convert.ToString(stu.CHINESE);
                textBoxMath.Text = Convert.ToString(stu.MATH);
                textBoxEnglish.Text = Convert.ToString(stu.ENGLISH);

                textBoxAverage.Text = Convert.ToString((stu.ENGLISH + stu.MATH + stu.CHINESE) / 3);
                textBoxTotal.Text = Convert.ToString(stu.ENGLISH + stu.MATH + stu.CHINESE);
            }
        }

        void showSortMode()
        {
            comboBoxSortMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSortMode.Items.Add("按学号排序");
            comboBoxSortMode.Items.Add("按总分排序");
            comboBoxSortMode.Items.Add("按数学排序");
            comboBoxSortMode.Items.Add("按语文排序");
            comboBoxSortMode.Items.Add("按英语排序");
        }

        void enableReadOnly(bool value)
        {
            textBoxName.ReadOnly = value;
            textBoxNum.ReadOnly = value;
            textBoxClass.ReadOnly = true;

            textBoxChinese.ReadOnly = value;
            textBoxMath.ReadOnly = value;
            textBoxEnglish.ReadOnly = value;

            textBoxAverage.ReadOnly = true;
            textBoxTotal.ReadOnly = true;
        }

        private void checkBoxChangeable_CheckedChanged(object sender, EventArgs e)
        {
            if (studentInUse != null)
            {
                if (checkBoxChangeable.Checked == true)
                {
                    enableReadOnly(false);
                    checkBoxChangeable.Visible = false;
                    buttonSearch.Text = "完成";
                    buttonSearch.Enabled = false;
                }
                else
                {

                    enableReadOnly(true);
                    buttonSearch.Text = "删除";
                }
            }
            else
            {
                checkBoxChangeable.Checked = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            switch (buttonSearch.Text)
            {
                case "删除":
                    {
                        if (studentInUse != null)
                        {
                            studentInUse.MyClass.removeStudent(studentInUse.NUM);
                            studentInUse = null;
                        }
                        break;
                    }
                case "完成":
                    {
                try
                {
                    studentInUse.NAME = textBoxName.Text;
                    studentInUse.NUM = textBoxNum.Text;
                    studentInUse.CHINESE = Convert.ToSingle(textBoxChinese.Text);
                    studentInUse.ENGLISH = Convert.ToSingle(textBoxEnglish.Text);
                    studentInUse.MATH = Convert.ToSingle(textBoxEnglish.Text);
                    refreshStudentList(classInUse);
                    enableReadOnly(true);
                    checkBoxChangeable.Visible = true;
                    checkBoxChangeable.Checked = false;
                }
                catch
                {
                    MessageBox.Show("更新失败，有些数据没有更新！");
                }
                finally
                {

                }
                        break;
                    }
                case "添加":
                    {
                        Student stuTmp = studentInUse;
                        try
                        {
                            studentInUse = new Student(textBoxNum.Text, textBoxName.Text, Convert.ToSingle(textBoxChinese.Text), Convert.ToSingle(textBoxMath.Text), Convert.ToSingle(textBoxEnglish.Text), classInUse);
                            refreshStudentList(classInUse);
                            showStudentInfo(studentInUse);
                            enableReadOnly(true);
                            checkBoxChangeable.Visible = true;
                            checkBoxChangeable.Checked = false;

                        }
                        catch
                        {
                            MessageBox.Show("创建失败");
                            studentInUse = stuTmp;
                            listBoxStuList.SelectedIndex = 0;
                        }
                        break;
                    }
                default: break;
            }
        }

        bool inputReadly()
        {

            //MessageBox.Show("name");
            if (!Regex.IsMatch(textBoxName.Text, "[^\x00-\xff]{2,5}") || textBoxName.Text.Length>=8) return false;
            //MessageBox.Show("name2");

            if (!Regex.IsMatch(textBoxNum.Text, "\\d{9}") || textBoxNum.Text.Length != 9) return false;
            //MessageBox.Show("num");
            if (!Regex.IsMatch(textBoxChinese.Text, "^(-?\\d+)(\\.\\d+)?$") || Convert.ToSingle(textBoxChinese.Text) > 100 || Convert.ToSingle(textBoxChinese.Text) < 0) return false;
            //MessageBox.Show("c");

            if (!Regex.IsMatch(textBoxEnglish.Text, "^(-?\\d+)(\\.\\d+)?$") || Convert.ToSingle(textBoxEnglish.Text) > 100 || Convert.ToSingle(textBoxEnglish.Text) < 0) return false;
            //MessageBox.Show("e");

            if (!Regex.IsMatch(textBoxMath.Text, "^(-?\\d+)(\\.\\d+)?$") || Convert.ToSingle(textBoxMath.Text) > 100 || Convert.ToSingle(textBoxMath.Text) < 0) return false;
            //MessageBox.Show("m");
            return true;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (inputReadly())
            {
                buttonSearch.Enabled = true;
            }
            else
            {
                buttonSearch.Enabled = false;
            }
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {
            if (inputReadly())
            {
                buttonSearch.Enabled = true;
            }
            else
            {
                buttonSearch.Enabled = false;
            }
        }

        private void textBoxChinese_TextChanged(object sender, EventArgs e)
        {
            if (inputReadly())
            {
                textBoxTotal.Text = Convert.ToString(Convert.ToSingle(textBoxChinese.Text) + Convert.ToSingle(textBoxEnglish.Text) + Convert.ToSingle(textBoxMath.Text));
                textBoxAverage.Text = Convert.ToString((Convert.ToSingle(textBoxChinese.Text) + Convert.ToSingle(textBoxEnglish.Text) + Convert.ToSingle(textBoxMath.Text))/3);
                buttonSearch.Enabled = true;
            }
            else
            {
                buttonSearch.Enabled = false;
            }
        }

        private void textBoxEnglish_TextChanged(object sender, EventArgs e)
        {
            if (inputReadly())
            {
                textBoxTotal.Text = Convert.ToString(Convert.ToSingle(textBoxChinese.Text) + Convert.ToSingle(textBoxEnglish.Text) + Convert.ToSingle(textBoxMath.Text));
                textBoxAverage.Text = Convert.ToString((Convert.ToSingle(textBoxChinese.Text) + Convert.ToSingle(textBoxEnglish.Text) + Convert.ToSingle(textBoxMath.Text)) / 3);
                buttonSearch.Enabled = true;
            }
            else
            {
                buttonSearch.Enabled = false;
            }
        }

        private void textBoxMath_TextChanged(object sender, EventArgs e)
        {
            if (inputReadly())
            {
                textBoxTotal.Text = Convert.ToString(Convert.ToSingle(textBoxChinese.Text) + Convert.ToSingle(textBoxEnglish.Text) + Convert.ToSingle(textBoxMath.Text));
                textBoxAverage.Text = Convert.ToString((Convert.ToSingle(textBoxChinese.Text) + Convert.ToSingle(textBoxEnglish.Text) + Convert.ToSingle(textBoxMath.Text)) / 3);
                buttonSearch.Enabled = true;
            }
            else
            {
                buttonSearch.Enabled = false;
            }
        }

        private void textBoxClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSortMode_TextChanged(object sender, EventArgs e)
        {
            switch (comboBoxSortMode.Text)
            {
                case "按学号排序": 
                    {
                        if (classInUse != null)
                        {
                            classInUse.sortByNum();
                            refreshStudentList(classInUse);
                        }

                        break;
                    }
                case "按总分排序":
                    {
                        if (classInUse != null)
                        {
                            classInUse.sortByTotal();
                            refreshStudentList(classInUse);
                        }
                        break;
                    }
                case "按数学排序":
                    {
                        if (classInUse != null)
                        {
                            classInUse.sortByMath();
                            refreshStudentList(classInUse);
                        }
                        break;
                    }
                case "按语文排序":
                    {
                        if (classInUse != null)
                        {
                            classInUse.sortByChinese();
                            refreshStudentList(classInUse);
                        }
                        break;
                    }
                case "按英语排序":
                    {
                        if (classInUse != null)
                        {
                            classInUse.sortByEnglis();
                            refreshStudentList(classInUse);
                        }
                        break;
                    }
                default:break;
            }
            refreshStudentList(classInUse);
        }

        private void listBoxClassList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxClassList.SelectedItem.ToString() == "添加新班级")
            {

            }
            else
            {
                classInUse = classList[listBoxClassList.SelectedIndex];
                refreshStudentList(classInUse);
            }
        }

        private void listBoxStuList_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void listBoxStuList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxStuList.SelectedItem.ToString() == "添加新学生")
            {
                checkBoxChangeable.Checked = true;
                buttonSearch.Text = "添加";
                enableReadOnly(false);
                checkBoxChangeable.Visible = false;
                {
                    textBoxName.Text = "";
                    textBoxNum.Text = "";
                    textBoxClass.Text = classInUse.ClassName;

                    textBoxChinese.Text = "0";
                    textBoxMath.Text = "0";
                    textBoxEnglish.Text = "0";
                    textBoxAverage.Text = "0";
                    textBoxTotal.Text = "0";
                }
            }
            else
            {
                enableReadOnly(true);
                checkBoxChangeable.Checked = false;
                checkBoxChangeable.Visible = true;
                buttonSearch.Text = "删除";
                int index;
                studentInUse = classInUse.getStudent(listBoxStuList.SelectedIndex + 1);
                index = listBoxStuList.SelectedIndex;
                showStudentInfo(studentInUse);
                listBoxStuList.SelectedIndex = index;
            }

        }
    }
}
