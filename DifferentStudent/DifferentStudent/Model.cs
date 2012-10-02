using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DifferentStudent
{
    public abstract class Student
    {
        public string m_StuName;
        public int m_StuAge;
        public char m_StuSex;
        public string m_StuId;
        public int m_StuGrade;
        public int m_StuClass;
        public string m_StuDuties;

        public Student(int Grade, int Class, string Id, string Name, int Age, char Sex, string Duties)
        {
            m_StuGrade = Grade;
            m_StuClass = Class;
            m_StuId = Id;
            m_StuName = Name;
            m_StuAge = Age;
            m_StuSex = Sex;
            m_StuDuties = Duties;
        }

        public abstract string Answer();

    }

    public class Pupil : Student
    {
        public string m_IsYoungPioneers;
        public static uint count = 0;
        public Pupil(int Grade, int Class, string Id, string Name, int Age, char Sex, string Duties, string YoungPioneers)
            : base(Grade, Class, Id, Name, Age, Sex, Duties)
        {
            m_IsYoungPioneers = YoungPioneers;
            count++;
        }

        public override string Answer()
        {
            //throw new NotImplementedException();
            string basicinfo = "I am pupil\n"+"Grade:" + m_StuGrade + "\tClass:" + m_StuClass + "\tID:" + m_StuId + "\n"
                + "Name:" + m_StuName + "\tSex:" + m_StuSex + "\tAge:" + m_StuAge + "\n"
                + "Duties:" + m_StuDuties;
            string expendinfo = "\nYoungPioneers:" + m_IsYoungPioneers;
            string classcount = "\nNumber Of Class:" + count;
            return basicinfo + expendinfo + classcount;
        }
    }

    public class MiddleSchoolStudent : Student
    {
        public string m_LeagueMember;
        public static uint count = 0;
        public MiddleSchoolStudent(int Grade, int Class, string Id, string Name, int Age, char Sex, string Duties, string LeagueMember)
            : base(Grade, Class, Id, Name, Age, Sex, Duties)
        {
            m_LeagueMember = LeagueMember;
            count++;
        }

        public override string Answer()
        {
            //throw new NotImplementedException();
            string basicinfo = "I am Middle School Student\n" + "Grade:" + m_StuGrade + "Class:" + m_StuClass + "ID:" + m_StuId + "\n"
                + "Name:" + m_StuName + "Sex:" + m_StuSex + "Age:" + m_StuAge + "\n"
                + "Duties:" + m_StuDuties;
            string expendinfo = "LeagueMember:" + m_LeagueMember;
            string classcount = "Number Of Class:" + count;
            return basicinfo + expendinfo + classcount;
        }
    }

    public class MediumVocationalStudent : Student
    {
        public string m_LeagueMember;
        public string m_specialty;
        public static uint count = 0;
        public MediumVocationalStudent(int Grade, int Class, string Id, string Name, int Age, char Sex, string Duties, string LeagueMember, string Specialty)
            : base(Grade, Class, Id, Name, Age, Sex, Duties)
        {
            m_specialty = Specialty;
            count++;
        }

        public override string Answer()
        {
            //throw new NotImplementedException();
            string basicinfo = "I am Medium Vocational Student\n" + "Grade:" + m_StuGrade + "Class:" + m_StuClass + "ID:" + m_StuId + "\n"
                + "Name:" + m_StuName + "Sex:" + m_StuSex + "Age:" + m_StuAge + "\n"
                + "Duties:" + m_StuDuties;
            string expendinfo = "Specialty:" + m_specialty + "\nLeagueMember:" + m_LeagueMember;
            string classcount = "Number Of Class:" + count;
            return basicinfo + expendinfo + classcount;
        }
    }

    public class UniversityStudent : Student
    {
        //public Union Identity;
        public string Identity;
        public string m_specialty;
        public static uint count = 0;
        public UniversityStudent(int Grade, int Class, string Id, string Name, int Age, char Sex, string Duties,  string Specialty)
            : base(Grade, Class, Id, Name, Age, Sex, Duties)
        {
            m_specialty = Specialty;
            count++;
        }

        public override string Answer()
        {
            //throw new NotImplementedException();
            string basicinfo = "I am University Student\n" + "Grade:" + m_StuGrade + "\tClass:" + m_StuClass + "\tID:" + m_StuId + "\n"
                + "Name:" + m_StuName + "\tSex:" + m_StuSex + "\tAge:" + m_StuAge + "\n"
                + "\tDuties:" + m_StuDuties;
            string expendinfo = "Specialty:" + m_specialty ;
            string classcount = "Number Of Class:" + count;
            return basicinfo + expendinfo + classcount;
        }
    }

}
