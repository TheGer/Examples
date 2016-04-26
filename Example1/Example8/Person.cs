using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example8
{
    class Person:Printable,Shootable,IComparable
    {
        string firstName;
        int age;
        
        
        //constructor 1
        public Person()
        {
            FirstName = "John Doe";
            Age = 0;
        }
        //constructor 2
        public Person(string s,int a)
        {
            FirstName = s;
            Age = a;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }




        public string printMe()
        {
            //return 0;
            return "Person: " + FirstName + " " + LastName;
        }


        public void shootMe()
        {
            LastName += " HAS BEEN SHOT!";
        }

        public int CompareTo(Object otherPerson)
        {
            Person op = (Person) otherPerson;
            return this.age.CompareTo(op.age);
        }
    }
}
