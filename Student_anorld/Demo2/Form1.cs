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
    public partial class Form1 : Form
    {
        StudentList studentlist;
        public Form1()
        {
            InitializeComponent();
            studentlist = new StudentList();
            
        }

       
        private void buttonAdd_Click(object sender, EventArgs e)
        { 
            //String Id, Name, Class;
            //float  chinese, math, english;
            //float all;
            Stusent student=new Stusent();
            student.id = Convert.ToString(textBoxID.Text);
            student.name = Convert.ToString(textBoxName.Text);
            student.Class = Convert.ToString(textBoxClass.Text);

            student.chinese = Convert.ToSingle(textBoxChinese.Text);
            student.math = Convert.ToSingle(textBoxMath.Text);
            student.english = Convert.ToSingle(textBoxEnglish.Text);

            student.all = student.chinese + student.english + student.math;
            int i = studentlist.AddStu(student);
            labelAllpoint.Text = Convert.ToString(i);

          }
    }
}
