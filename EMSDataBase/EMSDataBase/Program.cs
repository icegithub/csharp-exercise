using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace EMSDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataSource = "EMS.db";
            DBHelper.CreateDatabase(dataSource);
            SQLiteConnection connnection = DBHelper.Connection(dataSource);
            CreateTableCategory(connnection);
            CreateTableCourse(connnection);
            //Create the table
            //CreateTable(dsCourse, "Course", connnection);
            Console.ReadLine();

            connnection.Close();
        }

        public static void CreateTableCategory(SQLiteConnection connection)
        {
            string sql = "Create Table [Category](CategoryNO int, Category varchar(20))";
            DBHelper.ExecuteCommand(sql, connection);
        }

        public static void CreateTableCourse(SQLiteConnection connection)
        {
            string sql = "Create Table [Course](Cnumber int, Cname varchar(20), Category int, Quality int, ConLearn char(5))";
            DBHelper.ExecuteCommand(sql, connection);
        }

        public static void CreateTable(DataSet ds, string tableName, SQLiteConnection connection)
        {
            List<string> ColumnName = new List<string>();
            ColumnName = GetColumnName(ds, tableName);

            SQLiteCommand command = new SQLiteCommand();
            //string sql = "Create Table " + tableName + "(cname int, cname varchar(20), categoryNO int, quantity int, noConLearn char(5))";
            //string sql = "Create Table [" + tableName + "](cnumber int PRIMARY KEY , cname varchar(20), categoryNO int, quantity int, noConLearn char(5))";
            StringBuilder sql = new StringBuilder();
            sql.Append("Create Table [");
            sql.Append(tableName);
            sql.Append("](");
            //foreach (string cn in ColumnName)
            for (int i = 0; i < ColumnName.Count; i++ )
            {
                sql.Append('"');
                sql.Append(ColumnName[i].ToString());
                //sql.Append(cn);
                sql.Append('"');
                sql.Append(" varchar(20),");
            }
            int index = sql.Length - 1;
            sql.Remove(index, 1);
            sql.Append(")");
            string test = sql.ToString();
            command.CommandText = sql.ToString();
            command.Connection = connection;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                //throw ex;
                Console.WriteLine(ex.ToString());
            }            
        }

        public static void Insert()
        {
            SQLiteCommand cmd = new SQLiteCommand();
            //插入测试数据 
            for (int i = 2; i < 5; i++)
            {
                cmd.CommandText = string.Format("INSERT INTO [test] VALUES ({0}, '杜思波技术讨论区域')", i);
                cmd.ExecuteNonQuery();
            }

            for (int i = 5; i < 10; i++)
            {
                cmd.CommandText = string.Format("INSERT INTO [test] VALUES ({0}, 'English Test')", i);
                cmd.ExecuteNonQuery();
            }
        }


        /// <summary>
        /// get the name of the column from the dataset by the name of the table
        /// </summary>
        /// <param name="ds"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static List<string> GetColumnName(DataSet ds, string tableName)
        {
            List<string> ColumnName = new List<string>();
            //foreach (string cn in ds.Tables[tableName].Columns)
            for (int i = 0; i < ds.Tables[tableName].Columns.Count; i++ )
            {
                ColumnName.Add(ds.Tables[tableName].Columns[i].ToString());
            }
            return ColumnName;
        }


        public void demo()
        {
            DataSet dsCourse = new DataSet();
            // 创建课程表
            DataTable dtCourse = new DataTable("Course");

            dtCourse.Columns.Add("CategoryNO", typeof(string));
            dtCourse.Columns.Add("Cname", typeof(string));
            dtCourse.Columns.Add("Cnumber", typeof(string));
            dtCourse.Columns.Add("Quantity", typeof(int));
            dtCourse.Columns.Add("NoConLearn", typeof(bool));
            dtCourse.Columns["NoConLearn"].DefaultValue = false;

            // 将定义好的表添加到课程DataSet
            dsCourse.Tables.Add(dtCourse);
        }
    }
}
