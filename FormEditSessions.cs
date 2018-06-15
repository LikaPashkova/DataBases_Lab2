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
    public partial class FormEditSessions : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        int maxid = 0;
        public FormEditSessions()
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
                dgv.Rows.Add(s);
                comboBoxEditID.Items.Add(reader[0].ToString());
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
                comboBoxNewFilmsName.Items.Add(reader[0].ToString());
            }
            conn.Close();
        }
        public void getTime()
        {
            for (int i = 0; i <= 24; i++)
            {
                comboBoxNewHH.Items.Add("" + i);
            }
            for (int i = 0; i < 60; i++)
            {
                comboBoxNewMM.Items.Add("" + i);
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
                comboBoxNewHallsID.Items.Add(reader[0].ToString());
            }
            conn.Close();
        }
        public void get3D()
        {
            comboBoxNew3D.Items.Add("0-2D");
            comboBoxNew3D.Items.Add("1-3D");
        }
        public void getPrice()
        {
            for (int i = 5; i < 200; i++)
            {
                comboBoxNewPrice.Items.Add(i);
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
                comboBoxNewOperatorsID.Items.Add(reader[0].ToString());
            }
            conn.Close();
        }


        private void buttonEditSessions_Click(object sender, EventArgs e)
        {
            if (comboBoxEditID.SelectedItem != null)
            {
                string id = comboBoxEditID.SelectedItem.ToString();
                string sql = "UPDATE `cinema`.`sessions` SET ";
                bool fl = false;
                if (comboBoxNewFilmsName.SelectedItem != null)
                {
                    sql = sql + "`films_name`='" + comboBoxNewFilmsName.SelectedItem.ToString() + "'";
                    fl = true;
                }
                if ((comboBoxNewHH.SelectedItem != null) && (comboBoxNewMM.SelectedItem != null))
                {
                    string time = comboBoxNewHH.SelectedItem.ToString() + ":" + comboBoxNewMM.SelectedItem.ToString() + ":00";
                    if(fl == true)
                    {
                        sql = sql + ",";
                    }
                    sql = sql + "`time`='" + time + "'";
                    fl = true;
                }
                if (comboBoxNewHallsID.SelectedItem != null)
                {
                    if (fl == true)
                    {
                        sql = sql + ",";
                    }
                    sql = sql + "`halls_id`='" + comboBoxNewHallsID.SelectedItem.ToString() + "'";
                    fl = true;
                }
                if (comboBoxNew3D.SelectedItem != null)
                {
                    if (fl == true)
                    {
                        sql = sql + ",";
                    }
                    string dimens = comboBoxNew3D.SelectedItem.ToString();
                    if (dimens.Equals("0-2D"))
                    {
                        dimens = "0";
                    }
                    else
                    {
                        dimens = "1";
                    }
                    sql = sql + "`3D`='" + dimens + "'";
                    fl = true;
                }
                if (comboBoxNewPrice.SelectedItem != null)
                {
                    if (fl == true)
                    {
                        sql = sql + ",";
                    }
                    sql = sql + "`price`='" + comboBoxNewPrice.SelectedItem.ToString() + "'";
                    fl = true;
                }
                if(comboBoxNewOperatorsID.SelectedItem != null)
                {
                    if (fl == true)
                    {
                        sql = sql + ",";
                    }
                    sql = sql + "`operators_id`='" + comboBoxNewOperatorsID.SelectedItem.ToString() + "'";
                    fl = true;
                }
                if (fl == true)
                {
                    sql = sql + " WHERE `id`='" + id + "';";
                    conn.Open();
                    maxid++;
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                    this.Close();
                }
                else
                {
                    comboBoxNewFilmsName.BackColor = Color.Red;
                    comboBoxNewHH.BackColor = Color.Red;
                    comboBoxNewMM.BackColor = Color.Red;
                    comboBoxNewHallsID.BackColor = Color.Red; ;
                    comboBoxNew3D.BackColor = Color.Red;
                    comboBoxNewPrice.BackColor = Color.Red; ;
                    comboBoxNewOperatorsID.BackColor = Color.Red;
                }
            }
            else
            {
                comboBoxEditID.BackColor = Color.Red;
            }
        }
    }
}
