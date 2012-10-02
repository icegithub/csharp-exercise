using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace monkey
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (int i = 0; i < 10;i++ )
            {
                x = x * 2 + 1;
            }
            Console.WriteLine("The number of Pfirsich is {0}", x);
        }
    }
}
