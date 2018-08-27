using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerProg.AbstractClassProgram
{
     abstract class Figure
    {
        public double width, heigth, radius;
        public const float pi = 3.21f;
       public abstract double getArea();
    }
    class Rectangle : Figure
    {
       public  Rectangle(double width,double height)
        {
            this.width = width;
            this.heigth = height;
        }
        public override double getArea()
        {
            return width * heigth;
        }
    }
    class Circule : Figure
    {
        public Circule(double radius)
        {
            this.radius = radius;
        }
        public override double getArea()
        {
            return pi * radius * radius;
        }
    }
    class Cone : Figure
    {
        public Cone(double radius,double heigh)
        {
            this.radius = radius;
            this.heigth = heigh;
        }
        public override double getArea()
        {
            return pi * radius * (radius+Math.Sqrt(heigth*heigth+radius*radius));
        }
    }
}
