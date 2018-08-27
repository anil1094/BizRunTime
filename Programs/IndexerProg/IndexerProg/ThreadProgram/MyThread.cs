﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.ThreadProgram
{
    class MyThread
    {
        public static void Test1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Test2()
        {
            for (int i = 0; i < 10; i++)
            {
                if(i==5)
                {
                    Console.WriteLine("Thread is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread is going to Wokeup");
                }
                Console.WriteLine(i);
            }
        }
        public static void Test3()
        {
           for(int i=0;i<10;i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }

    }
}
