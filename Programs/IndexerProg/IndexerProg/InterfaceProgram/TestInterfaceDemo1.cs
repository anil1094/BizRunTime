using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.OOPs_Concepts
{
    class TestInterfaceDemo1
    {
        static void Main(string[] args)
        {
            TestImplementationClass obj1 = new TestImplementationClass();

            obj1.Add(10, 20);
            obj1.sub(20,5);
            Console.ReadLine();
        }
    }
}
