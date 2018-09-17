using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IndexerProg.ADO
{
    class Program1
    {
        class Program
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
                    SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017')", con);   
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
}

