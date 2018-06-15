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
    public partial class FormDeleteOperators : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        public FormDeleteOperators()
        {
            InitializeComponent();
            conn.Open();
            string sql = "SELECT * FROM operators";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            dgv.ColumnCount = 4;
            dgv.Columns[0].Name = "ID";
            dgv.Columns[1].Name = "PIB";
            dgv.Columns[2].Name = "Birthday";
            dgv.Columns[3].Name = "Salary";
            dgv.Columns[0].Width = 20;
            dgv.Columns[1].Width = 190;
            dgv.Columns[2].Width = 63;
            dgv.Columns[3].Width = 38;
            dgv.Columns[0].ReadOnly = true;
            dgv.Columns[1].ReadOnly = true;
            dgv.Columns[2].ReadOnly = true;
            dgv.Columns[3].ReadOnly = true;
            dgv.RowHeadersVisible = false;
            int i = 0;
            dgv.RowCount = 1;
            while (reader.Read())
            {
                string[] s = { reader[0].ToString(), reader[1].ToString(), reader[2].ToString().Substring(0, 10), reader[3].ToString() };
                comboBoxDeleteID.Items.Add(reader[0].ToString());
                dgv.Rows.Add(s);
                dgv.Rows[i].Height = 30;
                i++;
            }
            
            conn.Close();
        }

        private void buttonDeleteOperators_Click(object sender, EventArgs e)
        {
            if (comboBoxDeleteID.SelectedItem != null)
            {
                string id = comboBoxDeleteID.SelectedItem.ToString();
                conn.Open();
                string sql = "DELETE FROM `cinema`.`operators` WHERE `id`='"+id+"';";
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
