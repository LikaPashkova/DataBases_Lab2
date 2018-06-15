namespace WindowsFormsApp1
{
    partial class FormEditSessions
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
            this.comboBoxNewFilmsName = new System.Windows.Forms.ComboBox();
            this.comboBoxNewHH = new System.Windows.Forms.ComboBox();
            this.comboBoxNewMM = new System.Windows.Forms.ComboBox();
            this.comboBoxNewHallsID = new System.Windows.Forms.ComboBox();
            this.comboBoxNew3D = new System.Windows.Forms.ComboBox();
            this.comboBoxNewPrice = new System.Windows.Forms.ComboBox();
            this.comboBoxNewOperatorsID = new System.Windows.Forms.ComboBox();
            this.buttonEditSessions = new System.Windows.Forms.Button();
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
            this.dgv.TabIndex = 3;
            // 
            // comboBoxEditID
            // 
            this.comboBoxEditID.FormattingEnabled = true;
            this.comboBoxEditID.Location = new System.Drawing.Point(12, 532);
            this.comboBoxEditID.Name = "comboBoxEditID";
            this.comboBoxEditID.Size = new System.Drawing.Size(170, 39);
            this.comboBoxEditID.TabIndex = 8;
            this.comboBoxEditID.Text = "ID";
            // 
            // comboBoxNewFilmsName
            // 
            this.comboBoxNewFilmsName.FormattingEnabled = true;
            this.comboBoxNewFilmsName.Location = new System.Drawing.Point(12, 591);
            this.comboBoxNewFilmsName.Name = "comboBoxNewFilmsName";
            this.comboBoxNewFilmsName.Size = new System.Drawing.Size(196, 39);
            this.comboBoxNewFilmsName.TabIndex = 9;
            this.comboBoxNewFilmsName.Text = "Films Name";
            // 
            // comboBoxNewHH
            // 
            this.comboBoxNewHH.FormattingEnabled = true;
            this.comboBoxNewHH.Location = new System.Drawing.Point(214, 591);
            this.comboBoxNewHH.Name = "comboBoxNewHH";
            this.comboBoxNewHH.Size = new System.Drawing.Size(106, 39);
            this.comboBoxNewHH.TabIndex = 11;
            this.comboBoxNewHH.Text = "HH";
            // 
            // comboBoxNewMM
            // 
            this.comboBoxNewMM.FormattingEnabled = true;
            this.comboBoxNewMM.Location = new System.Drawing.Point(326, 591);
            this.comboBoxNewMM.Name = "comboBoxNewMM";
            this.comboBoxNewMM.Size = new System.Drawing.Size(110, 39);
            this.comboBoxNewMM.TabIndex = 12;
            this.comboBoxNewMM.Text = "MM";
            // 
            // comboBoxNewHallsID
            // 
            this.comboBoxNewHallsID.FormattingEnabled = true;
            this.comboBoxNewHallsID.Location = new System.Drawing.Point(442, 591);
            this.comboBoxNewHallsID.Name = "comboBoxNewHallsID";
            this.comboBoxNewHallsID.Size = new System.Drawing.Size(110, 39);
            this.comboBoxNewHallsID.TabIndex = 13;
            this.comboBoxNewHallsID.Text = "Hall";
            // 
            // comboBoxNew3D
            // 
            this.comboBoxNew3D.FormattingEnabled = true;
            this.comboBoxNew3D.Location = new System.Drawing.Point(558, 591);
            this.comboBoxNew3D.Name = "comboBoxNew3D";
            this.comboBoxNew3D.Size = new System.Drawing.Size(142, 39);
            this.comboBoxNew3D.TabIndex = 14;
            this.comboBoxNew3D.Text = "3D";
            // 
            // comboBoxNewPrice
            // 
            this.comboBoxNewPrice.FormattingEnabled = true;
            this.comboBoxNewPrice.Location = new System.Drawing.Point(706, 591);
            this.comboBoxNewPrice.Name = "comboBoxNewPrice";
            this.comboBoxNewPrice.Size = new System.Drawing.Size(142, 39);
            this.comboBoxNewPrice.TabIndex = 15;
            this.comboBoxNewPrice.Text = "Price";
            // 
            // comboBoxNewOperatorsID
            // 
            this.comboBoxNewOperatorsID.FormattingEnabled = true;
            this.comboBoxNewOperatorsID.Location = new System.Drawing.Point(854, 591);
            this.comboBoxNewOperatorsID.Name = "comboBoxNewOperatorsID";
            this.comboBoxNewOperatorsID.Size = new System.Drawing.Size(158, 39);
            this.comboBoxNewOperatorsID.TabIndex = 16;
            this.comboBoxNewOperatorsID.Text = "Operator";
            // 
            // buttonEditSessions
            // 
            this.buttonEditSessions.Location = new System.Drawing.Point(12, 660);
            this.buttonEditSessions.Name = "buttonEditSessions";
            this.buttonEditSessions.Size = new System.Drawing.Size(1000, 50);
            this.buttonEditSessions.TabIndex = 17;
            this.buttonEditSessions.Text = "Edit";
            this.buttonEditSessions.UseVisualStyleBackColor = true;
            this.buttonEditSessions.Click += new System.EventHandler(this.buttonEditSessions_Click);
            // 
            // FormEditSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonEditSessions);
            this.Controls.Add(this.comboBoxNewOperatorsID);
            this.Controls.Add(this.comboBoxNewPrice);
            this.Controls.Add(this.comboBoxNew3D);
            this.Controls.Add(this.comboBoxNewHallsID);
            this.Controls.Add(this.comboBoxNewMM);
            this.Controls.Add(this.comboBoxNewHH);
            this.Controls.Add(this.comboBoxNewFilmsName);
            this.Controls.Add(this.comboBoxEditID);
            this.Controls.Add(this.dgv);
            this.Name = "FormEditSessions";
            this.Text = "Edit Sessions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBoxEditID;
        private System.Windows.Forms.ComboBox comboBoxNewFilmsName;
        private System.Windows.Forms.ComboBox comboBoxNewHH;
        private System.Windows.Forms.ComboBox comboBoxNewMM;
        private System.Windows.Forms.ComboBox comboBoxNewHallsID;
        private System.Windows.Forms.ComboBox comboBoxNew3D;
        private System.Windows.Forms.ComboBox comboBoxNewPrice;
        private System.Windows.Forms.ComboBox comboBoxNewOperatorsID;
        private System.Windows.Forms.Button buttonEditSessions;
    }
}