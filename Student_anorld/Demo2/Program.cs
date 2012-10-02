using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Demo2
{
    public class Stusent
    {
        public String id;
        public String name;
        public String Class;
        public float chinese;
        public float math;
        public float english;
        public float all;
        //public int  chinese;
        //public int math;
        //public int  english;
        //public int all;

        //public float ALL
        //{
        //    get
        //    {
        //        return all;
        //    }
        //    set
        //    {
        //        if (math < 0 || chinese < 0 || english < 0)
        //        {
        //            MessageBox.Show("Error");
        //        }
        //        else
        //            all = chinese + math + english;
        //    }
        //}

    }
    

    public class StudentList
    {
        public Stusent[] student;
        public int amount;//用于记录学生人数

        public StudentList()
        {
            student = new Stusent[50];
            amount = 0;
        }

        public int AddStu(Stusent stu)
        {
            if (amount > 50)
            {
                MessageBox.Show("the array is full");
                return 0;
            }
            student[amount] = stu;
            amount++;
            return 1;
        }
    }

    
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            
        }
    }
}
