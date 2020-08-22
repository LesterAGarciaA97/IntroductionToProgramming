using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Para manejar MessageBox

namespace Lab_POO
{
    public class Motocicleta
    {
        // Atributos
        int Modelo;
        double Precio;
        string Marca;

        // Funciones

        public Motocicleta()
        {
            Modelo = 1990;
            Precio = 20000;
            Marca = "Toyota";
        }
        public void MostrarModelo()
        {
            MessageBox.Show("El modelo es" + Modelo.ToString());
        }

    }
}
