using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 学生成绩查询系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string Id, Name, Class;
            int chinese, math, english;
            int all;
            StudentList studentlist = new StudentList();
            Id = Convert.ToString(textBoxID.Text);
            Name = Convert.ToString(textBoxName.Text);
            Class = Convert.ToString(textBoxClass.Text);
            chinese = Convert.ToInt32(textBoxChinese.Text);
            math = Convert.ToInt32(textBoxMath.Text);
            english = Convert.ToInt32(textBoxEnglish.Text);
            all = studentlist.QueryALL(Id, Name, Class, chinese, math, english);
            textBoxAllPoint.Text = Convert.ToString(all);
        }
    }
}
