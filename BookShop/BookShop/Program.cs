using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {

            BookShopManage b1 = new BookShopManage("Gone with wind", "Margaret Mitchell", 100, 1);
            BookShopManage.DisplayInfo(b1);

            BookShopManage b2 = new BookShopManage();
            BookShopManage.DisplayInfo(b2);
        }
    }
}
