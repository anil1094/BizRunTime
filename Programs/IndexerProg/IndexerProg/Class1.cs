using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace IndexerProg
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Console.WriteLine("enter the element");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Print the array elemnt");
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("enter the elemet which you want to remove");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i % n== 0))
                {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.ReadLine();



        }
    }
}

