using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    class Classroom
    {
        //attributes which can be set
        public string classroomname;
        public int numberofstudents;
        public int numberofcomputers;
        string[] studentnames;

        //a public method
        public string getClassroomInfo()
        {
            return classroomname + " " + numberofstudents + " " + numberofcomputers + "\n" + getAllStudentNames();
        }

        //constructor
        public Classroom()
        {
            classroomname = "/";
            numberofstudents = 0;
            numberofcomputers = 0;
            studentnames = new string[5];
        }

        public Classroom(int nstudents,int ncomputers,string cname)
        {
            this.numberofstudents = nstudents;
            this.numberofcomputers = ncomputers;
            this.classroomname = cname;
            this.studentnames = new string[5];
        }

        public string getAllStudentNames()
        {
            string output = "";
            foreach(string sname in studentnames)
            {
                output += sname + "\n";
            }
            return output;
        }

        //updating the class name via parameter
        public void updateClassroomName(string newName)
        {
            this.classroomname = newName;
        }

        public void updateStudentNames(string[] studentNames)
        {
            this.studentnames = studentNames;
        }

        //update the number of students via parameter
        public bool updateNumberOfStudents(int numStudents)
        {
            if (numStudents>0)
            {
                this.numberofstudents = numStudents;
                return true;
            }
            return false;          
        }

        public int totalstudentsandcomputers()
        {
            return numberofstudents + numberofcomputers;
        }

    }
}
