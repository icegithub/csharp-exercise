using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseRent
{
    class Program
    {
        static void Main(string[] args)
        {
            Yearlease customer1 = new Yearlease(100, "2011-09-08", "2011-10-08");
            //customer1.ExtractCharacters("2011-10-10",out );
            customer1.Howmuch(10);

            Daylease customer2 = new Daylease('y', 1000, "2011-05-08", "2011-08-09", 10);
            customer2.Howmuch(1);

            Daylease customer3 = new Daylease('n', 1000, "2011-05-08", "2011-08-09", 10);



        }
    }
}

