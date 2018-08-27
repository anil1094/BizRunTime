using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.ThreadProgram
{
    class JoinThreadDemo
    {
        public static void Test1()
        {
            Console.WriteLine("Thread 1 is starting");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine("Test1 " + i);
            }
            Console.WriteLine("Thread 1 is Exixting");
        }
        public static void Test2()
        {
            Console.WriteLine("Thread 1 is Exixting");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Test2 " + i);
            }
            Console.WriteLine("Thread 2 is Exixting");
        }
        public static void Test3()
        {
            Console.WriteLine("Thread 1 is Exixting");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Test3 " + i);
            }
            Console.WriteLine("Thread 3 is Exixting");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Main thread Start now");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Join();
            t2.Join();
            t3.Join();
            Console.WriteLine("Main thread exixting");
            Console.ReadLine();
        }
    }
}
