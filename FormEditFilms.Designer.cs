namespace WindowsFormsApp1
{
    partial class FormEditFilms
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
            this.comboBoxFilmsEdit = new System.Windows.Forms.ComboBox();
            this.textBoxNewFilmsName = new System.Windows.Forms.TextBox();
            this.comboBoxNewFilmsGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxNewFilmsHH = new System.Windows.Forms.ComboBox();
            this.comboBoxNewFilmsMM = new System.Windows.Forms.ComboBox();
            this.buttonEditFilm = new System.Windows.Forms.Button();
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
            // comboBoxFilmsEdit
            // 
            this.comboBoxFilmsEdit.FormattingEnabled = true;
            this.comboBoxFilmsEdit.Location = new System.Drawing.Point(12, 528);
            this.comboBoxFilmsEdit.Name = "comboBoxFilmsEdit";
            this.comboBoxFilmsEdit.Size = new System.Drawing.Size(376, 39);
            this.comboBoxFilmsEdit.TabIndex = 3;
            this.comboBoxFilmsEdit.Text = "Select film";
            // 
            // textBoxNewFilmsName
            // 
            this.textBoxNewFilmsName.Location = new System.Drawing.Point(12, 582);
            this.textBoxNewFilmsName.Name = "textBoxNewFilmsName";
            this.textBoxNewFilmsName.Size = new System.Drawing.Size(300, 38);
            this.textBoxNewFilmsName.TabIndex = 4;
            this.textBoxNewFilmsName.Text = "Input films name";
            // 
            // comboBoxNewFilmsGenre
            // 
            this.comboBoxNewFilmsGenre.FormattingEnabled = true;
            this.comboBoxNewFilmsGenre.Location = new System.Drawing.Point(318, 582);
            this.comboBoxNewFilmsGenre.Name = "comboBoxNewFilmsGenre";
            this.comboBoxNewFilmsGenre.Size = new System.Drawing.Size(209, 39);
            this.comboBoxNewFilmsGenre.TabIndex = 5;
            this.comboBoxNewFilmsGenre.Text = "Genre";
            // 
            // comboBoxNewFilmsHH
            // 
            this.comboBoxNewFilmsHH.FormattingEnabled = true;
            this.comboBoxNewFilmsHH.Location = new System.Drawing.Point(533, 582);
            this.comboBoxNewFilmsHH.Name = "comboBoxNewFilmsHH";
            this.comboBoxNewFilmsHH.Size = new System.Drawing.Size(110, 39);
            this.comboBoxNewFilmsHH.TabIndex = 6;
            this.comboBoxNewFilmsHH.Text = "HH";
            // 
            // comboBoxNewFilmsMM
            // 
            this.comboBoxNewFilmsMM.FormattingEnabled = true;
            this.comboBoxNewFilmsMM.Location = new System.Drawing.Point(649, 581);
            this.comboBoxNewFilmsMM.Name = "comboBoxNewFilmsMM";
            this.comboBoxNewFilmsMM.Size = new System.Drawing.Size(110, 39);
            this.comboBoxNewFilmsMM.TabIndex = 7;
            this.comboBoxNewFilmsMM.Text = "MM";
            // 
            // buttonEditFilm
            // 
            this.buttonEditFilm.Location = new System.Drawing.Point(12, 627);
            this.buttonEditFilm.Name = "buttonEditFilm";
            this.buttonEditFilm.Size = new System.Drawing.Size(750, 45);
            this.buttonEditFilm.TabIndex = 8;
            this.buttonEditFilm.Text = "Edit Film";
            this.buttonEditFilm.UseVisualStyleBackColor = true;
            this.buttonEditFilm.Click += new System.EventHandler(this.buttonEditFilm_Click);
            // 
            // FormEditFilms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1968, 912);
            this.Controls.Add(this.buttonEditFilm);
            this.Controls.Add(this.comboBoxNewFilmsMM);
            this.Controls.Add(this.comboBoxNewFilmsHH);
            this.Controls.Add(this.comboBoxNewFilmsGenre);
            this.Controls.Add(this.textBoxNewFilmsName);
            this.Controls.Add(this.comboBoxFilmsEdit);
            this.Controls.Add(this.dgv);
            this.Name = "FormEditFilms";
            this.Text = "Edit Films";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox comboBoxFilmsEdit;
        private System.Windows.Forms.TextBox textBoxNewFilmsName;
        private System.Windows.Forms.ComboBox comboBoxNewFilmsGenre;
        private System.Windows.Forms.ComboBox comboBoxNewFilmsHH;
        private System.Windows.Forms.ComboBox comboBoxNewFilmsMM;
        private System.Windows.Forms.Button buttonEditFilm;
    }
}