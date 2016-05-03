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
                    Convert.ToInt32(personsGridView.Rows[e.RowIndex].Cells[4].Value));

                   controller.addPerson(newPerson);
                
                //MessageBox.Show("New Person Added");
                listLengthLabel.Text = controller.getPersons().Count().ToString();

                added = false;
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
            }
            else
            {
                e.Cancel = true;
            }
            
        }

        private void personsGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {



            //saves the value before the update has happened
            //  MessageBox.Show(personsGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            try
            {
                //get the person to find
                long? id = (long?)personsGridView.Rows[e.RowIndex].Cells[0].Value;
                string personName = personsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                string personSurname = personsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                string telNum = personsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                int age = (int)personsGridView.Rows[e.RowIndex].Cells[4].Value;

                PersonToUpdate = new PersonModel(personName, personSurname, telNum, age);

                PersonToUpdate = controller.getPersons().Find(person => person.Id == id);
            }
            catch (Exception n) { }


        }

        PersonModel PersonToUpdate;

        private void personsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personsGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

            try
            {

                PersonToUpdate.FirstName = personsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                PersonToUpdate.SecondName = personsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                PersonToUpdate.TelNumber = personsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                PersonToUpdate.Age = (int)personsGridView.Rows[e.RowIndex].Cells[4].Value;
            }
            catch (Exception n) { }

            //MessageBox.Show("updated");
        }

     
      
    }
}
