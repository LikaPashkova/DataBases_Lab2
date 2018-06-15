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
    public partial class FormEditOperators : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        public FormEditOperators()
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
                dgv.Rows.Add(s);
                comboBoxEditID.Items.Add(reader[0].ToString());
                dgv.Rows[i].Height = 30;
                i++;
            }
            for (i = 1900; i < 2000; i++)
            {
                comboBoxNewYYYY.Items.Add("" + i);
            }
            for (i = 1; i < 31; i++)
            {
                comboBoxNewDD.Items.Add("" + i);
            }
            for (i = 1; i <= 12; i++)
            {
                comboBoxNewMM.Items.Add("" + i);
            }
            for (i = 1000; i < 10000; i++)
            {
                comboBoxNewSalary.Items.Add("" + i);
            }
            conn.Close();
        }

        private void buttonEditOperators_Click(object sender, EventArgs e)
        {
            if (comboBoxEditID.SelectedItem != null)
            {
                string id = comboBoxEditID.SelectedItem.ToString();
                bool fl = false;
                string sql = "UPDATE `cinema`.`operators` SET ";
                if(!textBoxNewPIB.Text.Equals("Input PIB"))
                {
                    string newpib = textBoxNewPIB.Text;
                    sql = sql + "`PIB`='" + newpib + "'";
                    fl = true;
                }
                if ((comboBoxNewYYYY.SelectedItem != null) && (comboBoxNewMM.SelectedItem != null) && (comboBoxNewDD.SelectedItem != null))
                {
                    string newyear = comboBoxNewYYYY.SelectedItem.ToString(),
                        newmonth = comboBoxNewMM.SelectedItem.ToString(),
                        newday = comboBoxNewDD.SelectedItem.ToString();
                    if (fl == true)
                    {
                        sql = sql + ",";
                    }
                    sql = sql + "`birthday`='" + newyear + "-" + newmonth + "-" + newday + "'";
                    fl = true;
                }
                if (comboBoxNewSalary.SelectedItem != null)
                {
                    string newsalary = comboBoxNewSalary.SelectedItem.ToString();
                    if (fl == true)
                    {
                        sql = sql + ",";
                    }
                    sql = sql + "`salary`='" + newsalary + "'";
                    fl = true;
                }
                if (fl == true)
                {
                    sql = sql + " WHERE `id`='" + id + "';";
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                else
                {
                    textBoxNewPIB.BackColor = Color.Red;
                    comboBoxNewYYYY.BackColor = Color.Red;
                    comboBoxNewMM.BackColor = Color.Red;
                    comboBoxNewDD.BackColor = Color.Red;
                    comboBoxNewSalary.BackColor = Color.Red;
                }
            }
            else
            {
                comboBoxEditID.BackColor = Color.Red;
            }

        }
    }
}
