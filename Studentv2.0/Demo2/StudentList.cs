using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo2
{
    public class StudentList
    {
        public static Student[] STU = new Student[50];
        public static int i=0;//用于记录学生人数

        //ShowRequireInfo ShowRequireInfoDlg = new ShowRequireInfo();

        //构造函数，完成初始化功能
        //public StudentList()
        //{
        //    student = new Student[50];
        //    i = 0;
        //}
        
        
        /// <summary>
        /// 增加学生信息的方法
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Name"></param>
        /// <param name="Class"></param>
        /// <param name="chinese"></param>
        /// <param name="math"></param>
        /// <param name="english"></param>
        /// <returns></returns>
        public static void AddStudent(Student iStudent)
        {
            //STU[i] = new Student();
            int k;
            if (i >= 0)
            {
                for (k = 0; k < i; k++)
                {
                    if (iStudent.STRID == STU[k].STRID)
                    {
                        MessageBox.Show("This ID Already exists!");
                        break;
                    }
                }
                if (k == i)
                {
                    STU[i] = new Student();
                    STU[i] = iStudent;
                    ++i;
                    MessageBox.Show("Success!");
                }
                else
                    MessageBox.Show("Failing");
                
                
                //MessageBox.Show(Convert.ToString(STU[i-1].ALL));
            }
            else
                MessageBox.Show("Error!");
        }


        ///// <summary>
        ///// 显示所要查询的学生的信息
        ///// </summary>
        ///// <param name="SubName"></param>
        ///// <returns></returns>
        //public static int Search(string SubName)
        //{
        //    //int k = 0;
        //    //for (; k < i+1; k++)
        //    //{
        //    //    string name = STU[k].STRNAME;
        //    //    if (name == SubName)
        //    //    {
        //    //        return k;
        //    //        break;
        //    //    }
        //    //    else
        //    //        continue;
        //    //}
        //    //if (k >= i)
        //    //{
        //    //    return -1;
        //    //}
        //    //else
        //    //    return k;
        //}

        public static int Search(string SubID)
        {
            int k = 0;
            for (; k < i ; k++)
            {
                string ID = STU[k].STRID;
                if (ID == SubID)
                {
                    return k;
                    break;
                }
                else
                    continue;
            }
            if (k >= i)
            {
                return -1;
            }
            else
                return k;
        }

        

        //显示每位同学的总成绩(传值)
        public static Student ShowAllStudent(int k)
        {
            return STU[k];
        }

        /// <summary>
        /// 求全班平均成绩
        /// </summary>
        /// <returns></returns>
        public static float Average()
        {
            float ClaccTotal = 0;
            if (i==0)
            {
                return 0;
            }
            for (int k = 0; k < i; k++)
            {
                ClaccTotal += STU[k].ALL;
            }
            return Convert.ToSingle(ClaccTotal/i);
        }

        /// <summary>
        /// 排序，将全班成绩按照从大到小依次排列
        /// </summary>
        public static int SortByScore()
        {
            if (i == 1)
            {
                return 1;
            }
            else
            {
                for (int k = 0; k < i ; k++)
                {
                    //float MaxScore = STU[k].ALL;
                    //STU[k] = new Student();
                    for (int m = 1; m < i; m++)
                    {
                        if (STU[m].ALL > STU[k].ALL)
                        {
                            //STU[k] = new Student();
                            //float temp;
                            //temp = MaxScore;
                            //MaxScore = STU[m].ALL;
                            //STU[m].ALL = temp;
                            Student stutemp = new Student();
                            stutemp = STU[k];
                            STU[k] = STU[m];
                            STU[m] = stutemp;
                        }
                        else
                            continue;
                    }
                }
                return 2;
            }

            
        }
        /// <summary>
        /// 求语文个分数段的比例
        /// </summary>
        /// <returns></returns>
        public static float[] PercentageOfChinese()
        {
            float[] ChineseSection = new float[6]{0,0,0,0,0,0};
            //float max=0;
            //int pos=0;//用于记录最高语文成绩的位置
            //float ClaccTotal = 0;
            for (int k = 0; k < i; k++)
            {
                if (ChineseSection[5] < STU[k].CHINESE)
                    ChineseSection[5]=STU[k].CHINESE;//记录单科最高分

                if (STU[k].CHINESE >= 90)
                    ChineseSection[0]++;
                else if (STU[k].CHINESE >= 80)
                    ChineseSection[1]++;
                else if (STU[k].CHINESE >= 70)
                    ChineseSection[2]++;
                else if (STU[k].CHINESE >= 60)
                    ChineseSection[3]++;
                else
                    ChineseSection[4]++;
            }
                    //ChineseSection[0] /= i;
                    //ChineseSection[1] /= i;
                    //ChineseSection[2] /= i;
                    //ChineseSection[3] /= i;
                    //ChineseSection[4] /= i;

            return ChineseSection;
        }

        public static float[] PercentageOfMath()
        {
            float[] MathSection = new float[6] { 0, 0, 0, 0, 0, 0 };
            //float ClaccTotal = 0;
            for (int k = 0; k < i; k++)
            {
                if (MathSection[5] < STU[k].MATH)
                    MathSection[5]=STU[k].MATH;
                if (STU[k].CHINESE >= 90)
                    MathSection[0]++;
                else if (STU[k].MATH >= 80)
                    MathSection[1]++;
                else if (STU[k].MATH >= 70)
                    MathSection[2]++;
                else if (STU[k].MATH >= 60)
                    MathSection[3]++;
                else
                    MathSection[4]++;
            }
                    //MathSection[0] /= i;
                    //MathSection[1] /= i;
                    //MathSection[2] /= i;
                    //MathSection[3] /= i;
                    //MathSection[4] /= i;
            return MathSection;
        }

        public static float[] PercentageOfEnglish()
        {
            float[] EnglishSection = new float[6] { 0, 0, 0, 0, 0, 0 };
            //float ClaccTotal = 0;
            for (int k = 0; k < i+1; k++)
            {
                if (EnglishSection[5] < STU[k].ENGLISH)
                    EnglishSection[5]=STU[k].ENGLISH;
                if (STU[k].ENGLISH >= 90)
                    EnglishSection[0]++;
                else if (STU[k].ENGLISH >= 80)
                    EnglishSection[1]++;
                else if (STU[k].ENGLISH >= 70)
                    EnglishSection[2]++;
                else if (STU[k].ENGLISH >= 60)
                    EnglishSection[3]++;
                else
                    EnglishSection[4]++;
            }
                    //EnglishSection[0] /= i;
                    //EnglishSection[1] /= i;
                    //EnglishSection[2] /= i;
                    //EnglishSection[3] /= i;
                    //EnglishSection[4] /= i;
            return EnglishSection;
        }

    }
}
