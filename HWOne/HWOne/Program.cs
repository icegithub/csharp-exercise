using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HWOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1=new Student("宋加生","090810124",'男',100);
            Person.Answer(s1);
            //Student s2 = new Student(Convert.ToString(Console.Read()), Convert.ToString(Console.Read()), Convert.ToChar(Console.Read()), Convert.ToUInt32(Console.Read()));
            //Person.Answer(s2);
        }
    }
}
