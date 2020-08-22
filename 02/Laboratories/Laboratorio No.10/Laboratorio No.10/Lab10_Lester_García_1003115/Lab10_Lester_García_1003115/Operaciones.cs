using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_Lester_García_1003115
{
    class Operaciones
    {
        //Arreglo
        int[] Numeros = new int[10];
        Random Aleatorio = new Random(); //Random para crear números aleatorios

        public void GenerarNumeros()
        {
            for (int i = 0; i < 10; i++)
            {
                Numeros[i] = Aleatorio.Next(0, 100);
            }
            MessageBox.Show("Números aleatorios generados exitosamente");
        }
        public void GenerarPromedio()
        {
            int Suma = 0;
            for (int i = 0; i < 10; i++)
            {
                Suma = Suma + Numeros[i];
            }
            Suma = Suma / 10;
            MessageBox.Show("El promedio es: " + Suma);
        }
        public int[] DevolverArreglo()
        {
            return Numeros;
        }
    }
}
