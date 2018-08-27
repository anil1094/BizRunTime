using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.InheritanceProgram
{
    public class B:A
    {
        public B()
        {
            Console.WriteLine("Constructor_B");
        }
        public void Test2()
        {
            Console.WriteLine("Methods_B");
        }
    }
}
