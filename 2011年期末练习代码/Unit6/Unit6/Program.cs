using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grades g = new Grades();
            //School school = new School();

            ////学生报到登记
            //Student s = new Student("icecream", 'm');
            //g.Add(s);
            //s = new Student("qooni", 'm');
            //g.Add(s);
            //s = new Student("wujie", 'w');
            //g.Add(s);

            //school.AddStudents(g);
            //g.ProcessRegister();

            //for (int i = 0; i < school.Count; i++)
            //{
            //    Console.WriteLine("Name:{0}\tSex:{1}", school[i]._name, school[i]._sex);
            //}

            Master master = new Master();
            Server server = new Server();

            master.CallServent(server);
            master.Hungry();
			master.Hungry();

            Console.WriteLine("请按任意键退出。。。。");
            Console.ReadKey();
        }
    }
}
