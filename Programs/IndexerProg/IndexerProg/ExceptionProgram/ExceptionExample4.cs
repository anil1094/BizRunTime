using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ExceptionProgram
{
    class ExceptionExample4
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            try
            {
                Console.WriteLine("Before Exception Generated");
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = i;
                    Console.WriteLine("arr[(0)]:,{1}", i, arr[i]);
                }
               
                
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of Bound");
            }
            catch(DivideByZeroException ex)

            {
                Console.WriteLine("can not divided by zero");
            }
            Console.WriteLine("end of the code");
            Console.ReadLine();
        }
    }
}
