using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class frnPizzaHatSpa : Form
    {
        public frnPizzaHatSpa()
        {
            InitializeComponent();
        }

        
        private void frnPizzaHatSpa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            double Total = 0;

            if (checkBox1.Checked == true)
            {
                Total = Total + 22000;
            }

            if (checkBox2.Checked == true)
            {
                Total = Total + 12000;
            }

            if (checkBox3.Checked == true)
            {
                Total = Total + 8000;
            }

            if (checkBox4.Checked == true)
            {
                Total = Total + 1500;
            }

            if (checkBox5.Checked == true)
            {
                Total = Total + 5000;
            }

            MessageBox.Show("Lo recaudado es: " + Total.ToString());

            Login frn = new Login();
            frn.Show();
            this.Hide();
        }
        
    }
}
