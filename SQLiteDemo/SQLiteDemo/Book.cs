using System;
using System.Collections.Generic;
using System.Text;

namespace SQLiteDemo
{
    public class Book
    {

        private int id;

        private string bookName;

        private decimal price;



        public int ID
        {

            get { return id; }

            set { id = value; }

        }

        public string BookName
        {

            get { return bookName; }

            set { bookName = value; }

        }

        public decimal Price
        {

            get { return price; }

            set { price = value; }

        }

    } 
}
