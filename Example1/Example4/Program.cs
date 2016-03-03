using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("How many random numbers do you want?");
            int numberOfNumbers = Convert.ToInt32(Console.ReadLine());

            //create a new list of size numberOfNumbers
            List<RandomNumber> allTheNumbers = new List<RandomNumber>();

            //if I input 100 in number of numbers, I should have 100
            //random numbers in the list, because the list is DYNAMIC
            for (int counter = 0; counter < numberOfNumbers;counter++ )
            {
                
                RandomNumber n = new RandomNumber(0, 10,counter);
                
                allTheNumbers.Add(n);
                
  
            }

            allTheNumbers.Sort();

            RandomNumber[] someNumbers = new RandomNumber[4];

            someNumbers[0] = new RandomNumber(0,10,50);
            someNumbers[1] = new RandomNumber(0,10,53);
            someNumbers[2] = new RandomNumber(0,10,54);
            someNumbers[3] = new RandomNumber(0,10,57);
            
            //add 4 values at the same time 
            allTheNumbers.AddRange(someNumbers);

            //output from the List to a fixed size array of the size of the list
            RandomNumber[] outputArray = allTheNumbers.ToArray();

            List<RandomNumber> anotherEmptyList = new List<RandomNumber>();

            anotherEmptyList.AddRange(someNumbers);

            //add the other empty list to all the numbers.  Add the values to the end
           allTheNumbers.Concat(anotherEmptyList);

            

            //remove the first element of the list
            allTheNumbers.RemoveAt(0);

            //remove all the elements in anotheremptylist
            anotherEmptyList = new List<RandomNumber>();
            //small to large numbers
            allTheNumbers.Sort();

            //large to small numbers
            allTheNumbers.Reverse();


            


            //output here
            foreach(RandomNumber r in allTheNumbers)
            {
                Console.WriteLine(r);
            }
            Console.ReadLine();
            //all the different random numbers

          
            foreach (RandomNumber r in allTheNumbers)
            {
                Console.WriteLine(r);
            }

                Console.ReadLine();

        }
    }
}
