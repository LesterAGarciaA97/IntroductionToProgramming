using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro_a_la_Progra
{
    public partial class Form1 : Form
    {
        public static int posicionesLlenas = 0;
        public static double totalVotos = 0;
        public static List<Partidos> partidosPoliticos = new List<Partidos>();
        public Form1()
        {
            InitializeComponent();
            partidosPoliticos.Add(new Partidos("Nulo", Color.Black, "editdelete.png"));
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtcontras.Text == "votar")
            {
                votante votante = new votante();
                votante.Show();
            }
            else if (txtcontras.Text == "administrar")
            {
                Administrador administrador = new Administrador();
                administrador.Show();
            }
            else
            {
                MessageBox.Show("Debe ingresar una contraseña correcta.");
            }
        }
    }
}
