using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.ThreadProgram
{
    public class Program3
    {
        public static void Test()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart obj = new ThreadStart(Test);  //Using delegate
            //ThreadStart obj1 = Test;   //This is another way
           // ThreadStart onj2 = delegate () { Test(); }; //Anonymous methods
             ThreadStart obj3=() =>Test();
            Thread t = new Thread(obj);
            t.Start();
            Console.ReadLine();
        }
    
    }
}
