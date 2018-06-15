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
    public partial class FormAddHalls : Form
    {

        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        int maxid = 0;
        public FormAddHalls()
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
                comboBoxSeats.Items.Add(""+i);
            }
            conn.Close();
        }

        private void buttonAddHall_Click(object sender, EventArgs e)
        {
            string name = "Input halls name";
            string seats = "0";
            if (!textBoxHallsName.Text.Equals(name))
            {
                name = textBoxHallsName.Text;
                if (comboBoxSeats.SelectedItem != null)
                {
                    seats = comboBoxSeats.SelectedItem.ToString();
                    conn.Open();
                    string sql = "INSERT INTO `cinema`.`halls` (`id`,`name`,`number of seats`) VALUES ('"+(maxid+1)+"','"+name+"','"+seats+"');";
                    maxid++;
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                else
                {
                    comboBoxSeats.BackColor = Color.Red;
                }
            }
            else
            {
                textBoxHallsName.BackColor = Color.Red;
            }
        }
    }
}
