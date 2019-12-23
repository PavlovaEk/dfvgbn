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


namespace Шарпыыыыыыыыыыыыыыыыыыыы____
{
    public partial class Form1 : Form
    {
       
       
       
        public Form1()
        {
           InitializeComponent();
          
        }
 
        private void Button2_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
            
        }
    }
}
