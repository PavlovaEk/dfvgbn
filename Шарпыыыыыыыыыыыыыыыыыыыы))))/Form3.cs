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

namespace Шарпыыыыыыыыыыыыыыыыыыыы____
{
    public partial class Form3 : Form
    {


        MySqlConnection MS = new MySqlConnection();
        public Form3()
        {
            InitializeComponent();
            refresh();
        }







        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = voenkomat; uid = root; pwd = ; charset = utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from doctors", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MS.Close();
        }



        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            string x1, x2, x3, x4, x6 , x7;
            x1 = cueTextBox1.Text;
            x2 = cueTextBox2.Text;
            x3 = cueTextBox3.Text;
            x4 = cueTextBox4.Text;
            x6 = cueTextBox6.Text;
            x7 = cueTextBox7.Text;


            if ((x1 != "") && (x2 != "") && (x3 != "") && (x4 != "") && (x6 != "") && (x7 != ""))
            {
   

                if ((x1 is string) && (x2 is string) && (x3 is string) && (x4 is string))
                {
                    MySqlConnection con = new MySqlConnection("Server = localhost; Database = voenkomat;uid = root; pwd = ; charset = utf8");
                    MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO doctors(DSurname, DName, Dmidlename, Dspecialisation, ID_Prizivnika, Diagnoz) values ('" + cueTextBox1.Text + "', '" + cueTextBox2.Text + "','" + cueTextBox3.Text + "', '" + cueTextBox4.Text + "', '" + cueTextBox6.Text + "', '" + cueTextBox7.Text + "')", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    refresh();
                    MessageBox.Show("Данные успешно записаны!");
                    cueTextBox1.Text = "";
                    cueTextBox2.Text = "";
                    cueTextBox3.Text = "";
                    cueTextBox4.Text = "";
                    cueTextBox6.Text = "";
                    cueTextBox7.Text = "";
                }
             
            }
            else
            {
                MessageBox.Show("Введите все данные!");
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = voenkomat; uid = root; pwd = ; charset = utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM doctors Where ID_D = " + cueTextBox5.Text, con);
            DataTable dt = new DataTable();
            string z;
            z = cueTextBox5.Text;
            
            if (z != "")
            {
                da.Fill(dt);
                con.Close();
                cueTextBox5.Text = "";
            }
            refresh();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
        }

        private void CueTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }

        }

        private void CueTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CueTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox8_TextChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = voenkomat; uid = root; pwd = ; charset = utf8");
            MySqlDataAdapter da = new MySqlDataAdapter(String.Format("SELECT * from doctors Where ID_D Like '%{0}%'", cueTextBox8.Text), con);

            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }

}
