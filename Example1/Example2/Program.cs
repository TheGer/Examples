using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is an example of different loops
            int countDown = 5;


            //check if you can continue at the beginning
            //this loop can happen 0 or more times
            while(countDown>0)
            {
                Console.WriteLine(countDown);
                countDown--;
            }

            //this can happen 1 or more times
            countDown = 5;

            do
            {
                Console.WriteLine(countDown);
                countDown--;
            } while (countDown > 0);

            
            //the famous for loop
            for (int count = 5; count > 0;count--)
            {
                Console.WriteLine(count);
            }

            int[] myNumbers = {6,2,1,8,9};

            //myNumbers[0] = 6
            foreach (int num in myNumbers)
            {
                Console.WriteLine(num);
            }

            string[] daysOfWeek = { "Monday", "Tuesday", "Thursday" };

            foreach (string dayOfLesson in daysOfWeek)
            {
                Console.WriteLine(dayOfLesson);
            }

            for (int count1 = 0; count1 < 5;count1++ )
            {
                for(int count2=0;count2<=count1;count2++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            int[] junkNumbers = { 5, 6, 32, 3, 1 };

            foreach (int n in junkNumbers)
            {
                Console.WriteLine(n);
            }


            int[] myArrayOfNumbers = new int[5];



            //small to big
            Array.Sort(junkNumbers);

            //big to small
            Array.Reverse(junkNumbers);
           
            foreach (int n in junkNumbers)
            {
                Console.WriteLine(n);
            }


                Console.ReadLine();
            

        }
    }
}
