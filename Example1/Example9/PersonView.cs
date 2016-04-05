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
        public PersonView()
        {
            InitializeComponent();
            PersonController controller = new PersonController();
            //this variable contains the list of persons
            controller.getPersons();
        }
    }
}
