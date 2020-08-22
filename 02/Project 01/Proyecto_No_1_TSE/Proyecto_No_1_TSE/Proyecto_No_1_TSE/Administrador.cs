using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_No_1_TSE
{
    public partial class Administrador : Form
    {
        public int AzulPresiyVice7, AzulAlcalde7, AzulDiputadoNacional7, AzulDiputadoDistrital7, AzulDiputadoParlacen7, AzulNulo7;
        public int VerdePresiyVice7, VerdeAlcalde7, VerdeDiputadoNacional7, VerdeDiputadoDistrital7, VerdeDiputadoParlacen7, VerdeNulo7;
        public int RojoPresiyVice7, RojoAlcalde7, RojoDiputadoNacional7, RojoDiputadoDistrital7, RojoDiputadoParlacen7, RojoNulo7;
        public int NaranjaPresiyVice7, NaranjaAlcalde7, NaranjaDiputadoNacional7, NaranjaDiputadoDistrital7, NaranjaDiputadoParlacen7, NaranjaNulo7;
        public int AmarilloPresiyVice7, AmarilloAlcalde7, AmarilloDiputadoNacional7, AmarilloDiputadoDistrital7, AmarilloDiputadoParlacen7, AmarilloNulo7;
        public int Nulo7;

        public Administrador()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login Login = new Login();
            Login.Show();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = ("Partido Azul");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Text = ("Partido Verde");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Text = ("Partido Rojo");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label3.Text = ("Partido Naranja");
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label3.Text = ("Partido Amarillo");
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                label3.Text = ("Partido Nulo");
            }
        }
    }
}
