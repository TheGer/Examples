using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {


        static void Main(string[] args)
        {
            //creating a string variable
            string myHello = "Hello World";

            string myName = "Gerard Said";
            //therefore, myHello is a VARIABLE of type string


            //this code saves my age
            int age = 34;

            //temperature
            float currentTemperature = 11.65f;
            
            
            //the code below writes hello world in the console
            Console.WriteLine(myHello + "\n " + myName + "\n " + age + "\n "+currentTemperature);

            //ask the user his name
            Console.WriteLine("What is your name?");

            //input the name
            myName = Console.ReadLine();

            Console.WriteLine("What is your age?");

            //if the user types '18', the string is converted to the integer 18
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the current temperature?");

            //once the user enters a float value, it is converted to a float value
            currentTemperature = float.Parse(Console.ReadLine());

            Console.WriteLine(myHello + "\n " + myName + "\n " + age + "\n " + currentTemperature);

            //conditional statements
            if (currentTemperature < 10f)
            {
                Console.WriteLine("It is very cold");
            }

            if (currentTemperature > 30f)
            {
                Console.WriteLine("It is very warm");
            }


            //modify your square area application such that if the area of the square is less 
            //than 100, it will write 'your square is very small'
            //and if the area is greater than 1000 it will write 'your square is very large'

            //finally modify your square area application to choose if you are checking the 
            //area of a square or a rectangle.  If it is a square calculate normally if it is
            //a rectangle you need to input length and breadth and calculate using length * breadth



            //the code below waits for me to press enter
            Console.ReadLine();


        }
    }
}
