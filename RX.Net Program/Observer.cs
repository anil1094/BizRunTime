using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace IndexerProg.RX.Net_Program
{
    class Observer : IObserver<int>
    {
        public void OnNext(int value)
        {
            //step 3: write the method that will receive a value
            //form the observable

            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"value received on thread {threadId}: {value}");
        }
        public void OnError(Exception error)
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"Error: reported on thread {threadId}: {error.Message}");
        }
        public void OnCompleted()
        {
            var threadId = Thread.CurrentThread.ManagedThreadId.ToString();
            Console.WriteLine($"observervation completed on thread {threadId}.");
        }
    }
   
}
