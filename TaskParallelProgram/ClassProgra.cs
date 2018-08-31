using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Drawing;
using System.IO;

namespace IndexerProg.TaskParallelProgram
{
    class ClassProgra
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0,1, 2, 3, 4, 5, 6, 7, 8, 9};
            Parallel.For(0,10,i=>
            {
                Console.WriteLine("i : " + i);
                Thread.Sleep(100);
                Console.ReadLine(); 
            }
            );

        }
    }
}
