using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.OOPs_Concepts
{
    class TestInterfaceDemo2
    {
        static void Main(string[] args)
        {
            TestInterface obj1 = new TestInterface();
            int multiply = obj1.mul(10, 20);
            int divide = obj1.div(10, 5);
            Console.WriteLine(multiply);
            Console.WriteLine(divide);
            Console.ReadLine();
        }
    }
}
