using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace IndexerProg.RX.Net_Program
{
    class Subscruption
    {
        static void Main(string[] args)
        {
            //var values = new Subject<int>();
            //try
            //{
            //    values.Subscribe(value => Console.WriteLine("1st subscription received {0}", value));
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Won't catch anything here!");
            //}
            //values.OnNext(0);
            ////Exception will be thrown here causing the app to fail.
           // values.OnError(new Exception("Dummy exception"));

             var values = new Subject<int>();
            values.Subscribe(
            value => Console.WriteLine("1st subscription received {0}", value),
            ex => Console.WriteLine("Caught an exception : {0}", ex));
            values.OnNext(0);
            values.OnError(new Exception("Dummy exception"));


            values = new Subject<int>();
            var firstSUbscription = values.Subscribe(value =>
            Console.WriteLine("1st Subscription value received {0}", values));
            var secondSubscription = values.Subscribe(value => 
            Console.WriteLine("2nd Subscription value received {0} ", values));
            values.OnNext(0);
            values.OnNext(1);
            values.OnNext(2);
            values.OnNext(3);
            firstSUbscription.Dispose();
            Console.WriteLine("Dispose of 1st Subscription");
            values.OnNext(4);
            values.OnNext(5);
            Console.ReadLine();
        }
    }
}
