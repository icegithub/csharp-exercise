using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using XDICTGRB;//金山词霸组件

namespace WindowsApplication1
{
    public partial class Form1 : Form,IXDictGrabSink
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GrabProxy gp = new GrabProxy();
            gp.GrabInterval = 1;//指抓取时间间隔
            gp.GrabMode = XDictGrabModeEnum.XDictGrabMouse;//设定取词的属性
            gp.GrabEnabled = true;//是否取词的属性
            gp.AdviseGrab(this);
        }
        //接口的实现
        int IXDictGrabSink.QueryWord(string WordString, int lCursorX, int lCursorY, string SentenceString, ref int lLoc, ref int lStart)
        {
            this.textBox1.Text = SentenceString;//鼠标所在语句
            //this.textBox1.Text = SentenceString.Substring(lLoc + 1,1);//鼠标所在字符
            return 1;
        }
    }
}