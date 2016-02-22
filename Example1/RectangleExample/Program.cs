using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle myR = new Rectangle(10, 10);
            Console.WriteLine(myR.drawMe());
            Console.ReadLine();
        }
    }
}
