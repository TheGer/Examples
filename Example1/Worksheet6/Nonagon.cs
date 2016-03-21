using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6
{
    class Nonagon:Shape
    {
        double[] sides = new double[9];

        public override double getArea()
        {
            return 9 / 4 * Math.Pow(sides[0], 2) * 1 / Math.Tan(180 / 9);
        }

        public override double getPerimeter()
        {
            return sides[0] * 9;
        }

    }
}
