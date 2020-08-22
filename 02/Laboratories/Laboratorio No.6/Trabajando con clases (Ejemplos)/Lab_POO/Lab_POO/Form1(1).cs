using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //instanciar el objeto
        //nombre de la clase + nombre del objeto = new nombre de la clase ()
        Hola ObjetoHola = new Hola();
        Motocicleta Moto = new Motocicleta();

        private void button1_Click(object sender, EventArgs e)
        {
            //ejecutar el metodo Mostrar Hola del objeto ObjetoHola
            ObjetoHola.MostrarHola();            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ObjetoHola.MostrarHello();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ObjetoHola.MostrarOla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ObjetoHola.MostrarSumaV2(Convert.ToInt16(maskedTextBox1.Text), Convert.ToInt16(maskedTextBox2.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numeroA = Convert.ToInt16(maskedTextBox1.Text);
            int numeroB = Convert.ToInt16(maskedTextBox2.Text);
            //int resultado = numeroA + numeroB; 
            int resultado = ObjetoHola.MostrarSuma(numeroA, numeroB);
            MessageBox.Show("El resultado de la suma es: " + resultado.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Metodo con procedimiento
            int numeroA = Convert.ToInt16(maskedTextBox1.Text);
            int numeroB = Convert.ToInt16(maskedTextBox2.Text);
            ObjetoHola.MostrarProducto(numeroA, numeroB);
            
            //Método con función
            numeroA = Convert.ToInt16(maskedTextBox1.Text);
            numeroB = Convert.ToInt16(maskedTextBox2.Text);
            int resultado = ObjetoHola.MostrarProductoV2(numeroA, numeroB);
            MessageBox.Show("El resultado de la multiplicación es: " + resultado.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Moto.MostrarModelo();
        }
    }
}
