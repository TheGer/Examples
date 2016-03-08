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
            
            MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClassroom addC = new AddClassroom();
            addC.ShowDialog(this);
           
        }
    }
}
