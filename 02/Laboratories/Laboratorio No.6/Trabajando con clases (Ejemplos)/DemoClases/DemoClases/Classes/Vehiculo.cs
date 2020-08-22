using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClases.Classes
{
    class Vehiculo
    {
        // Todas las propiedades son ocultas y encapsuladas por los metodos get y set
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Color { get; set; }
        public Int32 Potencia { get; set; }

        //Sin get y set la propiedad es totalmente oculta
        public Int32 Velocidades;

        /// <summary>
        /// Comportamiento generico acelerar
        /// </summary>
        public void acelerar()
        {
            Debug.WriteLine("El vehiculo acelera genericamente");
        }

        /// <summary>
        /// Comportamiento generico frenar
        /// </summary>
        public void frenar()
        {
            Debug.WriteLine("El vehiculo frena genericamente");
        }

        /// <summary>
        /// Comportamiento generico girar
        /// </summary>
        public void girar()
        {
            Debug.WriteLine("El vehiculo gira genericamente");
        }
    }
}
