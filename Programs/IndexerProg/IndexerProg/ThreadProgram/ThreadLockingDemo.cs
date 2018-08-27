using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.ThreadProgram
{
    class ThreadLockingDemo
    {
        public void Display()
        {
            lock (this)
            {
                Console.WriteLine("CSharp is an");
                Thread.Sleep(3000);
                Console.WriteLine("Objecting orientd langauage");
            }
            
        }
        static void Main(string[] args)
        {
            ThreadLockingDemo t = new ThreadLockingDemo();
             Thread t1=new Thread(t.Display);
           Thread t2=new Thread(t.Display);
            Thread t3=new Thread(t.Display);
            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
