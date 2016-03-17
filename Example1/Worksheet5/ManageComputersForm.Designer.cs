namespace Worksheet5
{
    partial class ManageComputersForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addComputersButton = new System.Windows.Forms.Button();
            this.computersDataGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.computersDataGrid, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.44484F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.55516F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 370);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addComputersButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 85);
            this.panel1.TabIndex = 0;
            // 
            // addComputersButton
            // 
            this.addComputersButton.Location = new System.Drawing.Point(3, 16);
            this.addComputersButton.Name = "addComputersButton";
            this.addComputersButton.Size = new System.Drawing.Size(322, 23);
            this.addComputersButton.TabIndex = 0;
            this.addComputersButton.Text = "Add Computer";
            this.addComputersButton.UseVisualStyleBackColor = true;
            // 
            // computersDataGrid
            // 
            this.computersDataGrid.AllowUserToAddRows = false;
            this.computersDataGrid.AllowUserToDeleteRows = false;
            this.computersDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.computersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computersDataGrid.ColumnHeadersVisible = false;
            this.computersDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.computersDataGrid.Location = new System.Drawing.Point(3, 3);
            this.computersDataGrid.Name = "computersDataGrid";
            this.computersDataGrid.ReadOnly = true;
            this.computersDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.computersDataGrid.RowHeadersVisible = false;
            this.computersDataGrid.Size = new System.Drawing.Size(613, 273);
            this.computersDataGrid.TabIndex = 1;
            this.computersDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.computersDataGrid_CellClick);
            // 
            // ManageComputersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 370);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ManageComputersForm";
            this.Text = "ManageComputersForm";
            this.Load += new System.EventHandler(this.ManageComputersForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.computersDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addComputersButton;
        private System.Windows.Forms.DataGridView computersDataGrid;
    }
}