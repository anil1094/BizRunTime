using System;
using System.Data.SqlClient;

namespace Joins
{
    class Self
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;

            try
            {
                con = new SqlConnection("Data Source=LAP-AJEET2808\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
                SqlCommand query = new SqlCommand("select e2.name from salary e1, Salary e2 where e1.salary = e2.salary and e1.name ='sai'; ", con);
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