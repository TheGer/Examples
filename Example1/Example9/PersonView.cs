using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example9
{
    public partial class PersonView : Form
    {

        PersonController controller;
        Boolean initialized = false;
        Boolean added = false;
        Boolean refreshgrid = false;
        public PersonView()
        {
            InitializeComponent();
            controller = new PersonController();
            
            
            //this variable contains the list of persons

            updateGrid();
            initialized = true;
            listLengthLabel.Text = controller.getPersons().Count().ToString();
            
        }

        public void updateGrid()
        {
            personsGridView.Rows.Clear();
            personsGridView.Columns.Clear();
            personsGridView.Columns.Add("ID", "ID");
            personsGridView.Columns.Add("Name", "Name");
            personsGridView.Columns.Add("Surname", "Surname");
            personsGridView.Columns.Add("Telnumber", "Telephone Number");
            personsGridView.Columns.Add("Age", "Age");
            foreach (PersonModel p in controller.getPersons())
            {
                personsGridView.Rows.Add(p.Id,p.FirstName, p.SecondName, p.TelNumber, p.Age);
            }
            added = false;
            
        }

        private void personsGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            added = true;
        }

        private void personsGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (initialized && added && e.RowIndex == personsGridView.NewRowIndex-1)
            {
                //can do validation here
                PersonModel newPerson = new PersonModel(personsGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    personsGridView.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    personsGridView.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    0);
                    //Convert.ToInt32(personsGridView.Rows[e.RowIndex].Cells[4].Value));

                   newPerson = controller.addPerson(newPerson);
                
                //MessageBox.Show("New Person Added");
                listLengthLabel.Text = controller.getPersons().Count().ToString();
                //updateGrid();
                personsGridView.Rows[e.RowIndex].Cells[0].Value = newPerson.Id;
                personsGridView.Rows[e.RowIndex].Cells[1].Value = newPerson.FirstName;
                personsGridView.Rows[e.RowIndex].Cells[2].Value = newPerson.SecondName;
                personsGridView.Rows[e.RowIndex].Cells[3].Value = newPerson.TelNumber;
                personsGridView.Rows[e.RowIndex].Cells[4].Value = newPerson.Age;

            }//else here for updating

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void personsGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Sure", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
               // controller.getPersons().RemoveAt(e.Row.Index);
                //find the telephone number of the guy I'm going to delete
                long? id = (long?)e.Row.Cells[0].Value;

                PersonModel personToDelete = new PersonModel();
                personToDelete.Id = id;

                controller.deletePerson(personToDelete);

               // controller.getPersons().RemoveAll(person => person.Id == id);



                listLengthLabel.Text = controller.getPersons().Count().ToString();
                updateGrid();
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void personsGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

        }

        PersonModel PersonToUpdate;

        private void personsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personsGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personsGridView_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                PersonToUpdate = new PersonModel();
                PersonToUpdate.Id = Convert.ToInt64(personsGridView.Rows[e.RowIndex].Cells[0].Value);
                PersonToUpdate.FirstName = personsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                PersonToUpdate.SecondName = personsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                PersonToUpdate.TelNumber = personsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                PersonToUpdate.Age = (int)personsGridView.Rows[e.RowIndex].Cells[4].Value;
                controller.updatePerson(PersonToUpdate);
            }
            catch (Exception n) { }

        }

        private void personsGridView_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }
    }
}
