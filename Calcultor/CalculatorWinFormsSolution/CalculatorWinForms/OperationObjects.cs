﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorWinForms
{
    public class OperationObjects
    {
        private double _numberA = 0;
        private double _numberB = 0;

        /// <summary>
        /// 构造器 数字A
        /// </summary>
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        /// <summary>
        /// 构造器 数字B
        /// </summary>
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        /// <summary>
        /// 构造器 virtual类型在计算类中重写该方法
        /// </summary>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

                /// <summary>
        /// 检查输入的字符串是否准确
        /// </summary>
        /// <param name="currentNumber"></param>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static string checkNumberInput(string currentNumber, string inputString)
        {
            string result = "";
            if (inputString == ".")
            {
                if (currentNumber.IndexOf(".") < 0)
                {
                    if (currentNumber.Length == 0)
                        result = "0" + inputString;
                    else
                        result = currentNumber + inputString;
                }
            }
            else if (currentNumber == "0")
            {
                result = inputString;
            }
            else
            {
                result = currentNumber + inputString;
            }

            return result;
        }
    }

    /// <summary>
    /// 加法类
    /// </summary>
    class OperationAdd : OperationObjects
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }

    /// <summary>
    /// 减法类
    /// </summary>
    class OperationSub : OperationObjects
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }

    /// <summary>
    /// 乘法类
    /// </summary>
    class OperationMul : OperationObjects
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 除法类
    /// </summary>
    class OperationDiv : OperationObjects
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("除数不能为0。");
            result = NumberA / NumberB;
            return result;
        }
    }

    /// <summary>
    /// 平方类
    /// </summary>
    class OperationSqr : OperationObjects
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberB * NumberB;
            return result;
        }
    }

    /// <summary>
    /// 平方根类
    /// </summary>
    class OperationSqrt : OperationObjects
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB < 0)
                throw new Exception("负数不能开平方根。");
            result = Math.Sqrt(NumberB);
            return result;
        }
    }

    /// <summary>
    /// 相反数类
    /// </summary>
    class OperationReverse : OperationObjects
    {
        public override double GetResult()
        {
            double result = 0;
            result = -NumberB;
            return result;
        }
    }
}
