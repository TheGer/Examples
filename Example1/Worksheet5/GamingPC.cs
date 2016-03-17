using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet5
{
    class GamingPC:Computer
    {
        
        public GamingPC(string cname,string status,int faults)
        {
            base.Computername = cname;
            base.Computerstatus = status;
            base.Numberoffaults = faults;

        }


        public override string ToString()
        {
            return "Gaming PC \n"+base.ToString();
        }
    }
}
