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
    public partial class Form5 : Form
    {
        MySqlConnection MS = new MySqlConnection();
        public Form5()
        {
            InitializeComponent();
            refresh();
        }
      
        

        void refresh()
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = voenkomat; uid = root; pwd = ; charset = utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("select * from prizivniki", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MS.Close();
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string x1, x2, x3, x4, x6,x7,x8,x9,x10,x11, x12;
            x1 = cueTextBox1.Text;
            x2 = cueTextBox2.Text;
            x3 = cueTextBox3.Text;
            x4 = cueTextBox4.Text;
            x6=cueTextBox6.Text ;
            x7 =cueTextBox7.Text ;
            x8 = cueTextBox8.Text ;
            x9 = cueTextBox9.Text ;
            x10 = cueTextBox10.Text;
            x11 = cueTextBox11.Text;
            x12 = cueTextBox12.Text;

            if ((x1 != "") && (x2 != "") && (x3 != "") && (x4 != "") && (x6 != "") && (x7 != "") && (x8 != "") && (x9 != "") && (x10 != "") && (x11 != "") && (x12 != ""))
            {


               
                    MySqlConnection con = new MySqlConnection("Server = localhost; Database = voenkomat;uid = root; pwd = ; charset = utf8");
                    MySqlDataAdapter da = new MySqlDataAdapter("INSERT INTO prizivniki(PSurname, PName, PMidlename, Height, Weight, MaritalStatus , PlaceOfWork , Addres, GasMaskSize, DateOfCall, Category) values ('" + cueTextBox1.Text + "', '" + cueTextBox2.Text + "','" + cueTextBox6.Text + "','" + cueTextBox3.Text + "' ,'" + cueTextBox4.Text + "','" + cueTextBox7.Text + "','" + cueTextBox8.Text + "','" + cueTextBox9.Text + "','" + cueTextBox10.Text + "','" + cueTextBox11.Text + "','" + cueTextBox12.Text + "')", con);
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
                    cueTextBox8.Text = "";
                    cueTextBox9.Text = "";
                    cueTextBox10.Text = "";
                    cueTextBox11.Text = "";
                    cueTextBox12.Text = "";
            }
            else
            {
                MessageBox.Show("Введите все данные!");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("Server = localhost; Database = voenkomat; uid = root; pwd = ; charset = utf8");
            MySqlDataAdapter da = new MySqlDataAdapter("DELETE FROM prizivniki Where ID_P = " + cueTextBox5.Text, con);
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

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
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

        private void CueTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
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

        private void CueTextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void CueTextBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
           
        }


        private void CueTextBox13_TextChanged(object sender, EventArgs e)
        {
           MySqlConnection con = new MySqlConnection("Server = localhost; Database = voenkomat; uid = root; pwd = ; charset = utf8");
           MySqlDataAdapter da = new MySqlDataAdapter(String.Format("SELECT * from prizivniki Where ID_P Like '%{0}%'", cueTextBox13.Text), con);

           DataTable dt = new DataTable();

           da.Fill(dt);     
           dataGridView1.DataSource = dt;
        }



       

       
        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
