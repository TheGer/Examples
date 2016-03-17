using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6
{
    class Octagon:Shape
    {
        double[] sides = new double[8];

        public override double getArea()
        {
            return 2 * (1 + Math.Sqrt(2) * Math.Pow(sides[0], 2));
        }

        public override double getPerimeter()
        {
            return sides[0] * 8;
        }

    }
}
