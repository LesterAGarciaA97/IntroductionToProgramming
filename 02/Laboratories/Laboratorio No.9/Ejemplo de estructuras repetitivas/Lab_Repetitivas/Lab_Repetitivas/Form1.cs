using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Repetitivas
{
    public partial class Form1 : Form
    {
        //Creo el objeto de mi clase Repetitivas. 
        Repetitivas Ciclos = new Repetitivas();
       

        public Form1()
        {
            InitializeComponent();
        }


        // Acá resuelvo el problema de Fibonacci en un botón, 
        // ustedes deben hacerlo implementando un método de una clase, NO en el botón
        // Esto puede servirles de base, solo codifiqué lo indicado en el diagrama de flujo
        private void button3_Click(object sender, EventArgs e)
        {
            int A = 0, B = 1, C = 0, i = 2, N = 0; // Variables auxiliares, asignando valores
            N = Convert.ToInt16(mtxt_fibonacci.Text); // Leer N
            lbx_fibonacci.Items.Clear(); // Limpiando listbox

            lbx_fibonacci.Items.Add(A); // Imprimir A
            lbx_fibonacci.Items.Add(B); // Imprimir B

            //Estructura mientras 
            // Evalúo condición, mientras se cumpla que se ejecute lo que está entre llaves
            while (i < N) // ¿Es i igual a N? - i es cada número natural desde 2, cada iteración aumenta en 1. 
            { // mientras se cumpla
                C = A + B; // Obtengo el siguiente numero de la sucesión
                lbx_fibonacci.Items.Add(C); // Imprimir C
                A = B; // REalizo nuevas asignaciones para obtener el siguiente numero, si es necesario.
                B = C;
                i = i + 1; // Hago el incremento de mi contador para evaluar el siguiente
            } // fin-mientras
        }       

        private void button5_Click(object sender, EventArgs e)
        { 
            //Método de Javier Diaz
            int Suma = 0;
            int Contador = 1; 
            Ciclos.ContadorNumeros(Suma,Contador,Convert.ToInt16(maskedTextBox1.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Llamando método de Ingeniera
            Ciclos.SumarNumeros(Convert.ToInt16(maskedTextBox1.Text));
        }
    }
}
