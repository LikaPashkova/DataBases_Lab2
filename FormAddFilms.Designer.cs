namespace WindowsFormsApp1
{
    partial class FormAddFilms
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
            this.textBoxFilmsName = new System.Windows.Forms.TextBox();
            this.comboBoxFilmsGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxFilmsHH = new System.Windows.Forms.ComboBox();
            this.comboBoxFilmsMM = new System.Windows.Forms.ComboBox();
            this.buttonAddFilm = new System.Windows.Forms.Button();
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
            // textBoxFilmsName
            // 
            this.textBoxFilmsName.Location = new System.Drawing.Point(12, 532);
            this.textBoxFilmsName.Name = "textBoxFilmsName";
            this.textBoxFilmsName.Size = new System.Drawing.Size(300, 38);
            this.textBoxFilmsName.TabIndex = 2;
            this.textBoxFilmsName.Text = "Input films name";
            // 
            // comboBoxFilmsGenre
            // 
            this.comboBoxFilmsGenre.FormattingEnabled = true;
            this.comboBoxFilmsGenre.Location = new System.Drawing.Point(318, 532);
            this.comboBoxFilmsGenre.Name = "comboBoxFilmsGenre";
            this.comboBoxFilmsGenre.Size = new System.Drawing.Size(209, 39);
            this.comboBoxFilmsGenre.TabIndex = 3;
            this.comboBoxFilmsGenre.Text = "Genre";
            // 
            // comboBoxFilmsHH
            // 
            this.comboBoxFilmsHH.FormattingEnabled = true;
            this.comboBoxFilmsHH.Location = new System.Drawing.Point(533, 532);
            this.comboBoxFilmsHH.Name = "comboBoxFilmsHH";
            this.comboBoxFilmsHH.Size = new System.Drawing.Size(110, 39);
            this.comboBoxFilmsHH.TabIndex = 4;
            this.comboBoxFilmsHH.Text = "HH";
            // 
            // comboBoxFilmsMM
            // 
            this.comboBoxFilmsMM.FormattingEnabled = true;
            this.comboBoxFilmsMM.Location = new System.Drawing.Point(649, 531);
            this.comboBoxFilmsMM.Name = "comboBoxFilmsMM";
            this.comboBoxFilmsMM.Size = new System.Drawing.Size(110, 39);
            this.comboBoxFilmsMM.TabIndex = 5;
            this.comboBoxFilmsMM.Text = "MM";
            // 
            // buttonAddFilm
            // 
            this.buttonAddFilm.Location = new System.Drawing.Point(12, 577);
            this.buttonAddFilm.Name = "buttonAddFilm";
            this.buttonAddFilm.Size = new System.Drawing.Size(750, 45);
            this.buttonAddFilm.TabIndex = 6;
            this.buttonAddFilm.Text = "Add Film";
            this.buttonAddFilm.UseVisualStyleBackColor = true;
            this.buttonAddFilm.Click += new System.EventHandler(this.buttonAddFilm_Click);
            // 
            // FormAddFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonAddFilm);
            this.Controls.Add(this.comboBoxFilmsMM);
            this.Controls.Add(this.comboBoxFilmsHH);
            this.Controls.Add(this.comboBoxFilmsGenre);
            this.Controls.Add(this.textBoxFilmsName);
            this.Controls.Add(this.dgv);
            this.Name = "FormAddFilms";
            this.Text = "Add Films";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox textBoxFilmsName;
        private System.Windows.Forms.ComboBox comboBoxFilmsGenre;
        private System.Windows.Forms.ComboBox comboBoxFilmsHH;
        private System.Windows.Forms.ComboBox comboBoxFilmsMM;
        private System.Windows.Forms.Button buttonAddFilm;
    }
}