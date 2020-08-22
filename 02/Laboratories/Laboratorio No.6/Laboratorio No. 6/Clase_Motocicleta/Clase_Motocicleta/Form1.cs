using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Motocicleta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Motocicleta ObjetoModelo = new Motocicleta();
        Motocicleta ObjetoPrecio = new Motocicleta();
        Motocicleta ObjetoMarca = new Motocicleta();
        private void button1_Click(object sender, EventArgs e)
        {
            ObjetoModelo.MostrarModelo();
            ObjetoModelo.MostrarMarca();
            ObjetoPrecio.MostrarPrecioSinIVA();
            ObjetoPrecio.MostrarPrecioConIVA();
            ObjetoPrecio.MostrarTotalIVA();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ObjetoModelo.MostrarModelo();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ObjetoModelo.MostrarMarca();
        }
    }
}
