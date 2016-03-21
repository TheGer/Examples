namespace Worksheet6
{
    partial class ShapesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeChooserCombo = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.inputsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.perimeterOutputLabel = new System.Windows.Forms.Label();
            this.areaOutputLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.inputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.shapeChooserCombo);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(396, 320);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select shape:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // shapeChooserCombo
            // 
            this.shapeChooserCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.shapeChooserCombo.FormattingEnabled = true;
            this.shapeChooserCombo.Items.AddRange(new object[] {
            "Square",
            "Rectangle",
            "Triangle",
            "Hexagon",
            "Octagon",
            "n-agon (n sided shape)"});
            this.shapeChooserCombo.Location = new System.Drawing.Point(81, 3);
            this.shapeChooserCombo.Name = "shapeChooserCombo";
            this.shapeChooserCombo.Size = new System.Drawing.Size(247, 21);
            this.shapeChooserCombo.TabIndex = 0;
            this.shapeChooserCombo.SelectedIndexChanged += new System.EventHandler(this.shapeChooserCombo_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inputPanel);
            this.panel1.Controls.Add(this.perimeterOutputLabel);
            this.panel1.Controls.Add(this.areaOutputLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.calcButton);
            this.panel1.Location = new System.Drawing.Point(3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 269);
            this.panel1.TabIndex = 2;
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.inputsPanel);
            this.inputPanel.Location = new System.Drawing.Point(4, 3);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(386, 144);
            this.inputPanel.TabIndex = 6;
            // 
            // inputsPanel
            // 
            this.inputsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inputsPanel.Location = new System.Drawing.Point(0, 0);
            this.inputsPanel.Name = "inputsPanel";
            this.inputsPanel.Size = new System.Drawing.Size(386, 144);
            this.inputsPanel.TabIndex = 0;
            // 
            // perimeterOutputLabel
            // 
            this.perimeterOutputLabel.AutoSize = true;
            this.perimeterOutputLabel.Location = new System.Drawing.Point(75, 194);
            this.perimeterOutputLabel.Name = "perimeterOutputLabel";
            this.perimeterOutputLabel.Size = new System.Drawing.Size(13, 13);
            this.perimeterOutputLabel.TabIndex = 5;
            this.perimeterOutputLabel.Text = "0";
            // 
            // areaOutputLabel
            // 
            this.areaOutputLabel.AutoSize = true;
            this.areaOutputLabel.Location = new System.Drawing.Point(75, 164);
            this.areaOutputLabel.Name = "areaOutputLabel";
            this.areaOutputLabel.Size = new System.Drawing.Size(13, 13);
            this.areaOutputLabel.TabIndex = 4;
            this.areaOutputLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Area:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perimeter:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(4, 243);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // ShapesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 320);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ShapesForm";
            this.Text = "Shapes Form";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox shapeChooserCombo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Label perimeterOutputLabel;
        private System.Windows.Forms.Label areaOutputLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.FlowLayoutPanel inputsPanel;
    }
}

