using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HWOne
{
    class Person
    {
        public string name;
        public string id;
        public char sex;

        public static uint count;

        public Person(string name, string id, char sex)
        {
            count++;
            this.name = name;
            this.id = id;
            this.sex = sex;
        }
        static Person()
        {
            count = 0;
            countMan = 0;
        }

        public static int countMan { get; set; }

        public static void Answer(Person p)
        {
            Console.WriteLine("我是人类，我叫作：{0}，我的ID是：{1}，我的性别是：{2}.",p.name,p.id,p.sex);
        }

        public static void Answer(Student s)
        {
            Console.WriteLine("我是学生，我叫作：{0}，我的ID是：{1}，我的性别是：{2}，我的分数是：{3}", s.name, s.sid, s.sex,s.score);
        }
    }

    class Student:Person
    {
        public string sid;
        public uint score;

        public Student(string sid, string name, char sex, uint score)
            : base(sid, name, sex)
        {
            this.sid=sid;
            this.score=score;
        }        
    }
}
