using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using IndexerProg.IndexerDemo;

namespace IndexerProg.ADO
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
                con = new SqlConnection("Data Source=LAP-AJEET2808\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
                // writing sql query  
                // SqlCommand cm = new SqlCommand("create table Emp(id int not null,name varchar(100), Address varchar(50), City varchar(50))", con);
                //SqlCommand cm = new SqlCommand("insert into Emp(id, name, Address, City)values('101', 'Anil', 'BTM', 'Bangalore')", con);
                //SqlCommand cm = new SqlCommand("insert into Emp(id, name, Address, City)values('102', 'sunil', 'kushinagar', 'gorakhpur')", con);
                // SqlCommand cm = new SqlCommand("insert into Emp(id, name, Address, City)values('103', 'Amit', 'jaynagar', 'Lucknow')", con);
                //  SqlCommand cm = new SqlCommand("insert into Emp(id, name, Address, City)values('104', 'sunil', 'Bodarwar', 'Allahbad')", con);
                SqlCommand cm = new SqlCommand("Select * from Emp", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query 
                SqlDataReader sdr = cm.ExecuteReader();
                while (sdr.Read())
                {
                 
                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["Address"] + " " + sdr["Address"] + " " + sdr["City"]); // Displaying Record  
                }

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
