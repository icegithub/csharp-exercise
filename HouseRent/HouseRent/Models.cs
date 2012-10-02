using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HouseRent
{
    interface Lease
    {
        double Rent { get; set; }
        string StartDay { get; set; }
        string EndDay { get; set; }

        //void Howmuch();
        void Howmuch(int month);
    }

    public class Yearlease : Lease
    {
        double rent;
        string startday;
        string endday;

        public Yearlease(double rent, string startday, string endday)
        {
            this.Rent = rent;
            this.StartDay = startday;
            this.EndDay = endday;
        }

        public double Rent
        {
            get
            {
                return rent;
            }
            set
            {
                if (value <= 0)
                    rent = 0;
                else
                    rent = value;
            }
        }

        public string StartDay
        {
            get
            {
                return startday;
            }
            set
            {
                //Regex r = new Regex("[0 - 9]");
                if (Regex.IsMatch(value, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$"))
                //if (Regex.IsMatch(value, @"[1-9][0-9][0-9][0-9][-]\D"))
                {
                    startday = value;
                    Console.WriteLine("Successful!");
                }
                else
                    Console.WriteLine("Error,End!");
            }
        }

        public string EndDay
        {
            get
            {
                return endday;
            }
            set
            {
                if (Regex.IsMatch(value, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$"))
                {
                    startday = value;
                }
                else
                    Console.WriteLine("Error,End!");
            }
        }

        //public void ExtractYMD(string date, out string year, out string month, out string day)
        public void ExtraYMD(string date)
        {
            string tyear,tmonth, tday;
            int i;
            int flag = 0;
            for (i = 0; i < date.Length; i++)
            {
                char c = date[i];
                if (c == '-')
                {
                    flag++;
                    //year = Convert.ToInt32(date.Substring(0 , i-1));
                    tyear = date.Substring(0, i - 1);
                }
                if (flag == 1 && c == '-')
                {
                    flag++;
                    //month = Convert.ToInt32(date.Substring(i + 1, 2));
                    tmonth = date.Substring(i + 1, 2);
                }
                if (flag == 2 && c == '-')
                {
                    //day = Convert.ToInt32(date.Substring(i + 1, 2));
                    tday = date.Substring(i + 1, 2);
                }
            }
            Console.WriteLine("year={0},month={1},day={2}",tyear, tmonth,tday);
        }

        void Days()
        {

        }

        public void Howmuch(int month)
        {
            string syear, smonth, sday;
            string eyear,emonth,eday;
            //ExtractYMD(startday, out syear, out smonth, out sday);
            //ExtractYMD(endday, out eyear, out emonth, out eday);
            ExtraYMD(startday);
            Console.WriteLine("{0}-{1}-{2}", syear, smonth, sday);
            Console.WriteLine("{0}-{1}-{2}", eyear, emonth, eday);
            //int days = (month + 12 - Howmuch_month) / 12;
            //Console.WriteLine("You have pay ${0} yearrent", Howmuch_month * 100);
        }
    }

    public class Daylease : Lease
    {
        double rent;
        string startday;
        string endday;
        int days;
        char depositsInAdvance;
        public Daylease(char depositsInAdvance, double rent, string startday, string endday, int days)
        {
            this.depositsInAdvance = depositsInAdvance;
            if (this.depositsInAdvance == 'y')
            {
                Console.WriteLine("Ok,Welcome to my hotel:)");
                this.Rent = rent;
                this.StartDay = startday;
                this.EndDay = endday;
                this.Days = days;
            }
            else
            {
                Console.WriteLine("Error!Please pay for it first!");
            }
        }


        public double Rent
        {
            get
            {
                return rent;
            }
            set
            {
                if (value <= 0)
                    rent = 0;
                else
                    rent = value;
            }
        }

        public string StartDay
        {
            get
            {
                return startday;
            }
            set
            {
                //Regex r = new Regex("[0 - 9]");
                if (Regex.IsMatch(value, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$"))
                {
                    startday = value;
                }
                else
                    Console.WriteLine("Error,End!");
            }
        }

        public string EndDay
        {
            get
            {
                return endday;
            }
            set
            {
                if (Regex.IsMatch(value, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$"))
                {
                    startday = value;
                }
                else
                    Console.WriteLine("Error,End!");
            }
        }

        public int Days
        {
            get { return days; }
            set
            {
                if (value <= 0)
                {
                    Console.Write("Please input current day numbers!!");
                    value = 0;
                }
                else
                {
                    days = value;
                }
            }
        }

        public char DepositsInAdvance
        {
            get
            {
                return depositsInAdvance;
            }
            set
            {
                //Regex r = new Regex("[0 - 9]");
                //if (Regex.IsMatch(value,'[y]'))
                if (value == 'y' || value == 'n')
                {
                    depositsInAdvance = value;
                }
                else
                    Console.WriteLine("Please input current choice(y/n)");
            }
        }

        public void Howmuch(int month)
        {
            double howmuch = Days * Rent;
            Console.WriteLine("You will pay ${0} for it", howmuch);
        }
    }
}
