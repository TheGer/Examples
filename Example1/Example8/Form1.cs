using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void personButton_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            p.FirstName = "gerard";
            p.LastName = "said";
            p.Age = 34;


            Person p2 = new Person();
            p2.FirstName = "joe";
            p2.LastName = "borg";
            p2.Age = 35;



            outputText.Text = p.printMe();
            p.shootMe();
            outputText.Text += "\n"+p.printMe();

            outputText.Text += p.CompareTo(p2);



        }

    }
}
