using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.RX.Net_Program
{
   public class Program1
    {
            static void Main(string[] args)
            {
                var numbers = new MySequenceOfNumbers();
                var observer = new MyConsoleObserver<int>();
                numbers.Subscribe(observer);
                Console.ReadLine();
            }
        }
    }

