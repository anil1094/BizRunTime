using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.AbstractClassProgram
{
   abstract class AbsAritmatic
    {
        public  void Add(int a,int b)
        {
            Console.WriteLine("The sum of two number is : " +(a + b));
        }
        public void sub(int a,int b)
        {
            Console.WriteLine("The subtract of Two number is : " + (a - b));
        }
        public abstract void Mul(int a, int b);
        public abstract void Div(int a, int b);
    }
    class ChildClass : AbsAritmatic
    {
        public override void Mul(int a, int b)
        {
            Console.WriteLine("The multiply of Two number is : " +(a * b));
        }
        public override void Div(int a, int b)
        {
            Console.WriteLine("Divide of two number is : " + (a / b));
        }
    }
}
