using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.RX.Net_Program
{
    class Corecursion
    {
        static void Main(string[] args)
        {
           IEnumerable<T> Unfold<T>(T seed, Func<T, T> accumulator)
            {
                var nextValue = seed;
                while (true)
                {
                    yield return nextValue;
                    nextValue = accumulator(nextValue);
                }
            }
            var naturalNumbers = Unfold(1, i => i + 1);
            Console.WriteLine("1st 10 Natural numbers");
            foreach (var naturalNumber in naturalNumbers.Take(10))
            {
                Console.WriteLine(naturalNumber);
            }
            Console.ReadLine();

        }
    }
}
