using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;

namespace IndexerProg.RX.Net_Program
{
    class Class1
    {
        static void Main(string[] args)
        {
            //step 1:create the observable
            var observable = Observable.Range(5, 8);

            //step 2: Subscribe to the observable

            var subscription = observable.Subscribe(new Observer());

            Console.ReadKey();

            //step 4: Dispose the subscription when you do not
            //want to listen anymore.
            subscription.Dispose();
        }
    }
}
