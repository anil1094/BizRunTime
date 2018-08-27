using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.DelegateProgram
{
    public delegate void delegateRectange(double width, double height);
    class Rectangle
    {
        public void getArea(double width,double height)
        {
            Console.WriteLine("Area of Rectangle is " + width * height);
        }
        public void getParameter(double width,double height)
        {
            Console.WriteLine("Area of Parameter is " + 2 * (width + height));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            //delegateRectange obj = new delegateRectange(rect.getArea);
            delegateRectange obj = rect.getArea;
            obj += rect.getParameter;
            obj(10.4, 5.7);
            Console.WriteLine();
            obj.Invoke(10.5, 23.6);
            Console.ReadLine();
        }
    }
}
