using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet4
{
    class MainProgram
    {
        //static method which will load a menu
        static void Menu()
        {

        }

        

        static void Main(string[] args)
        {
        
            //starting point of the application
            //we will load the menu of the application 
            //here
            Computer PC1 = new Computer("L113-T", "OK", 0);
            Computer PC2 = new Computer("L113-1", "OK", 0);
            Computer PC3 = new Computer("L113-2", "NOT OK", 3);

            Computer[] computers = new Computer[3];

            computers[0] = PC1;
            computers[1] = PC2;
            computers[2] = PC3;

            Classroom myClassroom = new Classroom("L113", true,computers);

            

            Console.WriteLine(myClassroom);

            myClassroom.Computersinclassroom[0].Numberoffaults = 1;

            Console.WriteLine(myClassroom);



            
            Console.ReadLine();
        }
    }
}
