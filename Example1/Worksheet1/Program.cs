using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet1
{
    class Program
    {

        static void question1()
        {
            //calculate area of triangle
            Console.WriteLine("Enter base of triangle: ");
            float baseOfTriangle = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height of triangle: ");
            float height = float.Parse(Console.ReadLine());

            float area = (baseOfTriangle * 0.5f) * height;

            Console.WriteLine(String.Format("The area of the triangle is {0}", area));
            Console.ReadLine();
        }

        static void question2()
        {
            float temp1 = 0f;
            float temp2 = 0f;
            float temp3 = 0f;
            float temp4 = 0f;
            float temp5 = 0f;
            float temp6 = 0f;
            float temp7 = 0f;


            Console.WriteLine("Enter temperature for Monday: ");
            temp1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter temperature for Tuesday: ");
            temp2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter temperature for Wednesday: ");
            temp3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter temperature for Thursday: ");
            temp4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter temperature for Friday: ");
            temp5 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter temperature for Saturday: ");
            temp6 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter temperature for Sunday: ");
            temp7 = float.Parse(Console.ReadLine());

            float averagetemp = (temp1 + temp2 + temp3 + temp4 + temp5 + temp6 + temp7) / 7;


            Console.WriteLine(String.Format("The average temperature is {0}", averagetemp));
            Console.ReadLine();

        }


        static void question3()
        {
            //assuming 4 students in class
            int age1, age2, age3, age4 = 0;

            Console.WriteLine("Enter age of student1: ");
            age1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age of student2: ");
            age2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age of student3: ");
            age3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter age of student4: ");
            age4 = Convert.ToInt32(Console.ReadLine());

            double averageAge = (age1 + age2 + age3 + age4) / 4;

            Console.WriteLine(String.Format("The average age is {0}", averageAge));
            Console.ReadLine();

        }

        static void question4()
        {
            double circleArea = 0;
            Console.WriteLine("Enter radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            circleArea = Math.PI * Math.Pow(radius, 2);
            
            Console.WriteLine(String.Format("The area is {0}", circleArea));
            Console.ReadLine();
        }

        static void question5()
        {
            int num1, num2, num3, num4, num5 = 0;

            Console.WriteLine("Enter num1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter num3: ");
            num3 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter num4: ");
            num4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter num5: ");
            num5 = Convert.ToInt32(Console.ReadLine());


            if (num1>num2 && num1>num3 && num1 > num4 && num1>num5)
            {
                Console.WriteLine("Largest number is: " + num1);
            }

            if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                Console.WriteLine("Largest number is: " + num2);
            }

            if (num3 > num2 && num3 > num1 && num3 > num4 && num3 > num5)
            {
                Console.WriteLine("Largest number is: " + num3);
            }

            if (num4 > num2 && num4 > num3 && num4 > num1 && num4 > num5)
            {
                Console.WriteLine("Largest number is: " + num4);
            }

            if (num5 > num2 && num5 > num3 && num5 > num4 && num5 > num1)
            {
                Console.WriteLine("Largest number is: " + num5);
            }


            if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
            {
                Console.WriteLine("Smallest number is: " + num1);
            }

            if (num2 < num1 && num2 < num3 && num2 < num4 && num2 < num5)
            {
                Console.WriteLine("Smallest number is: " + num2);
            }

            if (num3 < num2 && num3 < num1 && num3 < num4 && num3 < num5)
            {
                Console.WriteLine("Smallest number is: " + num3);
            }

            if (num4 < num2 && num4 < num3 && num4 < num1 && num4 < num5)
            {
                Console.WriteLine("Smallest number is: " + num4);
            }

            if (num5 < num2 && num5 < num3 && num5 < num4 && num5 < num1)
            {
                Console.WriteLine("Smallest number is: " + num5);
            }

            double average = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine(String.Format("The average is {0}", average));
            Console.ReadLine();
        }

    

        static void Main(string[] args)
        {
            //question1();

            //question2();
            //question3();
            //question4();
            //question5();
            
            //menu
            int choice = 0;
            
            while(choice != 6)
            { 
                Console.WriteLine("Which question would you like to try?, choose 6 to quit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: question1();
                            break;
                    case 2: question2();
                            break;
                    case 3: question3();
                            break;
                    case 4: question4();
                            break;
                    case 5: question5();
                            break;
                    case 6: break;
                    default: Console.WriteLine("Invalid option");
                             break;
                }

            }
        }
    }
}
