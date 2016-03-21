using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6
{
    class Square:Shape
    {
        double side;

        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        public Square(double side)
        {
            this.Side = side;
        }

        public override double getArea()
        {
            return side * side;
        }

        public override double getPerimeter()
        {
            return side * 4;
        }

    }
}
