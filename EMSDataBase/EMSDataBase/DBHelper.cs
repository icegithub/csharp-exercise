using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace EMSDataBase
{
    class DBHelper
    {
        private DBHelper()
        {
        }

        public static void CreateDatabase(string datasource)
        {
            try
            {
                //Datasource = datasource;
                SQLiteConnection.CreateFile(datasource);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        //Set up the connection
        public static SQLiteConnection Connection(string datasource)
        {
            //连接数据库
            SQLiteConnection connection = new SQLiteConnection();
            SQLiteConnectionStringBuilder connstr = new SQLiteConnectionStringBuilder();
            connstr.DataSource = datasource;
            //connstr.Password = "admin";//设置密码，SQLite ADO.NET实现了数据库密码保护

            //将连接的信息传递给connection
            connection.ConnectionString = connstr.ToString();
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }
            return connection;
        }
        //Set up the connection with the password
        public static SQLiteConnection Connection(string dbname, string pwd)
        {
            string datasource = dbname;
            SQLiteConnection.CreateFile(datasource);
            //连接数据库
            SQLiteConnection connection = new SQLiteConnection();
            SQLiteConnectionStringBuilder connstr = new SQLiteConnectionStringBuilder();
            connstr.DataSource = datasource;
            connstr.Password = pwd;//设置密码，SQLite ADO.NET实现了数据库密码保护

            //将连接的信息传递给connection
            connection.ConnectionString = connstr.ToString();

            if (connection == null)
            {
                connection = new SQLiteConnection();
                connection.ConnectionString = connstr.ToString();
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            else if (connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }

            return connection;
        }

        //Execute Command
        public static int ExecuteCommand(string safeSql, SQLiteConnection connection)
        {
            SQLiteCommand cmd = new SQLiteCommand(safeSql, connection);
            int result = cmd.ExecuteNonQuery();
            return result;
        }

        public static int ExecuteCommand(string sql, SQLiteParameter[] values, SQLiteConnection connection)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }

        public static int GetScalar(string safeSql, SQLiteConnection connection)
        {
            SQLiteCommand cmd = new SQLiteCommand(safeSql, connection);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        public static int GetScalar(SQLiteParameter[] values, SQLiteConnection connection)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Pro_InsertOrder";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(values);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        public static int GetScalar(string sql, SQLiteParameter[] values, SQLiteConnection connection)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddRange(values);
            int result = Convert.ToInt32(cmd.ExecuteScalar());
            return result;
        }

        public static SQLiteDataReader GetReader(string safeSql, SQLiteConnection connection)
        {
            SQLiteCommand cmd = new SQLiteCommand(safeSql, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static SQLiteDataReader GetReader(string sql, SQLiteParameter[] values, SQLiteConnection connection)
        {
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddRange(values);
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public static DataTable GetDataSet(string safeSql, SQLiteConnection connection)
        {
            DataSet ds = new DataSet();
            SQLiteCommand cmd = new SQLiteCommand(safeSql, connection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }

        public static DataTable GetDataSet(string sql, SQLiteParameter[] values, SQLiteConnection connection)
        {
            DataSet ds = new DataSet();
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            cmd.Parameters.AddRange(values);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
