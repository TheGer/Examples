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
    public partial class ClassroomsForm : Form
    {
        public ClassroomsForm()
        {
            InitializeComponent();
        }


        public void updateGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            //style for classroom name
            DataGridViewCell cellStyle = new DataGridViewTextBoxCell();
            cellStyle.Style.BackColor = Color.Wheat;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();

            deleteButtonColumn.Text = "Delete Classroom";
            deleteButtonColumn.UseColumnTextForButtonValue = true;



            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.Text = "Update Classroom";

            updateButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn manageComputersButtonColumn = new DataGridViewButtonColumn();
            manageComputersButtonColumn.Text = "Manage computers";

            manageComputersButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(new DataGridViewColumn(cellStyle));
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn());



            dataGridView1.Columns.Add(updateButtonColumn);
            dataGridView1.Columns.Add(manageComputersButtonColumn);
            dataGridView1.Columns.Add(deleteButtonColumn);


            foreach (Classroom classroom in MainProgram.rooms)
                dataGridView1.Rows.Add(classroom.Classroomname,classroom.Projectoravailable);
        }

        private void ClassroomsForm_Load(object sender, EventArgs e)
        {
            updateGrid();
           
        


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  MessageBox.Show(e.ColumnIndex.ToString() + " " + e.RowIndex.ToString());
            //this event is triggered every time I click a cell 
            string currentRoomName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            if (e.ColumnIndex==4)
            {
                //delete classroom
                Classroom classtodelete = MainProgram.rooms.Find(croom => croom.Classroomname == currentRoomName);

                MessageBoxButtons confirmButtons = MessageBoxButtons.OKCancel;

                DialogResult result = MessageBox.Show("Are you sure you want to delete?","Delete", confirmButtons);

                if (result == DialogResult.OK)
                {
                    MainProgram.rooms.Remove(classtodelete);
                    updateGrid();
                }
              
            }
            if (e.ColumnIndex == 2)
            {
                //update classroom
              
                Classroom classtoupdate = MainProgram.rooms.Find(croom => croom.Classroomname == currentRoomName);


                AddEditClassroom addC = new AddEditClassroom(classtoupdate);
                addC.ShowDialog(this);
            }
            if (e.ColumnIndex == 3)
            {
                //manage classroom computers
                Classroom classtoupdate = MainProgram.rooms.Find(croom => croom.Classroomname == currentRoomName);

                ManageComputersForm manageCompForm = new ManageComputersForm(classtoupdate);
                manageCompForm.ShowDialog();
            }






            //MessageBox.Show();
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEditClassroom addC = new AddEditClassroom();
            addC.ShowDialog(this);
           
        }
    }
}
