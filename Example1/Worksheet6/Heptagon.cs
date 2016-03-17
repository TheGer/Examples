using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6
{
    class Heptagon:Shape
    {
        double[] sides = new double[7];

        public override double getArea()
        {
            return 7 / 4 * Math.Pow(sides[0], 2) * 1 / Math.Tan(180 / 7);
        }

        public override double getPerimeter()
        {
            return sides[0] * 7;
        }

    }
}
