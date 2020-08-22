using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            // Creamos un objeto con nombre aleatorio de la clase Random, esta nos ayudará a generar los números aleatorios
            Random aleatorio = new Random();

            // Creamos una variable con el número de personas que debemos simular el voto
            // Le asignamos el valor que se recibe del textbox
            int no_votos = Convert.ToInt16(txt_numero.Text);
            
            // Variables para el conteo de votos, una para cada partido y una donde se guarda el voto aleatorio generado
            int voto, v_rojo = 0, v_azul = 0, v_naranja = 0, v_amarillo = 0, v_verde = 0;

            // Para simular el voto del número de personas ingresado, usamos una estructura repetitiva FOR
            // No es necesario que profundicen mucho en ella, pueden copiar su sintaxis
            // Esto se lee así: desde i igual a cero hasta que i sea menor al no_votos ingresados hacer lo siguiente:
            for (int i = 0; i < no_votos; i++)
            {
                // Genera un voto aleatorio, en base a un rango entre el limite inferior que se incluye y el límite superior que no, se asigna a una variable
                voto = aleatorio.Next(1, 6); // En este caso, genera un valor aleatorio entre 1 y 5 (se excluye el 6)
                lbx_votos.Items.Add(voto.ToString()); // Agrego ese voto a un listbox para mostrarlo

                // Evaluo que voto obtuve
                if (voto == 1) // Si internamente manejo que el numero 1 equivale a un voto para el partido rojo, cuando obtenga un 1, aumento los votos para el partido rojo
                {
                    v_rojo = v_rojo + 1;
                }
                if (voto == 2) // Si internamente manejo que el numero 2 equivale a un voto para el partido azul, cuando obtenga un 2, aumento los votos para el partido azul
                {
                    v_azul = v_azul + 1;
                }
                if (voto == 3) // Si internamente manejo que el numero 3 equivale a un voto para el partido naranja, cuando obtenga un 3, aumento los votos para el partido naranja
                {
                    v_naranja = v_naranja + 1;
                }
                if (voto == 4) // Si internamente manejo que el numero 4 equivale a un voto para el partido amarillo, cuando obtenga un 4, aumento los votos para el partido amarillo
                {
                    v_amarillo = v_amarillo + 1;
                }
                if (voto == 5) // Si internamente manejo que el numero 5 equivale a un voto para el partido verde, cuando obtenga un 5, aumento los votos para el partido verde
                {
                    v_verde = v_verde + 1;
                }
            }

            //Luego de generar los votos aleatorios, muestro los totales obtenidos por cada partido en etiquetas
            lbl_rojo.Text = v_rojo.ToString();
            lbl_azul.Text = v_azul.ToString();
            lbl_naranja.Text = v_naranja.ToString();
            lbl_amarillo.Text = v_amarillo.ToString();
            lbl_verde.Text = v_verde.ToString();
            
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            lbx_votos.Items.Clear();
            lbl_rojo.Text = "";
            lbl_azul.Text = "";
            lbl_naranja.Text = "";
            lbl_amarillo.Text = "";
            lbl_verde.Text = "";
        }
    }
}
