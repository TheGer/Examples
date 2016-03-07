using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class RandomNumber:IComparable
    {
        //attribute of random number
        int number;

        Random generator;


        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        //create a new random number
        public RandomNumber(int seed)
        {
            //the next random number
            generator = new Random(seed);
            Number = generator.Next();
        }

        //create a new random number between two values
        public RandomNumber(int min,int max,int seed)
        {
            generator = new Random(seed);
            Number = generator.Next(min,max);
        }

        //update the number in the instance
        public void updateNumber(int min,int max)
        {

            Number = generator.Next(min, max);
        }

        public override string ToString()
        {
            return Number.ToString();
        }


        public int CompareTo(object obj)
        {
            RandomNumber otherNumber = (RandomNumber)obj;
           return this.number.CompareTo(otherNumber.number);
        }





        
    }
}
