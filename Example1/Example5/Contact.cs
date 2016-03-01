using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example5
{
    class Contact:IComparable
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        string telnumber;

        public string Telnumber
        {
            get { return telnumber; }
            set { telnumber = value; }
        }

        public Contact(string n,string tnumber)
        {
            name = n;
            telnumber = tnumber;
        }

        public int CompareTo(object obj)
        {
            Contact otherContact = (Contact)obj;
            return this.name.CompareTo(otherContact.name);
        }
    }
}
