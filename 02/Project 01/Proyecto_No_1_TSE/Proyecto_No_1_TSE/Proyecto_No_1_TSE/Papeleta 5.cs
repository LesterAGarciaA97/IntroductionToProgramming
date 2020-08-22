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
    public partial class Papeleta_5 : Form
    {
        public int AzulPresiyVice5, AzulAlcalde5, AzulDiputadoNacional5, AzulDiputadoDistrital5, AzulDiputadoParlacen5, AzulNulo5;
        public int VerdePresiyVice5, VerdeAlcalde5, VerdeDiputadoNacional5, VerdeDiputadoDistrital5, VerdeDiputadoParlacen5, VerdeNulo5;
        public int RojoPresiyVice5, RojoAlcalde5, RojoDiputadoNacional5, RojoDiputadoDistrital5, RojoDiputadoParlacen5, RojoNulo5;
        public int NaranjaPresiyVice5, NaranjaAlcalde5, NaranjaDiputadoNacional5, NaranjaDiputadoDistrital5, NaranjaDiputadoParlacen5, NaranjaNulo5;
        public int AmarilloPresiyVice5, AmarilloAlcalde5, AmarilloDiputadoNacional5, AmarilloDiputadoDistrital5, AmarilloDiputadoParlacen5, AmarilloNulo5;
        public int Nulo5;

        public Papeleta_5()
        {
            InitializeComponent();
        }

        private void Papeleta_5_Load(object sender, EventArgs e)
        {

            this.Dispose();
            Votante Votar = new Votante();

            AzulPresiyVice5 = Votar.AzulPresiyVice;
            AzulAlcalde5 = Votar.AzulAlcalde;
            AzulDiputadoNacional5 = Votar.AzulDiputadoNacional;
            AzulDiputadoDistrital5 = Votar.AzulDiputadoDistrital;
            AzulDiputadoParlacen5 = Votar.AzulDiputadoParlacen;
            AzulNulo5 = Votar.AzulNulo;

            VerdePresiyVice5 = Votar.VerdePresiyVice;
            VerdeAlcalde5 = Votar.VerdeAlcalde;
            VerdeDiputadoNacional5 = Votar.VerdeDiputadoNacional;
            VerdeDiputadoDistrital5 = Votar.VerdeDiputadoDistrital;
            VerdeDiputadoParlacen5 = Votar.VerdeDiputadoParlacen;
            VerdeNulo5 = Votar.AzulNulo;

            RojoPresiyVice5 = Votar.RojoPresiyVice;
            RojoAlcalde5 = Votar.RojoAlcalde;
            RojoDiputadoNacional5 = Votar.RojoDiputadoNacional;
            RojoDiputadoDistrital5 = Votar.RojoDiputadoDistrital;
            RojoDiputadoParlacen5 = Votar.RojoDiputadoParlacen;
            RojoNulo5 = Votar.RojoNulo;

            NaranjaPresiyVice5 = Votar.NaranjaPresiyVice;
            NaranjaAlcalde5 = Votar.NaranjaAlcalde;
            NaranjaDiputadoNacional5 = Votar.NaranjaDiputadoNacional;
            NaranjaDiputadoDistrital5 = Votar.NaranjaDiputadoDistrital;
            NaranjaDiputadoParlacen5 = Votar.NaranjaDiputadoParlacen;
            NaranjaNulo5 = Votar.NaranjaNulo;

            AmarilloPresiyVice5 = Votar.AmarilloPresiyVice;
            AmarilloAlcalde5 = Votar.AmarilloAlcalde;
            AmarilloDiputadoNacional5 = Votar.AmarilloDiputadoNacional;
            AmarilloDiputadoDistrital5 = Votar.AmarilloDiputadoDistrital;
            AmarilloDiputadoParlacen5 = Votar.AmarilloDiputadoParlacen;
            AmarilloNulo5 = Votar.AmarilloNulo;

            Nulo5 = Votar.Nulo;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Votante Votar = new Votante();
            Votar.Show();

            AzulDiputadoParlacen5++;

            AzulPresiyVice5 = Votar.AzulPresiyVice;
            AzulAlcalde5 = Votar.AzulAlcalde;
            AzulDiputadoNacional5 = Votar.AzulDiputadoNacional;
            AzulDiputadoDistrital5 = Votar.AzulDiputadoDistrital;
            AzulDiputadoParlacen5 = Votar.AzulDiputadoParlacen;
            AzulNulo5 = Votar.AzulNulo;

            VerdePresiyVice5 = Votar.VerdePresiyVice;
            VerdeAlcalde5 = Votar.VerdeAlcalde;
            VerdeDiputadoNacional5 = Votar.VerdeDiputadoNacional;
            VerdeDiputadoDistrital5 = Votar.VerdeDiputadoDistrital;
            VerdeDiputadoParlacen5 = Votar.VerdeDiputadoParlacen;
            VerdeNulo5 = Votar.AzulNulo;

            RojoPresiyVice5 = Votar.RojoPresiyVice;
            RojoAlcalde5 = Votar.RojoAlcalde;
            RojoDiputadoNacional5 = Votar.RojoDiputadoNacional;
            RojoDiputadoDistrital5 = Votar.RojoDiputadoDistrital;
            RojoDiputadoParlacen5 = Votar.RojoDiputadoParlacen;
            RojoNulo5 = Votar.RojoNulo;

            NaranjaPresiyVice5 = Votar.NaranjaPresiyVice;
            NaranjaAlcalde5 = Votar.NaranjaAlcalde;
            NaranjaDiputadoNacional5 = Votar.NaranjaDiputadoNacional;
            NaranjaDiputadoDistrital5 = Votar.NaranjaDiputadoDistrital;
            NaranjaDiputadoParlacen5 = Votar.NaranjaDiputadoParlacen;
            NaranjaNulo5 = Votar.NaranjaNulo;

            AmarilloPresiyVice5 = Votar.AmarilloPresiyVice;
            AmarilloAlcalde5 = Votar.AmarilloAlcalde;
            AmarilloDiputadoNacional5 = Votar.AmarilloDiputadoNacional;
            AmarilloDiputadoDistrital5 = Votar.AmarilloDiputadoDistrital;
            AmarilloDiputadoParlacen5 = Votar.AmarilloDiputadoParlacen;
            AmarilloNulo5 = Votar.AmarilloNulo;

            Nulo5 = Votar.Nulo;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Votante Votar = new Votante();
            Votar.Show();

            VerdeDiputadoParlacen5++;

            AzulPresiyVice5 = Votar.AzulPresiyVice;
            AzulAlcalde5 = Votar.AzulAlcalde;
            AzulDiputadoNacional5 = Votar.AzulDiputadoNacional;
            AzulDiputadoDistrital5 = Votar.AzulDiputadoDistrital;
            AzulDiputadoParlacen5 = Votar.AzulDiputadoParlacen;
            AzulNulo5 = Votar.AzulNulo;

            VerdePresiyVice5 = Votar.VerdePresiyVice;
            VerdeAlcalde5 = Votar.VerdeAlcalde;
            VerdeDiputadoNacional5 = Votar.VerdeDiputadoNacional;
            VerdeDiputadoDistrital5 = Votar.VerdeDiputadoDistrital;
            VerdeDiputadoParlacen5 = Votar.VerdeDiputadoParlacen;
            VerdeNulo5 = Votar.AzulNulo;

            RojoPresiyVice5 = Votar.RojoPresiyVice;
            RojoAlcalde5 = Votar.RojoAlcalde;
            RojoDiputadoNacional5 = Votar.RojoDiputadoNacional;
            RojoDiputadoDistrital5 = Votar.RojoDiputadoDistrital;
            RojoDiputadoParlacen5 = Votar.RojoDiputadoParlacen;
            RojoNulo5 = Votar.RojoNulo;

            NaranjaPresiyVice5 = Votar.NaranjaPresiyVice;
            NaranjaAlcalde5 = Votar.NaranjaAlcalde;
            NaranjaDiputadoNacional5 = Votar.NaranjaDiputadoNacional;
            NaranjaDiputadoDistrital5 = Votar.NaranjaDiputadoDistrital;
            NaranjaDiputadoParlacen5 = Votar.NaranjaDiputadoParlacen;
            NaranjaNulo5 = Votar.NaranjaNulo;

            AmarilloPresiyVice5 = Votar.AmarilloPresiyVice;
            AmarilloAlcalde5 = Votar.AmarilloAlcalde;
            AmarilloDiputadoNacional5 = Votar.AmarilloDiputadoNacional;
            AmarilloDiputadoDistrital5 = Votar.AmarilloDiputadoDistrital;
            AmarilloDiputadoParlacen5 = Votar.AmarilloDiputadoParlacen;
            AmarilloNulo5 = Votar.AmarilloNulo;

            Nulo5 = Votar.Nulo;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Votante Votar = new Votante();
            Votar.Show();

            RojoDiputadoParlacen5++;

            AzulPresiyVice5 = Votar.AzulPresiyVice;
            AzulAlcalde5 = Votar.AzulAlcalde;
            AzulDiputadoNacional5 = Votar.AzulDiputadoNacional;
            AzulDiputadoDistrital5 = Votar.AzulDiputadoDistrital;
            AzulDiputadoParlacen5 = Votar.AzulDiputadoParlacen;
            AzulNulo5 = Votar.AzulNulo;

            VerdePresiyVice5 = Votar.VerdePresiyVice;
            VerdeAlcalde5 = Votar.VerdeAlcalde;
            VerdeDiputadoNacional5 = Votar.VerdeDiputadoNacional;
            VerdeDiputadoDistrital5 = Votar.VerdeDiputadoDistrital;
            VerdeDiputadoParlacen5 = Votar.VerdeDiputadoParlacen;
            VerdeNulo5 = Votar.AzulNulo;

            RojoPresiyVice5 = Votar.RojoPresiyVice;
            RojoAlcalde5 = Votar.RojoAlcalde;
            RojoDiputadoNacional5 = Votar.RojoDiputadoNacional;
            RojoDiputadoDistrital5 = Votar.RojoDiputadoDistrital;
            RojoDiputadoParlacen5 = Votar.RojoDiputadoParlacen;
            RojoNulo5 = Votar.RojoNulo;

            NaranjaPresiyVice5 = Votar.NaranjaPresiyVice;
            NaranjaAlcalde5 = Votar.NaranjaAlcalde;
            NaranjaDiputadoNacional5 = Votar.NaranjaDiputadoNacional;
            NaranjaDiputadoDistrital5 = Votar.NaranjaDiputadoDistrital;
            NaranjaDiputadoParlacen5 = Votar.NaranjaDiputadoParlacen;
            NaranjaNulo5 = Votar.NaranjaNulo;

            AmarilloPresiyVice5 = Votar.AmarilloPresiyVice;
            AmarilloAlcalde5 = Votar.AmarilloAlcalde;
            AmarilloDiputadoNacional5 = Votar.AmarilloDiputadoNacional;
            AmarilloDiputadoDistrital5 = Votar.AmarilloDiputadoDistrital;
            AmarilloDiputadoParlacen5 = Votar.AmarilloDiputadoParlacen;
            AmarilloNulo5 = Votar.AmarilloNulo;

            Nulo5 = Votar.Nulo;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Votante Votar = new Votante();
            Votar.Show();

            NaranjaDiputadoParlacen5++;

            AzulPresiyVice5 = Votar.AzulPresiyVice;
            AzulAlcalde5 = Votar.AzulAlcalde;
            AzulDiputadoNacional5 = Votar.AzulDiputadoNacional;
            AzulDiputadoDistrital5 = Votar.AzulDiputadoDistrital;
            AzulDiputadoParlacen5 = Votar.AzulDiputadoParlacen;
            AzulNulo5 = Votar.AzulNulo;

            VerdePresiyVice5 = Votar.VerdePresiyVice;
            VerdeAlcalde5 = Votar.VerdeAlcalde;
            VerdeDiputadoNacional5 = Votar.VerdeDiputadoNacional;
            VerdeDiputadoDistrital5 = Votar.VerdeDiputadoDistrital;
            VerdeDiputadoParlacen5 = Votar.VerdeDiputadoParlacen;
            VerdeNulo5 = Votar.AzulNulo;

            RojoPresiyVice5 = Votar.RojoPresiyVice;
            RojoAlcalde5 = Votar.RojoAlcalde;
            RojoDiputadoNacional5 = Votar.RojoDiputadoNacional;
            RojoDiputadoDistrital5 = Votar.RojoDiputadoDistrital;
            RojoDiputadoParlacen5 = Votar.RojoDiputadoParlacen;
            RojoNulo5 = Votar.RojoNulo;

            NaranjaPresiyVice5 = Votar.NaranjaPresiyVice;
            NaranjaAlcalde5 = Votar.NaranjaAlcalde;
            NaranjaDiputadoNacional5 = Votar.NaranjaDiputadoNacional;
            NaranjaDiputadoDistrital5 = Votar.NaranjaDiputadoDistrital;
            NaranjaDiputadoParlacen5 = Votar.NaranjaDiputadoParlacen;
            NaranjaNulo5 = Votar.NaranjaNulo;

            AmarilloPresiyVice5 = Votar.AmarilloPresiyVice;
            AmarilloAlcalde5 = Votar.AmarilloAlcalde;
            AmarilloDiputadoNacional5 = Votar.AmarilloDiputadoNacional;
            AmarilloDiputadoDistrital5 = Votar.AmarilloDiputadoDistrital;
            AmarilloDiputadoParlacen5 = Votar.AmarilloDiputadoParlacen;
            AmarilloNulo5 = Votar.AmarilloNulo;

            Nulo5 = Votar.Nulo;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Votante Votar = new Votante();
            Votar.Show();

            AmarilloDiputadoParlacen5++;

            AzulPresiyVice5 = Votar.AzulPresiyVice;
            AzulAlcalde5 = Votar.AzulAlcalde;
            AzulDiputadoNacional5 = Votar.AzulDiputadoNacional;
            AzulDiputadoDistrital5 = Votar.AzulDiputadoDistrital;
            AzulDiputadoParlacen5 = Votar.AzulDiputadoParlacen;
            AzulNulo5 = Votar.AzulNulo;

            VerdePresiyVice5 = Votar.VerdePresiyVice;
            VerdeAlcalde5 = Votar.VerdeAlcalde;
            VerdeDiputadoNacional5 = Votar.VerdeDiputadoNacional;
            VerdeDiputadoDistrital5 = Votar.VerdeDiputadoDistrital;
            VerdeDiputadoParlacen5 = Votar.VerdeDiputadoParlacen;
            VerdeNulo5 = Votar.AzulNulo;

            RojoPresiyVice5 = Votar.RojoPresiyVice;
            RojoAlcalde5 = Votar.RojoAlcalde;
            RojoDiputadoNacional5 = Votar.RojoDiputadoNacional;
            RojoDiputadoDistrital5 = Votar.RojoDiputadoDistrital;
            RojoDiputadoParlacen5 = Votar.RojoDiputadoParlacen;
            RojoNulo5 = Votar.RojoNulo;

            NaranjaPresiyVice5 = Votar.NaranjaPresiyVice;
            NaranjaAlcalde5 = Votar.NaranjaAlcalde;
            NaranjaDiputadoNacional5 = Votar.NaranjaDiputadoNacional;
            NaranjaDiputadoDistrital5 = Votar.NaranjaDiputadoDistrital;
            NaranjaDiputadoParlacen5 = Votar.NaranjaDiputadoParlacen;
            NaranjaNulo5 = Votar.NaranjaNulo;

            AmarilloPresiyVice5 = Votar.AmarilloPresiyVice;
            AmarilloAlcalde5 = Votar.AmarilloAlcalde;
            AmarilloDiputadoNacional5 = Votar.AmarilloDiputadoNacional;
            AmarilloDiputadoDistrital5 = Votar.AmarilloDiputadoDistrital;
            AmarilloDiputadoParlacen5 = Votar.AmarilloDiputadoParlacen;
            AmarilloNulo5 = Votar.AmarilloNulo;

            Nulo5 = Votar.Nulo;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Votante Votar = new Votante();
            Votar.Show();

            Nulo5 = AzulNulo5 + VerdeNulo5 + RojoNulo5 + NaranjaNulo5 + AmarilloNulo5;

            AzulPresiyVice5 = Votar.AzulPresiyVice;
            AzulAlcalde5 = Votar.AzulAlcalde;
            AzulDiputadoNacional5 = Votar.AzulDiputadoNacional;
            AzulDiputadoDistrital5 = Votar.AzulDiputadoDistrital;
            AzulDiputadoParlacen5 = Votar.AzulDiputadoParlacen;
            AzulNulo5 = Votar.AzulNulo;

            VerdePresiyVice5 = Votar.VerdePresiyVice;
            VerdeAlcalde5 = Votar.VerdeAlcalde;
            VerdeDiputadoNacional5 = Votar.VerdeDiputadoNacional;
            VerdeDiputadoDistrital5 = Votar.VerdeDiputadoDistrital;
            VerdeDiputadoParlacen5 = Votar.VerdeDiputadoParlacen;
            VerdeNulo5 = Votar.AzulNulo;

            RojoPresiyVice5 = Votar.RojoPresiyVice;
            RojoAlcalde5 = Votar.RojoAlcalde;
            RojoDiputadoNacional5 = Votar.RojoDiputadoNacional;
            RojoDiputadoDistrital5 = Votar.RojoDiputadoDistrital;
            RojoDiputadoParlacen5 = Votar.RojoDiputadoParlacen;
            RojoNulo5 = Votar.RojoNulo;

            NaranjaPresiyVice5 = Votar.NaranjaPresiyVice;
            NaranjaAlcalde5 = Votar.NaranjaAlcalde;
            NaranjaDiputadoNacional5 = Votar.NaranjaDiputadoNacional;
            NaranjaDiputadoDistrital5 = Votar.NaranjaDiputadoDistrital;
            NaranjaDiputadoParlacen5 = Votar.NaranjaDiputadoParlacen;
            NaranjaNulo5 = Votar.NaranjaNulo;

            AmarilloPresiyVice5 = Votar.AmarilloPresiyVice;
            AmarilloAlcalde5 = Votar.AmarilloAlcalde;
            AmarilloDiputadoNacional5 = Votar.AmarilloDiputadoNacional;
            AmarilloDiputadoDistrital5 = Votar.AmarilloDiputadoDistrital;
            AmarilloDiputadoParlacen5 = Votar.AmarilloDiputadoParlacen;
            AmarilloNulo5 = Votar.AmarilloNulo;

            Nulo5 = Votar.Nulo;

        }
    }
}
