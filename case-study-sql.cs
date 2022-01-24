using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace app2
{
    public class Sql
    {
        SqlConnection conn;
        SqlCommand cmd;
        string query;

        public Sql(SqlConnection connection)
        {
            this.conn = connection;
        }
        public void executeQuery(string query)
        {
            this.query = query;
            if (this.conn.State == ConnectionState.Open)
            {
                this.cmd = new SqlCommand(this.query, this.conn);
                int i = this.cmd.ExecuteNonQuery();
            }

        }
        public void displayDetails(string query)
        {
            this.query = query;
            if (this.conn.State == ConnectionState.Open)
            {
                this.cmd = new SqlCommand(this.query, this.conn);
                SqlDataReader reader = this.cmd.ExecuteReader();
                Console.WriteLine("Customer Details:");
                while (reader.Read())
                {
                    Console.WriteLine("Customer ID: {0} Customer Name: {1} Customer Address: {2}", reader[0], reader[1], reader[2]);
                }
            }
        }
    }
    internal class Program
    {
            static void Main(string[] args)
            {
                SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\91894\Documents\SampleDB.mdf; Integrated Security = True; Connect Timeout = 30");
                conn.Open();
                Sql obj = new Sql(conn);
                try
                {
                    //obj.executeQuery("create table customers(customerid int primary key,customername varchar(20),customersaddress varchar(100))");
                    //obj.executeQuery("insert into customers values(1,'Jason Rough','23 old street')");
                    //obj.executeQuery("insert into customers values(2,'William Right','55 baker street')");
                    //obj.executeQuery("insert into customers values(3,'Edgar Rice Brough','93 walker street')");
                    obj.displayDetails("select * from customers");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    conn.Close();
                }

                Console.ReadKey();
            }
    }
}
