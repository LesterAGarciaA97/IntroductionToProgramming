using DemoClases.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoClases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Esta es una demostración de un zoologico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ejecutarDemo_Click(object sender, EventArgs e)
        {
            //Creando un vehiculo generico
            Vehiculo vehiculo1 = new Automovil();
            vehiculo1.Marca = "Honda";
            vehiculo1.Modelo = "Skyline";
            vehiculo1.Color = "Rojo";
            //vehiculo1.CantidadNeumaticos = 4; -- vehiculo generico no tiene neumaticos
            //El vehiculo debe acelerar de forma generica
            vehiculo1.acelerar();

            //Creando un vehiculo especifico
            Automovil vehiculo2 = new Automovil();
            vehiculo2.Marca = "Honda";
            vehiculo2.Modelo = "Pryus";
            vehiculo2.Color = "Rojo";
            vehiculo2.CantidadNeumaticos = 4;
            //El vehiculo debe acelerar de forma especifica
            vehiculo2.acelerar();

            //Creando otro vehiculo generico polimorfico
            Vehiculo vehiculo3 = new Avion();
            vehiculo3.Marca = "Airbus";
            vehiculo3.Modelo = "A100";
            vehiculo3.Color = "Blanco";
            //Acelerar como algo generico
            vehiculo3.acelerar();
            //Casting
            Avion avion1 = (Avion)vehiculo3;
            //Acelerar como avion
            avion1.acelerar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
