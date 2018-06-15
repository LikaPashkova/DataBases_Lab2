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
    public partial class FormDeleteFilms : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);

        public FormDeleteFilms()
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
                comboBoxFilmsDelete.Items.Add(reader[0].ToString());
                dgv.Rows.Add(s);
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();

        }

        private void buttonFilmsDelete_Click(object sender, EventArgs e)
        {
            string name="Select film";
            if (comboBoxFilmsDelete.SelectedItem != null)
            {
                name = comboBoxFilmsDelete.SelectedItem.ToString();
            }
            if(!name.Equals("Select film"))
            {
                conn.Open();
                string sql = "DELETE FROM `cinema`.`films` WHERE `name`='"+name+"';";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            else
            {
                comboBoxFilmsDelete.BackColor = Color.Red;
            }
        }
    }
}
