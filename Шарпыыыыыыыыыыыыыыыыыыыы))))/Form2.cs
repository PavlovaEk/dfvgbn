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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int n = 100;
        int s = 10;

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= s*3;

            if (n <= 0)
            { 
                n = 100;
                pictureBox1.Left = 0;
            }

        }
     
    }       
}
