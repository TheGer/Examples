using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worksheet6
{
    public partial class ShapesForm : Form
    {
        public ShapesForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void handleSquare()
        {
            Label sideInputLabel = new Label();
            sideInputLabel.Text = "Input square side: ";
            TextBox sideInput = new TextBox();
            sideInput.Name = "squareInput";
            inputsPanel.Controls.Add(sideInputLabel);
            inputsPanel.Controls.Add(sideInput);
            sideInput.Visible = true;
        }

        private void shapeChooserCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(shapeChooserCombo.SelectedItem.ToString()){
                case "Square":
                    handleSquare();
                    break;
                
            }
                
                        


        }
    }
}
