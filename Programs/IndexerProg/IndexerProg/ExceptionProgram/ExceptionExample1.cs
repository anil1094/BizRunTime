using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ExceptionProgram
{
    class ExceptionExample1
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a/b;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                
            }
            Console.WriteLine("end of the code");
            Console.ReadLine();
        }
    }
}
