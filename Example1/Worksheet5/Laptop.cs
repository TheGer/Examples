using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet5
{
    public class Laptop:Computer,Moveable
    {

        public Laptop(string cname, string status, int faults)
        {
            base.Computername = cname;
            base.Computerstatus = status;
            base.Numberoffaults = faults;

        }


        public override string ToString()
        {
            return "LAPTOP \n"+base.ToString();
        }

        public void move(Classroom c1, Classroom c2)
        {
            c1.Computersinclassroom.Remove(this);
            c2.Computersinclassroom.Add(this);
        }
    }
}
