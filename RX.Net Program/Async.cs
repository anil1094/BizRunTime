using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;


namespace IndexerProg.RX.Net_Program
{
    class Async
    {
            static void Main(string[] args)
            {
                var subject = new AsyncSubject<string>();
                subject.OnNext("a");
                subject.OnNext("b");
                subject.OnNext("c");
               subject.Subscribe(Console.WriteLine);
               Console.ReadKey();
            }

    }

       
    }

