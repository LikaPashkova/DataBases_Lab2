using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormAddFilms : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);

        public FormAddFilms()
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
                dgv.Rows.Add(s);
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();
            comboBoxFilmsGenre.Items.AddRange(new string[] { "action", "adventure", "comedy", "cartoon",
                                                             "drama", "historical", "horror", "dance",
                                                             "war", "westerns"});
            for(i=0; i<24; i++)
            {
                string s = ""+i;
                if (i < 10)
                {
                    s = "0" + s;
                }
                comboBoxFilmsHH.Items.Add(s);
            }
            for(i=0; i<60; i++)
            {
                string s = "" + i;
                if (i < 10)
                {
                    s = "0" + s;
                }
                comboBoxFilmsMM.Items.Add(s);
            }
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            string genre, hh, mm;
            string name = textBoxFilmsName.Text;
            if ((comboBoxFilmsGenre.SelectedItem != null) &&
                (comboBoxFilmsHH.SelectedItem != null)&&
                (comboBoxFilmsMM.SelectedItem != null))
            {
                genre = comboBoxFilmsGenre.SelectedItem.ToString();
                hh = comboBoxFilmsHH.SelectedItem.ToString();
                mm = comboBoxFilmsMM.SelectedItem.ToString();
            }
            else
            {
                genre = "Genre";
                hh = "HH";
                mm = "MM";
            }
            if (!name.Equals("Input films name"))
            {
                if ((!genre.Equals("Genre"))&&(!hh.Equals("HH"))&&(!mm.Equals("MM")))
                {
                    conn.Open();
                    string sql = "INSERT INTO `cinema`.`films` (`name`,`genre`,`duration`) VALUES ('" + textBoxFilmsName.Text + "', '" +
                        comboBoxFilmsGenre.SelectedItem.ToString() + "', '" +
                        comboBoxFilmsHH.SelectedItem.ToString() + ":" +
                        comboBoxFilmsMM.SelectedItem.ToString() + ":00');";
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                else
                {
                    comboBoxFilmsGenre.BackColor = Color.Red;
                }
            }
            else
            {
                textBoxFilmsName.BackColor = Color.Red;
            }
        }
    }
}
