using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_Garcia_Lester
{
    public partial class Form1 : Form
    {
        //Acá se va a crear el objeto de la clase OPERACIONES
        OPERACIONES Operar = new OPERACIONES();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double NumIngresado;
            double Resultado;
            NumIngresado = Convert.ToDouble(maskedTextBox1.Text);
            Resultado = ((1) / (Operar.Potencial(Convert.ToDouble(maskedTextBox1.Text))));
            MessageBox.Show("El resultado de la serie matemática es: " + Resultado);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;

            int[] Arreglo = new int[8];
            
            Arreglo[i] = Convert.ToInt32(maskedTextBox4.Text);
            dataGridView1.Rows.Add(Arreglo[i].ToString());
            maskedTextBox4.Clear();
            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Num1;
            int Num2;
            Num1 = Convert.ToInt32(maskedTextBox2.Text);
            Num2 = Convert.ToInt32(maskedTextBox3.Text);

        }
    }
}
