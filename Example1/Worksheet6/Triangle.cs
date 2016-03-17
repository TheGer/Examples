using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet6
{
    class Triangle:Shape
    {
        double baseoftriangle;
        double heightoftriangle;

        public override double getArea()
        {
            return baseoftriangle/2*heightoftriangle;
        }

        public override double getPerimeter()
        {
            return baseoftriangle+heightoftriangle + Math.Sqrt(Math.Pow(baseoftriangle,2)+Math.Pow(heightoftriangle,2));
        }

       

    }
}
