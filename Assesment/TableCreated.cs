using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class TableCreated
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
              
                con = new SqlConnection("Data Source=LAP-AJEET2808\\SQLEXPRESS;Initial Catalog=Anil;Integrated Security=True");
               
                SqlCommand cm = new SqlCommand("create table student1(id int not null,name varchar(100), email varchar(50), join_date date)", con);  
              
                con.Open();
               
                cm.ExecuteNonQuery();
          
                Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
        
            finally
            {
                con.Close();
            }
        }
    }
}