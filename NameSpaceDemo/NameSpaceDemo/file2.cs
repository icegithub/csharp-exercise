using System;
using System.Collections.Generic;
using System.Text;
using Lfg.Sales;

namespace Lfg.Designs
{
    public class Designer
    {
       public Customer c;
       //public string _name;
       public Designer()
       {
         c=new Customer();
       }
       public string Answer()
       {  
            //Customer c = new Customer("sjs");
            return c.Answer();
            //"Now, I call for Customer:\n\r"+'\n'+
       }

       public void StoreCusName(string name)
       {
           c.StoreName(name);
       }

       public List<object> ShowCusName()
        {
            return c.ShowName();
        }
    }
}
