namespace WindowsFormsApp1
{
    partial class FormDeleteFilms
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
            this.comboBoxFilmsDelete = new System.Windows.Forms.ComboBox();
            this.buttonFilmsDelete = new System.Windows.Forms.Button();
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
            this.dgv.TabIndex = 1;
            // 
            // comboBoxFilmsDelete
            // 
            this.comboBoxFilmsDelete.FormattingEnabled = true;
            this.comboBoxFilmsDelete.Location = new System.Drawing.Point(12, 525);
            this.comboBoxFilmsDelete.Name = "comboBoxFilmsDelete";
            this.comboBoxFilmsDelete.Size = new System.Drawing.Size(376, 39);
            this.comboBoxFilmsDelete.TabIndex = 2;
            this.comboBoxFilmsDelete.Text = "Select film";
            // 
            // buttonFilmsDelete
            // 
            this.buttonFilmsDelete.Location = new System.Drawing.Point(392, 518);
            this.buttonFilmsDelete.Name = "buttonFilmsDelete";
            this.buttonFilmsDelete.Size = new System.Drawing.Size(369, 50);
            this.buttonFilmsDelete.TabIndex = 3;
            this.buttonFilmsDelete.Text = "Delete";
            this.buttonFilmsDelete.UseVisualStyleBackColor = true;
            this.buttonFilmsDelete.Click += new System.EventHandler(this.buttonFilmsDelete_Click);
            // 
            // FormDeleteFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonFilmsDelete);
            this.Controls.Add(this.comboBoxFilmsDelete);
            this.Controls.Add(this.dgv);
            this.Name = "FormDeleteFilms";
            this.Text = "Delete Films";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBoxFilmsDelete;
        private System.Windows.Forms.Button buttonFilmsDelete;
    }
}