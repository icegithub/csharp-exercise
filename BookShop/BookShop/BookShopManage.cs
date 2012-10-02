using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookShop
{
    class BookShopManage
    {
        public uint inventory;//库存量
        public string title;
        public string author;
        public double wholesaleprice;//批发价
        public double retailprice;//零售价

        public static uint CountBook = 0;//统计总的书籍数

        public BookShopManage()
        {
            CountBook++;
        }

        public BookShopManage(string title,string author,double wholesaleprice,uint inventory)
        {
            this.title = title;
            this.author = author;
            this.wholesaleprice = wholesaleprice;
            this.inventory = inventory;
            this.retailprice = wholesaleprice / 0.7;
            CountBook++;
        }

        public static void DisplayInfo(BookShopManage b)
        {
            if (CountBook == 0)
            {
                Console.WriteLine("There is no book information!");
            } 
            else
            {
                Console.WriteLine("Book numbers:{0}", CountBook);
                Console.WriteLine("Title:{0},Author:{1},WholeSale price:{2},Inventory:{3},Retail price:{4}",b.title,b.author,b.wholesaleprice,b.inventory,b.retailprice);
            }
        }
    }
}
