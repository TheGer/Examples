using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6
{
    class Rectangle:Shape
    {
        double length;
        double breadth;

        public Rectangle()
        {
            length = 0;
            breadth = 0;
        }

        public Rectangle(double l, double b)
        {
            length = l;
            breadth = b;
        }

        public override double getArea()
        {
            return length*breadth;
        }

        public override double getPerimeter()
        {
            return length+breadth * 2;
        }

    }
}
