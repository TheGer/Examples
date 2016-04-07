namespace Example9
{
    partial class PersonView
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
            this.personsGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listLengthLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personsGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personsGridView
            // 
            this.personsGridView.AllowDrop = true;
            this.personsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsGridView.Location = new System.Drawing.Point(45, 12);
            this.personsGridView.Name = "personsGridView";
            this.personsGridView.Size = new System.Drawing.Size(911, 137);
            this.personsGridView.TabIndex = 0;
            this.personsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personsGridView_CellContentClick);
            this.personsGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.personsGridView_CellValidated);
            this.personsGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.personsGridView_CellValidating);
            this.personsGridView.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.personsGridView_RowLeave);
            this.personsGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.personsGridView_RowsAdded);
            this.personsGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.personsGridView_UserDeletingRow);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listLengthLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 100);
            this.panel1.TabIndex = 1;
            // 
            // listLengthLabel
            // 
            this.listLengthLabel.AutoSize = true;
            this.listLengthLabel.Location = new System.Drawing.Point(83, 21);
            this.listLengthLabel.Name = "listLengthLabel";
            this.listLengthLabel.Size = new System.Drawing.Size(0, 13);
            this.listLengthLabel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length of List:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PersonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 262);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personsGridView);
            this.Name = "PersonView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personsGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personsGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label listLengthLabel;
    }
}

