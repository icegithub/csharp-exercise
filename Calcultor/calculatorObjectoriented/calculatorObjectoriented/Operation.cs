using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculatorObjectoriented
{
    class Operation
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
        /// 构造器 运算结果
        /// </summary>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }

    /// <summary>
    ///  加法类
    /// </summary>
    class OpertionAdd : Operation
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
    class OpertionSub : Operation
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
    class OpertionMul : Operation
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
    class OpertionDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;

            if (NumberB == 0)
            {
                throw new Exception("除数不能为零");
            }

            result = NumberA / NumberB;
            return result;
        }
    }



}
