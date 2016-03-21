using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksheet5
{
    public class Classroom
    {
        string _classroomname;

        public string Classroomname
        {
            get { return _classroomname; }
            set { _classroomname = value; }
        }

        bool _projectoravailable;

        
        public bool Projectoravailable
        {
            get { return _projectoravailable; }
            set { _projectoravailable = value; }
        }

        List<Computer> _computersinclassroom;

        internal List<Computer> Computersinclassroom
        {
            get { return _computersinclassroom; }
            set { _computersinclassroom = value; }
        }

     

        public Classroom(string classroomname,bool projectoravailable,List<Computer> allComputers)
        {
            Classroomname = classroomname;
            Projectoravailable = projectoravailable;
            Computersinclassroom = allComputers;
        }

        public Classroom(string v1,bool v2)
        {
            Classroomname = v1;
            Projectoravailable = v2;
            Computersinclassroom = new List<Computer>();
        }

        public Classroom() 
        {
            Classroomname = "";
            Projectoravailable = false;
            Computersinclassroom = new List<Computer>();
        }


     
        public string outputClassroom()
        {
            return "Name of classroom: " + Classroomname + " Projector: " + Projectoravailable;
        }

        //hide the default ToString method with a new method that I have written
        public override string ToString()
        {
            string output = "";
            output += "Name of classroom: " + Classroomname + " Projector: " + Projectoravailable + "\n";
            foreach (Computer c in Computersinclassroom)
            {
                output += c;
            }
            return output;


        }

        public Classroom copyMe()
        {
            Classroom outputC = new Classroom(this.Classroomname, this.Projectoravailable, this.Computersinclassroom);
            return outputC;
        }
    }
}
