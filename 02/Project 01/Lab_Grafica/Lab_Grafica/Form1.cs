using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Grafica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Graficar_Click(object sender, EventArgs e)
        {
            // Creando el bitmap o el área de dibujo donde dibujaremos la gráfica
            Bitmap grafica = new Bitmap(1000, 1000); // Es un espacio de 1000x1000
            // Indicamos que dibujaremos la grafica dentro del bitmap creado
            Graphics lineas = Graphics.FromImage(grafica);
            // Creando el lápiz para dibujar las líneas
            Pen lapiz = new Pen(Color.Black, 2); // Para dibujar las líneas, se necesita color de línea y grosor           
            // Ahora dibujamos las líneas, indicando cada punto. 
            // Los parámetros para crear c/linea son: (Herramienta, coordenada X 1er punto, coordenada Y 1do punto, coordenada X 2do punto, coordenada Y 2do punto)
            lineas.DrawLine(lapiz, 0, 200, 50, 150);
            lineas.DrawLine(lapiz, 50, 150, 150, 100);
            lineas.DrawLine(lapiz, 150, 100, 250, 120);
            lineas.DrawLine(lapiz, 250, 120, 350, 140);
            lineas.DrawLine(lapiz, 350, 140, 450, 170);
            lineas.DrawLine(lapiz, 450, 170, 500, 200);
            // Ahora dibujamos los puntos de cada color
            // Los parámetros para crear c/punto son: (Color, coordenada X de la esquina superior izq, coordenada Y de la esquina superior izq, ancho, alto))
            lineas.FillEllipse(Brushes.Red, 45, 145, 10, 10); // Para dibujar el punto rojo
            lineas.FillEllipse(Brushes.Blue, 145, 95, 10, 10); // Para dibujar el punto azul
            lineas.FillEllipse(Brushes.Yellow, 245, 115, 10, 10); // Para dibujar el punto amarillo
            lineas.FillEllipse(Brushes.Green, 345, 135, 10, 10); // Para dibujar el punto verde
            lineas.FillEllipse(Brushes.Orange, 445, 165, 10, 10); // Para dibujar el punto naranja
            // Ya dibujado el bitmap lo mostramos en el picturebox usando la propiedad Image
            ptb_grafica.Image = grafica;
        }
    }
}
