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

            DataGridViewCell cellStyle = new DataGridViewTextBoxCell();
            cellStyle.Style.BackColor = Color.Wheat;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();

            deleteButtonColumn.Text = "Delete Classroom";
            deleteButtonColumn.UseColumnTextForButtonValue = true;



            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.Text = "Update Classroom";

            updateButtonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn viewComputersButtonColumn = new DataGridViewButtonColumn();
            viewComputersButtonColumn.Text = "View computers";

            viewComputersButtonColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(new DataGridViewColumn(cellStyle));

            dataGridView1.Columns.Add(updateButtonColumn);
            dataGridView1.Columns.Add(viewComputersButtonColumn);
            dataGridView1.Columns.Add(deleteButtonColumn);


            foreach (Classroom classroom in MainProgram.rooms)
                dataGridView1.Rows.Add(classroom.Classroomname);
        }

        private void ClassroomsForm_Load(object sender, EventArgs e)
        {
            updateGrid();
           
        


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  MessageBox.Show(e.ColumnIndex.ToString() + " " + e.RowIndex.ToString());
            //this event is triggered every time I click a cell 
            if (e.ColumnIndex==3)
            {
                //MessageBox.Show("Delete");
                string currentRoomName = dataGridView1.CurrentRow.Cells[0].Value.ToString();

               

                Classroom classtodelete = MainProgram.rooms.Find(croom => croom.Classroomname == currentRoomName);

                //Classroom backupClassroom = classtodelete.copyMe();
               // Classroom backupClassroom = MainProgram.copyClassroom(classtodelete);
                MessageBoxButtons confirmButtons = MessageBoxButtons.OKCancel;

                DialogResult result = MessageBox.Show("Are you sure you want to delete?","Delete", confirmButtons);

                if (result == DialogResult.OK)
                {
                    MainProgram.rooms.Remove(classtodelete);
                    updateGrid();
                }
              //  MessageBox.Show(backupClassroom.ToString());
            }
            if (e.ColumnIndex == 1)
            {
                string currentRoomName = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                Classroom classtoupdate = MainProgram.rooms.Find(croom => croom.Classroomname == currentRoomName);


                AddEditClassroom addC = new AddEditClassroom(classtoupdate);
                addC.ShowDialog(this);
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
