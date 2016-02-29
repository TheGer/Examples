using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet4
{
    class Computer
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

        public int CompareTo(Computer other)
        {
            return this.Numberoffaults.CompareTo(other.Numberoffaults);
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

    }
}
