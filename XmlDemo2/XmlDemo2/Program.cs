using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Data;

namespace XmlDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();
            //转换一个XML文件(本地\网络均可)为一个DataSet#region 转换一个XML文件(本地\网络均可)为一个DataSet
            //http://news.baidu.com/n?cmd=1&class=sportnews&tn=rss
            //F:\study\001CSharp_Study\002Source\XmlDesign\XmlDesign\Save_Plan.xml
            ds = XmlDatasetConvert.ConvertXMLFileToDataSet(@"product1.xml");
            Console.WriteLine("DataSet name is\"{0}\",include{1}table", ds.DataSetName, ds.Tables.Count);
            foreach(DataTable dt in ds.Tables)
            {
                PrintTableName(dt.TableName);
            };
            //#endregion

            //构造一个DataSet,并转换为XML字符串#region 构造一个DataSet,并转换为XML字符串
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            dt1.TableName = "test";
            dt1.Columns.Add("id");
            dt1.Columns.Add("name");
            dt1.Rows.Add("i001", "hekui");
            dt1.Rows.Add("i002", "liyang");
            DataTable dt2 = new DataTable();
            dt2.TableName = "test1";
            dt2.Columns.Add("bookid");
            dt2.Columns.Add("bookname");
            dt2.Rows.Add("b001", "book1");
            dt2.Rows.Add("b002", "book2");
            ds1.Tables.Add(dt1);
            ds1.Tables.Add(dt2);
            ds1.DataSetName = "Demo";
            string xmlOut = XmlDatasetConvert.ConvertDataSetToXML(ds1);
            //#endregion
            //转换一个XML字符串为一个DataSet#region 转换一个XML字符串为一个DataSet
            DataSet ds2 = new DataSet();
            ds2 = XmlDatasetConvert.ConvertXMLToDataSet(xmlOut);
            Console.WriteLine("DataSet name is\"{0}\",include{1}table", ds2.DataSetName, ds2.Tables.Count);
            foreach (DataTable dt in ds2.Tables)
            {
                PrintTableName(dt.TableName);
            };
            //#endregion
            //转换一个Dataset为一个XML文件#region 转换一个Dataset为一个XML文件
            XmlDatasetConvert.ConvertDataSetToXMLFile(ds2, "adadsda1.xml");
            //#endregion
            
            Console.ReadLine();
        }

        private static void PrintTableName(string tableName)
        {
            Console.WriteLine(tableName);
        }
    }
}
