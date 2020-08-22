using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_Motocicleta
{
    class Motocicleta
    {
        // Atributos
        int Modelo;
        double Precio;
        string Marca;

        // Funciones

        public Motocicleta()
        {
            Modelo = 2014;
            Precio = 1000;
            Marca = "Susuki";
        }
        public void MostrarModelo()
        {
            MessageBox.Show("El modelo es " + Modelo.ToString());
        }
        public void MostrarMarca()
        {
            MessageBox.Show("La marca de la motocicleta es " + Marca.ToString());
        }
        public void MostrarPrecioSinIVA()
        {
            MessageBox.Show("El precio sin IVA es de Q." + Convert.ToInt32(Precio - (Precio * 0.12)));
        }
        public void MostrarPrecioConIVA()
        {
            MessageBox.Show("El precio con IVA es de Q." + Precio.ToString());
        }
        public void MostrarTotalIVA()
        {
            MessageBox.Show("La cantidad de IVA a cobrar es Q." + Convert.ToInt32(Precio * 0.12));
        }
    }
}
