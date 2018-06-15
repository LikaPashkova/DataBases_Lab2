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
    public partial class FormEditHalls : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        int maxid = 0;
        public FormEditHalls()
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
                comboBoxHallsEdit.Items.Add(reader[0].ToString());
                dgv.Rows.Add(s);
                if (Int32.Parse(reader[0].ToString()) > maxid)
                {
                    maxid = Int32.Parse(reader[0].ToString());
                }
                dgv.Rows[i].Height = 30;
                i++;
            }
            for (i = 10; i <= 100; i += 5)
            {
                comboNewBoxSeats.Items.Add("" + i);
            }
            conn.Close();
        }

        private void buttonEditHalls_Click(object sender, EventArgs e)
        {
            string id = "0";
            if (comboBoxHallsEdit.SelectedItem != null)
            {
                id = comboBoxHallsEdit.SelectedItem.ToString();
                string newName = "Input halls name", newSeats = "Seats";
                if (!textBoxNewHallsName.Text.Equals(newName))
                {
                    newName = textBoxNewHallsName.Text;
                }
                if (comboNewBoxSeats.SelectedItem != null)
                {
                    newSeats = comboNewBoxSeats.SelectedItem.ToString();
                }
                bool fl = false;
                string sql = "UPDATE `cinema`.`halls` SET ";
                if (!newName.Equals("Input halls name"))
                {
                    sql = sql + "`name`='" + newName + "'";
                    fl = true;
                }
                if (!newSeats.Equals("Seats"))
                {
                    if (fl == true)
                    {
                        sql = sql + ",";
                    }
                    sql = sql + "`number of seats`='" + newSeats + "' ";
                    fl = true;
                }
                if (fl == true)
                {
                    sql = sql + "WHERE `id`='" + id + "';";
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                else
                {
                    textBoxNewHallsName.BackColor = Color.Red;
                    comboNewBoxSeats.BackColor = Color.Red;
                }
            }
            else
            {
                comboBoxHallsEdit.BackColor = Color.Red;
            }
        }
    }
}