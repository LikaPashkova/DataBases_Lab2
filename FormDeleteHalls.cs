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
    public partial class FormDeleteHalls : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);

        public FormDeleteHalls()
        {
            InitializeComponent();
            conn.Open();
            string sql = "SELECT * FROM halls";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            dgv.ColumnCount = 3;
            dgv.Columns[0].Name = "ID";
            dgv.Columns[1].Name = "Name";
            dgv.Columns[2].Name = "Numer of seats";
            dgv.Columns[0].Width = 25;
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
                comboBoxHallsDelete.Items.Add(reader[0].ToString());
                dgv.Rows.Add(s);
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();
        }

        private void buttonHallsDelete_Click(object sender, EventArgs e)
        {
            string id = "0";
            if (comboBoxHallsDelete.SelectedItem != null)
            {
                id = comboBoxHallsDelete.SelectedItem.ToString();
                conn.Open();
                string sql = "DELETE FROM `cinema`.`halls` WHERE `id`='" + id + "';";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            else
            {
                comboBoxHallsDelete.BackColor = Color.Red;
            }
        }
    }
}
