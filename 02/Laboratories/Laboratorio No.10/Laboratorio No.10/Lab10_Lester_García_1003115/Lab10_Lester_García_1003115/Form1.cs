using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_Lester_García_1003115
{
    public partial class Form1 : Form
    {
        //Instancias o crear el objeto
        Operaciones Lab10 = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab10.GenerarNumeros();
            Lab10.GenerarPromedio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Agregar filas al Datagridview
            dataGridView1.Rows.Add(7);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           for (int i=0; i<8; i++) //Aquí se están recorriendo las filas de la cuadrícula
           {
               for (int j=0; j<8; j++)//Aquí se están recorriendo 
               {
                   if ((i % 2 == 0) && (j % 2 == 1))//Detectar filas pares y columnas impares
                   {
                       dataGridView1[i, j].Style.BackColor = System.Drawing.Color.Black;
                   }
                   if ((i % 2 == 1) && (j % 2 == 0))//Detectar filas impares y columnas pares
                   {
                       dataGridView1[i, j].Style.BackColor = System.Drawing.Color.Black;
                   }
               }
           }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            int SumaTotal = 0;
            int SumaPares = 0;
            int SumaImpares = 0;

            int[] Arreglo = new int[10];
            Arreglo[i] = Convert.ToInt32(maskedTextBox1.Text);
            listBox1.Items.Add(Arreglo[i].ToString());
            SumaTotal += Arreglo[i];
            if (i % 2 == 0)
            {
                SumaPares += Arreglo[i];
            }
            else
            {
                SumaImpares += Arreglo[i];
            }
            maskedTextBox1.Clear();
            if (i == 9)
            {
                listBox1.Items.Add("La suma de las posiciones pares es: " + SumaPares.ToString());
                listBox1.Items.Add("La suma de las posiciones impares es: " + SumaImpares.ToString());
                listBox1.Items.Add("La suma todos las posiciones es: " + SumaTotal.ToString());
                button3.Enabled = false;
            }
            i++;
        }
    }
}
