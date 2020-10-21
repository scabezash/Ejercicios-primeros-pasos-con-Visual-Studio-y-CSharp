using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paqueteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            double correo_normal, paquet_normal, paquet_urgente, email, sms, fax;
            correo_normal = 3.99;
            paquet_normal= 5.31;
            paquet_urgente=7.99;
            email = 0;
            sms = 0.90;
            fax = 1.2;


            if (envioLento.Checked)
            {
                resultado.Text = (correo_normal + (notificacionEmail.Checked == true ? email : 0) + (notificacionFax.Checked == true ? fax : 0) + (notificacionSMS.Checked == true ? sms : 0)) + "€";

            }
            else if (envioNormal.Checked)
            {
                resultado.Text = (paquet_normal + (notificacionEmail.Checked == true ? email : 0) + (notificacionFax.Checked == true ? fax : 0) + (notificacionSMS.Checked == true ? sms : 0)) + "€";

            }
            else
            {
                resultado.Text = (paquet_urgente + (notificacionEmail.Checked == true ? email : 0) + (notificacionFax.Checked == true ? fax : 0) + (notificacionSMS.Checked == true ? sms : 0)) + "€";

            }
        }
    }
}
