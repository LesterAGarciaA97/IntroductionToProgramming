using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClases.Classes
{
    /// <summary>
    /// Clase avion que hereda de vehiculo algunas propiedades
    /// </summary>
    class Avion : Vehiculo
    {

        //Propiedad exclusiva de aviones
        private Int32 CandidadAlerones { get; set; }


        /// <summary>
        /// Comportamiento especifico acelerar
        /// </summary>
        public void acelerar()
        {
            Debug.WriteLine("Acelero como avion");
        }
    }
}
