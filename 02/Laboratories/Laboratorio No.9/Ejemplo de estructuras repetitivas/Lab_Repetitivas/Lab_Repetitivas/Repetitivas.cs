using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Para trabajar Messagebox se agrega (NO olvidar)

namespace Lab_Repetitivas
{
    class Repetitivas
    {
        // Método realizado por Javier Díaz
        // Recibe 3 parámetros para poder ejecutarse
        public void ContadorNumeros(int Suma, int Contador, int Resultado)
        {
            do // hacer
            {
                Suma = Suma+ Contador; // Suma acumulada
                Contador = Contador + 1; // incremento en 1 el contador
            } while (Contador <= Resultado); // mientras el contador sea menor o igual al resultado
            MessageBox.Show(Suma.ToString()); // Muestro la suma final (cuando termina el ciclo)
        }


        // Método realizado por Diana Gutiérrez
        // Recibe 1 parámetro para poder ejecutarse
        public void SumarNumeros(int numero)
        {
            int contador = 1, suma = 0; // Las variables que tiene Javier en el formulario, las declaré acá.
            do // hacer
            {
                suma = suma + contador; // suma acumulada
                contador = contador + 1; // incrementar en 1 el contador
            } while (contador <= numero); // mientras el contador sea menor o igual al número recibido. 
            MessageBox.Show("La suma del 1 al número ingresado es: " + suma.ToString()); // Mostrando la suma con mensaje
        }        
    } // Fin clase
} // Fin namespace
