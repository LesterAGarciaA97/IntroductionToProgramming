using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Repaso
{
    class Problema2
    {
        // Procedimiento para saber si un número es perfecto, revisando cada uno de sus divisores
        // Parametros: el número recibido en el formulario
        public void EsPerfecto(int numero)
        {
            int contador = 1, suma = 0;
            while (contador < numero) // mientras mi contador sea menor al número recibido (para buscar sus divisores, no incluimos el número)
            {
                if (numero % contador == 0) // Si el residuo es 0, quiere decir que contador es un divisor de ese número
                {
                    suma = suma + contador; // Por tanto, lo acumulamos en la suma de divisores
                }
                contador = contador + 1; // aumentamos en uno el contador para evaluar el siguiente número
            }
            if (suma == numero) // si la suma de divisores es igual al número recibido
            {
                MessageBox.Show("El número es perfecto"); // el número es perfecto
            }
            else // sino son iguales
            {
                MessageBox.Show("El número no es perfecto"); // no es número perfecto 
            }
        }
    }
}
