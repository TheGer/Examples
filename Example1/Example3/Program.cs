using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. an Object is an INSTANCE of a class
            //2. all Objects are INSTANCED using a constructor
            // and the NEW keyword

            //constructing an object

            
            Classroom myClassroom1 = new Classroom();

            myClassroom1.classroomname = "L113";
            myClassroom1.numberofcomputers = 25;
            myClassroom1.numberofstudents = 5;

            //Console.WriteLine(myClassroom.classroomname);
            Console.WriteLine(myClassroom1.getClassroomInfo());
            Console.WriteLine(myClassroom1.totalstudentsandcomputers());

            myClassroom1.updateClassroomName("L116");

            //the number of students cannot be negative.  UpdateNumberOfStudents
            //returns FALSE if that is the case and the value is NOT updated
            if (myClassroom1.updateNumberOfStudents(-1))
            {
                Console.WriteLine("Updated Successfully");
            }
           
            string[] studentnames = { "Gerry", "Test", "Test2" };
            myClassroom1.updateStudentNames(studentnames);

            Console.WriteLine(myClassroom1.getClassroomInfo());

            Classroom myClassroom2 = new Classroom();

            myClassroom2.classroomname = "L115";
            myClassroom2.numberofcomputers = 15;
            myClassroom2.numberofstudents = 0;

            //Console.WriteLine(myClassroom.classroomname);
            Console.WriteLine(myClassroom2.getClassroomInfo());
            Console.WriteLine(myClassroom2.totalstudentsandcomputers());


            Classroom myClassroom3 = new Classroom();
            Console.WriteLine(myClassroom3.getClassroomInfo());
            Console.WriteLine(myClassroom3.totalstudentsandcomputers());

           

            Classroom myClassroom4 = new Classroom(0, 25, "L112");


            string[] studentsinc4 = { "Joe", "Peter", "Simon" };
            myClassroom4.updateStudentNames(studentsinc4);

            Classroom[] thisCorridor = new Classroom[4];

            thisCorridor[0] = myClassroom1;
            thisCorridor[1] = myClassroom2;
            thisCorridor[2] = myClassroom3;
            thisCorridor[3] = myClassroom4;


            foreach (Classroom c in thisCorridor)
            {
                Console.WriteLine(c.getClassroomInfo());
            }

            //Console.WriteLine(myClassroom4.getClassroomInfo());
            //Console.WriteLine(myClassroom4.totalstudentsandcomputers());


            Console.ReadLine();

            //Create a method that constructs a rectangle taking the width
            //and the height as 2 parameters

            //Create a method that returns the perimeter of the rectangle
            //based on L+B x 2

            //Create a method which uses for loops to draw a representation
            //of the rectangle using Xs.  Width is equal to the width in characters
            //and height.  Method returns a string and is called from program.cs

        }
    }
}
