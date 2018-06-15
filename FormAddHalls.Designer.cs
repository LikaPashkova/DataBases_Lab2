namespace WindowsFormsApp1
{
    partial class FormAddHalls
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
            this.textBoxHallsName = new System.Windows.Forms.TextBox();
            this.comboBoxSeats = new System.Windows.Forms.ComboBox();
            this.buttonAddHall = new System.Windows.Forms.Button();
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
            this.dgv.TabIndex = 2;
            // 
            // textBoxHallsName
            // 
            this.textBoxHallsName.Location = new System.Drawing.Point(12, 518);
            this.textBoxHallsName.Name = "textBoxHallsName";
            this.textBoxHallsName.Size = new System.Drawing.Size(300, 38);
            this.textBoxHallsName.TabIndex = 3;
            this.textBoxHallsName.Text = "Input halls name";
            // 
            // comboBoxSeats
            // 
            this.comboBoxSeats.FormattingEnabled = true;
            this.comboBoxSeats.Location = new System.Drawing.Point(318, 517);
            this.comboBoxSeats.Name = "comboBoxSeats";
            this.comboBoxSeats.Size = new System.Drawing.Size(144, 39);
            this.comboBoxSeats.TabIndex = 4;
            this.comboBoxSeats.Text = "Seats";
            // 
            // buttonAddHall
            // 
            this.buttonAddHall.Location = new System.Drawing.Point(472, 511);
            this.buttonAddHall.Name = "buttonAddHall";
            this.buttonAddHall.Size = new System.Drawing.Size(290, 50);
            this.buttonAddHall.TabIndex = 5;
            this.buttonAddHall.Text = "Add";
            this.buttonAddHall.UseVisualStyleBackColor = true;
            this.buttonAddHall.Click += new System.EventHandler(this.buttonAddHall_Click);
            // 
            // FormAddHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonAddHall);
            this.Controls.Add(this.comboBoxSeats);
            this.Controls.Add(this.textBoxHallsName);
            this.Controls.Add(this.dgv);
            this.Name = "FormAddHalls";
            this.Text = "Add Halls";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBoxHallsName;
        private System.Windows.Forms.ComboBox comboBoxSeats;
        private System.Windows.Forms.Button buttonAddHall;
    }
}