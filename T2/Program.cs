using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Collections;

namespace T2
{
    public class Student
    {
        public const int numLength = 9;
        public const int nameLengthMax = 10;
        public const int nameLengthMin = 4;
        public const Double scoreMax = 100;
        public const Double scoreMin = 0;
        protected String num;
        protected String name;
        protected Double chinese;
        protected Double math;
        protected Double english;
        protected Classroom myClass;
        /// <summary>
        /// 初始化一个学生，抛出异常表示会出现了传入值错误
        /// </summary>
        /// <param name="num">学号，长度为9位数字</param>
        /// <param name="name">姓名</param>
        /// <param name="chinese">语文成绩</param>
        /// <param name="math">数学成绩</param>
        /// <param name="english">英语成绩</param>
        /// <param name="myClass">这个学生归属的班级</param>
        public Student(String num,String name,Double chinese,Double math,Double english,Classroom myClass)
        {
            if (num.Length != numLength) throw (new System.Exception());
            Convert.ToUInt32(num);
            this.num=num;
            
            if(name.Length>nameLengthMax||name.Length<nameLengthMin) throw (new System.Exception());
            this.name=name;

            if(chinese>scoreMax||chinese<scoreMin) throw (new System.Exception());
            this.chinese=chinese;

            if(math>scoreMax||math<scoreMin) throw (new System.Exception());
            this.math=math;
            
            if(english>scoreMax||english<scoreMin) throw (new System.Exception());
            this.english=english;

            if(myClass==null) throw (new System.Exception());
            this.myClass=myClass;

            if (!myClass.addStudent(this))  //将这个学生添加进班级
              throw (new System.InvalidOperationException());

        }

        public String NUM
        {
            get
            {
                return this.num;
            }
            set
            {
                try
                {
                    if (value.Length == numLength)
                    {
                        int.Parse(value);
                        num = value;
                    }
                }
                catch
                {
                }
            }
        }
        public String NAME
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length <= nameLengthMax || value.Length > nameLengthMin)
                {
                    name = value;
                }
                else
                {
                    throw (new System.Exception());
                }
            }
        }
        public Double CHINESE
        {
            get
            {
                return this.chinese;
            }
            set
            {
                if (value <= scoreMax && value >= scoreMin)
                {
                    this.chinese = value;
                }
                else
                {
                    throw (new System.Exception());
                }
            }
        }
        public Double ENGLISH
        {
            get
            {
                return this.english;
            }
            set
            {
                if (value <= scoreMax && value >= scoreMin)
                {
                    this.english = value;
                }
                else
                {
                    throw (new System.Exception());
                }
            }
        }
        public Double MATH
        {
            get
            {
                return this.math;
            }
            set
            {
                if (value <= scoreMax && value >= scoreMin)
                {
                    this.math = value;
                }
                else
                {
                    throw (new System.Exception());
                }
            }
        }

        /// <summary>
        /// 计算并返回学生总成绩
        /// </summary>
        /// <returns>总成绩</returns>
        public Double totalScore()
        {
            return math + chinese + english;
        }
    }
    public class Classroom
    {
        public const int maxNum = 50;
        public const int minNum = 10;
        public const int nameLengthMax = 10;
        public const int nameLengthMin = 4;
        protected String className;
        protected int studentNum;
        private Student[] studList=new Student[50];

        public Classroom(String className)
        {
            if (className.Length > nameLengthMax || className.Length < nameLengthMin)
                throw (new System.Exception());
            else
            {
                this.className = className;
            }
            studentNum=0;
        }
        public String ClassName
        {
            get
            {
                return this.className;
            }
            set
            {
                if(value.Length>=nameLengthMin&&value.Length<=nameLengthMax)
                {
                    className=value;
                }
            }
        }
        public int StudentNum
        {
            get
            {
                return studentNum;
            }
        }

        /// <summary>
        /// 添加一个学生进入班级实例的最后
        /// </summary>
        /// <param name="stu"></param>
        /// <returns></returns>
        public bool addStudent(Student stu)
        {
            int i;
            if(studentNum!=1)
            {
                for (i = 0; i < studentNum;i++ )
                {
                    if (studList[i].NUM == stu.NUM) return false;
                }
            }
            studList[studentNum] = stu;
            studentNum++;
            return true;
        }

        /// <summary>
        /// 删除指定学号的学生
        /// </summary>
        /// <param name="num">要被删除的学号</param>
        /// <returns>"NULL"指这是个空班级,"OK"表示成功删除,"NOT EXIST"表示不存在</returns>
        public String removeStudent(String num)
        {
            if(studentNum==0) return "NULL";
            int index;
            for (index = 0; index < studentNum;index++ )
            {
                if (num == this.studList[index].NUM)
                {
                    this.studList[index] = null;
                    int i;
                    for (i = index; i < studentNum; i++)
                    {
                        studList[i] = studList[i + 1];
                    }
                    return "OK";
                }
            }
            return "NOT EXIST";
        }

        /// <summary>
        /// 通过学号返回其所对应的学生
        /// </summary>
        /// <param name="num">学号</param>
        /// <returns>对应学生的引用，若为null则表示没有这个学生</returns>
        public Student getStudent(String num)
        {
            if (studentNum == 0) return null;
            int index;
            for (index = 0; index < studentNum; index++)
            {
                if (num == this.studList[index].NUM)
                {
                    return studList[index];
                }
            }
            return null;
        }

        /// <summary>
        /// 通过学号所对应的整形值排序班级
        /// </summary>
        /// <returns>排序成功或失败</returns>
        public bool sortByNum()
        {
            if(studentNum==0) return false;
            int i,j;
            Student stuTmp;
            for(i=0;i<studentNum;i++)
            {
                for (j = i; j < studentNum; j++)
                    if (Convert.ToUInt32(studList[j].NUM) > Convert.ToUInt32(studList[i].NUM))
                {
                    stuTmp=studList[i];
                    studList[i]=studList[j];
                    studList[j]=stuTmp;
                }
            }
            return true;
        }

        /// <summary>
        /// 通过数学成绩由高到低排序
        /// </summary>
        /// <returns>返回true表示成功</returns>
        public bool sortByMath()
        {
            if (studentNum == 0) return false;
            int i, j;
            Student stuTmp;
            for (i = 0; i < studentNum; i++)
            {
                for (j = i; j < studentNum; j++)
                    if (studList[j].MATH > studList[i].MATH)
                    {
                        stuTmp = studList[i];
                        studList[i] = studList[j];
                        studList[j] = stuTmp;
                    }
            }
            return true;
        }

        /// <summary>
        /// 通过语文成绩由高到低排序
        /// </summary>
        /// <returns>返回true表示成功</returns>
        public bool sortByChinese()
        {
            if (studentNum == 0) return false;
            int i, j;
            Student stuTmp;
            for (i = 0; i < studentNum; i++)
            {
                for (j = i; j < studentNum; j++)
                    if (studList[j].CHINESE > studList[i].CHINESE)
                    {
                        stuTmp = studList[i];
                        studList[i] = studList[j];
                        studList[j] = stuTmp;
                    }
            }
            return true;
        }

        /// <summary>
        /// 通过英语成绩由高到低排序
        /// </summary>
        /// <returns>返回true表示成功</returns>
        public bool sortByEnglis()
        {
            if (studentNum == 0) return false;
            int i, j;
            Student stuTmp;
            for (i = 0; i < studentNum; i++)
            {
                for (j = i; j < studentNum; j++)
                    if (studList[j].ENGLISH > studList[i].ENGLISH)
                    {
                        stuTmp = studList[i];
                        studList[i] = studList[j];
                        studList[j] = stuTmp;
                    }
            }
            return true;
        }

        /// <summary>
        /// 通过总分由高到低排序
        /// </summary>
        /// <returns>返回true表示成功</returns>
        public bool sortByTotal()
        {
            if (studentNum == 0) return false;
            int i, j;
            Student stuTmp;
            for (i = 0; i < studentNum; i++)
            {
                for (j = i; j < studentNum; j++)
                    if (studList[j].CHINESE + studList[j].ENGLISH + studList[j].MATH > studList[i].CHINESE + studList[i].ENGLISH + studList[i].MATH)
                    {
                        stuTmp = studList[i];
                        studList[i] = studList[j];
                        studList[j] = stuTmp;
                    }
            }
            return true;
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
            Application.Run(new FormMain());
        }
    }
}
