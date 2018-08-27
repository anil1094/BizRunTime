using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.OOPs_Concepts
{
    interface interface1
    {
        void test();
    }
    interface interface2
    {
        void test();
    }
    class MultiplyInheritanceTest:interface1,interface2
    {
        public void test()
        {
            Console.WriteLine("Test methods implements in Child class");
        }
        static void Main(string[] args)
        {
            MultiplyInheritanceTest obj1 = new MultiplyInheritanceTest();
            obj1.test();
            Console.ReadLine();
        }
    }
}
