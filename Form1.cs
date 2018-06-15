using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static string connStr = "server=localhost;user=root;database=cinema;password=123789456";
        static MySqlConnection conn = new MySqlConnection(connStr);
        ArrayList tbFilms = new ArrayList();
        ArrayList tbHalls = new ArrayList();
        ArrayList tbOperators = new ArrayList();
        ArrayList tbSessions = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            getFilmsTable();
            getHallsTable();
            getOperatorsTable();
            getSessionsTable();
        }

        private void getFilmsTable()
        {
            conn.Open();
            string sql = "SELECT * FROM films";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                ArrayList s = new ArrayList();
                s.Add(reader[0].ToString());
                s.Add(reader[1].ToString());
                s.Add(reader[2].ToString());
                tbFilms.Add(s);
                i++;
            }
            //ArrayList buf = (ArrayList)tbFilms[1];
            //textBox1.Text = (string)buf[0];
            conn.Close();
        }

        private void getHallsTable()
        {
            conn.Open();
            string sql = "SELECT * FROM halls";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                ArrayList s = new ArrayList();
                s.Add(reader[0].ToString());
                s.Add(reader[1].ToString());
                s.Add(reader[2].ToString());
                tbHalls.Add(s);
                i++;
            }
            conn.Close();
        }

        private void getOperatorsTable()
        {
            conn.Open();
            string sql = "SELECT * FROM operators";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                ArrayList s = new ArrayList();
                s.Add(reader[0].ToString());
                s.Add(reader[1].ToString());
                s.Add(reader[2].ToString().Substring(0,10));
                s.Add(reader[3].ToString());
                tbOperators.Add(s);
                i++;
            }
            conn.Close();
        }

        private void getSessionsTable()
        {
            conn.Open();
            string sql = "SELECT * FROM sessions";
            MySqlCommand comm = new MySqlCommand(sql, conn);
            MySqlDataReader reader = comm.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                ArrayList s = new ArrayList();
                s.Add(reader[0].ToString());
                s.Add(reader[1].ToString());
                s.Add(reader[2].ToString().Substring(0, 5));
                s.Add(reader[3].ToString());
                s.Add(reader[4].ToString());
                s.Add(reader[5].ToString());
                s.Add(reader[6].ToString());
                tbSessions.Add(s);
                i++;
            }
            conn.Close();
        }

        private void buttonFilmsShow_Click(object sender, EventArgs e)
        {
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
                dgv.Rows.Add(s);
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();
        }

        private void buttonHallsShow_Click(object sender, EventArgs e)
        {
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
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();
        }

        private void buttonOperatorsShow_Click(object sender, EventArgs e)
        {
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
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();
        }

        private void buttonSessionsShow_Click(object sender, EventArgs e)
        {
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
                dgv.Rows[i].Height = 30;
                i++;
            }
            conn.Close();
        }

        private void bEditFilms_Click(object sender, EventArgs e)
        {
            FormEditFilms Form2 = new FormEditFilms();
            Form2.Show();
        }

        private void bAddFilms_Click(object sender, EventArgs e)
        {
            FormAddFilms Form2 = new FormAddFilms();
            Form2.Show();
        }

        private void bDeleteFilms_Click(object sender, EventArgs e)
        {
            FormDeleteFilms Form2 = new FormDeleteFilms();
            Form2.Show();
        }

        private void bAddHalls_Click(object sender, EventArgs e)
        {
            FormAddHalls Form2 = new FormAddHalls();
            Form2.Show();
        }

        private void bDeleteHalls_Click(object sender, EventArgs e)
        {
            FormDeleteHalls Form2 = new FormDeleteHalls();
            Form2.Show();
        }

        private void bEditHalls_Click(object sender, EventArgs e)
        {
            FormEditHalls Form2 = new FormEditHalls();
            Form2.Show();

        }

        private void bAddOperators_Click(object sender, EventArgs e)
        {
            FormAddOperators Form2 = new FormAddOperators();
            Form2.Show();
        }

        private void bDeleteOperators_Click(object sender, EventArgs e)
        {
            FormDeleteOperators Form2 = new FormDeleteOperators();
            Form2.Show();
        }

        private void bEditOperators_Click(object sender, EventArgs e)
        {
            FormEditOperators Form2 = new FormEditOperators();
            Form2.Show();
        }

        private void bAddSessions_Click(object sender, EventArgs e)
        {
            FormAddSessions Form2 = new FormAddSessions();
            Form2.Show();
        }

        private void bDeleteSessions_Click(object sender, EventArgs e)
        {
            FormDeleteSessions Form2 = new FormDeleteSessions();
            Form2.Show();
        }

        private void bEditSessions_Click(object sender, EventArgs e)
        {
            FormEditSessions Form2 = new FormEditSessions();
            Form2.Show();
        }
        
        private String getGenreSearch()
        {
            String res = "";
            String buf = "films.genre=";
            bool fl = false;
            if (cb_action.Checked == true){
                res = res + " " + buf + "'action'";
                fl = true;
            }
            if (cb_adventure.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'adventure'";
                fl = true;
            }
            if (cb_comedy.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'comedy'";
                fl = true;
            }
            if (cb_cartoon.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'cartoon'";
                fl = true;
            }
            if (cb_drama.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'drama'";
                fl = true;
            }
            if (cb_historical.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'historical'";
                fl = true;
            }
            if (cb_horror.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'horror'";
                fl = true;
            }
            if (cb_dance.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'dance'";
                fl = true;
            }
            if (cb_war.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'war'";
                fl = true;
            }
            if (cb_westerns.Checked == true)
            {
                if (fl == true)
                {
                    res = res + " or ";
                }
                res = res + " " + buf + "'westerns'";
                fl = true;
            }
            if (fl == true)
            {
                if (cb_2d.Checked == true)
                {
                    if (cb_3d.Checked == false)
                    {
                        res = "(" + res + ")and(sessions.3D=0)";
                        fl = true;
                    }
                }
                else
                {
                    if (cb_3d.Checked == true)
                    {
                        res = "(" + res + ")and(sessions.3D=1)";
                        fl = true;
                    }
                }
            }
            else
            {
                if (cb_2d.Checked == true)
                {
                    if (cb_3d.Checked == false)
                    {
                        res = "sessions.3D=0";
                        fl = true;
                    }
                }
                else
                {
                    if (cb_3d.Checked == true)
                    {
                        res = "sessions.3D=1";
                        fl = true;
                    }
                }
            }
            if (!tb_mustIn.Text.Equals(""))
            {
                if (fl == true)
                {
                    res = "(" + res + ")and((match(films_name) against('" + tb_mustIn.Text + "' in boolean mode))or(match(PIB) against('" + tb_mustIn.Text + "' in boolean mode)))";
                    fl = true;
                }
                else
                {
                    res = "(match(films_name) against('" + tb_mustIn.Text + "' in boolean mode))or(match(PIB) against('" + tb_mustIn.Text + "' in boolean mode))";
                    fl = true;
                }
            }
            if (!tb_mustNotIn.Text.Equals(""))
            {
                if (fl == true)
                {
                    res = "(" + res + ")and((not match(films_name) against('" + tb_mustNotIn.Text + "' in boolean mode))and(not match(PIB) against('" + tb_mustNotIn.Text + "' in boolean mode)))";
                    fl = true;
                }
                else
                {
                    res = "(not match(films_name) against('" + tb_mustNotIn.Text + "' in boolean mode))and(not match(PIB) against('" + tb_mustNotIn.Text + "' in boolean mode))";
                    fl = true;
                }
            }
            if (res.Equals(""))
            {
                return null;
            }
            else
            {
                res = " LEFT JOIN films on films_name=films.name where " + res;
                return res;
            }

        }

        private void b_okSearch_Click(object sender, EventArgs e)
        {
            String search = getGenreSearch();
            if (search == null)
            {
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
                    dgv.Rows[i].Height = 30;
                    i++;
                }
                conn.Close();
            }
            else
            {
                conn.Open();
                string sql = "SELECT sessions.id, sessions.films_name, sessions.time, halls.name,sessions.3D, sessions.price, operators.PIB FROM cinema.sessions LEFT JOIN halls on halls_id = halls.id LEFT JOIN operators on operators_id = operators.id" + search+";";
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
                    dgv.Rows[i].Height = 30;
                    i++;
                }
                conn.Close();
            }
        }

        private void but_Import_Click(object sender, EventArgs e)
        {
            String text="";
            conn.Open();
            string del = "DELETE FROM `cinema`.`sessions`;";
            MySqlCommand comm0 = new MySqlCommand(del, conn);
            comm0.ExecuteNonQuery();
            del = "DELETE FROM `cinema`.`films`;";
            comm0 = new MySqlCommand(del, conn);
            comm0.ExecuteNonQuery();
            del = "DELETE FROM `cinema`.`halls`;";
            comm0 = new MySqlCommand(del, conn);
            comm0.ExecuteNonQuery();
            del = "DELETE FROM `cinema`.`operators`;";
            comm0 = new MySqlCommand(del, conn);
            comm0.ExecuteNonQuery();

            conn.Close();
            using (FileStream fstream = File.OpenRead(@"C:\Users\Lika\Documents\Visual Studio 2017\Projects\WindowsFormsApp1\WindowsFormsApp1\films.csv"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                text = textFromFile;
            }
            int i = 0;
            while (i < text.Length)
            {
                string w1 = "", w2 = "", w3 = "";
                while ((i < text.Length)&&(!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w1 = w1 + text[i];
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w2 = w2 + text[i];
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w3 = w3 + text[i];
                    i++;
                }
                i++;
                if (!(w1.Equals("") || w2.Equals("") || w3.Equals("")))
                {
                    conn.Open();
                    string sql = "INSERT INTO `cinema`.`films` (`name`,`genre`,`duration`) VALUES ('" + w1 + "', '" +
                        w2 + "', '" + w3 + "');";
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }

            using (FileStream fstream = File.OpenRead(@"C:\Users\Lika\Documents\Visual Studio 2017\Projects\WindowsFormsApp1\WindowsFormsApp1\halls.csv"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                text = textFromFile;
            }
            i = 0;
            while (i < text.Length)
            {
                string w1 = "", w2 = "", w3 = "";
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w1 = w1 + text[i];
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w2 = w2 + text[i];
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w3 = w3 + text[i];
                    i++;
                }
                i++;
                if (!(w1.Equals("") || w2.Equals("") || w3.Equals("")))
                {
                    conn.Open();
                    string sql = "INSERT INTO `cinema`.`halls` (`id`,`name`,`number of seats`) VALUES ('" + w1+ "','" + w2 + "','" + w3 + "');";
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }
            using (FileStream fstream = File.OpenRead(@"C:\Users\Lika\Documents\Visual Studio 2017\Projects\WindowsFormsApp1\WindowsFormsApp1\operators.csv"))
            {
                byte[] array = new byte[fstream.Length];
                fstream.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                text = textFromFile;
            }
            i = 0;
            while (i < text.Length)
            {
                string w1 = "", w2 = "", w3 = "", w4="";
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w1 = w1 + text[i];
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w2 = w2 + text[i];
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w3 = w3 + text[i];
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    i++;
                }
                i++;
                while ((i < text.Length) && (!text[i].Equals('"')))
                {
                    w4 = w4 + text[i];
                    i++;
                }
                i++;
                if (!(w1.Equals("") || w2.Equals("") || w3.Equals("")||w4.Equals("")))
                {

                    conn.Open();
                    string sql = "INSERT INTO `cinema`.`operators` (`id`,`PIB`,`birthday`,`salary`) VALUES ('" + w1 + "','" + w2 + "','" +w3 + "','" + w4 + "');";
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    conn.Close();
                }
            }


        }
    }
    

}
