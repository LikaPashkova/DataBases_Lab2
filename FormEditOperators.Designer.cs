namespace WindowsFormsApp1
{
    partial class FormEditOperators
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
            this.comboBoxEditID = new System.Windows.Forms.ComboBox();
            this.textBoxNewPIB = new System.Windows.Forms.TextBox();
            this.comboBoxNewYYYY = new System.Windows.Forms.ComboBox();
            this.comboBoxNewMM = new System.Windows.Forms.ComboBox();
            this.comboBoxNewDD = new System.Windows.Forms.ComboBox();
            this.comboBoxNewSalary = new System.Windows.Forms.ComboBox();
            this.buttonEditOperators = new System.Windows.Forms.Button();
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
            this.dgv.TabIndex = 5;
            // 
            // comboBoxEditID
            // 
            this.comboBoxEditID.FormattingEnabled = true;
            this.comboBoxEditID.Location = new System.Drawing.Point(12, 529);
            this.comboBoxEditID.Name = "comboBoxEditID";
            this.comboBoxEditID.Size = new System.Drawing.Size(170, 39);
            this.comboBoxEditID.TabIndex = 8;
            this.comboBoxEditID.Text = "ID";
            // 
            // textBoxNewPIB
            // 
            this.textBoxNewPIB.Location = new System.Drawing.Point(12, 585);
            this.textBoxNewPIB.Name = "textBoxNewPIB";
            this.textBoxNewPIB.Size = new System.Drawing.Size(750, 38);
            this.textBoxNewPIB.TabIndex = 9;
            this.textBoxNewPIB.Text = "Input PIB";
            // 
            // comboBoxNewYYYY
            // 
            this.comboBoxNewYYYY.FormattingEnabled = true;
            this.comboBoxNewYYYY.Location = new System.Drawing.Point(242, 651);
            this.comboBoxNewYYYY.Name = "comboBoxNewYYYY";
            this.comboBoxNewYYYY.Size = new System.Drawing.Size(153, 39);
            this.comboBoxNewYYYY.TabIndex = 10;
            this.comboBoxNewYYYY.Text = "YYYY";
            // 
            // comboBoxNewMM
            // 
            this.comboBoxNewMM.FormattingEnabled = true;
            this.comboBoxNewMM.Location = new System.Drawing.Point(128, 651);
            this.comboBoxNewMM.Name = "comboBoxNewMM";
            this.comboBoxNewMM.Size = new System.Drawing.Size(108, 39);
            this.comboBoxNewMM.TabIndex = 11;
            this.comboBoxNewMM.Text = "MM";
            // 
            // comboBoxNewDD
            // 
            this.comboBoxNewDD.FormattingEnabled = true;
            this.comboBoxNewDD.Location = new System.Drawing.Point(12, 651);
            this.comboBoxNewDD.Name = "comboBoxNewDD";
            this.comboBoxNewDD.Size = new System.Drawing.Size(110, 39);
            this.comboBoxNewDD.TabIndex = 12;
            this.comboBoxNewDD.Text = "DD";
            // 
            // comboBoxNewSalary
            // 
            this.comboBoxNewSalary.FormattingEnabled = true;
            this.comboBoxNewSalary.Location = new System.Drawing.Point(401, 651);
            this.comboBoxNewSalary.Name = "comboBoxNewSalary";
            this.comboBoxNewSalary.Size = new System.Drawing.Size(153, 39);
            this.comboBoxNewSalary.TabIndex = 13;
            this.comboBoxNewSalary.Text = "Salary";
            // 
            // buttonEditOperators
            // 
            this.buttonEditOperators.Location = new System.Drawing.Point(560, 644);
            this.buttonEditOperators.Name = "buttonEditOperators";
            this.buttonEditOperators.Size = new System.Drawing.Size(202, 50);
            this.buttonEditOperators.TabIndex = 14;
            this.buttonEditOperators.Text = "Edit";
            this.buttonEditOperators.UseVisualStyleBackColor = true;
            this.buttonEditOperators.Click += new System.EventHandler(this.buttonEditOperators_Click);
            // 
            // FormEditOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonEditOperators);
            this.Controls.Add(this.comboBoxNewSalary);
            this.Controls.Add(this.comboBoxNewDD);
            this.Controls.Add(this.comboBoxNewMM);
            this.Controls.Add(this.comboBoxNewYYYY);
            this.Controls.Add(this.textBoxNewPIB);
            this.Controls.Add(this.comboBoxEditID);
            this.Controls.Add(this.dgv);
            this.Name = "FormEditOperators";
            this.Text = "FormEdirOperators";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBoxEditID;
        private System.Windows.Forms.TextBox textBoxNewPIB;
        private System.Windows.Forms.ComboBox comboBoxNewYYYY;
        private System.Windows.Forms.ComboBox comboBoxNewMM;
        private System.Windows.Forms.ComboBox comboBoxNewDD;
        private System.Windows.Forms.ComboBox comboBoxNewSalary;
        private System.Windows.Forms.Button buttonEditOperators;
    }
}