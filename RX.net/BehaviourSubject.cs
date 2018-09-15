using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Subjects;

namespace IndexerProg.RX.Net_Program
{
    class BehaviourSubject
    {
        static void Main(string[] args)
        {
             
                //Need to provide a default value.
                var subject = new BehaviorSubject<string>("a");
                subject.Subscribe(Console.WriteLine);

            //'b' is written to the console, but not 'a'.
            var subject1 = new BehaviorSubject<string>("a");
                subject1.OnNext("b");
                subject1.Subscribe(Console.WriteLine);

            // In this example the values 'b', 'c' & 'd' are all written to the console, but again not 'a'


            var subject2 = new BehaviorSubject<string>("a");
                subject2.OnNext("b");
                subject2.Subscribe(Console.WriteLine);
                subject2.OnNext("c");
                subject2.OnNext("d");

            //Finally in this example, no values will be published as the sequence has completed. Nothing is written to the console.


            var subject3 = new BehaviorSubject<string>("a");
                subject3.OnNext("b");
                subject3.OnNext("c");
                subject3.OnCompleted();
                subject3.Subscribe(Console.WriteLine);
            Console.ReadLine();
            }
        }
    }