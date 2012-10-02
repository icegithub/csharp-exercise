using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit4
{
    abstract class Shape
    {
        private string _sid;
        public string SID
        {
            get { return _sid; }
            set { _sid = value; }
        }

        public Shape(string sid)
        {
            SID = sid;
        }

        public abstract string Area();
    }

    class Circlie : Shape
    {
        private int r;
        public int R
        {
            get
            {
                if (r <= 0)
                {
                    Console.WriteLine("Error!");
                    return 0;
                }
                else
                    return r;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Error!");
                else
                    r = value;
            }
        }

        public  Circlie(string sid,int r)
            : base(sid)
        {
            R = r;
        }

        public override string Area()
        {
            //throw new NotImplementedException();
            double area = Math.PI * R * R;
            return Convert.ToString(area);
        }
    }

    class Cyliner : Circlie
    {
        private int h;
        public int H
        {
            get
            {
                if (h <= 0)
                {
                    Console.WriteLine("Error!");
                    return 0;
                }
                else
                    return h;
            }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Error!");
                else
                    h = value;
            }
        }

        public Cyliner(string sid, int r, int h)
            : base(sid, r)
        {
            H = h;
        }

        public string Volumn()
        {
            Circlie c = new Circlie(SID, R);
            double volumn = Convert.ToSingle(c.Area()) * H;
            return Convert.ToString(volumn);
        }
    }
}
