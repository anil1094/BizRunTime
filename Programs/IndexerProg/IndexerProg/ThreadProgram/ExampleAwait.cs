using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.ThreadProgram
{
    class ExampleAwait
    {
        static void Main(string[] args)
        {
            MethodAsync();

            //Console.WriteLine("before read line");
            Console.ReadLine();
        }
        public static async void MethodAsync()
        {
            //Task.Run(new Action(LongTask));
            var t1 = Task.Run(new Action(Print1));
            var t2 = Task.Run(new Action(Print2));
            await t1;
            await t2;
            Console.WriteLine("new Thread");
        }
        public static void Print1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("P1 - " + i);
                Thread.Sleep(100);
            }
        }
        public static void Print2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("P2 - " + i);
                Thread.Sleep(100);
            }
        }
        //public static void MAsync()
        //{
        //    //Console.WriteLine("in dependent work");
        //    MethodAsync();
        //    Console.WriteLine("Main thread");
        //}
    }
}
