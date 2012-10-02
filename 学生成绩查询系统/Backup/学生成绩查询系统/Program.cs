using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace 学生成绩查询系统
{
    public class Stusent
    {
        public string id;
        public string name;
        public string Class;

        public int chinese;
        public int math;
        public int english;
        public int all;
    }
    public class StudentList
    {
        public Stusent[] student;
        public int i;//用于记录学生人数

        public StudentList()
        {
            student = new Stusent[50];
            i = 0;
        }
        
        public int QueryALL(string Id,string Name,string Class,
            /*float chinese,float math,float english*/
         int chinese, int math, int english)
        {
            
            if (i >= 0)
            {
                student[i].id = Id ;
                student[i].name = Name ;
                student[i].Class = Class ;
                student[i].chinese = chinese;
                student[i].math = math;
                student[i].english = english;
                student[i].all = chinese + math + english;
                i++;
                MessageBox.Show("Success!");
            }
            else
                MessageBox.Show("Error!");
            return student[i-1].all;
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
