using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ExceptionProgram
{
    class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                int i = 10;
                int j = 0;
                int c = i / j;
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("finally block will executed");
                Console.ReadLine();
            }
        }
    }
}
