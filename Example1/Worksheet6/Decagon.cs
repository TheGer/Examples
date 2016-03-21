using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6
{
    class Decagon:Shape
    {
        double[] sides = new double[10];

        public override double getArea()
        {
            return 5 / 2 * Math.Pow(sides[0], 2) * Math.Sqrt(5 + 2 * Math.Sqrt(5));
        }

        public override double getPerimeter()
        {
            return sides[0] * 10;
        }

    }
}
