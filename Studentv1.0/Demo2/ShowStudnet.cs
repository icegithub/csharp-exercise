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
    public partial class ShowStudnet : Form
    {
        int k;

        public ShowStudnet(int k)
        {
            InitializeComponent();
            this.k = k;
        }

        private void ShowStudnet_Load(object sender, EventArgs e)
        {
            //StudentList.STU[k] = new Student();
            textBoxID.Text = Convert.ToString(StudentList.STU[k].STRID);
            textBoxName.Text = Convert.ToString(StudentList.STU[k].STRNAME);
            textBoxClass.Text = Convert.ToString(StudentList.STU[k].STRCLASS);
            textBoxChinese.Text = Convert.ToString(StudentList.STU[k].CHINESE);
            textBoxMath.Text = Convert.ToString(StudentList.STU[k].MATH);
            textBoxEnglish.Text = Convert.ToString(StudentList.STU[k].ENGLISH);
            textBoxTotalScore.Text = Convert.ToString(StudentList.STU[k].ALL);
        }
        
    }
}
