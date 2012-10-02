using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLiteDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    Book book = new Book();

        //    book.ID = 1;

        //    book.BookName = "Book A";

        //    book.Price = 10.0m;

        //    BookDAL.Create(book);
            



        //    book.ID = 2;

        //    book.BookName = "第二本书";

        //    book.Price = 13.0m;

        //    BookDAL.Create(book);



        //    book = BookDAL.GetbyID(2);

        //    //Console.WriteLine(book.ID + " " + book.BookName + " " + book.Price);
        //    listBox1.Items.Add(book.ID + " " + book.BookName + " " + book.Price);



        //    book.Price = 11.1m;

        //    BookDAL.Update(book);



        //    book = BookDAL.GetbyID(2);

        //    //Console.WriteLine(book.ID + " " + book.BookName + " " + book.Price);
        //    listBox1.Items.Add(book.ID + " " + book.BookName + " " + book.Price);

        //    book = BookDAL.GetbyID(1);

        //    //Console.WriteLine(book.ID + " " + book.BookName + " " + book.Price); 
        //    listBox1.Items.Add(book.ID + " " + book.BookName + " " + book.Price);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个数据库文件

            string datasource = "test.db";

            System.Data.SQLite.SQLiteConnection.CreateFile(datasource);

            //连接数据库

            System.Data.SQLite.SQLiteConnection conn =

                new System.Data.SQLite.SQLiteConnection();

            System.Data.SQLite.SQLiteConnectionStringBuilder connstr =

                new System.Data.SQLite.SQLiteConnectionStringBuilder();

            connstr.DataSource = datasource;

            connstr.Password = "admin";//设置密码，SQLite ADO.NET实现了数据库密码保护

            conn.ConnectionString = connstr.ToString();

            conn.Open();

            //创建表

            System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand();

            string sql = "CREATE TABLE test(username varchar(20),password varchar(20))";

            cmd.CommandText = sql;

            cmd.Connection = conn;

            cmd.ExecuteNonQuery();

            //插入数据

            sql = "INSERT INTO test VALUES(’dotnetthink’,'mypassword’)";

            cmd.CommandText = sql;

            cmd.ExecuteNonQuery();

            //取出数据

            sql = "SELECT * FROM test";

            cmd.CommandText = sql;

            System.Data.SQLite.SQLiteDataReader reader = cmd.ExecuteReader();

            StringBuilder sb = new StringBuilder();

            while (reader.Read())
            {

                sb.Append("username:").Append(reader.GetString(0)).Append("\n")

                .Append("password:").Append(reader.GetString(1));

            }

            MessageBox.Show(sb.ToString());
        }
    }
}
