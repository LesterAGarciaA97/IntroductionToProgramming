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
        
    public partial class Papeleta_2 : Form
    {
        public int AzulPresiyVice2, AzulAlcalde2, AzulDiputadoNacional2, AzulDiputadoDistrital2, AzulDiputadoParlacen2, AzulNulo2;
        public int VerdePresiyVice2, VerdeAlcalde2, VerdeDiputadoNacional2, VerdeDiputadoDistrital2, VerdeDiputadoParlacen2, VerdeNulo2;
        public int RojoPresiyVice2, RojoAlcalde2, RojoDiputadoNacional2, RojoDiputadoDistrital2, RojoDiputadoParlacen2, RojoNulo2;
        public int NaranjaPresiyVice2, NaranjaAlcalde2, NaranjaDiputadoNacional2, NaranjaDiputadoDistrital2, NaranjaDiputadoParlacen2, NaranjaNulo2;
        public int AmarilloPresiyVice2, AmarilloAlcalde2, AmarilloDiputadoNacional2, AmarilloDiputadoDistrital2, AmarilloDiputadoParlacen2, AmarilloNulo2;
        public int Nulo2;

        public Papeleta_2()
        {
            InitializeComponent();
        }

        private void Papeleta_2_Load(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_3 Papeleta3 = new Papeleta_3();

            AzulPresiyVice2 = Papeleta3.AzulPresiyVice3;
            AzulAlcalde2 = Papeleta3.AzulAlcalde3;
            AzulDiputadoNacional2 = Papeleta3.AzulDiputadoNacional3;
            AzulDiputadoDistrital2 = Papeleta3.AzulDiputadoDistrital3;
            AzulDiputadoParlacen2 = Papeleta3.AzulDiputadoParlacen3;
            AzulNulo2 = Papeleta3.AzulNulo3;

            VerdePresiyVice2 = Papeleta3.VerdePresiyVice3;
            VerdeAlcalde2 = Papeleta3.VerdeAlcalde3;
            VerdeDiputadoNacional2 = Papeleta3.VerdeDiputadoNacional3;
            VerdeDiputadoDistrital2 = Papeleta3.VerdeDiputadoDistrital3;
            VerdeDiputadoParlacen2 = Papeleta3.VerdeDiputadoParlacen3;
            VerdeNulo2 = Papeleta3.AzulNulo3;

            RojoPresiyVice2 = Papeleta3.RojoPresiyVice3;
            RojoAlcalde2 = Papeleta3.RojoAlcalde3;
            RojoDiputadoNacional2 = Papeleta3.RojoDiputadoNacional3;
            RojoDiputadoDistrital2 = Papeleta3.RojoDiputadoDistrital3;
            RojoDiputadoParlacen2 = Papeleta3.RojoDiputadoParlacen3;
            RojoNulo2 = Papeleta3.RojoNulo3;

            NaranjaPresiyVice2 = Papeleta3.NaranjaPresiyVice3;
            NaranjaAlcalde2 = Papeleta3.NaranjaAlcalde3;
            NaranjaDiputadoNacional2 = Papeleta3.NaranjaDiputadoNacional3;
            NaranjaDiputadoDistrital2 = Papeleta3.NaranjaDiputadoDistrital3;
            NaranjaDiputadoParlacen2 = Papeleta3.NaranjaDiputadoParlacen3;
            NaranjaNulo2 = Papeleta3.NaranjaNulo3;

            AmarilloPresiyVice2 = Papeleta3.AmarilloPresiyVice3;
            AmarilloAlcalde2 = Papeleta3.AmarilloAlcalde3;
            AmarilloDiputadoNacional2 = Papeleta3.AmarilloDiputadoNacional3;
            AmarilloDiputadoDistrital2 = Papeleta3.AmarilloDiputadoDistrital3;
            AmarilloDiputadoParlacen2 = Papeleta3.AmarilloDiputadoParlacen3;
            AmarilloNulo2 = Papeleta3.AmarilloNulo3;

            Nulo2 = Papeleta3.Nulo3;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_3 Papeleta3 = new Papeleta_3();
            Papeleta3.Show();

            AzulAlcalde2++;

            AzulPresiyVice2 = Papeleta3.AzulPresiyVice3;
            AzulAlcalde2 = Papeleta3.AzulAlcalde3;
            AzulDiputadoNacional2 = Papeleta3.AzulDiputadoNacional3;
            AzulDiputadoDistrital2 = Papeleta3.AzulDiputadoDistrital3;
            AzulDiputadoParlacen2 = Papeleta3.AzulDiputadoParlacen3;
            AzulNulo2 = Papeleta3.AzulNulo3;

            VerdePresiyVice2 = Papeleta3.VerdePresiyVice3;
            VerdeAlcalde2 = Papeleta3.VerdeAlcalde3;
            VerdeDiputadoNacional2 = Papeleta3.VerdeDiputadoNacional3;
            VerdeDiputadoDistrital2 = Papeleta3.VerdeDiputadoDistrital3;
            VerdeDiputadoParlacen2 = Papeleta3.VerdeDiputadoParlacen3;
            VerdeNulo2 = Papeleta3.AzulNulo3;

            RojoPresiyVice2 = Papeleta3.RojoPresiyVice3;
            RojoAlcalde2 = Papeleta3.RojoAlcalde3;
            RojoDiputadoNacional2 = Papeleta3.RojoDiputadoNacional3;
            RojoDiputadoDistrital2 = Papeleta3.RojoDiputadoDistrital3;
            RojoDiputadoParlacen2 = Papeleta3.RojoDiputadoParlacen3;
            RojoNulo2 = Papeleta3.RojoNulo3;

            NaranjaPresiyVice2 = Papeleta3.NaranjaPresiyVice3;
            NaranjaAlcalde2 = Papeleta3.NaranjaAlcalde3;
            NaranjaDiputadoNacional2 = Papeleta3.NaranjaDiputadoNacional3;
            NaranjaDiputadoDistrital2 = Papeleta3.NaranjaDiputadoDistrital3;
            NaranjaDiputadoParlacen2 = Papeleta3.NaranjaDiputadoParlacen3;
            NaranjaNulo2 = Papeleta3.NaranjaNulo3;

            AmarilloPresiyVice2 = Papeleta3.AmarilloPresiyVice3;
            AmarilloAlcalde2 = Papeleta3.AmarilloAlcalde3;
            AmarilloDiputadoNacional2 = Papeleta3.AmarilloDiputadoNacional3;
            AmarilloDiputadoDistrital2 = Papeleta3.AmarilloDiputadoDistrital3;
            AmarilloDiputadoParlacen2 = Papeleta3.AmarilloDiputadoParlacen3;
            AmarilloNulo2 = Papeleta3.AmarilloNulo3;

            Nulo2 = Papeleta3.Nulo3;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_3 Papeleta3 = new Papeleta_3();
            Papeleta3.Show();

            VerdeAlcalde2++;

            AzulPresiyVice2 = Papeleta3.AzulPresiyVice3;
            AzulAlcalde2 = Papeleta3.AzulAlcalde3;
            AzulDiputadoNacional2 = Papeleta3.AzulDiputadoNacional3;
            AzulDiputadoDistrital2 = Papeleta3.AzulDiputadoDistrital3;
            AzulDiputadoParlacen2 = Papeleta3.AzulDiputadoParlacen3;
            AzulNulo2 = Papeleta3.AzulNulo3;

            VerdePresiyVice2 = Papeleta3.VerdePresiyVice3;
            VerdeAlcalde2 = Papeleta3.VerdeAlcalde3;
            VerdeDiputadoNacional2 = Papeleta3.VerdeDiputadoNacional3;
            VerdeDiputadoDistrital2 = Papeleta3.VerdeDiputadoDistrital3;
            VerdeDiputadoParlacen2 = Papeleta3.VerdeDiputadoParlacen3;
            VerdeNulo2 = Papeleta3.AzulNulo3;

            RojoPresiyVice2 = Papeleta3.RojoPresiyVice3;
            RojoAlcalde2 = Papeleta3.RojoAlcalde3;
            RojoDiputadoNacional2 = Papeleta3.RojoDiputadoNacional3;
            RojoDiputadoDistrital2 = Papeleta3.RojoDiputadoDistrital3;
            RojoDiputadoParlacen2 = Papeleta3.RojoDiputadoParlacen3;
            RojoNulo2 = Papeleta3.RojoNulo3;

            NaranjaPresiyVice2 = Papeleta3.NaranjaPresiyVice3;
            NaranjaAlcalde2 = Papeleta3.NaranjaAlcalde3;
            NaranjaDiputadoNacional2 = Papeleta3.NaranjaDiputadoNacional3;
            NaranjaDiputadoDistrital2 = Papeleta3.NaranjaDiputadoDistrital3;
            NaranjaDiputadoParlacen2 = Papeleta3.NaranjaDiputadoParlacen3;
            NaranjaNulo2 = Papeleta3.NaranjaNulo3;

            AmarilloPresiyVice2 = Papeleta3.AmarilloPresiyVice3;
            AmarilloAlcalde2 = Papeleta3.AmarilloAlcalde3;
            AmarilloDiputadoNacional2 = Papeleta3.AmarilloDiputadoNacional3;
            AmarilloDiputadoDistrital2 = Papeleta3.AmarilloDiputadoDistrital3;
            AmarilloDiputadoParlacen2 = Papeleta3.AmarilloDiputadoParlacen3;
            AmarilloNulo2 = Papeleta3.AmarilloNulo3;

            Nulo2 = Papeleta3.Nulo3;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_3 Papeleta3 = new Papeleta_3();
            Papeleta3.Show();

            RojoDiputadoNacional2++;

            AzulPresiyVice2 = Papeleta3.AzulPresiyVice3;
            AzulAlcalde2 = Papeleta3.AzulAlcalde3;
            AzulDiputadoNacional2 = Papeleta3.AzulDiputadoNacional3;
            AzulDiputadoDistrital2 = Papeleta3.AzulDiputadoDistrital3;
            AzulDiputadoParlacen2 = Papeleta3.AzulDiputadoParlacen3;
            AzulNulo2 = Papeleta3.AzulNulo3;

            VerdePresiyVice2 = Papeleta3.VerdePresiyVice3;
            VerdeAlcalde2 = Papeleta3.VerdeAlcalde3;
            VerdeDiputadoNacional2 = Papeleta3.VerdeDiputadoNacional3;
            VerdeDiputadoDistrital2 = Papeleta3.VerdeDiputadoDistrital3;
            VerdeDiputadoParlacen2 = Papeleta3.VerdeDiputadoParlacen3;
            VerdeNulo2 = Papeleta3.AzulNulo3;

            RojoPresiyVice2 = Papeleta3.RojoPresiyVice3;
            RojoAlcalde2 = Papeleta3.RojoAlcalde3;
            RojoDiputadoNacional2 = Papeleta3.RojoDiputadoNacional3;
            RojoDiputadoDistrital2 = Papeleta3.RojoDiputadoDistrital3;
            RojoDiputadoParlacen2 = Papeleta3.RojoDiputadoParlacen3;
            RojoNulo2 = Papeleta3.RojoNulo3;

            NaranjaPresiyVice2 = Papeleta3.NaranjaPresiyVice3;
            NaranjaAlcalde2 = Papeleta3.NaranjaAlcalde3;
            NaranjaDiputadoNacional2 = Papeleta3.NaranjaDiputadoNacional3;
            NaranjaDiputadoDistrital2 = Papeleta3.NaranjaDiputadoDistrital3;
            NaranjaDiputadoParlacen2 = Papeleta3.NaranjaDiputadoParlacen3;
            NaranjaNulo2 = Papeleta3.NaranjaNulo3;

            AmarilloPresiyVice2 = Papeleta3.AmarilloPresiyVice3;
            AmarilloAlcalde2 = Papeleta3.AmarilloAlcalde3;
            AmarilloDiputadoNacional2 = Papeleta3.AmarilloDiputadoNacional3;
            AmarilloDiputadoDistrital2 = Papeleta3.AmarilloDiputadoDistrital3;
            AmarilloDiputadoParlacen2 = Papeleta3.AmarilloDiputadoParlacen3;
            AmarilloNulo2 = Papeleta3.AmarilloNulo3;

            Nulo2 = Papeleta3.Nulo3;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_3 Papeleta3 = new Papeleta_3();
            Papeleta3.Show();

            NaranjaAlcalde2++;

            AzulPresiyVice2 = Papeleta3.AzulPresiyVice3;
            AzulAlcalde2 = Papeleta3.AzulAlcalde3;
            AzulDiputadoNacional2 = Papeleta3.AzulDiputadoNacional3;
            AzulDiputadoDistrital2 = Papeleta3.AzulDiputadoDistrital3;
            AzulDiputadoParlacen2 = Papeleta3.AzulDiputadoParlacen3;
            AzulNulo2 = Papeleta3.AzulNulo3;

            VerdePresiyVice2 = Papeleta3.VerdePresiyVice3;
            VerdeAlcalde2 = Papeleta3.VerdeAlcalde3;
            VerdeDiputadoNacional2 = Papeleta3.VerdeDiputadoNacional3;
            VerdeDiputadoDistrital2 = Papeleta3.VerdeDiputadoDistrital3;
            VerdeDiputadoParlacen2 = Papeleta3.VerdeDiputadoParlacen3;
            VerdeNulo2 = Papeleta3.AzulNulo3;

            RojoPresiyVice2 = Papeleta3.RojoPresiyVice3;
            RojoAlcalde2 = Papeleta3.RojoAlcalde3;
            RojoDiputadoNacional2 = Papeleta3.RojoDiputadoNacional3;
            RojoDiputadoDistrital2 = Papeleta3.RojoDiputadoDistrital3;
            RojoDiputadoParlacen2 = Papeleta3.RojoDiputadoParlacen3;
            RojoNulo2 = Papeleta3.RojoNulo3;

            NaranjaPresiyVice2 = Papeleta3.NaranjaPresiyVice3;
            NaranjaAlcalde2 = Papeleta3.NaranjaAlcalde3;
            NaranjaDiputadoNacional2 = Papeleta3.NaranjaDiputadoNacional3;
            NaranjaDiputadoDistrital2 = Papeleta3.NaranjaDiputadoDistrital3;
            NaranjaDiputadoParlacen2 = Papeleta3.NaranjaDiputadoParlacen3;
            NaranjaNulo2 = Papeleta3.NaranjaNulo3;

            AmarilloPresiyVice2 = Papeleta3.AmarilloPresiyVice3;
            AmarilloAlcalde2 = Papeleta3.AmarilloAlcalde3;
            AmarilloDiputadoNacional2 = Papeleta3.AmarilloDiputadoNacional3;
            AmarilloDiputadoDistrital2 = Papeleta3.AmarilloDiputadoDistrital3;
            AmarilloDiputadoParlacen2 = Papeleta3.AmarilloDiputadoParlacen3;
            AmarilloNulo2 = Papeleta3.AmarilloNulo3;

            Nulo2 = Papeleta3.Nulo3;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_3 Papeleta3 = new Papeleta_3();
            Papeleta3.Show();

            AmarilloAlcalde2++;

            AzulPresiyVice2 = Papeleta3.AzulPresiyVice3;
            AzulAlcalde2 = Papeleta3.AzulAlcalde3;
            AzulDiputadoNacional2 = Papeleta3.AzulDiputadoNacional3;
            AzulDiputadoDistrital2 = Papeleta3.AzulDiputadoDistrital3;
            AzulDiputadoParlacen2 = Papeleta3.AzulDiputadoParlacen3;
            AzulNulo2 = Papeleta3.AzulNulo3;

            VerdePresiyVice2 = Papeleta3.VerdePresiyVice3;
            VerdeAlcalde2 = Papeleta3.VerdeAlcalde3;
            VerdeDiputadoNacional2 = Papeleta3.VerdeDiputadoNacional3;
            VerdeDiputadoDistrital2 = Papeleta3.VerdeDiputadoDistrital3;
            VerdeDiputadoParlacen2 = Papeleta3.VerdeDiputadoParlacen3;
            VerdeNulo2 = Papeleta3.AzulNulo3;

            RojoPresiyVice2 = Papeleta3.RojoPresiyVice3;
            RojoAlcalde2 = Papeleta3.RojoAlcalde3;
            RojoDiputadoNacional2 = Papeleta3.RojoDiputadoNacional3;
            RojoDiputadoDistrital2 = Papeleta3.RojoDiputadoDistrital3;
            RojoDiputadoParlacen2 = Papeleta3.RojoDiputadoParlacen3;
            RojoNulo2 = Papeleta3.RojoNulo3;

            NaranjaPresiyVice2 = Papeleta3.NaranjaPresiyVice3;
            NaranjaAlcalde2 = Papeleta3.NaranjaAlcalde3;
            NaranjaDiputadoNacional2 = Papeleta3.NaranjaDiputadoNacional3;
            NaranjaDiputadoDistrital2 = Papeleta3.NaranjaDiputadoDistrital3;
            NaranjaDiputadoParlacen2 = Papeleta3.NaranjaDiputadoParlacen3;
            NaranjaNulo2 = Papeleta3.NaranjaNulo3;

            AmarilloPresiyVice2 = Papeleta3.AmarilloPresiyVice3;
            AmarilloAlcalde2 = Papeleta3.AmarilloAlcalde3;
            AmarilloDiputadoNacional2 = Papeleta3.AmarilloDiputadoNacional3;
            AmarilloDiputadoDistrital2 = Papeleta3.AmarilloDiputadoDistrital3;
            AmarilloDiputadoParlacen2 = Papeleta3.AmarilloDiputadoParlacen3;
            AmarilloNulo2 = Papeleta3.AmarilloNulo3;

            Nulo2 = Papeleta3.Nulo3;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_3 Papeleta3 = new Papeleta_3();
            Papeleta3.Show();

            Nulo2 = AzulNulo2 + VerdeNulo2 + RojoNulo2 + NaranjaNulo2 + AmarilloNulo2;

            AzulPresiyVice2 = Papeleta3.AzulPresiyVice3;
            AzulAlcalde2 = Papeleta3.AzulAlcalde3;
            AzulDiputadoNacional2 = Papeleta3.AzulDiputadoNacional3;
            AzulDiputadoDistrital2 = Papeleta3.AzulDiputadoDistrital3;
            AzulDiputadoParlacen2 = Papeleta3.AzulDiputadoParlacen3;
            AzulNulo2 = Papeleta3.AzulNulo3;

            VerdePresiyVice2 = Papeleta3.VerdePresiyVice3;
            VerdeAlcalde2 = Papeleta3.VerdeAlcalde3;
            VerdeDiputadoNacional2 = Papeleta3.VerdeDiputadoNacional3;
            VerdeDiputadoDistrital2 = Papeleta3.VerdeDiputadoDistrital3;
            VerdeDiputadoParlacen2 = Papeleta3.VerdeDiputadoParlacen3;
            VerdeNulo2 = Papeleta3.AzulNulo3;

            RojoPresiyVice2 = Papeleta3.RojoPresiyVice3;
            RojoAlcalde2 = Papeleta3.RojoAlcalde3;
            RojoDiputadoNacional2 = Papeleta3.RojoDiputadoNacional3;
            RojoDiputadoDistrital2 = Papeleta3.RojoDiputadoDistrital3;
            RojoDiputadoParlacen2 = Papeleta3.RojoDiputadoParlacen3;
            RojoNulo2 = Papeleta3.RojoNulo3;

            NaranjaPresiyVice2 = Papeleta3.NaranjaPresiyVice3;
            NaranjaAlcalde2 = Papeleta3.NaranjaAlcalde3;
            NaranjaDiputadoNacional2 = Papeleta3.NaranjaDiputadoNacional3;
            NaranjaDiputadoDistrital2 = Papeleta3.NaranjaDiputadoDistrital3;
            NaranjaDiputadoParlacen2 = Papeleta3.NaranjaDiputadoParlacen3;
            NaranjaNulo2 = Papeleta3.NaranjaNulo3;

            AmarilloPresiyVice2 = Papeleta3.AmarilloPresiyVice3;
            AmarilloAlcalde2 = Papeleta3.AmarilloAlcalde3;
            AmarilloDiputadoNacional2 = Papeleta3.AmarilloDiputadoNacional3;
            AmarilloDiputadoDistrital2 = Papeleta3.AmarilloDiputadoDistrital3;
            AmarilloDiputadoParlacen2 = Papeleta3.AmarilloDiputadoParlacen3;
            AmarilloNulo2 = Papeleta3.AmarilloNulo3;

            Nulo2 = Papeleta3.Nulo3;

        }
    }
}
