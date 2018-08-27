using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.IndexerDemo
{
    class TestEmp
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(100, 50000, "amit", "software", "IT", "Bangalore");
            Console.WriteLine("Eno is : " + emp[0]);
            Console.WriteLine("ESalary is  : " + emp[1]);
            Console.WriteLine("Ename is : " + emp[2]);
            Console.WriteLine("EJob is : " + emp[3]);
            Console.WriteLine("EDap is : " + emp[4]);
            Console.WriteLine("ELocation is : " + emp[5]);

            emp[0] = 101;
            emp[4] = "sales";
            emp[5] = "Mumbai";


            Console.WriteLine();
            Console.WriteLine("After modify the data of Employee");
            Console.WriteLine("Eno is : " + emp[0]);
            Console.WriteLine("ESalary is  : " + emp[1]);
            Console.WriteLine("Ename is : " + emp[2]);
            Console.WriteLine("EJob is : " + emp[3]);
            Console.WriteLine("EDap is : " + emp[4]);
            Console.WriteLine("ELOcation is : " + emp[5]);
            Console.ReadLine();
        }
    }
}

