namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.bDeleteFilms = new System.Windows.Forms.Button();
            this.bAddFilms = new System.Windows.Forms.Button();
            this.bEditFilms = new System.Windows.Forms.Button();
            this.bEditSessions = new System.Windows.Forms.Button();
            this.bEditOperators = new System.Windows.Forms.Button();
            this.bEditHalls = new System.Windows.Forms.Button();
            this.bAddSessions = new System.Windows.Forms.Button();
            this.bAddOperators = new System.Windows.Forms.Button();
            this.bAddHalls = new System.Windows.Forms.Button();
            this.bDeleteSessions = new System.Windows.Forms.Button();
            this.bDeleteOperators = new System.Windows.Forms.Button();
            this.bDeleteHalls = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_action = new System.Windows.Forms.CheckBox();
            this.cb_adventure = new System.Windows.Forms.CheckBox();
            this.cb_comedy = new System.Windows.Forms.CheckBox();
            this.cb_cartoon = new System.Windows.Forms.CheckBox();
            this.cb_drama = new System.Windows.Forms.CheckBox();
            this.cb_historical = new System.Windows.Forms.CheckBox();
            this.cb_horror = new System.Windows.Forms.CheckBox();
            this.cb_dance = new System.Windows.Forms.CheckBox();
            this.cb_war = new System.Windows.Forms.CheckBox();
            this.cb_westerns = new System.Windows.Forms.CheckBox();
            this.b_okSearch = new System.Windows.Forms.Button();
            this.cb_2d = new System.Windows.Forms.CheckBox();
            this.cb_3d = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_mustIn = new System.Windows.Forms.TextBox();
            this.tb_mustNotIn = new System.Windows.Forms.TextBox();
            this.but_Import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2210, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonFilmsShow_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(28, 23);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 40;
            this.dgv.Size = new System.Drawing.Size(1500, 1000);
            this.dgv.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2210, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonHallsShow_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2210, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonOperatorsShow_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(2210, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonSessionsShow_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(2035, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(170, 38);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Films";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(2035, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(170, 38);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Halls";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(2035, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(170, 38);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Sessions";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(2035, 175);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(170, 38);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "Operators";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bDeleteFilms
            // 
            this.bDeleteFilms.Location = new System.Drawing.Point(2735, 65);
            this.bDeleteFilms.Name = "bDeleteFilms";
            this.bDeleteFilms.Size = new System.Drawing.Size(170, 50);
            this.bDeleteFilms.TabIndex = 11;
            this.bDeleteFilms.Text = "Delete";
            this.bDeleteFilms.UseVisualStyleBackColor = true;
            this.bDeleteFilms.Click += new System.EventHandler(this.bDeleteFilms_Click);
            // 
            // bAddFilms
            // 
            this.bAddFilms.Location = new System.Drawing.Point(2560, 65);
            this.bAddFilms.Name = "bAddFilms";
            this.bAddFilms.Size = new System.Drawing.Size(170, 50);
            this.bAddFilms.TabIndex = 12;
            this.bAddFilms.Text = "Add";
            this.bAddFilms.UseVisualStyleBackColor = true;
            this.bAddFilms.Click += new System.EventHandler(this.bAddFilms_Click);
            // 
            // bEditFilms
            // 
            this.bEditFilms.Location = new System.Drawing.Point(2385, 65);
            this.bEditFilms.Name = "bEditFilms";
            this.bEditFilms.Size = new System.Drawing.Size(170, 50);
            this.bEditFilms.TabIndex = 13;
            this.bEditFilms.Text = "Edit";
            this.bEditFilms.UseVisualStyleBackColor = true;
            this.bEditFilms.Click += new System.EventHandler(this.bEditFilms_Click);
            // 
            // bEditSessions
            // 
            this.bEditSessions.Location = new System.Drawing.Point(2385, 230);
            this.bEditSessions.Name = "bEditSessions";
            this.bEditSessions.Size = new System.Drawing.Size(170, 50);
            this.bEditSessions.TabIndex = 14;
            this.bEditSessions.Text = "Edit";
            this.bEditSessions.UseVisualStyleBackColor = true;
            this.bEditSessions.Click += new System.EventHandler(this.bEditSessions_Click);
            // 
            // bEditOperators
            // 
            this.bEditOperators.Location = new System.Drawing.Point(2385, 175);
            this.bEditOperators.Name = "bEditOperators";
            this.bEditOperators.Size = new System.Drawing.Size(170, 50);
            this.bEditOperators.TabIndex = 15;
            this.bEditOperators.Text = "Edit";
            this.bEditOperators.UseVisualStyleBackColor = true;
            this.bEditOperators.Click += new System.EventHandler(this.bEditOperators_Click);
            // 
            // bEditHalls
            // 
            this.bEditHalls.Location = new System.Drawing.Point(2385, 120);
            this.bEditHalls.Name = "bEditHalls";
            this.bEditHalls.Size = new System.Drawing.Size(170, 50);
            this.bEditHalls.TabIndex = 16;
            this.bEditHalls.Text = "Edit";
            this.bEditHalls.UseVisualStyleBackColor = true;
            this.bEditHalls.Click += new System.EventHandler(this.bEditHalls_Click);
            // 
            // bAddSessions
            // 
            this.bAddSessions.Location = new System.Drawing.Point(2560, 230);
            this.bAddSessions.Name = "bAddSessions";
            this.bAddSessions.Size = new System.Drawing.Size(170, 50);
            this.bAddSessions.TabIndex = 17;
            this.bAddSessions.Text = "Add";
            this.bAddSessions.UseVisualStyleBackColor = true;
            this.bAddSessions.Click += new System.EventHandler(this.bAddSessions_Click);
            // 
            // bAddOperators
            // 
            this.bAddOperators.Location = new System.Drawing.Point(2560, 175);
            this.bAddOperators.Name = "bAddOperators";
            this.bAddOperators.Size = new System.Drawing.Size(170, 50);
            this.bAddOperators.TabIndex = 18;
            this.bAddOperators.Text = "Add";
            this.bAddOperators.UseVisualStyleBackColor = true;
            this.bAddOperators.Click += new System.EventHandler(this.bAddOperators_Click);
            // 
            // bAddHalls
            // 
            this.bAddHalls.Location = new System.Drawing.Point(2560, 120);
            this.bAddHalls.Name = "bAddHalls";
            this.bAddHalls.Size = new System.Drawing.Size(170, 50);
            this.bAddHalls.TabIndex = 19;
            this.bAddHalls.Text = "Add";
            this.bAddHalls.UseVisualStyleBackColor = true;
            this.bAddHalls.Click += new System.EventHandler(this.bAddHalls_Click);
            // 
            // bDeleteSessions
            // 
            this.bDeleteSessions.Location = new System.Drawing.Point(2735, 230);
            this.bDeleteSessions.Name = "bDeleteSessions";
            this.bDeleteSessions.Size = new System.Drawing.Size(170, 50);
            this.bDeleteSessions.TabIndex = 20;
            this.bDeleteSessions.Text = "Delete";
            this.bDeleteSessions.UseVisualStyleBackColor = true;
            this.bDeleteSessions.Click += new System.EventHandler(this.bDeleteSessions_Click);
            // 
            // bDeleteOperators
            // 
            this.bDeleteOperators.Location = new System.Drawing.Point(2735, 175);
            this.bDeleteOperators.Name = "bDeleteOperators";
            this.bDeleteOperators.Size = new System.Drawing.Size(170, 50);
            this.bDeleteOperators.TabIndex = 21;
            this.bDeleteOperators.Text = "Delete";
            this.bDeleteOperators.UseVisualStyleBackColor = true;
            this.bDeleteOperators.Click += new System.EventHandler(this.bDeleteOperators_Click);
            // 
            // bDeleteHalls
            // 
            this.bDeleteHalls.Location = new System.Drawing.Point(2735, 120);
            this.bDeleteHalls.Name = "bDeleteHalls";
            this.bDeleteHalls.Size = new System.Drawing.Size(170, 50);
            this.bDeleteHalls.TabIndex = 22;
            this.bDeleteHalls.Text = "Delete";
            this.bDeleteHalls.UseVisualStyleBackColor = true;
            this.bDeleteHalls.Click += new System.EventHandler(this.bDeleteHalls_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2071, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2067, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tables:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2045, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 32);
            this.label3.TabIndex = 27;
            this.label3.Text = "Genre:";
            // 
            // cb_action
            // 
            this.cb_action.AutoSize = true;
            this.cb_action.Location = new System.Drawing.Point(2043, 440);
            this.cb_action.Name = "cb_action";
            this.cb_action.Size = new System.Drawing.Size(130, 36);
            this.cb_action.TabIndex = 28;
            this.cb_action.Text = "action";
            this.cb_action.UseVisualStyleBackColor = true;
            // 
            // cb_adventure
            // 
            this.cb_adventure.AutoSize = true;
            this.cb_adventure.Location = new System.Drawing.Point(2043, 482);
            this.cb_adventure.Name = "cb_adventure";
            this.cb_adventure.Size = new System.Drawing.Size(180, 36);
            this.cb_adventure.TabIndex = 29;
            this.cb_adventure.Text = "adventure";
            this.cb_adventure.UseVisualStyleBackColor = true;
            // 
            // cb_comedy
            // 
            this.cb_comedy.AutoSize = true;
            this.cb_comedy.Location = new System.Drawing.Point(2043, 524);
            this.cb_comedy.Name = "cb_comedy";
            this.cb_comedy.Size = new System.Drawing.Size(152, 36);
            this.cb_comedy.TabIndex = 30;
            this.cb_comedy.Text = "comedy";
            this.cb_comedy.UseVisualStyleBackColor = true;
            // 
            // cb_cartoon
            // 
            this.cb_cartoon.AutoSize = true;
            this.cb_cartoon.Location = new System.Drawing.Point(2043, 566);
            this.cb_cartoon.Name = "cb_cartoon";
            this.cb_cartoon.Size = new System.Drawing.Size(148, 36);
            this.cb_cartoon.TabIndex = 31;
            this.cb_cartoon.Text = "cartoon";
            this.cb_cartoon.UseVisualStyleBackColor = true;
            // 
            // cb_drama
            // 
            this.cb_drama.AutoSize = true;
            this.cb_drama.Location = new System.Drawing.Point(2043, 608);
            this.cb_drama.Name = "cb_drama";
            this.cb_drama.Size = new System.Drawing.Size(133, 36);
            this.cb_drama.TabIndex = 32;
            this.cb_drama.Text = "drama";
            this.cb_drama.UseVisualStyleBackColor = true;
            // 
            // cb_historical
            // 
            this.cb_historical.AutoSize = true;
            this.cb_historical.Location = new System.Drawing.Point(2043, 650);
            this.cb_historical.Name = "cb_historical";
            this.cb_historical.Size = new System.Drawing.Size(167, 36);
            this.cb_historical.TabIndex = 33;
            this.cb_historical.Text = "historical";
            this.cb_historical.UseVisualStyleBackColor = true;
            // 
            // cb_horror
            // 
            this.cb_horror.AutoSize = true;
            this.cb_horror.Location = new System.Drawing.Point(2043, 692);
            this.cb_horror.Name = "cb_horror";
            this.cb_horror.Size = new System.Drawing.Size(128, 36);
            this.cb_horror.TabIndex = 34;
            this.cb_horror.Text = "horror";
            this.cb_horror.UseVisualStyleBackColor = true;
            // 
            // cb_dance
            // 
            this.cb_dance.AutoSize = true;
            this.cb_dance.Location = new System.Drawing.Point(2043, 734);
            this.cb_dance.Name = "cb_dance";
            this.cb_dance.Size = new System.Drawing.Size(131, 36);
            this.cb_dance.TabIndex = 35;
            this.cb_dance.Text = "dance";
            this.cb_dance.UseVisualStyleBackColor = true;
            // 
            // cb_war
            // 
            this.cb_war.AutoSize = true;
            this.cb_war.Location = new System.Drawing.Point(2043, 776);
            this.cb_war.Name = "cb_war";
            this.cb_war.Size = new System.Drawing.Size(98, 36);
            this.cb_war.TabIndex = 36;
            this.cb_war.Text = "war";
            this.cb_war.UseVisualStyleBackColor = true;
            // 
            // cb_westerns
            // 
            this.cb_westerns.AutoSize = true;
            this.cb_westerns.Location = new System.Drawing.Point(2043, 818);
            this.cb_westerns.Name = "cb_westerns";
            this.cb_westerns.Size = new System.Drawing.Size(166, 36);
            this.cb_westerns.TabIndex = 37;
            this.cb_westerns.Text = "westerns";
            this.cb_westerns.UseVisualStyleBackColor = true;
            // 
            // b_okSearch
            // 
            this.b_okSearch.Location = new System.Drawing.Point(2041, 944);
            this.b_okSearch.Name = "b_okSearch";
            this.b_okSearch.Size = new System.Drawing.Size(143, 65);
            this.b_okSearch.TabIndex = 38;
            this.b_okSearch.Text = "OK";
            this.b_okSearch.UseVisualStyleBackColor = true;
            this.b_okSearch.Click += new System.EventHandler(this.b_okSearch_Click);
            // 
            // cb_2d
            // 
            this.cb_2d.AutoSize = true;
            this.cb_2d.Location = new System.Drawing.Point(2043, 860);
            this.cb_2d.Name = "cb_2d";
            this.cb_2d.Size = new System.Drawing.Size(89, 36);
            this.cb_2d.TabIndex = 39;
            this.cb_2d.Text = "2D";
            this.cb_2d.UseVisualStyleBackColor = true;
            // 
            // cb_3d
            // 
            this.cb_3d.AutoSize = true;
            this.cb_3d.Location = new System.Drawing.Point(2043, 902);
            this.cb_3d.Name = "cb_3d";
            this.cb_3d.Size = new System.Drawing.Size(89, 36);
            this.cb_3d.TabIndex = 40;
            this.cb_3d.Text = "3D";
            this.cb_3d.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2373, 639);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 41;
            this.label4.Text = "Must in";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2373, 738);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 42;
            this.label5.Text = "Must not in";
            // 
            // tb_mustIn
            // 
            this.tb_mustIn.Location = new System.Drawing.Point(2379, 690);
            this.tb_mustIn.Name = "tb_mustIn";
            this.tb_mustIn.Size = new System.Drawing.Size(219, 38);
            this.tb_mustIn.TabIndex = 43;
            // 
            // tb_mustNotIn
            // 
            this.tb_mustNotIn.Location = new System.Drawing.Point(2379, 788);
            this.tb_mustNotIn.Name = "tb_mustNotIn";
            this.tb_mustNotIn.Size = new System.Drawing.Size(219, 38);
            this.tb_mustNotIn.TabIndex = 44;
            // 
            // but_Import
            // 
            this.but_Import.Location = new System.Drawing.Point(28, 1074);
            this.but_Import.Name = "but_Import";
            this.but_Import.Size = new System.Drawing.Size(143, 65);
            this.but_Import.TabIndex = 45;
            this.but_Import.Text = "Import";
            this.but_Import.UseVisualStyleBackColor = true;
            this.but_Import.Click += new System.EventHandler(this.but_Import_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2956, 1412);
            this.Controls.Add(this.but_Import);
            this.Controls.Add(this.tb_mustNotIn);
            this.Controls.Add(this.tb_mustIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_3d);
            this.Controls.Add(this.cb_2d);
            this.Controls.Add(this.b_okSearch);
            this.Controls.Add(this.cb_westerns);
            this.Controls.Add(this.cb_war);
            this.Controls.Add(this.cb_dance);
            this.Controls.Add(this.cb_horror);
            this.Controls.Add(this.cb_historical);
            this.Controls.Add(this.cb_drama);
            this.Controls.Add(this.cb_cartoon);
            this.Controls.Add(this.cb_comedy);
            this.Controls.Add(this.cb_adventure);
            this.Controls.Add(this.cb_action);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDeleteHalls);
            this.Controls.Add(this.bDeleteOperators);
            this.Controls.Add(this.bDeleteSessions);
            this.Controls.Add(this.bAddHalls);
            this.Controls.Add(this.bAddOperators);
            this.Controls.Add(this.bAddSessions);
            this.Controls.Add(this.bEditHalls);
            this.Controls.Add(this.bEditOperators);
            this.Controls.Add(this.bEditSessions);
            this.Controls.Add(this.bEditFilms);
            this.Controls.Add(this.bAddFilms);
            this.Controls.Add(this.bDeleteFilms);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Must in";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button bDeleteFilms;
        private System.Windows.Forms.Button bAddFilms;
        private System.Windows.Forms.Button bEditFilms;
        private System.Windows.Forms.Button bEditSessions;
        private System.Windows.Forms.Button bEditOperators;
        private System.Windows.Forms.Button bEditHalls;
        private System.Windows.Forms.Button bAddSessions;
        private System.Windows.Forms.Button bAddOperators;
        private System.Windows.Forms.Button bAddHalls;
        private System.Windows.Forms.Button bDeleteSessions;
        private System.Windows.Forms.Button bDeleteOperators;
        private System.Windows.Forms.Button bDeleteHalls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_action;
        private System.Windows.Forms.CheckBox cb_adventure;
        private System.Windows.Forms.CheckBox cb_comedy;
        private System.Windows.Forms.CheckBox cb_cartoon;
        private System.Windows.Forms.CheckBox cb_drama;
        private System.Windows.Forms.CheckBox cb_historical;
        private System.Windows.Forms.CheckBox cb_horror;
        private System.Windows.Forms.CheckBox cb_dance;
        private System.Windows.Forms.CheckBox cb_war;
        private System.Windows.Forms.CheckBox cb_westerns;
        private System.Windows.Forms.Button b_okSearch;
        private System.Windows.Forms.CheckBox cb_2d;
        private System.Windows.Forms.CheckBox cb_3d;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_mustIn;
        private System.Windows.Forms.TextBox tb_mustNotIn;
        private System.Windows.Forms.Button but_Import;
    }
}

