using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculatorBusinessPackage
{
    class Operation
    {
        public static string GetResult(double numberA, double numberB, string operate)
        {
            string result = "";
            double res = 0d;
            switch (operate)
            {
                case "+":
                    res = numberA + numberB;
                    result = res.ToString();
                    break;
                case "-":
                    res = numberA - numberB;
                    result = res.ToString();
                    break;
                case "*":
                    res = numberA * numberB;
                    result = res.ToString();
                    break;
                case "/":
                    if (numberB != 0)
                    {
                        res = numberA / numberB;
                        result = res.ToString();
                    }
                    else
                        result = "除数不能为零";
                    break;
            }
            return result;
        }
    }
}
