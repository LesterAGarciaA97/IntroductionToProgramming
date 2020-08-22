using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9_Ejemplo
{
    public partial class Form1 : Form
    {
        // Creamos el objeto de la clase
        Repetitivas Ciclos = new Repetitivas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_serie1_Click(object sender, EventArgs e)
        {
            try
            {
                // llamando al método del objeto de mi clase
                // Envío como parámetro el valor que recibo en el maskedTextBox
                Ciclos.P_RealizarSerie1(Convert.ToInt16(mtxt_numero.Text));                
            }
            catch (Exception)
            {
                MessageBox.Show("Error en ingreso de datos");
            }
            
        }

        private void btn_Fserie1_Click(object sender, EventArgs e)
        { // Usando una función del objeto Ciclos
            try
            {
                // llamando a la función del objeto de mi clase
                // Por ser función, devuelve un valor, el cual debo recibir en el formulario en una variable local
                // Envío como parámetro el valor que recibo en el maskedTextBox
                string mensaje = Ciclos.F_RealizarSerie1(Convert.ToInt16(mtxt_numero.Text)); 
                lbl_serie.Text = mensaje; // Muestro la cadena recibida por la función en una etiqueta
            }
            catch (Exception)
            {
                MessageBox.Show("Error en ingreso de datos");
            }
        }
    }
}
