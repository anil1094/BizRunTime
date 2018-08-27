using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.ThreadProgram
{
    class AsyncAwait1cs
    {
        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1");
                }
            });
        }


        public static async void Method2()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine(" Method 2");
                }
            });
        }

    }
}