using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AnySort
{
    class Sort
    {
        //public int integer;

        ArrayList ArraySort= new ArrayList();

        public Sort()
        {
            //while (true)
            //{
            //    Console.WriteLine("Please input the data:");
            //    string data;
            //    data = Console.ReadLine();
            //    if (data == "end")
            //    {
            //        break;
            //    }
            //    //Console.Read();
            //    ArraySort.Add(data);
            //}

            //while (true)
            //{
            //    //屏幕上输出一行字，请输入一个字符串元素给ArrayList
            //    Console.WriteLine("Please add a string to ArrayList:");
            //    //等待用户输入，将输入的值以字符串的方式赋值给str1变量
            //    string str1 = Console.ReadLine();
            //    //假如我们输入end字符串，执行break语句跳出循环，结束程序
            //    if (str1 == "end")
            //    {
            //        break;
            //    }
            //    //通过Add添加函数将str1的内容添加到ArrayList的实例arr中
            //    ArraySort.Add(str1);
            //    Console.WriteLine();
            //}
        }

        // public Sort(double MyDecimal)
        //{
        //    ArraySort.Add(MyDecimal);
        //}

        // public Sort(char MyChar)
        //{
        //    ArraySort.Add(MyChar);
        //}
        public static void SortInteger()
        {
            
        }

        /// <summary>
        /// 显示数组中存放的数值
        /// </summary>
        public void Display()
        {
            foreach (int data in ArraySort)
            {
                Console.WriteLine("{0} ", data);  
            }
        }
        string[] a = new string[5];
        //string.

    }
}
