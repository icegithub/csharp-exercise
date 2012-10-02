using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 实验4_2Windows应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students s = new Students();
            s[0] = new Student("张云翼", '男', "电子科大");
            s[1] = new Student("王海", '男', "成都东软");
            s[2] = new Student("陈若水", '女', "电子科大");
            s[3] = new Student("赵霞", '女', "电子科大");
            s[4] = new Student("梅岭", '女', "电子科大");

            PointPerson point = new PointPerson(s.getStudent);
            listBox1.Items.Clear();
            for (int i = 0; i < 5; i++)
            {
                Person a = point(i);
                listBox1.Items.Add("姓名:"+ a.covariant_name+"\t性别:"+ a.covariant_sex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Persons p = new Persons();
            p[0] = new Person("许珊珊", '女');
            p[1] = new Person("尹佳云",'女');
            p[2] = new Person("周巍",'男');
            p[3] = new Person("杨森",'男');
            p[4] = new Person("刘通",'男');
            Position pos = new Position(p.getPos);
            int k = pos(new Student("周巍",'男',"电子科大"));
            k++;
            listBox1.Items.Clear();
            listBox1.Items.Add("该生是第" + k + "个学生");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
