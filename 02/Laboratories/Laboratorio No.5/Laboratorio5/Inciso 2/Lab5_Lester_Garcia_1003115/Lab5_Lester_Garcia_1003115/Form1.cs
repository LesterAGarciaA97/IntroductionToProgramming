using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Lester_Garcia_1003115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            int ResultadoSuma;
            ResultadoSuma = Convert.ToInt32(mtxt_numero1.Text) + Convert.ToInt32(mtxt_numero2.Text);
            lbx_resultados.Items.Add(ResultadoSuma.ToString());
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            int ResultadoResta;
            ResultadoResta = Convert.ToInt32(mtxt_numero1.Text) - Convert.ToInt32(mtxt_numero2.Text);
            lbx_resultados.Items.Add(ResultadoResta.ToString());
        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            int ResultadoDivision;
            ResultadoDivision = Convert.ToInt32(mtxt_numero1.Text) / Convert.ToInt32(mtxt_numero2.Text);
            lbx_resultados.Items.Add(ResultadoDivision.ToString());
        }

        private void btn_residuo_Click(object sender, EventArgs e)
        {
            int ResultadoResiduo;
            ResultadoResiduo = Convert.ToInt32(mtxt_numero1.Text) % Convert.ToInt32(mtxt_numero2.Text);
            lbx_resultados.Items.Add(ResultadoResiduo.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbx_resultados.Items.Clear();
        }
    }
}
