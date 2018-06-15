namespace WindowsFormsApp1
{
    partial class FormEditHalls
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.comboBoxHallsEdit = new System.Windows.Forms.ComboBox();
            this.textBoxNewHallsName = new System.Windows.Forms.TextBox();
            this.comboNewBoxSeats = new System.Windows.Forms.ComboBox();
            this.buttonEditHalls = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 12);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 40;
            this.dgv.Size = new System.Drawing.Size(750, 500);
            this.dgv.TabIndex = 3;
            // 
            // comboBoxHallsEdit
            // 
            this.comboBoxHallsEdit.FormattingEnabled = true;
            this.comboBoxHallsEdit.Location = new System.Drawing.Point(12, 518);
            this.comboBoxHallsEdit.Name = "comboBoxHallsEdit";
            this.comboBoxHallsEdit.Size = new System.Drawing.Size(376, 39);
            this.comboBoxHallsEdit.TabIndex = 4;
            this.comboBoxHallsEdit.Text = "Select halls ID";
            // 
            // textBoxNewHallsName
            // 
            this.textBoxNewHallsName.Location = new System.Drawing.Point(12, 575);
            this.textBoxNewHallsName.Name = "textBoxNewHallsName";
            this.textBoxNewHallsName.Size = new System.Drawing.Size(300, 38);
            this.textBoxNewHallsName.TabIndex = 5;
            this.textBoxNewHallsName.Text = "Input halls name";
            // 
            // comboNewBoxSeats
            // 
            this.comboNewBoxSeats.FormattingEnabled = true;
            this.comboNewBoxSeats.Location = new System.Drawing.Point(318, 574);
            this.comboNewBoxSeats.Name = "comboNewBoxSeats";
            this.comboNewBoxSeats.Size = new System.Drawing.Size(144, 39);
            this.comboNewBoxSeats.TabIndex = 6;
            this.comboNewBoxSeats.Text = "Seats";
            // 
            // buttonEditHalls
            // 
            this.buttonEditHalls.Location = new System.Drawing.Point(468, 518);
            this.buttonEditHalls.Name = "buttonEditHalls";
            this.buttonEditHalls.Size = new System.Drawing.Size(294, 95);
            this.buttonEditHalls.TabIndex = 7;
            this.buttonEditHalls.Text = "Edit";
            this.buttonEditHalls.UseVisualStyleBackColor = true;
            this.buttonEditHalls.Click += new System.EventHandler(this.buttonEditHalls_Click);
            // 
            // FormEditHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonEditHalls);
            this.Controls.Add(this.comboNewBoxSeats);
            this.Controls.Add(this.textBoxNewHallsName);
            this.Controls.Add(this.comboBoxHallsEdit);
            this.Controls.Add(this.dgv);
            this.Name = "FormEditHalls";
            this.Text = "Edit Halls";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBoxHallsEdit;
        private System.Windows.Forms.TextBox textBoxNewHallsName;
        private System.Windows.Forms.ComboBox comboNewBoxSeats;
        private System.Windows.Forms.Button buttonEditHalls;
    }
}