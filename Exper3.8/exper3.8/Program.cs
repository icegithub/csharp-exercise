using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exper3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int resault = string.Compare("abc", "de");
            Console.WriteLine(resault);
            int length;
            Console.WriteLine("Please input the the number of date you want to input:");
            length = Convert.ToInt32(Console.ReadLine());
            Sort AnySort1 = new Sort(1,length);
            AnySort1.AddData(1);
            AnySort1.Display(1);
            Sort AnySort2 = new Sort(2,length);
            AnySort2.AddData(2);
            AnySort2.Display(2);
            Sort AnySort3 = new Sort(3,length);
            AnySort3.AddData(3);
            AnySort3.Display(3);
            //AnySort.AnySort();
            //AnySort.Display();

        }
    }
}
