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
            Classroom myClassroom = new Classroom("L113", true);

            

            Console.WriteLine(myClassroom);
            
            Console.ReadLine();
        }
    }
}
