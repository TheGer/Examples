using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example9
{
    class PersonModel:IComparable
    {
        string name, surname, telnumber;

        public PersonModel(string n,string s,string t,int a)
        {
            this.Name = n;
            this.Surname = s;
            this.Telnumber = t;
            this.Age = a;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Telnumber
        {
            get { return telnumber; }
            set { telnumber = value; }
        }
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public int CompareTo(object obj)
        {
            //sort surname by alphabetical order
            PersonModel otherPerson = (PersonModel)obj;
            return this.Surname.CompareTo(otherPerson.Surname);
        }


    }
}
