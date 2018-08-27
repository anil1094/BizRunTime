using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.AbstractClassProgram
{
    class AbsMainClass
    {
        static void Main(string[] args)
        {
            ChildClass c = new ChildClass();
            c.Add(10,20);
            c.Div(10,4);
            c.Mul(10, 4);
            c.sub(10, 7);
            Console.ReadLine();
        }
    }
}
