using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.Plomorphism_Program
{
    class OverloadProgramDemo
    {
        static void Main(string[] args)
        {
            OverloadProgram obj1 = new OverloadProgram();
            obj1.Test();
            obj1.Test(10);
            obj1.Test("anil");
            obj1.Test(10, "sunil");
            obj1.Test("sunil", 15);
            Console.ReadLine();
                
        }
    }
}
