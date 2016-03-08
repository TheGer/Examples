using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worksheet5
{
    class MainProgram
    {

        public static List<Classroom> rooms;

        //static method which will load a menu
        static void Menu(String menutext)
        {
            int option = 0;
            while (option!= 7)
            { 
                Console.WriteLine(menutext);
                option = Convert.ToInt32(Console.ReadKey(false).KeyChar.ToString());
                switch (option)
                {
                    case 1:
                        opt1();
                        break;
                    case 2:
                        opt2();
                        break;
                    case 3:
                        opt3();
                        break;
                    case 4:
                        opt4();
                        break;
                    case 5:
                        opt5();
                        break;
                    case 6:
                        opt6();
                        break;
                    case 7:
                        opt7();
                        break;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("Error - incorrect option");
                        break;
                }
            }
        }


        static void opt7()
        {
            ClassroomsForm frm = new ClassroomsForm();

            Application.Run(frm);

        }
        
        static void opt1()
        {
            //list all classrooms
            foreach(Classroom c in rooms)
            {
                Console.WriteLine(c);
            }

        }

        static void opt2()
        {
            int roomscounter = 0;

            foreach (Classroom c in rooms)
            {
                if (c!=null)
                {
                    roomscounter++;
                }
            }

            Console.WriteLine("Enter new classroom name: ");
            string classroomname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Does the classroom have a projector? ");
            bool projector = yesno();
            //create a new classroom with an empty array of computers
            Classroom newClassroom = new Classroom(classroomname, projector,new List<Computer>());

           


            rooms.Add(newClassroom);
        }

        static void opt3()
        {
            int counter = 0;
            //1. select classroom

            
            foreach (Classroom cl in rooms)
            {
                if (cl!=null)
                { 
                    Console.WriteLine(counter + ") " + cl.Classroomname + " ");
                    counter++;
                }
            }
            Console.WriteLine("Select a classroom:");
            int classroomchoice = Convert.ToInt32(Console.ReadLine());

            //2. add computer to classroom
            Computer c = newComputer();

            List<Computer> computersInClassroom = rooms[classroomchoice].Computersinclassroom;

            computersInClassroom.Add(c);
            
        }

        static void opt4()
        {
            Console.WriteLine("Select a classroom:");
            int classroomchoice = Convert.ToInt32(Console.ReadLine());

            //2. add computer to classroom
            Computer c = newComputer();

            

            List<Computer> computersInClassroom = rooms[classroomchoice].Computersinclassroom;

            int i =0;
            foreach (Computer comp in computersInClassroom)
            {
                
                    Console.WriteLine(i + ") " + comp.Computername + " ");
            }
        }

        static void opt5()
        {




        }

        static void opt6()
        {
            //1. create an array containing all the computers in all the rooms
            List<Computer> allComputers = new List<Computer>();

            
            
            

            foreach (Classroom c in rooms)
            {
                if (c!=null)
                { 
                    foreach(Computer cm in c.Computersinclassroom)
                    {
                        allComputers.Add(cm);
                    }
                }

            }
            
            allComputers.Sort();

            foreach (Computer c in allComputers)
            {
                Console.WriteLine(c);
            }
            Console.ReadLine();




        }

        static bool yesno()
        {
            Console.WriteLine("y/n?");
            string input = Convert.ToString(Console.ReadKey(false).KeyChar);
            bool accept = false;

            if (input == "y")
                accept = true;
            else if (input == "n")
                accept = false;
           
            return accept;
        }


        static Computer newComputer()
        {
            Console.WriteLine("Enter computer name:");
            string computer = Console.ReadLine();
            Console.WriteLine("Enter computer status:");
            string status = Console.ReadLine();
            Console.WriteLine("Enter number of faults:");
            int numberOfFaults = Convert.ToInt32(Console.ReadLine());
            Computer pc = new Computer(computer, status, numberOfFaults);
            return pc;
        }

        static void updateStatusAndFaults(Computer pctoupdate)
        {
            Console.WriteLine("Enter computer status:");
            string status = Console.ReadLine();
            Console.WriteLine("Enter number of faults:");
            int numberOfFaults = Convert.ToInt32(Console.ReadLine());
            pctoupdate.Computerstatus = status;
            pctoupdate.Numberoffaults = numberOfFaults;
        }


        static void Main(string[] args)
        {
        
            //starting point of the application
            //we will load the menu of the application 
            //here
            rooms = new List<Classroom>();


            Computer PC1 = new Computer("L113-", "OK", 5);
            Computer PC2 = new Computer("L11", "OK", 2);
            Computer PC3 = new Computer("L1", "NOT OK", 3);
            Computer PC4 = new Computer("L113-8", "NOT OK", 3);

            List<Computer> computers = new List<Computer>();

            computers.Add(PC1);
            computers.Add(PC2);
            computers.Add(PC3);
            computers.Add(PC4);
            
            //myClassroom = L113
            Classroom myClassroom = new Classroom("L113", true,computers);

            List<Computer> computers2 = new List<Computer>();

            computers2.Add(new Computer("L114-1", "OK", 1));
            computers2.Add(new Computer("L114-2", "OK", 5));

            //myClassroom2 = L114
            Classroom myClassroom2 = new Classroom("L114", true, computers2);

            //max classrooms = 4
         

            //first 2 classrooms
           rooms.Add(myClassroom);
            rooms.Add(myClassroom2);


            String menu =
                "1.) List all classrooms in system \t\n" +
                "2.) Add new classroom \t\n" +
                "3.) Add new computer to classroom \t\n" +
                "4.) List all computers in classroom \t\n" +
                "5.) Update computer status by computer name \t\n" +
                "6.) List all computers ordered by fault \t\n" +
                "7.) GUI \t\n" +
                "8.) Quit \t\n";

            Menu(menu);

            
            
            
            Console.ReadLine();
        }
    }
}
