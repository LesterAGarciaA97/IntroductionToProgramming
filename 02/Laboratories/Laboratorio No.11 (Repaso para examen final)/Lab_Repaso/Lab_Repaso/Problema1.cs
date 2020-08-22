using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Para usar messagebox en mi clase

namespace Lab_Repaso
{
    class Problema1
    {
        // Procedimiento Serie A
        // Parámetros: numero tipo double que se recibe del formulario, el limite al que se quiere llegar en la serie. 
        public void Proc_ResolverSerieA(double N)
        {
            double resultado = 0;
            for (double i = 1; i <= N; i++) // Desde 1 hasta que mi contador i sea menor o igual al número N
            {
                resultado = resultado + (1 / i); //  ir realizando (y acumulando) la suma
            }
            MessageBox.Show("El resultado de la serie es: "+ resultado.ToString());
        }

        // Procedimiento Serie B
        // Parámetros: numero tipo double que se recibe del formulario, el limite al que se quiere llegar en la serie. 
        public void Proc_ResolverSerieB(double N)
        {
            double resultado = 0;
            for (double i = 1; i <= N; i++) // Desde 1 hasta que mi contador i sea menor o igual al número N
            {
                resultado = resultado + (1 / (Funcion_Potencia(2,i))); //  ir realizando (y acumulando) la suma, acá hago mi llamada a mi función potencia
            }
            MessageBox.Show("El resultado de la serie es: " + resultado.ToString());
        }

        // función auxiliar para poder realizar la potencia de un número, recibe como parámetros la base y la potencia. 
        public double Funcion_Potencia(double Base, double Potencia)
        {
            double resultado = 1; // es 1 y no 0 porque como se va a multiplicar, si fuera 0, el resultado siempre sería 0
            for (int i = 1; i <= Potencia; i++) // Desde 1 hasta mi potencia
            {
                resultado = resultado * Base; // ir realizando la multiplicación de mi base por el resultado
            }
            return resultado; // No tengo messagebox, sino que devuelvo un resultado
        }
    }
}
