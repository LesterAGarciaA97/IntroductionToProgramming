using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Intro_a_la_Progra
{
    public class Partidos
    {
        public string NombredelPartido = "";
        public double presidente = 0;
        public double alcalde = 0;
        public double dlNacional = 0;
        public double dDistritales = 0;
        public double daParlacen = 0;
        public Color Color = new Color();
        public string Imagen = null;

        public Partidos(string nombre, Color color, string imagen)
        {
            NombredelPartido = nombre;
            Color = color;
            Imagen = imagen;
        }
        public void Presidente()
        {
            presidente++;
        }
        public void Alcalde()
        {
            alcalde++;
        }
        public void Nacionales()
        {
            dlNacional++;
        }
        public void Distritales()
        {
            dDistritales++;
        }
        public void Parlacen()
        {
            daParlacen++;
        }
        public double getPresidente()
        {
            return presidente;
        }
        public double getAlcalde()
        {
            return alcalde;
        }
        public double getNacionales()
        {
            return dlNacional;
        }
        public double getDistritales()
        {
            return dDistritales;
        }
        public double getParlacen()
        {
            return daParlacen;
        }
    }
}
