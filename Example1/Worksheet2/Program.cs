using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet2
{
    class Program
    {

        static string Diamond()
        {
            int diamondbase = 10;
            string output = "";


            for (int rows = 0; rows< diamondbase/2;rows++)
            {

                for (int cols = 0; cols <= diamondbase;cols++)
                {
                    if ((cols <= (diamondbase/2)-rows) || (cols >= (diamondbase/2)+rows))
                    {
                        
                        output += " ";
                    }
                    else
                    {
                        output += "X";
                    }
                  
                }
                output += "\n";
            }

            for (int rows = diamondbase/2; rows >0; rows--)
            {

                for (int cols = 0; cols <= diamondbase; cols++)
                {
                    if ((cols <= (diamondbase / 2) - rows) || (cols >= (diamondbase / 2) + rows))
                    {

                        output += " ";
                    }
                    else
                    {
                        output += "X";
                    }

                }
                output += "\n";
            }





            return output;
        }


        static void Main(string[] args)
        {

            Console.Write(Diamond());
            Console.ReadLine();

        }
    }
}
