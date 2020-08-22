using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incisos_1_2__y__3
{
    class Estructuras_Repetitivas
    {
        public void SumaNumeros(int Contador, int Suma, int Resultado)
        {
            do
            {
                //La variable "Suma" tiene un valor inicial 0
                Suma = Suma + Contador;
                //Acá se tomará un incremento de 1 en la variable "Contador"
                Contador = Contador + 1;
            }
            //Mientras el valor del contador sea menor o igual que el número ingresado, sumar todos los numeros anteriores a el
            while (Contador <= Resultado);
            MessageBox.Show("La suma del 1 al número ingresado es: " + Suma.ToString());
        }

        public int FactorialNumero(int NumIngresado)
        {
            int i = 1;
            int Resultado = 1;
            while (i <= NumIngresado)
            {
                Resultado = Resultado * i;
                i++;
            }
            return Resultado;
            
        }

        public void SucesionFibonacci()
        {
            
        }
    }
}
