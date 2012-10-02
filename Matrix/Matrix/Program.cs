using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明了一个4乘6的二维数组arr
            int[,] arr = new int[4, 6];
            //这使用了嵌套的循环，对arr赋值
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //arr赋值
                    //把第一个维度加上1乘以10作为它的十位数
                    //j加上1作为arr的个位数
                    arr[i, j] = (i + 1) * 10 + j + 1;
                }
            }
            //将数组打印出来
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("{0}   ", arr[i, j]);
                }
                //打印一行换行
                Console.WriteLine();
            }
        }
    }
}
