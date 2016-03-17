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
    public partial class ClassroomChooser : Form
    {
        Laptop comp;
        Classroom sourceCroom;
        


        public ClassroomChooser()
        {
            InitializeComponent();
        }

        public ClassroomChooser(Laptop computerToMove,Classroom sourceClassroom)
        {
            InitializeComponent();
            comp = computerToMove;
            sourceCroom = sourceClassroom;

        }

        private void ClassroomChooser_Load(object sender, EventArgs e)
        {
            foreach (Classroom r in MainProgram.rooms)
                classroomsCombo.Items.Add(r.Classroomname);
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            //get selected index from the classroom chooser
            string selectedClassroom = classroomsCombo.Text;
            Classroom targetClassroom = MainProgram.rooms.Find(cname => cname.Classroomname == selectedClassroom);

            comp.move(sourceCroom, targetClassroom);

            MessageBox.Show(this, "Computer successfully moved");

            this.Close();
        }


    }
}
