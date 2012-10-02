using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoTest
{
    class Program
    {
        delegate string MyDelegate();//声明委托
        static void Main(string[] args)
        {
            Helloworld hello = new Helloworld();
            MyDelegate h = new MyDelegate(hello.HelloCN);
            Console.WriteLine(h());
            h = new MyDelegate(hello.HelloEN);
            Console.WriteLine(h());
        }
    }
}
