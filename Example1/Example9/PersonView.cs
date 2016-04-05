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

        PersonController controller = new PersonController();
        Boolean initialized = false;
        Boolean added = false;
        public PersonView()
        {
            InitializeComponent();
            
            //this variable contains the list of persons

            updateGrid();
            initialized = true;
            
        }

        public void updateGrid()
        {
            personsGridView.Rows.Clear();
            personsGridView.Columns.Clear();
            personsGridView.Columns.Add("Name", "Name");
            personsGridView.Columns.Add("Surname", "Surname");
            personsGridView.Columns.Add("Telnumber", "Telephone Number");
            personsGridView.Columns.Add("Age", "Age");
            foreach (PersonModel p in controller.getPersons())
            {
                personsGridView.Rows.Add(p.Name, p.Surname, p.Telnumber, p.Age);
            }
            
        }

        private void personsGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            added = true;
        }

        private void personsGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (initialized && added)
            {
                PersonModel newPerson = new PersonModel(personsGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    personsGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    personsGridView.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Convert.ToInt32(personsGridView.Rows[e.RowIndex].Cells[3].Value));

                controller.addPerson(newPerson);
                
                //MessageBox.Show("New Person Added");
                added = false;
            }
        }

      
    }
}
