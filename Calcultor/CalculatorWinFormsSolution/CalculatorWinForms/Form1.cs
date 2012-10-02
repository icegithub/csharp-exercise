using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculatorWinForms
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        bool bOperate = false;
        OperationObjects oper;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 0-9 和 . 的按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button0_Click(object sender, EventArgs e)
        {
            if (bOperate)
            {
                txtShow.Text = "";
                bOperate = false;
            }

            string number = ((Button)sender).Text;

            txtShow.Text = OperationObjects.checkNumberInput(txtShow.Text, number);

        }

        /// <summary>
        /// C 清除按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtShow.Text = "";
        }

        /// <summary>
        /// + - * / 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                oper = OperationFactory.createOperate(((Button)sender).Text);

                oper.NumberA = Convert.ToDouble(txtShow.Text);

                bOperate = true;
            }
        }

        /// <summary>
        /// =、sqr、sqrt、+/- 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                if (((Button)sender).Text != "=")
                {
                    oper = OperationFactory.createOperate(((Button)sender).Text);
                }

                oper.NumberB = Convert.ToDouble(txtShow.Text);

                txtShow.Text = oper.GetResult().ToString();
                bOperate = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
