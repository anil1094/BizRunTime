using System;
using System.Data.SqlClient;

namespace Joins
{
    class LeftOuter
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("Data Source=LAP-AJEET2808\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
                SqlCommand query = new SqlCommand("select * from studentc left outer join student on emp_ofc.id = emp_pc.sno ", con);
                con.Open();
                SqlDataReader data = query.ExecuteReader();
                int count = data.FieldCount;
                while (data.Read())
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(data[i] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("some thing went wrong:" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}