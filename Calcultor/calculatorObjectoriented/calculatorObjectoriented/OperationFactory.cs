using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculatorObjectoriented
{
    class OperationFactory
    {
        public static Operation creatOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    {
                        oper = new OpertionAdd();
                        break;
                    }
                case "-":
                    {
                        oper = new OpertionSub();
                        break;
                    }
                case "*":
                    {
                        oper = new OpertionMul();
                        break;
                    }
                case "/":
                    {
                        oper = new OpertionDiv();
                        break;
                    }
            }
            return oper;
        }
    }
}
