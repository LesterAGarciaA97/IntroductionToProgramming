using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_Arreglos
{
    public partial class Form1 : Form
    {
        // Instanció (creó) el objeto
        Operaciones Lab10 = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generarpromedio_Click(object sender, EventArgs e)
        {
            Lab10.GenerarNumeros();
            Lab10.GenerarPromedio();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar filas al datagridview
            dgv_Tablero.Rows.Add(7);
        }

        private void btn_pintar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++) // Recorrer filas
            {
                for (int j = 0; j < 8; j++) // Recorrer columnas
                {
                    if ((i % 2 == 0) && (j % 2 == 1)) // fila par y columna impar
                    {
                        dgv_Tablero[i, j].Style.BackColor = System.Drawing.Color.Black;
                    }
                    if ((i % 2 == 1) && (j % 2 == 0)) // fila impar y columna par
                    {
                        dgv_Tablero[i, j].Style.BackColor = System.Drawing.Color.Black;
                    }
                }
            }
        }
    }
}
