using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AnySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] b =new int[5]{2,1,5,3,2};
            foreach (int obj in b)
            {
                Console.Write("{0} ", obj);
            }
            Console.WriteLine();
            Array.Sort(b);
            foreach (int obj in b)
            {
                Console.Write("{0} ", obj);
            }
            

            //int a;
            //ArrayList test = new ArrayList();
            //while( (a=Convert.ToInt32(Console.ReadLine())) )
            Sort DataSort=new Sort();
            DataSort.Display();
            //int MyInteger;
            //char test;
            //Console.ReadLine();
            //Console.WriteLine("{0}", (MyInteger = Convert.ToInt32(Console.ReadLine())) );
            //while ((MyInteger = Convert.ToInt32(Console.ReadLine())) != 0)
            //{
                //IntegerSort = new Sort();
                
            //}


            //new了一个ArrayList的对象实例arr
            ArrayList arr = new ArrayList();
            //声明了一个字符串对象str1
            string str1;
            //使用while循环，条件为true
            //条件为true的话，必然循环中有break跳出循环关键字
            while (true)
            {
                //屏幕上输出一行字，请输入一个字符串元素给ArrayList
                Console.WriteLine("Please add a string to ArrayList:");
                //等待用户输入，将输入的值以字符串的方式赋值给str1变量
                str1 = Console.ReadLine();
                //假如我们输入end字符串，执行break语句跳出循环，结束程序
                if (str1 == "end")
                {
                    break;
                }
                //通过Add添加函数将str1的内容添加到ArrayList的实例arr中
                arr.Add(str1);
                Console.WriteLine();
                for (int i = 0; i < arr.Count; i++)
                    //打印arr中的元素
                    Console.Write("{0}  ", arr[i]);
                //打印一个换行符\n
                Console.WriteLine("\n");
                //然后继续循环，继续等待用户输入下一个想要加入arr的字符串元素
                //直到用户输入end字符结束程序
            }

                arr.Sort();
                for (int i = 0; i < arr.Count; i++)
                        //打印arr中的元素
                        Console.Write("{0}  ", arr[i]);
        }
    }
}
