using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example11
{
    public partial class Form1 : Form
    {
        SQLiteConnection m_dbConnection;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            

            string path = "Data Source=" + Application.StartupPath + "/telnumbers.s3db;Version=3;";
            MessageBox.Show(path);
            m_dbConnection = new SQLiteConnection(path);
            m_dbConnection.Open();
            string sql = "SELECT * FROM Contact";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            string output = "";
            while (reader.Read())
                
                
                //output += reader["id"]+" "+reader["firstName"] + " " + reader["secondName"] + " " + reader["telnumber"]+"\r\n";

            textBox1.Text = output;
            m_dbConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "Data Source=" + Application.StartupPath + "/telnumbers.s3db;Version=3;";
           // MessageBox.Show(path);
            m_dbConnection = new SQLiteConnection(path);
            m_dbConnection.Open();
            string sql = "INSERT INTO Contact(firstName,secondName,telNumber) VALUES ('a','b','c')";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            MessageBox.Show(command.ExecuteNonQuery().ToString());

            m_dbConnection.Close();
        }

        //update statement as follows 
        // UPDATE Contact SET firstName = 'new value',secondName = 'new value', telNumber = 'new value' where ID = value
        // DELETE from Contact WHERE ID = value
    }
}
