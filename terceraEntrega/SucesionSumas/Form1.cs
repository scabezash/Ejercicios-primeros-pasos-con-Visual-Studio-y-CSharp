using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SucesionSumas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            if (verResultados.Checked==true)
            {
                for (int i=1; i<=limite.Value; i++)
                {
                    Lista.Items.Add("sumando: " +i+ " Suma Parcial: " + i*(i+1)/2);
                }
            }
            
            Lista.Items.Add(limite.Value*(limite.Value+1)/2);
           // Lista.Text=;
        }
    }
}
