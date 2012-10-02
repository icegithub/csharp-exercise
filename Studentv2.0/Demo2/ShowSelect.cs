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
    public partial class ShowSelect : Form
    {
        
        public ShowSelect()
        {
            InitializeComponent();
            
            
        }

        //~public ShowSelect()
        //{
        //    Dispose();
        //}

        private void ShowSelect_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            ShowRequireInfo ShowRequireInfoDlg = new ShowRequireInfo();
            ShowRequireInfoDlg.Show();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            checkBox1.CheckState = CheckState.Checked;
            checkBox2.CheckState = CheckState.Checked;
            checkBox3.CheckState = CheckState.Checked;
            checkBox4.CheckState = CheckState.Checked;
            checkBox5.CheckState = CheckState.Checked;
            checkBox6.CheckState = CheckState.Checked;
            checkBox7.CheckState = CheckState.Checked;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            checkBox1.CheckState = CheckState.Unchecked;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox3.CheckState = CheckState.Unchecked;
            checkBox4.CheckState = CheckState.Unchecked;
            checkBox5.CheckState = CheckState.Unchecked;
            checkBox6.CheckState = CheckState.Unchecked;
            checkBox7.CheckState = CheckState.Unchecked;
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        
        //private void groupBox1_Enter(object sender, EventArgs e)
        //{

        //    ShowRequireInfo ShowRequireInfodlg = new ShowRequireInfo();

        //    if (checkBox1.CheckState == CheckState.Checked)
        //        flag[0] = 1;
        //    if (checkBox2.CheckState == CheckState.Checked)
        //        flag[1] = 1;
        //    if (checkBox2.CheckState == CheckState.Checked)
        //        flag[2] = 1;
        //    if (checkBox2.CheckState == CheckState.Checked)
        //        flag[3] = 1;
        //    if (checkBox2.CheckState == CheckState.Checked)
        //        flag[4] = 1;
        //    if (checkBox2.CheckState == CheckState.Checked)
        //        flag[5] = 1;
        //    if (checkBox2.CheckState == CheckState.Checked)
        //        flag[6] = 1;

        //}

    }
}
