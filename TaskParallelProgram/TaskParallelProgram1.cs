using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.TaskParallelProgram
{
    class TaskParallelProgram1
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Factory.StartNew(() => DoWork(1,2000)).ContinueWith((prev)=>DoOtherWork(1,20000));
            Task t2 = Task.Factory.StartNew(() => DoWork(2,3000));
            Task t3 = Task.Factory.StartNew(() => DoWork(3, 4000));
            Console.ReadLine();
        }
        static void DoWork(int id, int sleep)
        {
            Console.WriteLine("Task {0} is begining...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Task {0} is completed....", id);

        }
        static void DoOtherWork(int id, int sleep)
        {
            Console.WriteLine("Other Task {0} is begining...", id);
            Thread.Sleep(sleep);
            Console.WriteLine("Other Task {0} is completed....", id);

        }
    }
}
