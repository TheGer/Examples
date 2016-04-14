using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example10
{
    


    public class Person
    {
        public string name;
        public string surname;

        public Person()
        {
            name = "";
            surname = "";
        }

        public string getName() 
        {
            if (name != "")
            { 
            return name;
            }
            else
            {
                Exception myException = new Exception("M'hemmx Isem");
                
                throw myException;
            }
        }


        public string getSurname()
        {
            return surname;
        }


    }
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int num1 = 0;
                int num2 = 10;

                int number = num2 / num1;
                
                
                
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.ToString());

            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            finally
            {
                
            }

            try
            {

                Person p = new Person();

                p.surname = "Borg";

                MessageBox.Show(p.getName());
 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
