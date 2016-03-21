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
            inputsPanel.Controls.Clear();
            Label sideInputLabel = new Label();
            sideInputLabel.Text = "Input square side: ";
            TextBox sideInput = new TextBox();
            sideInput.Name = "squareInput";
            inputsPanel.Controls.Add(sideInputLabel);
            inputsPanel.Controls.Add(sideInput);
            sideInput.Visible = true;
          
            
        }

        private void handleRectangle()
        {
            inputsPanel.Controls.Clear();
            Label sideInputLabel = new Label();
            sideInputLabel.Text = "Input rectangle side: ";
            sideInputLabel.AutoSize = true;
            TextBox lengthInput = new TextBox();
            lengthInput.Name = "rectangleLength";
            Label sideInputLabel2 = new Label();
            sideInputLabel2.Text = "Input rectangle side2: ";
            sideInputLabel2.AutoSize = true;
            TextBox breadthInput = new TextBox();
            breadthInput.Name = "rectangleBreadth";

            inputsPanel.Controls.Add(sideInputLabel);
            inputsPanel.Controls.Add(lengthInput);
            inputsPanel.Controls.Add(sideInputLabel2);
            inputsPanel.Controls.Add(breadthInput);
            
            lengthInput.Visible = true;
            breadthInput.Visible = true;


        }


        Shape shapeToCalculate;
        

        private void shapeChooserCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(shapeChooserCombo.SelectedItem.ToString()){
                case "Square":
                    handleSquare();
                    break;
                case "Rectangle":
                    handleRectangle();
                    break;
                
            }




        }


        private void handleOutput()
        {
            areaOutputLabel.Text = shapeToCalculate.getArea().ToString();
            perimeterOutputLabel.Text = shapeToCalculate.getPerimeter().ToString();
        }

        private double getInput(String inputboxname)
        {
            foreach (Control input in inputsPanel.Controls)
            {
                if (input.Name == inputboxname)
                {
                   return Convert.ToDouble(input.Text);
                   break;
                }
            }
            return 0.0;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            switch (shapeChooserCombo.SelectedItem.ToString())
            {
                case "Square":
                    shapeToCalculate = new Square(getInput("squareInput"));
                    handleOutput();
                    break;
                case "Rectangle":
                    shapeToCalculate = new Rectangle(getInput("rectangleLength"), getInput("rectangleBreadth"));
                    handleOutput();
                    break;

            }
        }

           

    }
}
