using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormEditFilms : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);

        public FormEditFilms()
        {
            InitializeComponent();
            conn.Open();
            string sql = "SELECT * FROM films";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            dgv.ColumnCount = 3;
            dgv.Columns[0].Name = "Name";
            dgv.Columns[1].Name = "Genre";
            dgv.Columns[2].Name = "Duration";
            dgv.Columns[0].Width = 120;
            dgv.Columns[1].Width = 60;
            dgv.Columns[2].Width = 50;
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true;
            dgv.RowHeadersVisible = false;
            int i = 0;
            dgv.RowCount = 1;
            while (reader.Read())
            {
                string[] s = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString() };
                comboBoxFilmsEdit.Items.Add(reader[0].ToString());
                dgv.Rows.Add(s);
                dgv.Rows[i].Height = 30;
                i++;
            }
            comboBoxNewFilmsGenre.Items.AddRange(new string[] { "action", "adventure", "comedy", "cartoon",
                                                             "drama", "historical", "horror", "dance",
                                                             "war", "westerns"});
            for (i = 0; i < 24; i++)
            {
                string s = "" + i;
                if (i < 10)
                {
                    s = "0" + s;
                }
                comboBoxNewFilmsHH.Items.Add(s);
            }
            for (i = 0; i < 60; i++)
            {
                string s = "" + i;
                if (i < 10)
                {
                    s = "0" + s;
                }
                comboBoxNewFilmsMM.Items.Add(s);
            }
            conn.Close();
        }

        private void buttonEditFilm_Click(object sender, EventArgs e)
        {
            string name = "Select film";
            string newname = "Input films name";
            string newgenre = "Genre";
            string newhh = "HH";
            string newmm = "MM";
            if (comboBoxFilmsEdit.SelectedItem != null)
            {
                name = comboBoxFilmsEdit.SelectedItem.ToString();
            }
            if (comboBoxNewFilmsGenre.SelectedItem != null)
            {
                newgenre = comboBoxNewFilmsGenre.SelectedItem.ToString();
            }
            if (comboBoxNewFilmsHH.SelectedItem != null)
            {
                newhh = comboBoxNewFilmsHH.SelectedItem.ToString();
            }
            if (comboBoxNewFilmsMM.SelectedItem != null)
            {
                newmm = comboBoxNewFilmsMM.SelectedItem.ToString();
            }
            if(!name.Equals("Select film"))
            { 
                bool fl = false;
                conn.Open();
                string sql = "UPDATE `cinema`.`films` SET ";
                if(!newname.Equals("Input films name"))
                {
                    sql = sql + "`name`='" + newname + "'";
                    fl = true;
                }
                if (!newgenre.Equals("Genre"))
                {
                    if (fl == true)
                    {
                        sql = sql + ",";
                    }
                    sql = sql + "`genre`= '" + newgenre + "'";
                    fl = true;
                }
                if (!newhh.Equals("HH"))
                {
                    if (!newmm.Equals("MM"))
                    {
                        if (fl == true)
                        {
                            sql = sql + ",";
                        }
                        sql = sql + "`duration`='" + newhh + ":" + newmm + ":00'";
                        fl = true;
                    }
                    else
                    {
                        comboBoxNewFilmsMM.BackColor = Color.Red;
                    }
                }
                if (fl == false)
                {
                    textBoxNewFilmsName.BackColor = Color.Red;
                    comboBoxNewFilmsGenre.BackColor = Color.Red;
                    comboBoxNewFilmsHH.BackColor = Color.Red;
                    comboBoxNewFilmsMM.BackColor = Color.Red;
                }
                else
                {
                    sql = sql + " WHERE `name`='" + name + "';";
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    this.Close();
                }
            }
            else
            {
                comboBoxFilmsEdit.BackColor = Color.Red;
            }
            conn.Close();
        }
    }
}
