using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.RX.Net_Program
{
    class SequenceReturn
    {
        static void Main(string[] args)
        {
            var singleValue = Observable.Return<string>("Value");

            //which could have also been simulated with a replay subject

            var subject = new ReplaySubject<string>();
            subject.OnNext("Value");
            subject.OnCompleted();
            singleValue = Observable.Return<string>("Value");
            //Can be reduced to the following
            singleValue = Observable.Return("Value");
            Console.ReadLine();
        }
    }
}
