using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6
{
    class Hexagon:Shape
    {
        double[] sides = new double[6];

        public override double getArea()
        {
            return 3 * Math.Sqrt(3) / 2 * Math.Pow(sides[0], 2);
        }

        public override double getPerimeter()
        {
            return sides[0] * 6;
        }

    }
}
