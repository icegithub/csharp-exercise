using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第四章面向对象的高级程序设计
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个边长为5的正方形对象
            Square s = new Square( "正方形",5);
            Console.WriteLine(s.ToString());

            //创建一个学生
            Student[] stu = new Student[4];
            stu[0] = new Student("090810116", "icecream", 'm', "cslg", "HuShan Road 99#");
            Console.WriteLine("学生1\n"+((IStudent)stu[0]).Answer()+((ISchool)stu[0]).Answer());

            stu[1] = new Student("090810124", "sjs", 'm');
            string result = ((IStudent)stu[1]).Answer();
            Console.WriteLine("学生2：\n"+result);


            //测试委托（degelate）
            Students c_s = new Students();
            c_s [0]=new Covariant_Student("张云翼",'男',"电子科大");
            c_s [1]=new Covariant_Student("张云翼",'男',"电子科大");
            c_s [2]=new Covariant_Student("张云翼",'男',"电子科大");
            c_s [3]=new Covariant_Student("张云翼",'男',"电子科大");
            c_s [4]=new Covariant_Student("张云翼",'男',"电子科大");

            PointPerson point = new PointPerson(c_s.getStudent);
            for(int i = 0; i < 5; i++)
            {
                Covariant_Person a = point(i);
                Console.WriteLine("姓名：{0}\t性别：{1}.",a.covariant_name,a.covariant_sex);
            }
        }
    }
}
