using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        string usuario = "Josegras";
        string passwd = "cescristorey";


        public Form1()
        {
            InitializeComponent();
        }


        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void iniciar_Click(object sender, EventArgs e)
        {
            if (user.Text==usuario && login.Text==passwd)
            {
                resultado.Text = "Usuario correcto";
            }
            else
            {
                resultado.Text = "Error, usuario o contraseña erronea";
            }
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
