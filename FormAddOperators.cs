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
    public partial class FormAddOperators : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        int maxid = 0;
        public FormAddOperators()
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
                if (Int32.Parse(reader[0].ToString()) > maxid)
                {
                    maxid = Int32.Parse(reader[0].ToString());
                }
                dgv.Rows.Add(s);
                dgv.Rows[i].Height = 30;
                i++;
            }
            for (i = 1900; i < 2000; i++)
            {
                comboBoxYYYY.Items.Add("" + i);
            }
            for(i=1;i<31; i++)
            {
                comboBoxDD.Items.Add("" + i);
            }
            for(i=1; i <= 12; i++)
            {
                comboBoxMM.Items.Add("" + i);
            }
            for (i = 1000; i < 10000; i++)
            {
                comboBoxSalary.Items.Add("" + i);
            }
            conn.Close();
        }

        private void buttonAddOperators_Click(object sender, EventArgs e)
        {
            if(!textBoxPIB.Text.Equals("Input PIB"))
            {
                string pib = textBoxPIB.Text;
                if ((comboBoxYYYY.SelectedItem != null) && (comboBoxMM.SelectedItem != null) && (comboBoxDD.SelectedItem != null))
                {
                    string year = comboBoxYYYY.SelectedItem.ToString(),
                        month = comboBoxMM.SelectedItem.ToString(),
                        day = comboBoxDD.SelectedItem.ToString();
                    if (comboBoxSalary.SelectedItem != null)
                    {
                        string salary = comboBoxSalary.SelectedItem.ToString();
                        conn.Open();
                        string sql = "INSERT INTO `cinema`.`operators` (`id`,`PIB`,`birthday`,`salary`) VALUES ('" + (maxid + 1) + "','" + pib + "','" + year+"-"+month+"-"+day+"','"+salary+"');";
                        maxid++;
                        MySqlCommand comm = new MySqlCommand(sql, conn);
                        comm.ExecuteNonQuery();
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        comboBoxSalary.BackColor = Color.Red;
                    }
                }
                else
                {
                    comboBoxYYYY.BackColor = Color.Red;
                    comboBoxMM.BackColor = Color.Red;
                    comboBoxDD.BackColor = Color.Red;
                }
            }
            else
            {
                textBoxPIB.BackColor = Color.Red;
            }
        }
    }
}
