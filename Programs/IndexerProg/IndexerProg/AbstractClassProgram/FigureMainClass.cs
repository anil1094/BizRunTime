using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.AbstractClassProgram
{
    class FigureMainClass
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(10, 3);
            Circule c1 = new Circule(5);
            Cone c2 = new Cone(3, 8);
            Console.WriteLine("Area of Rectangle is : " + r1.getArea());
            Console.WriteLine("Area of Circule is : " + c1.getArea());
            Console.WriteLine("Area of Cone is : " + c2.getArea());
            Console.ReadLine();

        }
    }
}
