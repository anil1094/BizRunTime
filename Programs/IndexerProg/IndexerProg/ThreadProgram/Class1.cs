using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.ThreadProgram
{
    class Class1
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main thread");
            Console.ReadLine();
        }
        public static async void Method()
        {
            //  Task.Run(new Action(LongTask));
            await Task.Run(new Action(LongTask));
            Console.WriteLine("new Thread");
        }
        public static void LongTask()
        {
            for(int i=1;i<=10;i++)
            {
                
                
            }
            Thread.Sleep(1000);
        }
    }
}
