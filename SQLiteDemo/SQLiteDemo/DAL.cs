using System;

using System.Collections.Generic;

using System.Text;

using System.Data.SQLite;


namespace SQLiteDemo
{

    public class BookDAL
    {

        public static bool Create(Book book)
        {
            string datasource = "test.db";
            SQLiteConnection.CreateFile(datasource);
            try
            {
                SQLiteConnection conn = new SQLiteConnection();
                SQLiteConnectionStringBuilder connstr = new SQLiteConnectionStringBuilder();
                connstr.DataSource = datasource;
                connstr.Password = "admin";
                conn.ConnectionString = connstr.ToString();
                conn.Open();
                //using (SQLiteConnection conn = new SQLiteConnection("Data Source=test.db3"))
                //{

                    //conn.Open();

                    SQLiteCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "insert into Book values(@ID,@BookName,@Price);";

                    cmd.Parameters.Add(new SQLiteParameter("ID", book.ID));

                    cmd.Parameters.Add(new SQLiteParameter("BookName", book.BookName));

                    cmd.Parameters.Add(new SQLiteParameter("Price", book.Price));

                    int i = cmd.ExecuteNonQuery();

                    return i == 1;

                //}

            }

            catch (Exception ex)
            {

                //Do any logging operation here if necessary

                //return false;
                throw ex;

            }

        }



        public static bool Update(Book book)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=AppData\test.db3"))
                {

                    conn.Open();

                    SQLiteCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "update Book set BookName=@BookName,Price=@Price where ID=@ID;";

                    cmd.Parameters.Add(new SQLiteParameter("ID", book.ID));

                    cmd.Parameters.Add(new SQLiteParameter("BookName", book.BookName));

                    cmd.Parameters.Add(new SQLiteParameter("Price", book.Price));

                    int i = cmd.ExecuteNonQuery();

                    return i == 1;

                }

            }

            catch (Exception)
            {

                //Do any logging operation here if necessary

                return false;

            }

        }



        public static bool Delete(int ID)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=AppData\test.db3"))
                {

                    conn.Open();

                    SQLiteCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "delete from Book where ID=@ID;";

                    cmd.Parameters.Add(new SQLiteParameter("ID", ID));

                    int i = cmd.ExecuteNonQuery();

                    return i == 1;

                }

            }

            catch (Exception)
            {

                //Do any logging operation here if necessary

                return false;

            }

        }



        public static Book GetbyID(int ID)
        {

            try
            {

                using (SQLiteConnection conn = new SQLiteConnection("Data Source=AppData\test.db3"))
                {

                    conn.Open();

                    SQLiteCommand cmd = conn.CreateCommand();

                    cmd.CommandText = "select * from Book where ID=@ID;";

                    cmd.Parameters.Add(new SQLiteParameter("ID", ID));

                    SQLiteDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {

                        Book book = new Book();

                        book.ID = dr.GetInt32(0);

                        book.BookName = dr.GetString(1);

                        book.Price = dr.GetDecimal(2);

                        return book;

                    }

                    else

                        return null;

                }

            }

            catch (Exception)
            {

                //Do any logging operation here if necessary

                return null;

            }

        }

    }

} 
