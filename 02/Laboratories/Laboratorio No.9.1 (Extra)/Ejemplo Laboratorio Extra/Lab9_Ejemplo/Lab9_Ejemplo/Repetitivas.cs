using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;  // Para utilizar MessageBox desde la clase

namespace Lab9_Ejemplo
{
    class Repetitivas
    {
        // Procedimiento que  recibe un parámetro el cual es N = número ingresado, no devuelve ningún valor
        public void P_RealizarSerie1(int N)
        {
            double i = 1; // Contador (double para manejar decimales)
            double suma = 0; // Acumulador (double para manejar decimales)
            do // hacer              
            {
                suma = suma + (1 / i); // Acumulando el resultado
                i = i + 1; // Incremento al contador
            } while (i <= N); // mientras el contador sea menor o igual al número
            MessageBox.Show("El resultado de la serie es: " + suma.ToString());  // Mostramos el resultado          
        }

        //Función que devuelve una cadena (string), recibe un parámetro que es N = número ingresado
        public string F_RealizarSerie1(int N)
        {
            string serie = ""; // Variable para ir formando la cadena
            double i = 1; // Contador (double para manejar decimales)
            double suma = 0; // Acumulador (double para manejar decimales)
            do // hacer
            {
                suma = suma + (1 / i); // Acumulando el resultado
                serie = serie + "  1/" + i.ToString(); // Armando la cadena con cada número de la serie
                i = i + 1; // Incremento al contador
            } while (i <= N); // mientras el contador sea menor o igual al número
            MessageBox.Show("El resultado de la serie es: " + suma.ToString()); // Mostramos el resultado
            return serie; // Devolvemos el resultado, si es función SIEMPRE debe haber un return
        }

    }
}
