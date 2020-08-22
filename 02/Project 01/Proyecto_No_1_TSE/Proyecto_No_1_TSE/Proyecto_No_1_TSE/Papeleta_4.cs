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
    public partial class Papeleta_4 : Form
    {
        public int AzulPresiyVice4, AzulAlcalde4, AzulDiputadoNacional4, AzulDiputadoDistrital4, AzulDiputadoParlacen4, AzulNulo4;
        public int VerdePresiyVice4, VerdeAlcalde4, VerdeDiputadoNacional4, VerdeDiputadoDistrital4, VerdeDiputadoParlacen4, VerdeNulo4;
        public int RojoPresiyVice4, RojoAlcalde4, RojoDiputadoNacional4, RojoDiputadoDistrital4, RojoDiputadoParlacen4, RojoNulo4;
        public int NaranjaPresiyVice4, NaranjaAlcalde4, NaranjaDiputadoNacional4, NaranjaDiputadoDistrital4, NaranjaDiputadoParlacen4, NaranjaNulo4;
        public int AmarilloPresiyVice4, AmarilloAlcalde4, AmarilloDiputadoNacional4, AmarilloDiputadoDistrital4, AmarilloDiputadoParlacen4, AmarilloNulo4;
        public int Nulo4;

        public Papeleta_4()
        {
            InitializeComponent();
        }

        private void Papeleta_4_Load(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_5 Papeleta5 = new Papeleta_5();

            AzulPresiyVice4 = Papeleta5.AzulPresiyVice5;
            AzulAlcalde4 = Papeleta5.AzulAlcalde5;
            AzulDiputadoNacional4 = Papeleta5.AzulDiputadoNacional5;
            AzulDiputadoDistrital4 = Papeleta5.AzulDiputadoDistrital5;
            AzulDiputadoParlacen4 = Papeleta5.AzulDiputadoParlacen5;
            AzulNulo4 = Papeleta5.AzulNulo5;

            VerdePresiyVice4 = Papeleta5.VerdePresiyVice5;
            VerdeAlcalde4 = Papeleta5.VerdeAlcalde5;
            VerdeDiputadoNacional4 = Papeleta5.VerdeDiputadoNacional5;
            VerdeDiputadoDistrital4 = Papeleta5.VerdeDiputadoDistrital5;
            VerdeDiputadoParlacen4 = Papeleta5.VerdeDiputadoParlacen5;
            VerdeNulo4 = Papeleta5.AzulNulo5;

            RojoPresiyVice4 = Papeleta5.RojoPresiyVice5;
            RojoAlcalde4 = Papeleta5.RojoAlcalde5;
            RojoDiputadoNacional4 = Papeleta5.RojoDiputadoNacional5;
            RojoDiputadoDistrital4 = Papeleta5.RojoDiputadoDistrital5;
            RojoDiputadoParlacen4 = Papeleta5.RojoDiputadoParlacen5;
            RojoNulo4 = Papeleta5.RojoNulo5;

            NaranjaPresiyVice4 = Papeleta5.NaranjaPresiyVice5;
            NaranjaAlcalde4 = Papeleta5.NaranjaAlcalde5;
            NaranjaDiputadoNacional4 = Papeleta5.NaranjaDiputadoNacional5;
            NaranjaDiputadoDistrital4 = Papeleta5.NaranjaDiputadoDistrital5;
            NaranjaDiputadoParlacen4 = Papeleta5.NaranjaDiputadoParlacen5;
            NaranjaNulo4 = Papeleta5.NaranjaNulo5;

            AmarilloPresiyVice4 = Papeleta5.AmarilloPresiyVice5;
            AmarilloAlcalde4 = Papeleta5.AmarilloAlcalde5;
            AmarilloDiputadoNacional4 = Papeleta5.AmarilloDiputadoNacional5;
            AmarilloDiputadoDistrital4 = Papeleta5.AmarilloDiputadoDistrital5;
            AmarilloDiputadoParlacen4 = Papeleta5.AmarilloDiputadoParlacen5;
            AmarilloNulo4 = Papeleta5.AmarilloNulo5;

            Nulo4 = Papeleta5.Nulo5;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            AzulDiputadoDistrital4++;

            this.Dispose();
            Papeleta_5 Papeleta5 = new Papeleta_5();
            Papeleta5.Show();

            AzulDiputadoDistrital4++;

            AzulPresiyVice4 = Papeleta5.AzulPresiyVice5;
            AzulAlcalde4 = Papeleta5.AzulAlcalde5;
            AzulDiputadoNacional4 = Papeleta5.AzulDiputadoNacional5;
            AzulDiputadoDistrital4 = Papeleta5.AzulDiputadoDistrital5;
            AzulDiputadoParlacen4 = Papeleta5.AzulDiputadoParlacen5;
            AzulNulo4 = Papeleta5.AzulNulo5;

            VerdePresiyVice4 = Papeleta5.VerdePresiyVice5;
            VerdeAlcalde4 = Papeleta5.VerdeAlcalde5;
            VerdeDiputadoNacional4 = Papeleta5.VerdeDiputadoNacional5;
            VerdeDiputadoDistrital4 = Papeleta5.VerdeDiputadoDistrital5;
            VerdeDiputadoParlacen4 = Papeleta5.VerdeDiputadoParlacen5;
            VerdeNulo4 = Papeleta5.AzulNulo5;

            RojoPresiyVice4 = Papeleta5.RojoPresiyVice5;
            RojoAlcalde4 = Papeleta5.RojoAlcalde5;
            RojoDiputadoNacional4 = Papeleta5.RojoDiputadoNacional5;
            RojoDiputadoDistrital4 = Papeleta5.RojoDiputadoDistrital5;
            RojoDiputadoParlacen4 = Papeleta5.RojoDiputadoParlacen5;
            RojoNulo4 = Papeleta5.RojoNulo5;

            NaranjaPresiyVice4 = Papeleta5.NaranjaPresiyVice5;
            NaranjaAlcalde4 = Papeleta5.NaranjaAlcalde5;
            NaranjaDiputadoNacional4 = Papeleta5.NaranjaDiputadoNacional5;
            NaranjaDiputadoDistrital4 = Papeleta5.NaranjaDiputadoDistrital5;
            NaranjaDiputadoParlacen4 = Papeleta5.NaranjaDiputadoParlacen5;
            NaranjaNulo4 = Papeleta5.NaranjaNulo5;

            AmarilloPresiyVice4 = Papeleta5.AmarilloPresiyVice5;
            AmarilloAlcalde4 = Papeleta5.AmarilloAlcalde5;
            AmarilloDiputadoNacional4 = Papeleta5.AmarilloDiputadoNacional5;
            AmarilloDiputadoDistrital4 = Papeleta5.AmarilloDiputadoDistrital5;
            AmarilloDiputadoParlacen4 = Papeleta5.AmarilloDiputadoParlacen5;
            AmarilloNulo4 = Papeleta5.AmarilloNulo5;

            Nulo4 = Papeleta5.Nulo5;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_5 Papeleta5 = new Papeleta_5();
            Papeleta5.Show();

            VerdeDiputadoDistrital4++;

            AzulPresiyVice4 = Papeleta5.AzulPresiyVice5;
            AzulAlcalde4 = Papeleta5.AzulAlcalde5;
            AzulDiputadoNacional4 = Papeleta5.AzulDiputadoNacional5;
            AzulDiputadoDistrital4 = Papeleta5.AzulDiputadoDistrital5;
            AzulDiputadoParlacen4 = Papeleta5.AzulDiputadoParlacen5;
            AzulNulo4 = Papeleta5.AzulNulo5;

            VerdePresiyVice4 = Papeleta5.VerdePresiyVice5;
            VerdeAlcalde4 = Papeleta5.VerdeAlcalde5;
            VerdeDiputadoNacional4 = Papeleta5.VerdeDiputadoNacional5;
            VerdeDiputadoDistrital4 = Papeleta5.VerdeDiputadoDistrital5;
            VerdeDiputadoParlacen4 = Papeleta5.VerdeDiputadoParlacen5;
            VerdeNulo4 = Papeleta5.AzulNulo5;

            RojoPresiyVice4 = Papeleta5.RojoPresiyVice5;
            RojoAlcalde4 = Papeleta5.RojoAlcalde5;
            RojoDiputadoNacional4 = Papeleta5.RojoDiputadoNacional5;
            RojoDiputadoDistrital4 = Papeleta5.RojoDiputadoDistrital5;
            RojoDiputadoParlacen4 = Papeleta5.RojoDiputadoParlacen5;
            RojoNulo4 = Papeleta5.RojoNulo5;

            NaranjaPresiyVice4 = Papeleta5.NaranjaPresiyVice5;
            NaranjaAlcalde4 = Papeleta5.NaranjaAlcalde5;
            NaranjaDiputadoNacional4 = Papeleta5.NaranjaDiputadoNacional5;
            NaranjaDiputadoDistrital4 = Papeleta5.NaranjaDiputadoDistrital5;
            NaranjaDiputadoParlacen4 = Papeleta5.NaranjaDiputadoParlacen5;
            NaranjaNulo4 = Papeleta5.NaranjaNulo5;

            AmarilloPresiyVice4 = Papeleta5.AmarilloPresiyVice5;
            AmarilloAlcalde4 = Papeleta5.AmarilloAlcalde5;
            AmarilloDiputadoNacional4 = Papeleta5.AmarilloDiputadoNacional5;
            AmarilloDiputadoDistrital4 = Papeleta5.AmarilloDiputadoDistrital5;
            AmarilloDiputadoParlacen4 = Papeleta5.AmarilloDiputadoParlacen5;
            AmarilloNulo4 = Papeleta5.AmarilloNulo5;

            Nulo4 = Papeleta5.Nulo5;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_5 Papeleta5 = new Papeleta_5();
            Papeleta5.Show();

            RojoDiputadoDistrital4++;

            AzulPresiyVice4 = Papeleta5.AzulPresiyVice5;
            AzulAlcalde4 = Papeleta5.AzulAlcalde5;
            AzulDiputadoNacional4 = Papeleta5.AzulDiputadoNacional5;
            AzulDiputadoDistrital4 = Papeleta5.AzulDiputadoDistrital5;
            AzulDiputadoParlacen4 = Papeleta5.AzulDiputadoParlacen5;
            AzulNulo4 = Papeleta5.AzulNulo5;

            VerdePresiyVice4 = Papeleta5.VerdePresiyVice5;
            VerdeAlcalde4 = Papeleta5.VerdeAlcalde5;
            VerdeDiputadoNacional4 = Papeleta5.VerdeDiputadoNacional5;
            VerdeDiputadoDistrital4 = Papeleta5.VerdeDiputadoDistrital5;
            VerdeDiputadoParlacen4 = Papeleta5.VerdeDiputadoParlacen5;
            VerdeNulo4 = Papeleta5.AzulNulo5;

            RojoPresiyVice4 = Papeleta5.RojoPresiyVice5;
            RojoAlcalde4 = Papeleta5.RojoAlcalde5;
            RojoDiputadoNacional4 = Papeleta5.RojoDiputadoNacional5;
            RojoDiputadoDistrital4 = Papeleta5.RojoDiputadoDistrital5;
            RojoDiputadoParlacen4 = Papeleta5.RojoDiputadoParlacen5;
            RojoNulo4 = Papeleta5.RojoNulo5;

            NaranjaPresiyVice4 = Papeleta5.NaranjaPresiyVice5;
            NaranjaAlcalde4 = Papeleta5.NaranjaAlcalde5;
            NaranjaDiputadoNacional4 = Papeleta5.NaranjaDiputadoNacional5;
            NaranjaDiputadoDistrital4 = Papeleta5.NaranjaDiputadoDistrital5;
            NaranjaDiputadoParlacen4 = Papeleta5.NaranjaDiputadoParlacen5;
            NaranjaNulo4 = Papeleta5.NaranjaNulo5;

            AmarilloPresiyVice4 = Papeleta5.AmarilloPresiyVice5;
            AmarilloAlcalde4 = Papeleta5.AmarilloAlcalde5;
            AmarilloDiputadoNacional4 = Papeleta5.AmarilloDiputadoNacional5;
            AmarilloDiputadoDistrital4 = Papeleta5.AmarilloDiputadoDistrital5;
            AmarilloDiputadoParlacen4 = Papeleta5.AmarilloDiputadoParlacen5;
            AmarilloNulo4 = Papeleta5.AmarilloNulo5;

            Nulo4 = Papeleta5.Nulo5;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_5 Papeleta5 = new Papeleta_5();
            Papeleta5.Show();

            NaranjaDiputadoDistrital4++;

            AzulPresiyVice4 = Papeleta5.AzulPresiyVice5;
            AzulAlcalde4 = Papeleta5.AzulAlcalde5;
            AzulDiputadoNacional4 = Papeleta5.AzulDiputadoNacional5;
            AzulDiputadoDistrital4 = Papeleta5.AzulDiputadoDistrital5;
            AzulDiputadoParlacen4 = Papeleta5.AzulDiputadoParlacen5;
            AzulNulo4 = Papeleta5.AzulNulo5;

            VerdePresiyVice4 = Papeleta5.VerdePresiyVice5;
            VerdeAlcalde4 = Papeleta5.VerdeAlcalde5;
            VerdeDiputadoNacional4 = Papeleta5.VerdeDiputadoNacional5;
            VerdeDiputadoDistrital4 = Papeleta5.VerdeDiputadoDistrital5;
            VerdeDiputadoParlacen4 = Papeleta5.VerdeDiputadoParlacen5;
            VerdeNulo4 = Papeleta5.AzulNulo5;

            RojoPresiyVice4 = Papeleta5.RojoPresiyVice5;
            RojoAlcalde4 = Papeleta5.RojoAlcalde5;
            RojoDiputadoNacional4 = Papeleta5.RojoDiputadoNacional5;
            RojoDiputadoDistrital4 = Papeleta5.RojoDiputadoDistrital5;
            RojoDiputadoParlacen4 = Papeleta5.RojoDiputadoParlacen5;
            RojoNulo4 = Papeleta5.RojoNulo5;

            NaranjaPresiyVice4 = Papeleta5.NaranjaPresiyVice5;
            NaranjaAlcalde4 = Papeleta5.NaranjaAlcalde5;
            NaranjaDiputadoNacional4 = Papeleta5.NaranjaDiputadoNacional5;
            NaranjaDiputadoDistrital4 = Papeleta5.NaranjaDiputadoDistrital5;
            NaranjaDiputadoParlacen4 = Papeleta5.NaranjaDiputadoParlacen5;
            NaranjaNulo4 = Papeleta5.NaranjaNulo5;

            AmarilloPresiyVice4 = Papeleta5.AmarilloPresiyVice5;
            AmarilloAlcalde4 = Papeleta5.AmarilloAlcalde5;
            AmarilloDiputadoNacional4 = Papeleta5.AmarilloDiputadoNacional5;
            AmarilloDiputadoDistrital4 = Papeleta5.AmarilloDiputadoDistrital5;
            AmarilloDiputadoParlacen4 = Papeleta5.AmarilloDiputadoParlacen5;
            AmarilloNulo4 = Papeleta5.AmarilloNulo5;

            Nulo4 = Papeleta5.Nulo5;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_5 Papeleta5 = new Papeleta_5();
            Papeleta5.Show();

            AmarilloDiputadoDistrital4++;

            AzulPresiyVice4 = Papeleta5.AzulPresiyVice5;
            AzulAlcalde4 = Papeleta5.AzulAlcalde5;
            AzulDiputadoNacional4 = Papeleta5.AzulDiputadoNacional5;
            AzulDiputadoDistrital4 = Papeleta5.AzulDiputadoDistrital5;
            AzulDiputadoParlacen4 = Papeleta5.AzulDiputadoParlacen5;
            AzulNulo4 = Papeleta5.AzulNulo5;

            VerdePresiyVice4 = Papeleta5.VerdePresiyVice5;
            VerdeAlcalde4 = Papeleta5.VerdeAlcalde5;
            VerdeDiputadoNacional4 = Papeleta5.VerdeDiputadoNacional5;
            VerdeDiputadoDistrital4 = Papeleta5.VerdeDiputadoDistrital5;
            VerdeDiputadoParlacen4 = Papeleta5.VerdeDiputadoParlacen5;
            VerdeNulo4 = Papeleta5.AzulNulo5;

            RojoPresiyVice4 = Papeleta5.RojoPresiyVice5;
            RojoAlcalde4 = Papeleta5.RojoAlcalde5;
            RojoDiputadoNacional4 = Papeleta5.RojoDiputadoNacional5;
            RojoDiputadoDistrital4 = Papeleta5.RojoDiputadoDistrital5;
            RojoDiputadoParlacen4 = Papeleta5.RojoDiputadoParlacen5;
            RojoNulo4 = Papeleta5.RojoNulo5;

            NaranjaPresiyVice4 = Papeleta5.NaranjaPresiyVice5;
            NaranjaAlcalde4 = Papeleta5.NaranjaAlcalde5;
            NaranjaDiputadoNacional4 = Papeleta5.NaranjaDiputadoNacional5;
            NaranjaDiputadoDistrital4 = Papeleta5.NaranjaDiputadoDistrital5;
            NaranjaDiputadoParlacen4 = Papeleta5.NaranjaDiputadoParlacen5;
            NaranjaNulo4 = Papeleta5.NaranjaNulo5;

            AmarilloPresiyVice4 = Papeleta5.AmarilloPresiyVice5;
            AmarilloAlcalde4 = Papeleta5.AmarilloAlcalde5;
            AmarilloDiputadoNacional4 = Papeleta5.AmarilloDiputadoNacional5;
            AmarilloDiputadoDistrital4 = Papeleta5.AmarilloDiputadoDistrital5;
            AmarilloDiputadoParlacen4 = Papeleta5.AmarilloDiputadoParlacen5;
            AmarilloNulo4 = Papeleta5.AmarilloNulo5;

            Nulo4 = Papeleta5.Nulo5;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_5 Papeleta5 = new Papeleta_5();
            Papeleta5.Show();

            Nulo4 = AzulNulo4 + VerdeNulo4 + RojoNulo4 + NaranjaNulo4 + AmarilloNulo4;

            AzulPresiyVice4 = Papeleta5.AzulPresiyVice5;
            AzulAlcalde4 = Papeleta5.AzulAlcalde5;
            AzulDiputadoNacional4 = Papeleta5.AzulDiputadoNacional5;
            AzulDiputadoDistrital4 = Papeleta5.AzulDiputadoDistrital5;
            AzulDiputadoParlacen4 = Papeleta5.AzulDiputadoParlacen5;
            AzulNulo4 = Papeleta5.AzulNulo5;

            VerdePresiyVice4 = Papeleta5.VerdePresiyVice5;
            VerdeAlcalde4 = Papeleta5.VerdeAlcalde5;
            VerdeDiputadoNacional4 = Papeleta5.VerdeDiputadoNacional5;
            VerdeDiputadoDistrital4 = Papeleta5.VerdeDiputadoDistrital5;
            VerdeDiputadoParlacen4 = Papeleta5.VerdeDiputadoParlacen5;
            VerdeNulo4 = Papeleta5.AzulNulo5;

            RojoPresiyVice4 = Papeleta5.RojoPresiyVice5;
            RojoAlcalde4 = Papeleta5.RojoAlcalde5;
            RojoDiputadoNacional4 = Papeleta5.RojoDiputadoNacional5;
            RojoDiputadoDistrital4 = Papeleta5.RojoDiputadoDistrital5;
            RojoDiputadoParlacen4 = Papeleta5.RojoDiputadoParlacen5;
            RojoNulo4 = Papeleta5.RojoNulo5;

            NaranjaPresiyVice4 = Papeleta5.NaranjaPresiyVice5;
            NaranjaAlcalde4 = Papeleta5.NaranjaAlcalde5;
            NaranjaDiputadoNacional4 = Papeleta5.NaranjaDiputadoNacional5;
            NaranjaDiputadoDistrital4 = Papeleta5.NaranjaDiputadoDistrital5;
            NaranjaDiputadoParlacen4 = Papeleta5.NaranjaDiputadoParlacen5;
            NaranjaNulo4 = Papeleta5.NaranjaNulo5;

            AmarilloPresiyVice4 = Papeleta5.AmarilloPresiyVice5;
            AmarilloAlcalde4 = Papeleta5.AmarilloAlcalde5;
            AmarilloDiputadoNacional4 = Papeleta5.AmarilloDiputadoNacional5;
            AmarilloDiputadoDistrital4 = Papeleta5.AmarilloDiputadoDistrital5;
            AmarilloDiputadoParlacen4 = Papeleta5.AmarilloDiputadoParlacen5;
            AmarilloNulo4 = Papeleta5.AmarilloNulo5;

            Nulo4 = Papeleta5.Nulo5;

        }
    }
}
