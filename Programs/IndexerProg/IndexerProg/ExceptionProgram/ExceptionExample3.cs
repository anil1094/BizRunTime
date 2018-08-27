using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ExceptionProgram
{
    class ExceptionExample3
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = new int[5];
                arr[6] = 5;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            
        }
    }
}
