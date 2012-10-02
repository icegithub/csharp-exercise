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
        public static uint studentNum=0;//用于记录学生人数
        public static float total = 0;//用于记录全班总成绩的总成绩

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
        public static int AddStudent(Student iStudent)
        {
            STU[studentNum] = new Student();
            if (studentNum == 0)
            {
                STU[0] = iStudent;
                studentNum++;
                total += STU[0].ALL;
                MessageBox.Show("Success!");
                return 1;
            }
            else
            {
                int k;
                for (k = 0; k < studentNum; k++)
                {
                    STU[k] = new Student();
                    if (iStudent.STRID == STU[k].STRID)
                    {
                        MessageBox.Show("Already exists!");
                        return 0;
                        //break;
                    }
                    else
                    {
                        STU[studentNum] = iStudent;
                        total += STU[studentNum].ALL;

                        ++studentNum;
                        MessageBox.Show("Success!");
                        return 1;
                    }
                }
                if (k >= studentNum)
                {
                    return 0;
                }
                else
                    return 1;
                
            }

            //    //MessageBox.Show(Convert.ToString(STU[i-1].ALL));
            
            //else
            //    MessageBox.Show("Error!");
        }
    

        /// <summary>
        /// 显示所要查询的学生的信息
        /// </summary>
        /// <param name="SubName"></param>
        /// <returns></returns>
        public static int Search(string SubName)
        {
            int k=0;
            if (studentNum == 0)
            {
                MessageBox.Show("There is no students!");
                return -1;
            }
            else
            {
                for (k = 0; k < studentNum; k++)
                {
                    STU[k] = new Student();
                    string name = STU[k].STRNAME;
                    if (name == SubName)
                    {
                        break;
                    }
                    else
                        continue;
                }

                if (k > studentNum)
                {
                    return -1;
                }
                else
                    return k;
            }
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
            //float ClaccTotal = 0;
            //for (int k = 0; k < i+1; k++)
            //{
            //    ClaccTotal += STU[k].ALL;
            //}
            if (studentNum > 0)
            {
                return Convert.ToSingle(total / studentNum);
            }
            else
                return 0;
            
        }

        /// <summary>
        /// 排序，将全班成绩按照从大到小依次排列
        /// </summary>
        public static int SortByScore()
        {
            Student stutemp = new Student();
            for (int k = 0; k < studentNum+1; k++)
            {
                STU[k] = new Student();
                //float MaxScore = STU[k].ALL;
                for (int m = 1; m < studentNum+1; m++)
                {
                    STU[m] = new Student();
                    if (STU[m].ALL > STU[k].ALL)
                    {                        
                        stutemp = STU[k];
                        STU[k] = STU[m];
                        STU[m] = stutemp;
                    }
                    else
                        continue;
                }
            }
            return 1;
        }
        /// <summary>
        /// 求语文个分数段的比例
        /// </summary>
        /// <returns></returns>
        public static float[] PercentageOfChinese()
        {
            float[] ChineseSection = new float[6]{0,0,0,0,0,0};
            //float ClaccTotal = 0;

            float MaxChinese = STU[0].CHINESE;
            int pos;
            for (int k = 0; k < studentNum; k++)
            {

                if (STU[k].CHINESE > MaxChinese)
                {
                    MaxChinese = STU[k].CHINESE;
                    pos = k;
                }
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
            for (int k = 0; k < studentNum + 1; k++)
            {
                if (studentNum > 0)
                {
                    ChineseSection[0] /= studentNum;
                    ChineseSection[1] /= studentNum;
                    ChineseSection[2] /= studentNum;
                    ChineseSection[3] /= studentNum;
                    ChineseSection[4] /= studentNum;
                }
            }
            return ChineseSection;
        }

        public static float[] PercentageOfMath()
        {
            float[] MathSection = new float[5] { 0, 0, 0, 0, 0 };
            //float ClaccTotal = 0;
            for (int k = 0; k < studentNum; k++)
            {
                if (STU[k].CHINESE >= 90)
                    MathSection[0]++;
                else if (STU[k].CHINESE >= 80)
                    MathSection[1]++;
                else if (STU[k].CHINESE >= 70)
                    MathSection[2]++;
                else if (STU[k].CHINESE >= 60)
                    MathSection[3]++;
                else
                    MathSection[4]++;
            }
            for (int k = 0; k < studentNum + 1; k++)
            {
                if (studentNum > 0)
                {
                    MathSection[0] /= studentNum;
                    MathSection[1] /= studentNum;
                    MathSection[2] /= studentNum;
                    MathSection[3] /= studentNum;
                    MathSection[4] /= studentNum;
                }
            }
            return MathSection;
        }

        public static float[] PercentageOfEnglish()
        {
            float[] EnglishSection = new float[5] { 0, 0, 0, 0, 0 };
            //float ClaccTotal = 0;
            for (int k = 0; k < studentNum+1; k++)
            {
                if (STU[k].CHINESE >= 90)
                    EnglishSection[0]++;
                else if (STU[k].CHINESE >= 80)
                    EnglishSection[1]++;
                else if (STU[k].CHINESE >= 70)
                    EnglishSection[2]++;
                else if (STU[k].CHINESE >= 60)
                    EnglishSection[3]++;
                else
                    EnglishSection[4]++;
            }
            for (int k = 0; k < studentNum+1; k++)
            {
                if (studentNum > 0)
                {
                    EnglishSection[0] /= studentNum;
                    EnglishSection[1] /= studentNum;
                    EnglishSection[2] /= studentNum;
                    EnglishSection[3] /= studentNum;
                    EnglishSection[4] /= studentNum;
                }
            }
            return EnglishSection;
        }

    }
}
