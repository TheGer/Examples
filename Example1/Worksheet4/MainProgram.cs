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
        static void Menu(Classroom[] rooms,String menutext)
        {
            int option = 0;
            while (option!= 7)
            { 
                Console.WriteLine(menutext);
                option = Convert.ToInt32(Console.ReadKey(false).KeyChar.ToString());
                switch (option)
                {
                    case 1:
                        opt1(rooms);
                        break;
                    case 2:
                        opt2(rooms);
                        break;
                    case 3:
                        opt3(rooms);
                        break;
                    case 4:
                        opt4(rooms);
                        break;
                    case 5:
                        opt5(rooms);
                        break;
                    case 6:
                        opt6(rooms);
                        break;
                    case 7:
                        break;
                    default:
                        Console.WriteLine("Error - incorrect option");
                        break;
                }
            }
        }

        
        static void opt1(Classroom[] rooms)
        {
            //list all classrooms
            foreach(Classroom c in rooms)
            {
                Console.WriteLine(c);
            }

        }

        static void opt2(Classroom[] rooms)
        {
            int roomscounter = 0;

            foreach (Classroom c in rooms)
            {
                if (c!=null)
                {
                    roomscounter++;
                }
            }

            Console.WriteLine("Enter new classroom name: ("+roomscounter+"/"+rooms.Length+") slots taken ");
            string classroomname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Does the classroom have a projector? ");
            bool projector = yesno();
            //create a new classroom with an empty array of computers
            Classroom newClassroom = new Classroom(classroomname, projector,new Computer[6]);

            //Computer[] testArray = new Computer[20];

            //newClassroom.Computersinclassroom = testArray;



            rooms[roomscounter] = newClassroom;
        }

        static void opt3(Classroom[] rooms)
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

      
            Computer[] computersInClassroom = rooms[classroomchoice].Computersinclassroom;

            for (int i=0;i<computersInClassroom.Length;i++)
            {
                if (computersInClassroom[i]!=null)
                    Console.WriteLine(i + ") " + computersInClassroom[i].Computername + " ");
                else
                    Console.WriteLine(i + ") Free slot ");
            }

            Console.WriteLine("Select a slot:");
            int compchoice = Convert.ToInt32(Console.ReadLine());
            computersInClassroom[compchoice] = c;
            
        }

        static void opt4(Classroom[] rooms)
        {
            Console.WriteLine("Select a classroom:");
            int classroomchoice = Convert.ToInt32(Console.ReadLine());

            //2. add computer to classroom
            Computer c = newComputer();

            

            Computer[] computersInClassroom = rooms[classroomchoice].Computersinclassroom;

            for (int i = 0; i < computersInClassroom.Length; i++)
            {
                if (computersInClassroom[i] != null)
                    Console.WriteLine(i + ") " + computersInClassroom[i].Computername + " ");
                else
                    Console.WriteLine(i + ") Free slot ");
            }
        }

        static void opt5(Classroom[] rooms)
        {




        }

        static void opt6(Classroom[] rooms)
        {
            //1. create an array containing all the computers in all the rooms
            Computer[] allComputers = new Computer[1];

            int totalComputerSlots = 0;

            foreach(Classroom c in rooms)
            {
                if (c != null)
                    totalComputerSlots += c.Computersinclassroom.Length;
            }
            //total number of computers = arrayLength
            allComputers = new Computer[totalComputerSlots];

            int counter = 0;

            foreach (Classroom c in rooms)
            {
                if (c!=null)
                { 
                    foreach(Computer cm in c.Computersinclassroom)
                    {
                        if (cm!=null)
                        {
                            allComputers[counter] = cm;
                            counter++;
                        }
                    }
                }

            }
            
            Array.Sort(allComputers);

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

            Computer PC1 = new Computer("L113-", "OK", 5);
            Computer PC2 = new Computer("L11", "OK", 2);
            Computer PC3 = new Computer("L1", "NOT OK", 3);
            Computer PC4 = new Computer("L113-8", "NOT OK", 3);

            Computer[] computers = new Computer[4];

            computers[0] = PC1;
            computers[1] = PC2;
            computers[2] = PC3;
            computers[3] = PC4;

            
            //myClassroom = L113
            Classroom myClassroom = new Classroom("L113", true,computers);

            Computer[] computers2 = new Computer[2];

            computers2[0] = new Computer("L114-1", "OK", 1);
            computers2[1] = new Computer("L114-2", "OK", 5);

            //myClassroom2 = L114
            Classroom myClassroom2 = new Classroom("L114", true, computers2);

            //max classrooms = 4
            Classroom[] allRooms = new Classroom[5];

            //first 2 classrooms
            allRooms[0] = myClassroom;
            allRooms[1] = myClassroom2;


            String menu =
                "1.) List all classrooms in system \t\n" +
                "2.) Add new classroom \t\n" +
                "3.) Add new computer to classroom \t\n" +
                "4.) List all computers in classroom \t\n" +
                "5.) Update computer status by computer name \t\n" +
                "6.) List all computers ordered by fault \t\n" +
                "7.) Quit \t\n";

            Menu(allRooms, menu);

            
            
            
            Console.ReadLine();
        }
    }
}
