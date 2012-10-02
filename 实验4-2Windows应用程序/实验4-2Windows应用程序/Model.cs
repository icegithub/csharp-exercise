using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 实验4_2Windows应用程序
{
    //协变和逆变的演示
    public delegate Person PointPerson(int i);//声明委托，返回第i人
    public delegate int Position(Person s);

    public class Person
    {
        public string covariant_name;
        public char covariant_sex;

        public Person()
        {

        }
        public Person(string name, char sex)
        {
            this.covariant_name = name;
            this.covariant_sex = sex;
        }
    }

    public class Student : Person
    {
        private string covariant_school;

        public Student(string name, char sex, string school)
            : base(name, sex)
        {
            covariant_school = school;
        }
    }
    //若干人的集合
    public class Persons
    {
        private Person[] p = new Person[5];
        public Person this[int i]
        {
            set
            {
                if (i < 0 || i > p.Length)
                    p[0] = value;
                else
                    p[i] = value;
            }
        }

        //返回第i个人
        public Person getPerson(int i)
        {
            if (i < 0 || i > p.Length)
                return p[0];
            else
                return p[i];
        }

        //返回某个人的位置
        public int getPos(Person per)
        {
            int k = -1;
            for (int i = 0; i < p.Length; i++)
            {
                if (per.covariant_name==p[i].covariant_name)
                {
                    k = i;
                    break;
                }
            }
            return k;
        }
    }

    //若干学生的集合
    public class Students
    {
        private Student[] s = new Student[5];
        /// <summary>
        /// 索引器
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Student this[int i]
        {
            set
            {
                if (i < 0 || i > s.Length)
                    s[0] = value;
                else
                    s[i] = value;
            }
        }

        //返回第i个人
        public Student getStudent(int i)
        {
            if (i < 0 || i > s.Length)
                return s[0];
            else
                return s[i];
        }

        //返回某个人的位置
        public int getPos(Student stu)
        {
            int k = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (stu.covariant_name == s[i].covariant_name)
                {
                    k = i;
                    break;
                }
            }
            return k;
        }
    }
}