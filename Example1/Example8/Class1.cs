using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    class Class1
    {


          [STAThread]
        public static void main(string[] args)
        {
            Person Kenny = new Person("Kenny", 28);
            Person Gerry = new Person("Gerry", 34);


            Console.WriteLine(Kenny.CompareTo(Gerry));
            Console.ReadLine();
        }
    }
}
