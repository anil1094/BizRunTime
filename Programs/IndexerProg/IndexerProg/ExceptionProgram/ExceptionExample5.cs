using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ExceptionProgram
{
    class ExceptionExample5
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 50, 40, 20, 10, 100, 500, 700, 110 };
            int[] arr1 = { 2, 0, 6, 3, 0 };
            for(int i=0;i<arr.Length;i++)
            {
                try
                {
                    Console.WriteLine(arr[i] + " / " + arr1[0] + " is " + arr[i] / arr1[i]);
                }
                catch
                {
                    Console.WriteLine("some exception occur");

                }

            }
            Console.WriteLine();

        }
    }
}
