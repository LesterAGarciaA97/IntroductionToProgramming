using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incisos_1_2__y__3
{
    public partial class Form1 : Form
    {
        //Acá se va a crear el objeto de la clase Estructuras Repetitivas
        Estructuras_Repetitivas Ciclos = new Estructuras_Repetitivas();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Suma = 0;
            int Contador = 0;
            Ciclos.SumaNumeros(Suma, Contador, Convert.ToInt16(maskedTextBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Ciclos.FactorialNumero(Convert.ToInt32(maskedTextBox2.Text)).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
