using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Lester_Andrés_García_Aquino_1003115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_elegir_Click(object sender, EventArgs e)
        {
            try
            {
                lb_resultado.Text = cb_opciones.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Ninguna opción está seleccionada", "Error");
            }
       }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            t_tiempo.Start();
            lb_cronometro.Text = "0";
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            t_tiempo.Stop();
        }

        private void t_tiempo_Tick(object sender, EventArgs e)
        {
            double contador = Convert.ToDouble(lb_cronometro.Text);
            contador = contador + 1;
            lb_cronometro.Text = Convert.ToString(contador);
        }
    }
}
    