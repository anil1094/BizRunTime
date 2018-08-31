using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.TaskParallelProgram
{
    class TaskProgram
    {
        static void Main(string[] args)
        {
            var t1 = new Task(() => DoWork(1, 1000));
            t1.Start();
            var t2 = new Task(() => DoWork(3, 3000));
            t2.Start();
            var t3 = new Task(() => DoWork(4, 5000));
            t3.Start();
            Console.ReadLine();
        }
        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is begining...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed....", id);
            
        }
    }
}
