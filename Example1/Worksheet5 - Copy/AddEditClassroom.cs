using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worksheet5
{
    public partial class AddEditClassroom : Form
    {
        public AddEditClassroom()
        {
            InitializeComponent();
        }

        bool editing = false;
        Classroom currentClassroom;

        public AddEditClassroom(Classroom classroomtoedit)
        {
            InitializeComponent();
            textBox1.Text = classroomtoedit.Classroomname;
            checkBox1.Checked = classroomtoedit.Projectoravailable;
            editing = true;
            button1.Text = "Update classroom";
            this.Text = "Update classroom";
            currentClassroom = classroomtoedit;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!editing) { 
                string classroomname = textBox1.Text;
                bool projector = checkBox1.Checked;
                Classroom newClassroom = new Classroom(classroomname, projector, new List<Computer>());
                MainProgram.rooms.Add(newClassroom);   
            }
            else
            {
                currentClassroom.Classroomname = textBox1.Text;
                currentClassroom.Projectoravailable = checkBox1.Checked;
            }

            ClassroomsForm owner = (ClassroomsForm)this.Owner;
            owner.updateGrid();
            this.Close();
        }
    }
}
