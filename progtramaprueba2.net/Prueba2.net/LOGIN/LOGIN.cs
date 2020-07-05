using System;
using System.Windows.Forms;

/// Colaboradores:
/// Daniel Alarcón
/// Adalberth Baeza
/// Jorge Campos

namespace LOGIN
{
    public partial class Login : Form
    {
        frnPizzaHatSpa logeo;

        public Login()
        {
            InitializeComponent();
        }

        private void btncontra_Click(object sender, EventArgs e)
        {
            if ((txtcajero.Text != "") && (txtcontra.Text != ""))
            {
                if ((txtcajero.Text == "Cajero") && (txtcontra.Text == "clave123"))
                {
                    logeo = new frnPizzaHatSpa();
                    logeo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error de Usuario o Contraseña");
                }
            }
        }

    }
}
