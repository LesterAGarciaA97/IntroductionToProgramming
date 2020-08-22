using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Repaso
{
    class Problema3
    {
        // Atributos de mi clase, cada una de las medidas solicitadas
        double gramos, kilos, libras, toneladas;

        // Se realiza una función para cada conversión, solo la conversión de onzas a gramos tiene parámetros,
        // porque son las onzas el valor que recibimos del formulario.
        // Todas las funciones devuelven al formulario el valor con la conversión realizada.         
            
        public double ConvertirAGramos(double onzas)
        {
            gramos = onzas * 28.35;
            return gramos;
        }

        public double ConvertirAKilos()
        {
            kilos = gramos * 0.001; 
            return kilos;
        }

        public double ConvertirALibras()
        {
            libras = kilos * 2.2;
            return libras;
        }

        public double ConvertirAToneladas()
        {
            toneladas = libras * 0.000454;
            return toneladas;
        }
    }
}
