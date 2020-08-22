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
    public partial class Login : Form
    {
        public int AzulPresiyVice6, AzulAlcalde6, AzulDiputadoNacional6, AzulDiputadoDistrital6, AzulDiputadoParlacen6, AzulNulo6;
        public int VerdePresiyVice6, VerdeAlcalde6, VerdeDiputadoNacional6, VerdeDiputadoDistrital6, VerdeDiputadoParlacen6, VerdeNulo6;
        public int RojoPresiyVice6, RojoAlcalde6, RojoDiputadoNacional6, RojoDiputadoDistrital6, RojoDiputadoParlacen6, RojoNulo6;
        public int NaranjaPresiyVice6, NaranjaAlcalde6, NaranjaDiputadoNacional6, NaranjaDiputadoDistrital6, NaranjaDiputadoParlacen6, NaranjaNulo6;
        public int AmarilloPresiyVice6, AmarilloAlcalde6, AmarilloDiputadoNacional6, AmarilloDiputadoDistrital6, AmarilloDiputadoParlacen6, AmarilloNulo6;
        public int Nulo6;

        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                 if (textBox2.Text == "Elecciones_2015")
            {
                this.Dispose();
                Administrador Admin = new Administrador();

                AzulPresiyVice6 = Admin.AzulPresiyVice7;
                AzulAlcalde6 = Admin.AzulAlcalde7;
                AzulDiputadoNacional6 = Admin.AzulDiputadoNacional7;
                AzulDiputadoDistrital6 = Admin.AzulDiputadoDistrital7;
                AzulDiputadoParlacen6 = Admin.AzulDiputadoParlacen7;
                AzulNulo6 = Admin.AzulNulo7;

                VerdePresiyVice6 = Admin.VerdePresiyVice7;
                VerdeAlcalde6 = Admin.VerdeAlcalde7;
                VerdeDiputadoNacional6 = Admin.VerdeDiputadoNacional7;
                VerdeDiputadoDistrital6 = Admin.VerdeDiputadoDistrital7;
                VerdeDiputadoParlacen6 = Admin.VerdeDiputadoParlacen7;
                VerdeNulo6 = Admin.VerdeNulo7;

                RojoPresiyVice6 = Admin.RojoPresiyVice7;
                RojoAlcalde6 = Admin.RojoAlcalde7;
                RojoDiputadoNacional6 = Admin.RojoDiputadoNacional7;
                RojoDiputadoDistrital6 = Admin.RojoDiputadoDistrital7;
                RojoDiputadoParlacen6 = Admin.RojoDiputadoParlacen7;
                RojoNulo6 = Admin.RojoNulo7;

                NaranjaPresiyVice6 = Admin.NaranjaPresiyVice7;
                NaranjaAlcalde6 = Admin.NaranjaAlcalde7;
                NaranjaDiputadoNacional6 = Admin.NaranjaDiputadoNacional7;
                NaranjaDiputadoDistrital6 = Admin.NaranjaDiputadoDistrital7;
                NaranjaDiputadoParlacen6 = Admin.NaranjaDiputadoParlacen7;
                NaranjaNulo6 = Admin.NaranjaNulo7;

                AmarilloPresiyVice6 = Admin.AmarilloPresiyVice7;
                AmarilloAlcalde6 = Admin.AmarilloAlcalde7;
                AmarilloDiputadoNacional6 = Admin.AmarilloDiputadoNacional7;
                AmarilloDiputadoDistrital6 = Admin.AmarilloDiputadoDistrital7;
                AmarilloDiputadoParlacen6 = Admin.AmarilloDiputadoParlacen7;
                AmarilloNulo6 = Admin.AmarilloNulo7;

                Nulo6 = Admin.Nulo7;

                Admin.Show();
            }
            else if (textBox2.Text == "Votar")
            {
                this.Dispose();
                Votante Vot = new Votante();
                Vot.Show();
            }
            }
            catch
            {
                MessageBox.Show("ERROR, Contraseña incorrecta, inténtelo de nuevo");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox2.Text == "Elecciones_2015")
                {
                    this.Dispose();
                    Administrador Admin = new Administrador();
                    MessageBox.Show("Bienvenido usuario administrador");
                    Admin.Show();
                }
                else if (textBox2.Text == "Votar")
                {
                    this.Dispose();
                    Votante Vot = new Votante();
                    MessageBox.Show("Bienvenido usuario votante");
                    Vot.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta, intente de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
