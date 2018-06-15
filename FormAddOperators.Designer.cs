namespace WindowsFormsApp1
{
    partial class FormAddOperators
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
            this.textBoxPIB = new System.Windows.Forms.TextBox();
            this.comboBoxYYYY = new System.Windows.Forms.ComboBox();
            this.comboBoxMM = new System.Windows.Forms.ComboBox();
            this.comboBoxDD = new System.Windows.Forms.ComboBox();
            this.comboBoxSalary = new System.Windows.Forms.ComboBox();
            this.buttonAddOperators = new System.Windows.Forms.Button();
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
            // textBoxPIB
            // 
            this.textBoxPIB.Location = new System.Drawing.Point(12, 518);
            this.textBoxPIB.Name = "textBoxPIB";
            this.textBoxPIB.Size = new System.Drawing.Size(750, 38);
            this.textBoxPIB.TabIndex = 4;
            this.textBoxPIB.Text = "Input PIB";
            // 
            // comboBoxYYYY
            // 
            this.comboBoxYYYY.FormattingEnabled = true;
            this.comboBoxYYYY.Location = new System.Drawing.Point(242, 571);
            this.comboBoxYYYY.Name = "comboBoxYYYY";
            this.comboBoxYYYY.Size = new System.Drawing.Size(153, 39);
            this.comboBoxYYYY.TabIndex = 5;
            this.comboBoxYYYY.Text = "YYYY";
            // 
            // comboBoxMM
            // 
            this.comboBoxMM.FormattingEnabled = true;
            this.comboBoxMM.Location = new System.Drawing.Point(128, 571);
            this.comboBoxMM.Name = "comboBoxMM";
            this.comboBoxMM.Size = new System.Drawing.Size(108, 39);
            this.comboBoxMM.TabIndex = 6;
            this.comboBoxMM.Text = "MM";
            // 
            // comboBoxDD
            // 
            this.comboBoxDD.FormattingEnabled = true;
            this.comboBoxDD.Location = new System.Drawing.Point(12, 571);
            this.comboBoxDD.Name = "comboBoxDD";
            this.comboBoxDD.Size = new System.Drawing.Size(110, 39);
            this.comboBoxDD.TabIndex = 7;
            this.comboBoxDD.Text = "DD";
            // 
            // comboBoxSalary
            // 
            this.comboBoxSalary.FormattingEnabled = true;
            this.comboBoxSalary.Location = new System.Drawing.Point(401, 571);
            this.comboBoxSalary.Name = "comboBoxSalary";
            this.comboBoxSalary.Size = new System.Drawing.Size(153, 39);
            this.comboBoxSalary.TabIndex = 9;
            this.comboBoxSalary.Text = "Salary";
            // 
            // buttonAddOperators
            // 
            this.buttonAddOperators.Location = new System.Drawing.Point(560, 564);
            this.buttonAddOperators.Name = "buttonAddOperators";
            this.buttonAddOperators.Size = new System.Drawing.Size(202, 50);
            this.buttonAddOperators.TabIndex = 10;
            this.buttonAddOperators.Text = "Add";
            this.buttonAddOperators.UseVisualStyleBackColor = true;
            this.buttonAddOperators.Click += new System.EventHandler(this.buttonAddOperators_Click);
            // 
            // FormAddOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonAddOperators);
            this.Controls.Add(this.comboBoxSalary);
            this.Controls.Add(this.comboBoxDD);
            this.Controls.Add(this.comboBoxMM);
            this.Controls.Add(this.comboBoxYYYY);
            this.Controls.Add(this.textBoxPIB);
            this.Controls.Add(this.dgv);
            this.Name = "FormAddOperators";
            this.Text = "Add Operators";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBoxPIB;
        private System.Windows.Forms.ComboBox comboBoxYYYY;
        private System.Windows.Forms.ComboBox comboBoxMM;
        private System.Windows.Forms.ComboBox comboBoxDD;
        private System.Windows.Forms.ComboBox comboBoxSalary;
        private System.Windows.Forms.Button buttonAddOperators;
    }
}