using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.Plomorphism_Program
{
    class OverloadProgram
    {
        public void Test()
        {
            Console.WriteLine("1st Methods");
        }
        public void Test(int i)
        {
            Console.WriteLine("2nd  Methods");
        }
        public void Test(String i)
        {
            Console.WriteLine("3nd Methods");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("4th methods");
        }
        public void Test(String s,int i)
        {
            Console.WriteLine("5th methods");
        }
    }
}
