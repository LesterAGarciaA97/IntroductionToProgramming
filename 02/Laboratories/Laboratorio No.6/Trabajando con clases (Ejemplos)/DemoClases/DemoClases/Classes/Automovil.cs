using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClases.Classes
{
    /// <summary>
    /// Clase automovil que hereda de vehiculo algunas propiedades
    /// </summary>
    class Automovil : Vehiculo
    {

        //Propiedad exclusiva de automoviles
        public Int32 CantidadNeumaticos { get; set; }


        /// <summary>
        /// Comportamiento generico acelerar
        /// </summary>
        public void acelerar()
        {
            Debug.WriteLine("Acelero con mis "+CantidadNeumaticos+ " neumaticos");
        }
    
    }
}
