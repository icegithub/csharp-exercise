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
    public partial class AddStudent : Form
    {
        //StudentList iStudentList;
        public AddStudent()
        {
            InitializeComponent();
            //iStudentList = new StudentList();
        }

       

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "")
                MessageBox.Show("Please input ID");
     
            else if (textBoxName.Text == "")
                MessageBox.Show("Please input Name");

            else if (textBoxClass.Text == "")
                MessageBox.Show("Please input Class");

            else if (textBoxChinese.Text == "")
                MessageBox.Show("Please input Chinese");

            else if (textBoxMath.Text == "")
                MessageBox.Show("Please input Math");

            else if (textBoxEnglish.Text == "")
                MessageBox.Show("Please input English");

            else
            {
                Student iStudent = new Student();

                iStudent.STRID = Convert.ToString(textBoxID.Text);
                iStudent.STRNAME = Convert.ToString(textBoxName.Text);
                iStudent.STRCLASS = Convert.ToString(textBoxClass.Text);

                iStudent.CHINESE = Convert.ToSingle(textBoxChinese.Text);
                iStudent.MATH = Convert.ToSingle(textBoxMath.Text);
                iStudent.ENGLISH = Convert.ToSingle(textBoxEnglish.Text);
                iStudent.ALL = iStudent.CHINESE + iStudent.MATH + iStudent.ENGLISH;

                MessageBox.Show("Your total score:" + Convert.ToString(iStudent.ALL));
                //labelAllPoint.Text = Convert.ToString(iStudent.ALL);

                //置空textbox
                textBoxID.Text = "";
                textBoxName.Text = "";
                textBoxClass.Text = "";
                textBoxChinese.Text = "";
                textBoxMath.Text = "";
                textBoxEnglish.Text = "";

                StudentList.AddStudent(iStudent);
            }


        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
