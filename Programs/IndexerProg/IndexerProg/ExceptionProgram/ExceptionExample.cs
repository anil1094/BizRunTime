using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ExceptionProgram
{
    class ExceptionExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int b = int.Parse(Console.ReadLine());
            int c = a / b;
            Console.WriteLine(c);
            Console.WriteLine("end of the code");
            Console.ReadLine();
        }
    }
}
