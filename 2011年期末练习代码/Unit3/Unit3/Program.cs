using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit3
{
    abstract class StaticDemo
    {
        static public int y;
        public static int x;
        public abstract void Answer();

        static StaticDemo()
        {
            x = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            Dictionary<int, string> b = new Dictionary<int, string>();
        }
    }
}
