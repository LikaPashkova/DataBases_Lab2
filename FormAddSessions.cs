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
    public partial class FormAddSessions : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        int maxid = 0;
        public FormAddSessions()
        {
            InitializeComponent();
            conn.Open();
            string sql = "SELECT sessions.id, sessions.films_name, sessions.time, halls.name,sessions.3D, sessions.price, operators.PIB FROM cinema.sessions LEFT JOIN halls on halls_id = halls.id LEFT JOIN operators on operators_id = operators.id";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            dgv.ColumnCount = 7;
            dgv.Columns[0].Name = "ID";
            dgv.Columns[1].Name = "Films Name";
            dgv.Columns[2].Name = "Time";
            dgv.Columns[3].Name = "Halls";
            dgv.Columns[4].Name = "0-2D 1-3D";
            dgv.Columns[5].Name = "Price";
            dgv.Columns[6].Name = "Operator";
            dgv.Columns[0].Width = 20;
            dgv.Columns[1].Width = 100;
            dgv.Columns[2].Width = 40;
            dgv.Columns[3].Width = 92;
            dgv.Columns[4].Width = 42;
            dgv.Columns[5].Width = 42;
            dgv.Columns[6].Width = 240;
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
                dgv.Rows.Add(s);
                if (Int32.Parse(reader[0].ToString()) > maxid)
                {
                    maxid = Int32.Parse(reader[0].ToString());
                }
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();
            getFilmsName();
            getTime();
            getHallsID();
            get3D();
            getPrice();
            getOperatorsID();
        }
        public void getFilmsName()
        {
            conn.Open();
            string sql = "SELECT * FROM films";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                comboBoxFilmsName.Items.Add(reader[0].ToString());
            }
            conn.Close();
        }
        public void getTime()
        {
            for(int i=0; i<=24; i++)
            {
                comboBoxHH.Items.Add("" + i);
            }
            for(int i=0; i<60; i++)
            {
                comboBoxMM.Items.Add("" + i);
            }
        }
        public void getHallsID()
        {
            conn.Open();
            string sql = "SELECT * FROM halls";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                comboBoxHallsID.Items.Add(reader[0].ToString()+" "+reader[1].ToString());
            }
            conn.Close();
        }
        public void get3D()
        {
            comboBox3D.Items.Add("0-2D");
            comboBox3D.Items.Add("1-3D");
        }
        public void getPrice()
        {
            for(int i=5; i<200; i++)
            {
                comboBoxPrice.Items.Add(i);
            }
        }
        public void getOperatorsID()
        {
            conn.Open();
            string sql = "SELECT * FROM operators";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                comboBoxOperatorsID.Items.Add(reader[0].ToString()+" "+reader[1].ToString());
            }
            conn.Close();
        }

        private void buttonAddSessions_Click(object sender, EventArgs e)
        {
            if (comboBoxFilmsName != null)
            {
                string filmName = comboBoxFilmsName.SelectedItem.ToString();
                if ((comboBoxHH.SelectedItem != null) && (comboBoxMM.SelectedItem != null))
                {
                    string time = comboBoxHH.SelectedItem.ToString() + ":" + comboBoxMM.SelectedItem.ToString() + ":00";
                    if (comboBoxHallsID.SelectedItem != null)
                    {
                        string hallsId = comboBoxHallsID.SelectedItem.ToString().Substring(0,2);
                        if (comboBox3D.SelectedItem != null)
                        {
                            string dimens = comboBox3D.SelectedItem.ToString();
                            if (dimens.Equals("0-2D")){
                                dimens = "0";
                            }
                            else
                            {
                                dimens = "1";
                            }
                            if (comboBoxPrice.SelectedItem != null)
                            {
                                string price = comboBoxPrice.SelectedItem.ToString();
                                if (comboBoxOperatorsID.SelectedItem != null)
                                {
                                    string operatorsId = comboBoxOperatorsID.SelectedItem.ToString().Substring(0,2);
                                    conn.Open();
                                    string sql = "INSERT INTO `cinema`.`sessions` (`id`,`films_name`,`time`,`halls_id`,`3D`,`price`,`operators_id`) VALUES ('" + (maxid + 1) + "','" +
                                        filmName + "','" + time +"','"+hallsId+"','"+dimens+"','"+price+"','"+operatorsId+"');";
                                    maxid++;
                                    MySqlCommand comm = new MySqlCommand(sql, conn);
                                    comm.ExecuteNonQuery();
                                    conn.Close();
                                    this.Close();
                                }
                                else
                                {
                                    comboBoxOperatorsID.BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                comboBoxPrice.BackColor = Color.Red;
                            }
                        }
                        else
                        {
                            comboBox3D.BackColor = Color.Red;
                        }
                    }
                    else
                    {
                        comboBoxHallsID.BackColor = Color.Red;
                    }
                }
                else
                {
                    comboBoxHH.BackColor = Color.Red;
                    comboBoxMM.BackColor = Color.Red;
                }
            }
            else
            {
                comboBoxFilmsName.BackColor = Color.Red;
            }
        }
    }
}
