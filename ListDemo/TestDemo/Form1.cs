using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<object> store = new List<object>();
            store.Add(21);
            foreach (object obj in store)
            {
                label1.Text = Convert.ToString(obj);
                listBox1.Items.Add(obj);
            }
        }
    }
}
