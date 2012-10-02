using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace exper3._8
{
    class Sort
    {
        //public int integer;
        private int length;
        public int LENGTH
        {
            get { return length; }
            set
            {
                if (value<=0)
                {
                    //throw new System.Exception("Error");
                    length = 1;
                    Console.WriteLine("Error");
                    throw (new System.Exception());
                }
                else
                    length = value;
            }
        }
        private int[] integer;
        private float[] Mydecimal;
        private string[] MyString;
        public Sort(int type,int length)
        {
            this.LENGTH = length;
            switch (type)
            {
                case 1:
                    integer = new int[LENGTH];
                    break;
                case 2:
                    Mydecimal = new float[LENGTH];
                    break;
                case 3:
                    MyString = new string[LENGTH];
                    break;
                default:
                    break;
            }
            
            //this.integer = integer;
        }

        public void AddData(int type)
        {
            switch (type)
            {
            case 1:
                for (int i = 0; i < LENGTH; i++)
                {
                Console.WriteLine("Please input the Integer:");
                int InputInteger = Convert.ToInt32(Console.ReadLine());
                integer[i] = InputInteger;
                 }
                break;
             case 2:
                for (int i = 0; i < LENGTH; i++)
                {
                    Console.WriteLine("Please input the Decimal:");
                    float InputDecimal = Convert.ToSingle(Console.ReadLine());
                    Mydecimal[i] = InputDecimal;
                }
                    break;
             case 3:
                for (int i = 0; i < LENGTH; i++)
                {
                    Console.WriteLine("Please input the String:");
                     string InputDecimal = Console.ReadLine();
                    MyString[i] = InputDecimal;
                }
                    break;
                default:
                    break;
            }            
        }

        /// <summary>
        /// 排序
        /// </summary>
        public void AnySort()
        {
            int i, j,pos;
            for (i = 0; i < LENGTH-1; i++)
            {
                pos = i;
                for (j = i + 1; j < LENGTH; j++)
                    if (integer[pos] > integer[j])
                        pos = j;
                if (pos != i)
                {
                    int temp = integer[pos];
                    integer[pos] = integer[i];
                    integer[i] = temp;
                }
            }
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        public void Display(int type)
        {
            switch (type)
            {
                case 1:
                    foreach (int obj in integer)
                    {
                        Console.Write("{0}  ", obj);
                    }
                    Console.WriteLine();
                    break;
                case 2:
                    foreach (float obj in Mydecimal)
                    {
                        Console.Write("{0}  ", obj);
                    }
                    Console.WriteLine();
                    break;
                case 3:
                    foreach (string  obj in MyString)
                    {
                        Console.Write("{0}  ", obj);
                    }
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }

        public void companysting(string A,string B)
        {
            
        }


    }
}
