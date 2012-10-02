using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit6
{
    class EatEvetArg:EventArgs
    {
        private string _address;
        private int _money;

        public string Address
        {
            get{ return _address;}
            set{ _address = value;}
        }
        public int Money
        {
            get { return _money;}
            set { _money = value;}
        }
        public EatEvetArg(string address,int money)
        {
            Address = address;
            Money = money;
        }

        public void TellServer()
        {
            Console.WriteLine("明明：去{0},花￥{1}", Address, Money);
        }

        public void ACK()
        {
            Console.WriteLine("明明：干得漂亮，我们走：）");
        }
    }

    class Master
    {
        public delegate void EatEventHandle(object sender, EatEvetArg e);
        public event EatEventHandle onEatEvent;
        public Master()
        {
            Console.WriteLine("明明：我是明明，我来了。。。。。");
            System.Threading.Thread.Sleep(3000);
        }

        public void Hungry()
        {
            Console.WriteLine("明明：加生，你在哪里，我饿了。");
            System.Threading.Thread.Sleep(3000);
            EatEvetArg e = new EatEvetArg("教工食堂", 100);
            if (onEatEvent != null)
                onEatEvent(this, e);
        }

        //public void TellInfo(EatEvetArg e)
        //{
        //    EatEvetArg e = new EatEvetArg("教工食堂", 100);
        //    Console.WriteLine("明明：去{0},花{1}",e.Address,e.Money);
        //}

        public void CallServent(Server s)
        {
            onEatEvent += new EatEventHandle(s.Servant);
        }
    }

    class Server
    {
        public Server()
        {
            Console.WriteLine("加生：明明，加生我来了。。。。。");
            System.Threading.Thread.Sleep(3000);
        }

        public void Servant(object sender, EatEvetArg e)
        {
            Console.WriteLine("加生：明明想去哪里吃？我马上去安排。");
            System.Threading.Thread.Sleep(4000);
            e.TellServer();
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("加生：明明您想去{0}吃饭,花￥{1}，我这就去安排。请明明稍等。。。。。。。", e.Address, e.Money);
            System.Threading.Thread.Sleep(4000);
            Console.WriteLine("加生：明明，已经安排好，请明明前去。");
			e.ACK();
        }
    }
}
