using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void resetear_Click(object sender, EventArgs e)
        {
            numero1.Text = "";
            numero2.Text = "";
            solucion.Text = "";
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double suma1, suma2, resultado;
            //asigno a las variables los valores de los campos
            if (numero1.Text!="" && numero2.Text!="")
            {
                try
                {
                    suma1 = Convert.ToDouble(numero1.Text);
                    suma2 = Convert.ToDouble(numero2.Text);
                    resultado = suma1 + suma2;
                    solucion.Text = resultado.ToString();
                }
                catch (Exception fallo)
                {
                    Console.WriteLine("Error: {0}",
                    fallo.Message);
                }
                
            }
            else
            {
                solucion.Text = "Error. Faltan datos";
            }
            
            
            
            
            
        }
    }
}
