using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.ThreadProgram
{
    class ThreadPriorityDemo
    {
        static long count1, count2;
        public static void IncrementCount1()
        {
            while(true)
            count1 +=1;
        }
        public static void IncrementCount2()
        {
            while(true)
            count2 +=1;
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount1);
            Thread t2 = new Thread(IncrementCount2);
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;
            t1.Start();
            t2.Start();
            Console.WriteLine("Main thread going to Sleep");
            Thread.Sleep(1000);
            Console.WriteLine("Main thread Wokeup");
            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();
            Console.WriteLine("Count1 " + count1);
            Console.WriteLine("Count2 " + count2);
            Console.ReadLine();
        }
    }
}
