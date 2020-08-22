using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Repaso
{
    public partial class Form1 : Form
    {
        // Instanciado objetos de las diferentes clases creadas
        Problema1 Prob1 = new Problema1(); // Clase del problema 1
        Problema2 Prob2 = new Problema2(); // Clase del problema 2
        Problema3 Prob3 = new Problema3(); // Clase del problema 3

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_problema1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt16(txt_numero.Text); // Entrada
                if (rbn_seriea.Checked == true) // Escogio serie A
                {
                    Prob1.Proc_ResolverSerieA(numero); 
                }
                else // sino
                {
                    if (rbn_serieb.Checked == true) // Escogió serie B
                    {
                        Prob1.Proc_ResolverSerieB(numero);
                    }
                    else // sino no ha escogido serie
                    {
                        MessageBox.Show("Debe escoger alguna serie");
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Debe ingresar un número");
            }
        }

        private void btn_Pproblema2_Click(object sender, EventArgs e)
        {
            Prob2.EsPerfecto(Convert.ToInt16(txt_perfecto.Text)); // Llamamos al método y le enviamos la entrada correspondiente
        }

        private void bnt_convertir_Click(object sender, EventArgs e)
        {
            // Acá llamamos cada método de la clase Problema 3, solo en la primera función enviamos el valor de onzas
            // porque es el valor que recibimos en el textbox. Todas las funciones devuelven un valor tipo double y
            // dado que las etiquetas esperan un valor tipo string, se realiza la conversión correspondiente.
            lbl_gramos.Text = Prob3.ConvertirAGramos(Convert.ToDouble(txt_onzas.Text)).ToString();
            lbl_kilos.Text = Prob3.ConvertirAKilos().ToString();
            lbl_libras.Text = Prob3.ConvertirALibras().ToString();
            lbl_toneladas.Text = Prob3.ConvertirAToneladas().ToString();
        }
    }       
}
