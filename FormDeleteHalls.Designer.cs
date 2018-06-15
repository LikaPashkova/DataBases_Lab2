namespace WindowsFormsApp1
{
    partial class FormDeleteHalls
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
            this.comboBoxHallsDelete = new System.Windows.Forms.ComboBox();
            this.buttonHallsDelete = new System.Windows.Forms.Button();
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
            // comboBoxHallsDelete
            // 
            this.comboBoxHallsDelete.FormattingEnabled = true;
            this.comboBoxHallsDelete.Location = new System.Drawing.Point(12, 518);
            this.comboBoxHallsDelete.Name = "comboBoxHallsDelete";
            this.comboBoxHallsDelete.Size = new System.Drawing.Size(376, 39);
            this.comboBoxHallsDelete.TabIndex = 3;
            this.comboBoxHallsDelete.Text = "Select halls ID";
            // 
            // buttonHallsDelete
            // 
            this.buttonHallsDelete.Location = new System.Drawing.Point(394, 511);
            this.buttonHallsDelete.Name = "buttonHallsDelete";
            this.buttonHallsDelete.Size = new System.Drawing.Size(369, 50);
            this.buttonHallsDelete.TabIndex = 4;
            this.buttonHallsDelete.Text = "Delete";
            this.buttonHallsDelete.UseVisualStyleBackColor = true;
            this.buttonHallsDelete.Click += new System.EventHandler(this.buttonHallsDelete_Click);
            // 
            // FormDeleteHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonHallsDelete);
            this.Controls.Add(this.comboBoxHallsDelete);
            this.Controls.Add(this.dgv);
            this.Name = "FormDeleteHalls";
            this.Text = "Delete Halls";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBoxHallsDelete;
        private System.Windows.Forms.Button buttonHallsDelete;
    }
}