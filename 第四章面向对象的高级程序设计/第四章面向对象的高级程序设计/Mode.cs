using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 第四章面向对象的高级程序设计
{
    //抽象类练习
    public abstract class Shape
    {
        private string m_id;
        public Shape(string id)
        {
            m_id = id;
        }
        public string Id
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        /// <summary>
        /// 定义一个只读的抽象属性，表示形状的面积
        /// </summary>
        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            //return base.ToString();
            return Id + "面积=" + string.Format("{0:F2}", Area);
        }
    }

    public class Square : Shape
    {
        private int m_side;
        public Square(string id, int side)
            : base(id)
        {
            m_side = side;
        }

        public override double Area
        {
            //get { throw new NotImplementedException(); }
            get
            {
                return m_side * m_side;
            }
        }
    }

    //接口练习
    interface IPerson
    {
        string Name { get; set; }
        char Sex { get; set; }

        string Answer();
    }

    interface IStudent 
    {
        string StudentID { get; set; }
        //为何这个接口这里学要这个？？？？？？？
        string Name { get; set; }
        char Sex { get; set; }

        new string Answer();//这里的new是干什么的呢？难道是。。。。
    }

    interface ISchool
    {
        string SchoolName { get; set; }
        string SchoolAddress { get; set; }

        string Answer();
    }

    class Student : IStudent,ISchool
    {
        private string studentID;
        private string name;
        private char sex;
        private string schoolname;
        private string schooladdress;

        //学校及其地址可以不写
        public Student(string studentID, string name, char sex)
        {
            this.studentID = studentID;
            this.name = name;
            this.sex = sex;
            //this.schoolname = "";
            //this.schooladdress = "";
        }

        //必须写学校及其地址
        public Student(string studentID, string name, char sex, string schoolname, string schooladdress)
        {
            this.StudentID = studentID;
            this.name = name;
            this.sex = sex;
            this.schoolname = schoolname;
            this.schooladdress = schooladdress;
        }

        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public char Sex
        {
            get
            {
                return sex;
            }
            set
            {
                sex = value;
            }
        }

        //显示实现学生接口定义的方法(不需要public修饰了，否则将出现重复定义的错误)
        string IStudent.Answer()
        {
            string s = "学号：" + StudentID;
            s += " 姓名：" + Name;
            s += " 性别：" + Sex;
            return s;
        }

        public string SchoolName
        {
            get
            {
                return schoolname;
            }
            set
            {
                schoolname = value;
            }
        }

        public string SchoolAddress
        {
            get
            {
                return schooladdress;
            }
            set
            {
                schooladdress = value;
            }
        }

        //Answer方法之一
        //public string Answer()
        //{
        //    string s = "学号：" + StudentID;
        //    s += " 姓名：" + Name;
        //    s += " 性别：" + Sex;
        //    //s += " 学校：" + SchoolName;
        //    //s += " 学校地址：" + SchoolAddress;
        //    return s;
        //}
        
        //显示实现学校接口定义的方法(不需要public修饰了，否则将出现重复定义的错误)

        string ISchool.Answer()
        {
            string s;
            s = " 学校：" + SchoolName;
            s += " 学校地址：" + SchoolAddress;
            return s;
        }
    }

    
    //class Person:IPerson
    //{
    //    private string name ;
    //    private char sex;
    //    public Person(string oname,char osex)
    //    {
    //        name=oname;
    //        sex=osex;
    //    }
    //    public string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;
    //        }
    //    }

    //    public char Sex
    //    {
    //        get
    //        {
    //            return sex;
    //        }
    //        set
    //        {
    //            sex = value;
    //        }
    //    }
    //}
    //class Student:Person
    //{
    //    int score;
    //    public Student(string oname,char osex,int oscore)
    //        :base(oname,osex)
    //    {
    //        score=oscore;
    //    }
    //}

    //协变和逆变的演示

    public delegate Covariant_Person PointPerson(int i);//声明委托，返回第i人
    public delegate int Position (Covariant_Person s);
    
    public class Covariant_Person
    {
        public string covariant_name;
        public char covariant_sex;

        public Covariant_Person(string name, char sex)
        {
            this.covariant_name = name;
            this.covariant_sex = sex;
        }
    }

    public class Covariant_Student : Covariant_Person
    {
        private string covariant_school;

        public Covariant_Student(string name,char sex,string school)
            :base(name,sex)
        {
            covariant_school=school;
        }
    }
        //若干人的集合
        public class Persons
        {
            private Covariant_Person[] p =new Covariant_Person[5];
            public Covariant_Person this[int i]
            {
                set
                {
                    if (i<0||i>p.Length)                   
                        p[0]=value;
                    else
                        p[i]=value;
                }
            }

            //返回第i个人
            public Covariant_Person getPerson(int i)
            {
                if(i<0||i>p.Length)
                    return p[0];
                else
                    return p[i];
            }

            //返回某个人的位置
            public int getPos(Covariant_Person per)
            {
                int k=-1;
                for(int i=0;i<p.Length;i++)
                {
                    k=i;
                    break;
                }
                return k;
            }            
        }

        //若干学生的集合
        public class Students
        {
            private Covariant_Student[] p =new Covariant_Student[5];
            /// <summary>
            /// 索引器
            /// </summary>
            /// <param name="i"></param>
            /// <returns></returns>
            public Covariant_Student this[int i]
            {
                set
                {
                    if (i<0||i>p.Length)                   
                        p[0]=value;
                    else
                        p[i]=value;
                }
            }

            //返回第i个人
            public Covariant_Student getStudent(int i)
            {
                if(i<0||i>p.Length)
                    return p[0];
                else
                    return p[i];
            }

            //返回某个人的位置
            public int getPos(Covariant_Student per)
            {
                int k=-1;
                for(int i=0;i<p.Length;i++)
                {
                    k=i;
                    break;
                }
                return k;
            }            
        }
    
}
