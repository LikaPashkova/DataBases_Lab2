namespace WindowsFormsApp1
{
    partial class FormDeleteOperators
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
            this.comboBoxDeleteID = new System.Windows.Forms.ComboBox();
            this.buttonDeleteOperators = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 40;
            this.dgv.Size = new System.Drawing.Size(750, 500);
            this.dgv.TabIndex = 4;
            // 
            // comboBoxDeleteID
            // 
            this.comboBoxDeleteID.FormattingEnabled = true;
            this.comboBoxDeleteID.Location = new System.Drawing.Point(12, 512);
            this.comboBoxDeleteID.Name = "comboBoxDeleteID";
            this.comboBoxDeleteID.Size = new System.Drawing.Size(170, 39);
            this.comboBoxDeleteID.TabIndex = 7;
            this.comboBoxDeleteID.Text = "ID";
            // 
            // buttonDeleteOperators
            // 
            this.buttonDeleteOperators.Location = new System.Drawing.Point(188, 505);
            this.buttonDeleteOperators.Name = "buttonDeleteOperators";
            this.buttonDeleteOperators.Size = new System.Drawing.Size(574, 50);
            this.buttonDeleteOperators.TabIndex = 11;
            this.buttonDeleteOperators.Text = "Delete";
            this.buttonDeleteOperators.UseVisualStyleBackColor = true;
            this.buttonDeleteOperators.Click += new System.EventHandler(this.buttonDeleteOperators_Click);
            // 
            // FormDeleteOperators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonDeleteOperators);
            this.Controls.Add(this.comboBoxDeleteID);
            this.Controls.Add(this.dgv);
            this.Name = "FormDeleteOperators";
            this.Text = "Delete Operators";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBoxDeleteID;
        private System.Windows.Forms.Button buttonDeleteOperators;
    }
}