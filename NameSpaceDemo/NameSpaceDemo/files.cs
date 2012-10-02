using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//使用命名空间的练习
namespace Lfg.Sales
{
    public class Customer
    {
        private string _name;
        //private string _telephonenum;
        //private string _age;
        public List<Object> store=new List<Object>();
        public string Name
        {
            get{return _name;}
            set
            {
                if(Regex.IsMatch(value,"[^0-9]"))
                    _name=value;
                else
                   throw(new System.Exception("Please input current name:)"));
            }
        }
        //public string Telephonenum
        //{
        //    get{return _telephonenum;}
        //    set
        //    {
        //        if(Regex.IsMatch(value,"@\\d{8}"))
        //            _telephonenum=value;
        //        else
        //            throw(new System.Exception());
        //    }
        //}
        //public string  Age
        //{
        //    get{return _age;}
        //    set
        //    {
        //        if(Regex.IsMatch(value,"@\\d\\d\\d"))
        //            _age=value;
        //        else
        //            throw(new System.Exception());
        //    }
        //}
        public Customer(/*string name/*',string telephonenum,string age*/)
        {
            //Name=name;
            //Telephonenum=telephonenum;
            //Age=age;
            //List<String> store = new List<String>();
            //store.Add(Name);
         }
        public string Answer()
        {
            //Console.WriteLine("");
            return "I am is a customer\r\n";
        }

        public void StoreName(string name)
        {
            Name = name;
            store.Add(Name);
            //store.Add(Telephonenum);
            //store.Add(Age);
            //store.Add(12);
        }

        public List<Object> ShowName()
        {
            return store;
        }
    }
}
