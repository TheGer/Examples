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
    public partial class ManageComputersForm : Form
    {
        Classroom classroom;

        public ManageComputersForm()
        {
            InitializeComponent();
        }

        public ManageComputersForm(Classroom classroomtoedit)
        {
            InitializeComponent();
            classroom = classroomtoedit;
        }

        public void filldatagrid()
        {
            computersDataGrid.Rows.Clear();
            computersDataGrid.Columns.Clear();

            DataGridViewCell cellStyle = new DataGridViewTextBoxCell();
            cellStyle.Style.BackColor = Color.Wheat;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();

            deleteButtonColumn.Text = "Delete Computer";
            deleteButtonColumn.UseColumnTextForButtonValue = true;



            DataGridViewButtonColumn updateButtonColumn = new DataGridViewButtonColumn();
            updateButtonColumn.Text = "Update Computer";

            updateButtonColumn.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn viewComputerButtonColumn = new DataGridViewButtonColumn();
            viewComputerButtonColumn.Text = "View computer details";
            viewComputerButtonColumn.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn moveComputerButtonColumn = new DataGridViewButtonColumn();
            moveComputerButtonColumn.Text = "Move computer";
            moveComputerButtonColumn.UseColumnTextForButtonValue = true;



            computersDataGrid.Columns.Add(new DataGridViewColumn(cellStyle));
            computersDataGrid.Columns.Add(updateButtonColumn);
            computersDataGrid.Columns.Add(deleteButtonColumn);
            computersDataGrid.Columns.Add(viewComputerButtonColumn);
            computersDataGrid.Columns.Add(moveComputerButtonColumn);


            foreach (Computer comp in classroom.Computersinclassroom)
                computersDataGrid.Rows.Add(comp.Computername);
        }


        private void ManageComputersForm_Load(object sender, EventArgs e)
        {
            //update the datagrid
            filldatagrid();
        }

        private void computersDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedComputer = computersDataGrid.CurrentRow.Cells[0].Value.ToString();

            if (e.ColumnIndex == 3)
            {
                Computer currentComputer = classroom.Computersinclassroom.Find(cname => cname.Computername == selectedComputer);
                //open a message box on top of THIS window
                MessageBox.Show(this,currentComputer.ToString());
            }
            if (e.ColumnIndex == 4)
            {
                Computer currentComputer = classroom.Computersinclassroom.Find(cname => cname.Computername == selectedComputer);


                if (currentComputer.GetType().Equals(typeof(Laptop)))
                {
                    Laptop currentLaptop = (Laptop)currentComputer;
                    ClassroomChooser chooser = new ClassroomChooser(currentLaptop, classroom);
                    
                    chooser.ShowDialog();
                    filldatagrid();
                }
                else
                {
                    MessageBox.Show(this, "Only laptops may be moved");
                }
                
            }




        }




    }
}
