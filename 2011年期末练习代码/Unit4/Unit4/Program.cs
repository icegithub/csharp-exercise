using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit4
{
    class Program
    {
        static int Main(string[] args)
        {
            Circlie c1 = new Circlie("圆", 1);
            Console.WriteLine(c1.SID + "的面积是：" + c1.Area());
            Cyliner c2 = new Cyliner("圆柱体", 1, 2);
            Console.WriteLine(c2.SID + "的体积是：" + c2.Volumn());
            return 0;
        }
    }
}
