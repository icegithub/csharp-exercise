using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Lfg.Designs;

namespace NameSpaceDemo
{
    public partial class Form1 : Form
    {
        //创建对象
        Designer d=new Designer();

        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //d = new Designer();
            listBox1.Items.Clear();            
            //label1.Text = Designer.Answer();
            listBox1.Items.Add(d.Answer());
            //listBox1.Items.Add(12);
            //List<object> testlist = new List<object>();
            //testlist.Add(1212122112);
            listBox1.Items.Add("I can remember these names:");
            foreach (object obj in d.ShowCusName())
            {
                listBox1.Items.Add(obj);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Store_Click(object sender, EventArgs e)
        {            
            //string name;
            //d = new Designer();
            if (textBox1.Text == "")
                MessageBox.Show("Please Input name :)");
            else
            {
                d.StoreCusName(textBox1.Text);
            }
            textBox1.Clear();
            //return name;
        }
    }
}