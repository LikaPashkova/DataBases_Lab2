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
    public partial class FormDeleteSessions : Form
    {

        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        public FormDeleteSessions()
        {
            InitializeComponent();
            conn.Open();
            string sql = "SELECT * FROM sessions";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            dgv.ColumnCount = 7;
            dgv.Columns[0].Name = "ID";
            dgv.Columns[1].Name = "Films Name";
            dgv.Columns[2].Name = "Time";
            dgv.Columns[3].Name = "Halls ID";
            dgv.Columns[4].Name = "0-2D 1-3D";
            dgv.Columns[5].Name = "Price";
            dgv.Columns[6].Name = "Opera- tor ID";
            dgv.Columns[0].Width = 20;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 40;
            dgv.Columns[3].Width = 42;
            dgv.Columns[4].Width = 42;
            dgv.Columns[5].Width = 42;
            dgv.Columns[6].Width = 42;
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true;
            dgv.Columns[3].ReadOnly = true;
            dgv.Columns[4].ReadOnly = true;
            dgv.Columns[5].ReadOnly = true;
            dgv.Columns[6].ReadOnly = true;
            dgv.RowHeadersVisible = false;
            int i = 0;
            dgv.RowCount = 1;
            while (reader.Read())
            {
                string[] s = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString().Substring(0, 5), reader[3].ToString(), reader[4].ToString().ToString(), reader[5].ToString(), reader[6].ToString() };
                comboBoxDeleteID.Items.Add(reader[0].ToString());
                dgv.Rows.Add(s);
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();
        }

        private void buttonDeleteSessions_Click(object sender, EventArgs e)
        {
            if (comboBoxDeleteID.SelectedItem != null)
            {
                string id = comboBoxDeleteID.SelectedItem.ToString();
                conn.Open();
                string sql = "DELETE FROM `cinema`.`sessions` WHERE `id`='"+id+"';";
                MySqlCommand comm = new MySqlCommand(sql, conn);
                comm.ExecuteNonQuery();
                conn.Close();
                this.Close();
            }
            else
            {
                comboBoxDeleteID.BackColor = Color.Red;
            }

        }
    }
}
