using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Unit6
{
    class Student
    {
        public string _name;
        public char _sex;

        public Student(string name, char sex)
        {
            _name = name;
            _sex = sex;
        }
    }

    class StudentEventArgs : EventArgs
    {
        private Student someone;
        public StudentEventArgs(Student s)
        {
            someone = s;
        }
        public Student student
        {
            get { return someone; }
        }
    }

    class Grades
    {
        private ArrayList list;
        //声明新生报到的委托类型
        public delegate void StuentHandler(Object sender, StudentEventArgs e);

        //声明新生注册事件
        public event StuentHandler onNewStudent;

        public Grades()
        {
            list = new ArrayList();
        }

        public void Add(Student s)
        {
            list.Add(s);
        }

        //注册到学校的花名册，同时发布事件
        public void ProcessRegister()
        {
            Student s;
            for (int i = 0; i < list.Count; i++ )
            {
                s = (Student)list[i];
                //创建事件参数
                StudentEventArgs e = new StudentEventArgs(s);
                if (onNewStudent != null && s != null)
                {
                    onNewStudent(this, e);//触发事件，并发送学生信息
                }
            }
        }
    }

    class School
    {
        private int students;//全校学生人数
        private ArrayList list;
        public School()
        {
            students = 0;
            list = new ArrayList();
        }

        public Student this[int index]
        {
            get
            {
                if (index < 0 || index > list.Count)
                    return (Student)list[0];
                else
                    return (Student)list[index];
            }
        }

        public int Count
        {
            get { return students; }
        }

        private void Add_NeeStudent(Object sender, StudentEventArgs e)
        {
            if (e.student != null)
            {
                students++;
                list.Add(e.student);
            }
        }

        //声明一个订阅新生注册事件的方法
        public void AddStudents(Grades g)
        {
            g.onNewStudent += new Grades.StuentHandler(this.Add_NeeStudent);
        }
    }

}
