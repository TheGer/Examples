using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example7
{
    public partial class RandomNumbersForm : Form
    {

        List<int> numbList;

        public RandomNumbersForm()
        {
            InitializeComponent();
        }

        public RandomNumbersForm(List<int> numList)
        {
            InitializeComponent();
            numbList = numList;
        }



        private void updateDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            DataGridViewCell cellStyle = new DataGridViewTextBoxCell();
            cellStyle.Style.BackColor = Color.Wheat;

            dataGridView1.Columns.Add(new DataGridViewColumn(cellStyle));
            
            foreach (int i in numbList)
                dataGridView1.Rows.Add(i.ToString());
        }



        private void generateButton_Click(object sender, EventArgs e)
        {
            Program.updateRandomNumbers(numbList);
            updateDataGrid();
          

        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            numbList.Sort();
            updateDataGrid();

        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            numbList.Reverse();
            updateDataGrid();
        }

        private void distinctButton_Click(object sender, EventArgs e)
        {
            numbList = numbList.Distinct().ToList<int>();
            updateDataGrid();
        }

        private void RandomNumbersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
