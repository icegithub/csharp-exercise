using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PinYin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {
            if (textBoxHZ.Text.Length > 0) textBoxPY.Text = HZ2PY.GetPYString(textBoxHZ.Text);
        }
    }
}
