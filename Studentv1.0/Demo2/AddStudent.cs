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

            Student iStudent = new Student();

            iStudent.STRID = Convert.ToString(textBoxID.Text);
            iStudent.STRNAME = Convert.ToString(textBoxName.Text);
            iStudent.STRCLASS = Convert.ToString(textBoxClass.Text);

            iStudent.CHINESE = Convert.ToSingle(textBoxChinese.Text);
            iStudent.MATH = Convert.ToSingle(textBoxMath.Text);
            iStudent.ENGLISH = Convert.ToSingle(textBoxEnglish.Text);
            iStudent.ALL = iStudent.CHINESE + iStudent.MATH + iStudent.ENGLISH;
            if (StudentList.AddStudent(iStudent) == 1)
            {
                MessageBox.Show("Your total score:" + Convert.ToString(iStudent.ALL));
            }
            
            //labelAllPoint.Text = Convert.ToString(iStudent.ALL);

            //置空textbox
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxClass.Text = "";
            textBoxChinese.Text = "";
            textBoxMath.Text = "";
            textBoxEnglish.Text = "";

            

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
