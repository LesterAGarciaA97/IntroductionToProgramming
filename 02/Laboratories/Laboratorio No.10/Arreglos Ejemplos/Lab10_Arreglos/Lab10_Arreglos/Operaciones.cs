using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Usar messagebox en mi clase

namespace Lab10_Arreglos
{
    class Operaciones
    {
        // Arreglo
        int[] Numeros = new int[10];
        Random aleatorio = new Random(); // Random para crear aleatorios

        public void GenerarNumeros() 
        {
            for (int i = 0; i < 10; i++)
            {
                Numeros[i] = aleatorio.Next(0, 101);
            }
            MessageBox.Show("Numeros generados con éxito");
        }

        public void GenerarPromedio()
        {
            int suma = 0;
            for (int i = 0; i < 10; i++)
            {
                suma = suma + Numeros[i];
            }
            suma = suma / 10;
            MessageBox.Show("El promedio es: " + suma.ToString());
 
        }
        public int[] DevolverArreglo()
        {
            return Numeros;
        }
    }
}
