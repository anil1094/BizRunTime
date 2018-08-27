using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.OOPs_Concepts
{
    interface TestInterface1
    {
        void Add(int a, int b);
    }
    interface TestInterface2
    {
        void sub(int a, int b);
    }
    class Implementationclass : TestInterface1
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
    }
    class TestImplementationClass: Implementationclass
    {
        public void sub(int a,int b)
        {
            Console.WriteLine(a - b);
        }
    }

}
