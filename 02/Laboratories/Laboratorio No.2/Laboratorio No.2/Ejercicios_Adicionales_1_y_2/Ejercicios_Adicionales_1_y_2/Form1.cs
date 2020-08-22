using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_Adicionales_1_y_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Procesar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("El alumno " + cb_Nombres.SelectedItem + " está cursando " + cb_materias.SelectedItem);
                lb_Informacion.Text = "El alumno " + cb_Nombres.SelectedItem.ToString() +  " está cursando " + cb_materias.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("El alumno " + cb_Nombres.SelectedItem + " está cursando " + cb_materias.SelectedItem);
                lb_Informacion.Text = "El alumno " + cb_Nombres.SelectedItem.ToString() + cb_materias.SelectedItem.ToString() + " está cursando ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_timer.Start();
            lb_cronómetro.Text = "100";
        }

        private void btn_detener_Click(object sender, EventArgs e)
        {
            t_timer.Stop();
        }

        private void t_timer_Tick(object sender, EventArgs e)
        {
            double contador = Convert.ToDouble(lb_cronómetro.Text);
            contador = contador - 1;
            lb_cronómetro.Text = Convert.ToString(contador);
        }
    }
}
                    
                       
                    
