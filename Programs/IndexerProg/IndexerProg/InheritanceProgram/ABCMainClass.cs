using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.InheritanceProgram
{
    class ABCMainClass
    {
        static void Main(string[] args)
        {
            C c1 = new C();
            c1.Test1();
            c1.Test2();
            c1.Test3();


            // A a1 = new A();
            //a1.Test1();


            // B b1 = new B();
            //b1.Test1();
            //b1.Test2();

            //A a1; //a1 is the variable of class A
            //B b1 = new B(); b1 is the instance of class B
            //a1 = b1; //a1 is the reference of parent class created by using child classs instance.
            //a1.Test1();



            Console.ReadLine();
        }
    }
}
