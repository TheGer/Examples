using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example7
{
    
    class Program
    {

        

        public static void updateRandomNumbers(List<int> ListOfNumbers)
        {
            Random randomGen = new Random();
            //create a list of 10 random numbers

            ListOfNumbers.Clear();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = randomGen.Next(1, 10);
                ListOfNumbers.Add(randomNumber);
            }
        }

        [STAThread]
        static void Main(string[] args)
        {

            

            //using a List of type int
            List<int> ListOfNumbers = new List<int>();
            //instantiate random number generator
           

            updateRandomNumbers(ListOfNumbers);

           


            RandomNumbersForm form = new RandomNumbersForm(ListOfNumbers);
            Application.Run(form);

            //output
            outputNumbers(ListOfNumbers);
            Console.ReadLine();

            //list method examples

            //sort
            ListOfNumbers.Sort();

            outputNumbers(ListOfNumbers);
            Console.ReadLine();

            //reverse
            ListOfNumbers.Reverse();

            outputNumbers(ListOfNumbers);
            Console.ReadLine();

            //get distinct elements into another list
            List<int> distinctList = ListOfNumbers.Distinct().ToList<int>();

            outputNumbers(distinctList);
            Console.ReadLine();

            //concatenate another list to the first list
            ListOfNumbers.Concat(distinctList);

            outputNumbers(distinctList);
           Console.ReadLine();

           //find a value which is equivalent to the value entered. returns the value
            Console.WriteLine(ListOfNumbers.Find(n => n == 8));
            Console.ReadLine();

            //for multiple values.  returns a list of the values
            outputNumbers(ListOfNumbers.FindAll(n => n == 8));
            Console.ReadLine();

            //gets the index of the value you are searching for
            Console.WriteLine(ListOfNumbers.FindIndex(n => n == 8));
            Console.ReadLine();

            //gets the biggest number
            Console.WriteLine(ListOfNumbers.Max());
            Console.ReadLine();

            //gets the smallest number
            Console.WriteLine(ListOfNumbers.Min());
            Console.ReadLine();


        }

        static void outputNumbers(List<int> theNumbers)
        {
            foreach (int n in theNumbers)
                Console.WriteLine(n);
        }
    }
}
