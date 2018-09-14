using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Class1
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
            Console.ReadLine();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=LAP-AJEET2808\\SQLEXPRESS;Initial Catalog=Anil;Integrated Security=True");
                // writing sql query  
                SqlCommand cm = new SqlCommand("create table Employee3(id int not null,Firstname varchar(100),LastName varchar(100),Adress varchar(100),City varchar(100))", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}