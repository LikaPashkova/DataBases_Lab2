namespace WindowsFormsApp1
{
    partial class FormAddSessions
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
            this.comboBoxFilmsName = new System.Windows.Forms.ComboBox();
            this.comboBoxMM = new System.Windows.Forms.ComboBox();
            this.comboBoxHH = new System.Windows.Forms.ComboBox();
            this.comboBoxHallsID = new System.Windows.Forms.ComboBox();
            this.comboBox3D = new System.Windows.Forms.ComboBox();
            this.comboBoxPrice = new System.Windows.Forms.ComboBox();
            this.comboBoxOperatorsID = new System.Windows.Forms.ComboBox();
            this.buttonAddSessions = new System.Windows.Forms.Button();
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
            this.dgv.Size = new System.Drawing.Size(1000, 500);
            this.dgv.TabIndex = 2;
            // 
            // comboBoxFilmsName
            // 
            this.comboBoxFilmsName.FormattingEnabled = true;
            this.comboBoxFilmsName.Location = new System.Drawing.Point(12, 518);
            this.comboBoxFilmsName.Name = "comboBoxFilmsName";
            this.comboBoxFilmsName.Size = new System.Drawing.Size(196, 39);
            this.comboBoxFilmsName.TabIndex = 8;
            this.comboBoxFilmsName.Text = "Films Name";
            // 
            // comboBoxMM
            // 
            this.comboBoxMM.FormattingEnabled = true;
            this.comboBoxMM.Location = new System.Drawing.Point(326, 518);
            this.comboBoxMM.Name = "comboBoxMM";
            this.comboBoxMM.Size = new System.Drawing.Size(110, 39);
            this.comboBoxMM.TabIndex = 9;
            this.comboBoxMM.Text = "MM";
            // 
            // comboBoxHH
            // 
            this.comboBoxHH.FormattingEnabled = true;
            this.comboBoxHH.Location = new System.Drawing.Point(214, 518);
            this.comboBoxHH.Name = "comboBoxHH";
            this.comboBoxHH.Size = new System.Drawing.Size(106, 39);
            this.comboBoxHH.TabIndex = 10;
            this.comboBoxHH.Text = "HH";
            // 
            // comboBoxHallsID
            // 
            this.comboBoxHallsID.FormattingEnabled = true;
            this.comboBoxHallsID.Location = new System.Drawing.Point(442, 518);
            this.comboBoxHallsID.Name = "comboBoxHallsID";
            this.comboBoxHallsID.Size = new System.Drawing.Size(110, 39);
            this.comboBoxHallsID.TabIndex = 11;
            this.comboBoxHallsID.Text = "Hall";
            // 
            // comboBox3D
            // 
            this.comboBox3D.FormattingEnabled = true;
            this.comboBox3D.Location = new System.Drawing.Point(558, 518);
            this.comboBox3D.Name = "comboBox3D";
            this.comboBox3D.Size = new System.Drawing.Size(142, 39);
            this.comboBox3D.TabIndex = 12;
            this.comboBox3D.Text = "3D";
            // 
            // comboBoxPrice
            // 
            this.comboBoxPrice.FormattingEnabled = true;
            this.comboBoxPrice.Location = new System.Drawing.Point(706, 518);
            this.comboBoxPrice.Name = "comboBoxPrice";
            this.comboBoxPrice.Size = new System.Drawing.Size(142, 39);
            this.comboBoxPrice.TabIndex = 13;
            this.comboBoxPrice.Text = "Price";
            // 
            // comboBoxOperatorsID
            // 
            this.comboBoxOperatorsID.FormattingEnabled = true;
            this.comboBoxOperatorsID.Location = new System.Drawing.Point(854, 518);
            this.comboBoxOperatorsID.Name = "comboBoxOperatorsID";
            this.comboBoxOperatorsID.Size = new System.Drawing.Size(158, 39);
            this.comboBoxOperatorsID.TabIndex = 14;
            this.comboBoxOperatorsID.Text = "Operator";
            // 
            // buttonAddSessions
            // 
            this.buttonAddSessions.Location = new System.Drawing.Point(21, 576);
            this.buttonAddSessions.Name = "buttonAddSessions";
            this.buttonAddSessions.Size = new System.Drawing.Size(991, 50);
            this.buttonAddSessions.TabIndex = 15;
            this.buttonAddSessions.Text = "Add";
            this.buttonAddSessions.UseVisualStyleBackColor = true;
            this.buttonAddSessions.Click += new System.EventHandler(this.buttonAddSessions_Click);
            // 
            // FormAddSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonAddSessions);
            this.Controls.Add(this.comboBoxOperatorsID);
            this.Controls.Add(this.comboBoxPrice);
            this.Controls.Add(this.comboBox3D);
            this.Controls.Add(this.comboBoxHallsID);
            this.Controls.Add(this.comboBoxHH);
            this.Controls.Add(this.comboBoxMM);
            this.Controls.Add(this.comboBoxFilmsName);
            this.Controls.Add(this.dgv);
            this.Name = "FormAddSessions";
            this.Text = "Add Sessions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBoxFilmsName;
        private System.Windows.Forms.ComboBox comboBoxMM;
        private System.Windows.Forms.ComboBox comboBoxHH;
        private System.Windows.Forms.ComboBox comboBoxHallsID;
        private System.Windows.Forms.ComboBox comboBox3D;
        private System.Windows.Forms.ComboBox comboBoxPrice;
        private System.Windows.Forms.ComboBox comboBoxOperatorsID;
        private System.Windows.Forms.Button buttonAddSessions;
    }
}