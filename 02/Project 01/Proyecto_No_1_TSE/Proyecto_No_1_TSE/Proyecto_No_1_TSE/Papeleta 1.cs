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
    public partial class Papeleta_1 : Form
    {
        
        public int AzulPresiyVice1, AzulAlcalde1, AzulDiputadoNacional1, AzulDiputadoDistrital1, AzulDiputadoParlacen1, AzulNulo1;
        public int VerdePresiyVice1, VerdeAlcalde1, VerdeDiputadoNacional1, VerdeDiputadoDistrital1, VerdeDiputadoParlacen1, VerdeNulo1;
        public int RojoPresiyVice1, RojoAlcalde1, RojoDiputadoNacional1, RojoDiputadoDistrital1, RojoDiputadoParlacen1, RojoNulo1;
        public int NaranjaPresiyVice1, NaranjaAlcalde1, NaranjaDiputadoNacional1, NaranjaDiputadoDistrital1, NaranjaDiputadoParlacen1, NaranjaNulo1;
        public int AmarilloPresiyVice1, AmarilloAlcalde1, AmarilloDiputadoNacional1, AmarilloDiputadoDistrital1, AmarilloDiputadoParlacen1, AmarilloNulo1;
        public int Nulo1;
 
        public Papeleta_1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Papeleta_2 Papeleta2 = new Papeleta_2();

            AzulPresiyVice1++;

            AzulPresiyVice1 = Papeleta2.AzulPresiyVice2;
            AzulAlcalde1 = Papeleta2.AzulAlcalde2;
            AzulDiputadoNacional1 = Papeleta2.AzulDiputadoNacional2;
            AzulDiputadoDistrital1 = Papeleta2.AzulDiputadoDistrital2;
            AzulDiputadoParlacen1 = Papeleta2.AzulDiputadoParlacen2;
            AzulNulo1 = Papeleta2.AzulNulo2;

            VerdePresiyVice1 = Papeleta2.VerdePresiyVice2;
            VerdeAlcalde1 = Papeleta2.VerdeAlcalde2;
            VerdeDiputadoNacional1 = Papeleta2.VerdeDiputadoNacional2;
            VerdeDiputadoDistrital1 = Papeleta2.VerdeDiputadoDistrital2;
            VerdeDiputadoParlacen1 = Papeleta2.VerdeDiputadoParlacen2;
            VerdeNulo1 = Papeleta2.AzulNulo2;

            RojoPresiyVice1 = Papeleta2.RojoPresiyVice2;
            RojoAlcalde1 = Papeleta2.RojoAlcalde2;
            RojoDiputadoNacional1 = Papeleta2.RojoDiputadoNacional2;
            RojoDiputadoDistrital1 = Papeleta2.RojoDiputadoDistrital2;
            RojoDiputadoParlacen1 = Papeleta2.RojoDiputadoParlacen2;
            RojoNulo1 = Papeleta2.RojoNulo2;

            NaranjaPresiyVice1 = Papeleta2.NaranjaPresiyVice2;
            NaranjaAlcalde1 = Papeleta2.NaranjaAlcalde2;
            NaranjaDiputadoNacional1 = Papeleta2.NaranjaDiputadoNacional2;
            NaranjaDiputadoDistrital1 = Papeleta2.NaranjaDiputadoDistrital2;
            NaranjaDiputadoParlacen1 = Papeleta2.NaranjaDiputadoParlacen2;
            NaranjaNulo1 = Papeleta2.NaranjaNulo2;

            AmarilloPresiyVice1 = Papeleta2.AmarilloPresiyVice2;
            AmarilloAlcalde1 = Papeleta2.AmarilloAlcalde2;
            AmarilloDiputadoNacional1 = Papeleta2.AmarilloDiputadoNacional2;
            AmarilloDiputadoDistrital1 = Papeleta2.AmarilloDiputadoDistrital2;
            AmarilloDiputadoParlacen1 = Papeleta2.AmarilloDiputadoParlacen2;
            AmarilloNulo1 = Papeleta2.AmarilloNulo2;

            Nulo1 = Papeleta2.Nulo2;

            this.Dispose();
            Papeleta2.Show();

            }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Papeleta_2 Papeleta2 = new Papeleta_2();

            VerdePresiyVice1++;

            AzulPresiyVice1 = Papeleta2.AzulPresiyVice2;
            AzulAlcalde1 = Papeleta2.AzulAlcalde2;
            AzulDiputadoNacional1 = Papeleta2.AzulDiputadoNacional2;
            AzulDiputadoDistrital1 = Papeleta2.AzulDiputadoDistrital2;
            AzulDiputadoParlacen1 = Papeleta2.AzulDiputadoParlacen2;
            AzulNulo1 = Papeleta2.AzulNulo2;

            VerdePresiyVice1 = Papeleta2.VerdePresiyVice2;
            VerdeAlcalde1 = Papeleta2.VerdeAlcalde2;
            VerdeDiputadoNacional1 = Papeleta2.VerdeDiputadoNacional2;
            VerdeDiputadoDistrital1 = Papeleta2.VerdeDiputadoDistrital2;
            VerdeDiputadoParlacen1 = Papeleta2.VerdeDiputadoParlacen2;
            VerdeNulo1 = Papeleta2.AzulNulo2;

            RojoPresiyVice1 = Papeleta2.RojoPresiyVice2;
            RojoAlcalde1 = Papeleta2.RojoAlcalde2;
            RojoDiputadoNacional1 = Papeleta2.RojoDiputadoNacional2;
            RojoDiputadoDistrital1 = Papeleta2.RojoDiputadoDistrital2;
            RojoDiputadoParlacen1 = Papeleta2.RojoDiputadoParlacen2;
            RojoNulo1 = Papeleta2.RojoNulo2;

            NaranjaPresiyVice1 = Papeleta2.NaranjaPresiyVice2;
            NaranjaAlcalde1 = Papeleta2.NaranjaAlcalde2;
            NaranjaDiputadoNacional1 = Papeleta2.NaranjaDiputadoNacional2;
            NaranjaDiputadoDistrital1 = Papeleta2.NaranjaDiputadoDistrital2;
            NaranjaDiputadoParlacen1 = Papeleta2.NaranjaDiputadoParlacen2;
            NaranjaNulo1 = Papeleta2.NaranjaNulo2;

            AmarilloPresiyVice1 = Papeleta2.AmarilloPresiyVice2;
            AmarilloAlcalde1 = Papeleta2.AmarilloAlcalde2;
            AmarilloDiputadoNacional1 = Papeleta2.AmarilloDiputadoNacional2;
            AmarilloDiputadoDistrital1 = Papeleta2.AmarilloDiputadoDistrital2;
            AmarilloDiputadoParlacen1 = Papeleta2.AmarilloDiputadoParlacen2;
            AmarilloNulo1 = Papeleta2.AmarilloNulo2;

            Nulo1 = Papeleta2.Nulo2;

            this.Dispose();
            Papeleta2.Show();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            Papeleta_2 Papeleta2 = new Papeleta_2();

            RojoPresiyVice1++;

            AzulPresiyVice1 = Papeleta2.AzulPresiyVice2;
            AzulAlcalde1 = Papeleta2.AzulAlcalde2;
            AzulDiputadoNacional1 = Papeleta2.AzulDiputadoNacional2;
            AzulDiputadoDistrital1 = Papeleta2.AzulDiputadoDistrital2;
            AzulDiputadoParlacen1 = Papeleta2.AzulDiputadoParlacen2;
            AzulNulo1 = Papeleta2.AzulNulo2;

            VerdePresiyVice1 = Papeleta2.VerdePresiyVice2;
            VerdeAlcalde1 = Papeleta2.VerdeAlcalde2;
            VerdeDiputadoNacional1 = Papeleta2.VerdeDiputadoNacional2;
            VerdeDiputadoDistrital1 = Papeleta2.VerdeDiputadoDistrital2;
            VerdeDiputadoParlacen1 = Papeleta2.VerdeDiputadoParlacen2;
            VerdeNulo1 = Papeleta2.AzulNulo2;

            RojoPresiyVice1 = Papeleta2.RojoPresiyVice2;
            RojoAlcalde1 = Papeleta2.RojoAlcalde2;
            RojoDiputadoNacional1 = Papeleta2.RojoDiputadoNacional2;
            RojoDiputadoDistrital1 = Papeleta2.RojoDiputadoDistrital2;
            RojoDiputadoParlacen1 = Papeleta2.RojoDiputadoParlacen2;
            RojoNulo1 = Papeleta2.RojoNulo2;

            NaranjaPresiyVice1 = Papeleta2.NaranjaPresiyVice2;
            NaranjaAlcalde1 = Papeleta2.NaranjaAlcalde2;
            NaranjaDiputadoNacional1 = Papeleta2.NaranjaDiputadoNacional2;
            NaranjaDiputadoDistrital1 = Papeleta2.NaranjaDiputadoDistrital2;
            NaranjaDiputadoParlacen1 = Papeleta2.NaranjaDiputadoParlacen2;
            NaranjaNulo1 = Papeleta2.NaranjaNulo2;

            AmarilloPresiyVice1 = Papeleta2.AmarilloPresiyVice2;
            AmarilloAlcalde1 = Papeleta2.AmarilloAlcalde2;
            AmarilloDiputadoNacional1 = Papeleta2.AmarilloDiputadoNacional2;
            AmarilloDiputadoDistrital1 = Papeleta2.AmarilloDiputadoDistrital2;
            AmarilloDiputadoParlacen1 = Papeleta2.AmarilloDiputadoParlacen2;
            AmarilloNulo1 = Papeleta2.AmarilloNulo2;

            Nulo1 = Papeleta2.Nulo2;

            this.Dispose();
            Papeleta2.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Papeleta_2 Papeleta2 = new Papeleta_2();

            NaranjaPresiyVice1++;

            AzulPresiyVice1 = Papeleta2.AzulPresiyVice2;
            AzulAlcalde1 = Papeleta2.AzulAlcalde2;
            AzulDiputadoNacional1 = Papeleta2.AzulDiputadoNacional2;
            AzulDiputadoDistrital1 = Papeleta2.AzulDiputadoDistrital2;
            AzulDiputadoParlacen1 = Papeleta2.AzulDiputadoParlacen2;
            AzulNulo1 = Papeleta2.AzulNulo2;

            VerdePresiyVice1 = Papeleta2.VerdePresiyVice2;
            VerdeAlcalde1 = Papeleta2.VerdeAlcalde2;
            VerdeDiputadoNacional1 = Papeleta2.VerdeDiputadoNacional2;
            VerdeDiputadoDistrital1 = Papeleta2.VerdeDiputadoDistrital2;
            VerdeDiputadoParlacen1 = Papeleta2.VerdeDiputadoParlacen2;
            VerdeNulo1 = Papeleta2.AzulNulo2;

            RojoPresiyVice1 = Papeleta2.RojoPresiyVice2;
            RojoAlcalde1 = Papeleta2.RojoAlcalde2;
            RojoDiputadoNacional1 = Papeleta2.RojoDiputadoNacional2;
            RojoDiputadoDistrital1 = Papeleta2.RojoDiputadoDistrital2;
            RojoDiputadoParlacen1 = Papeleta2.RojoDiputadoParlacen2;
            RojoNulo1 = Papeleta2.RojoNulo2;

            NaranjaPresiyVice1 = Papeleta2.NaranjaPresiyVice2;
            NaranjaAlcalde1 = Papeleta2.NaranjaAlcalde2;
            NaranjaDiputadoNacional1 = Papeleta2.NaranjaDiputadoNacional2;
            NaranjaDiputadoDistrital1 = Papeleta2.NaranjaDiputadoDistrital2;
            NaranjaDiputadoParlacen1 = Papeleta2.NaranjaDiputadoParlacen2;
            NaranjaNulo1 = Papeleta2.NaranjaNulo2;

            AmarilloPresiyVice1 = Papeleta2.AmarilloPresiyVice2;
            AmarilloAlcalde1 = Papeleta2.AmarilloAlcalde2;
            AmarilloDiputadoNacional1 = Papeleta2.AmarilloDiputadoNacional2;
            AmarilloDiputadoDistrital1 = Papeleta2.AmarilloDiputadoDistrital2;
            AmarilloDiputadoParlacen1 = Papeleta2.AmarilloDiputadoParlacen2;
            AmarilloNulo1 = Papeleta2.AmarilloNulo2;

            Nulo1 = Papeleta2.Nulo2;

            this.Dispose();
            Papeleta2.Show();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            Papeleta_2 Papeleta2 = new Papeleta_2();

            AmarilloPresiyVice1++;

            AzulPresiyVice1 = Papeleta2.AzulPresiyVice2;
            AzulAlcalde1 = Papeleta2.AzulAlcalde2;
            AzulDiputadoNacional1 = Papeleta2.AzulDiputadoNacional2;
            AzulDiputadoDistrital1 = Papeleta2.AzulDiputadoDistrital2;
            AzulDiputadoParlacen1 = Papeleta2.AzulDiputadoParlacen2;
            AzulNulo1 = Papeleta2.AzulNulo2;

            VerdePresiyVice1 = Papeleta2.VerdePresiyVice2;
            VerdeAlcalde1 = Papeleta2.VerdeAlcalde2;
            VerdeDiputadoNacional1 = Papeleta2.VerdeDiputadoNacional2;
            VerdeDiputadoDistrital1 = Papeleta2.VerdeDiputadoDistrital2;
            VerdeDiputadoParlacen1 = Papeleta2.VerdeDiputadoParlacen2;
            VerdeNulo1 = Papeleta2.AzulNulo2;

            RojoPresiyVice1 = Papeleta2.RojoPresiyVice2;
            RojoAlcalde1 = Papeleta2.RojoAlcalde2;
            RojoDiputadoNacional1 = Papeleta2.RojoDiputadoNacional2;
            RojoDiputadoDistrital1 = Papeleta2.RojoDiputadoDistrital2;
            RojoDiputadoParlacen1 = Papeleta2.RojoDiputadoParlacen2;
            RojoNulo1 = Papeleta2.RojoNulo2;

            NaranjaPresiyVice1 = Papeleta2.NaranjaPresiyVice2;
            NaranjaAlcalde1 = Papeleta2.NaranjaAlcalde2;
            NaranjaDiputadoNacional1 = Papeleta2.NaranjaDiputadoNacional2;
            NaranjaDiputadoDistrital1 = Papeleta2.NaranjaDiputadoDistrital2;
            NaranjaDiputadoParlacen1 = Papeleta2.NaranjaDiputadoParlacen2;
            NaranjaNulo1 = Papeleta2.NaranjaNulo2;

            AmarilloPresiyVice1 = Papeleta2.AmarilloPresiyVice2;
            AmarilloAlcalde1 = Papeleta2.AmarilloAlcalde2;
            AmarilloDiputadoNacional1 = Papeleta2.AmarilloDiputadoNacional2;
            AmarilloDiputadoDistrital1 = Papeleta2.AmarilloDiputadoDistrital2;
            AmarilloDiputadoParlacen1 = Papeleta2.AmarilloDiputadoParlacen2;
            AmarilloNulo1 = Papeleta2.AmarilloNulo2;

            Nulo1 = Papeleta2.Nulo2;

            this.Dispose();
            Papeleta2.Show();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            Papeleta_2 Papeleta2 = new Papeleta_2();

            Nulo1 = AzulNulo1 + VerdeNulo1 + RojoNulo1 + NaranjaNulo1 + AmarilloNulo1;

            AzulPresiyVice1 = Papeleta2.AzulPresiyVice2;
            AzulAlcalde1 = Papeleta2.AzulAlcalde2;
            AzulDiputadoNacional1 = Papeleta2.AzulDiputadoNacional2;
            AzulDiputadoDistrital1 = Papeleta2.AzulDiputadoDistrital2;
            AzulDiputadoParlacen1 = Papeleta2.AzulDiputadoParlacen2;
            AzulNulo1 = Papeleta2.AzulNulo2;

            VerdePresiyVice1 = Papeleta2.VerdePresiyVice2;
            VerdeAlcalde1 = Papeleta2.VerdeAlcalde2;
            VerdeDiputadoNacional1 = Papeleta2.VerdeDiputadoNacional2;
            VerdeDiputadoDistrital1 = Papeleta2.VerdeDiputadoDistrital2;
            VerdeDiputadoParlacen1 = Papeleta2.VerdeDiputadoParlacen2;
            VerdeNulo1 = Papeleta2.AzulNulo2;

            RojoPresiyVice1 = Papeleta2.RojoPresiyVice2;
            RojoAlcalde1 = Papeleta2.RojoAlcalde2;
            RojoDiputadoNacional1 = Papeleta2.RojoDiputadoNacional2;
            RojoDiputadoDistrital1 = Papeleta2.RojoDiputadoDistrital2;
            RojoDiputadoParlacen1 = Papeleta2.RojoDiputadoParlacen2;
            RojoNulo1 = Papeleta2.RojoNulo2;

            NaranjaPresiyVice1 = Papeleta2.NaranjaPresiyVice2;
            NaranjaAlcalde1 = Papeleta2.NaranjaAlcalde2;
            NaranjaDiputadoNacional1 = Papeleta2.NaranjaDiputadoNacional2;
            NaranjaDiputadoDistrital1 = Papeleta2.NaranjaDiputadoDistrital2;
            NaranjaDiputadoParlacen1 = Papeleta2.NaranjaDiputadoParlacen2;
            NaranjaNulo1 = Papeleta2.NaranjaNulo2;

            AmarilloPresiyVice1 = Papeleta2.AmarilloPresiyVice2;
            AmarilloAlcalde1 = Papeleta2.AmarilloAlcalde2;
            AmarilloDiputadoNacional1 = Papeleta2.AmarilloDiputadoNacional2;
            AmarilloDiputadoDistrital1 = Papeleta2.AmarilloDiputadoDistrital2;
            AmarilloDiputadoParlacen1 = Papeleta2.AmarilloDiputadoParlacen2;
            AmarilloNulo1 = Papeleta2.AmarilloNulo2;

            Nulo1 = Papeleta2.Nulo2;

            this.Dispose();
            Papeleta2.Show();
        }

        private void Papeleta_1_Load(object sender, EventArgs e)
        {

        }

        }
    }
