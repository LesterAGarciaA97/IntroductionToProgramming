using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinal_Garcia_Lester
{
    class OPERACIONES
    {
        public int Factorial(int NumIngresado)
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

        public double Potencial(double NumIngresado)
        {
            double NumBase = 2;
            double Resultado = 1;

            Resultado = Math.Pow(NumBase, NumIngresado);

            return Resultado;
        }

        public int NúmerosAmigos(int N1, int N2)
        {
            for (int i = 2; i < N1; i++) 
            {   
                if(N1 % i==0)
                {  
                    N2 = N2 + i; 
                }
        }
            return N2;
    }
}
