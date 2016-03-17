using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet5
{
   public class Computer:IComparable
    {
        string _computername;

        public string Computername
        {
            get { return _computername; }
            set { _computername = value; }
        }
        string _computerstatus;

        public string Computerstatus
        {
            get { return _computerstatus; }
            set { _computerstatus = value; }
        }
        int _numberoffaults;

        public int Numberoffaults
        {
            get { return _numberoffaults; }
            set { _numberoffaults = value; }
        }

       public Computer()
        {

        }

        public Computer(string cname,string status,int faults)
        {
            Computername = cname;
            Computerstatus = status;
            Numberoffaults = faults;
        }

        public int showNumberOfFaults()
        {
            return Numberoffaults;
        }

       
        public override string ToString()
        {
            string output = "";
            output = "==========================================\n";
            output += "Computer name: " + Computername + "\n";
            output += "Computer status: " + Computerstatus + "\n";
            output += "Number of faults: " + Numberoffaults + "\n";
            output += "==========================================\n";
            return output;
        }


        public int CompareTo(object other)
        {
            Computer referenceToOtherComputer = (Computer)other;
            return this.Numberoffaults.CompareTo(referenceToOtherComputer.Numberoffaults);

        }

        

    }
}
