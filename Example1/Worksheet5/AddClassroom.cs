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
    public partial class AddClassroom : Form
    {
        public AddClassroom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string classroomname = textBox1.Text;
            bool projector = checkBox1.Checked;
            Classroom newClassroom = new Classroom(classroomname, projector, new List<Computer>());
            MainProgram.rooms.Add(newClassroom);
            ClassroomsForm owner = (ClassroomsForm)this.Owner;
            owner.updateGrid();
            this.Close();
        }
    }
}
