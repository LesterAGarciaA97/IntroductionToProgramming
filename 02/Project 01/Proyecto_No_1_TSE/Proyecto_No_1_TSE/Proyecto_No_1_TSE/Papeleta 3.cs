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
    public partial class Papeleta_3 : Form
    {
        public int AzulPresiyVice3, AzulAlcalde3, AzulDiputadoNacional3, AzulDiputadoDistrital3, AzulDiputadoParlacen3, AzulNulo3;
        public int VerdePresiyVice3, VerdeAlcalde3, VerdeDiputadoNacional3, VerdeDiputadoDistrital3, VerdeDiputadoParlacen3, VerdeNulo3;
        public int RojoPresiyVice3, RojoAlcalde3, RojoDiputadoNacional3, RojoDiputadoDistrital3, RojoDiputadoParlacen3, RojoNulo3;
        public int NaranjaPresiyVice3, NaranjaAlcalde3, NaranjaDiputadoNacional3, NaranjaDiputadoDistrital3, NaranjaDiputadoParlacen3, NaranjaNulo3;
        public int AmarilloPresiyVice3, AmarilloAlcalde3, AmarilloDiputadoNacional3, AmarilloDiputadoDistrital3, AmarilloDiputadoParlacen3, AmarilloNulo3;
        public int Nulo3;

        public Papeleta_3()
        {
            InitializeComponent();
        }

        private void Papeleta_3_Load(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_4 Papeleta4 = new Papeleta_4();

            AzulPresiyVice3 = Papeleta4.AzulPresiyVice4;
            AzulAlcalde3 = Papeleta4.AzulAlcalde4;
            AzulDiputadoNacional3 = Papeleta4.AzulDiputadoNacional4;
            AzulDiputadoDistrital3 = Papeleta4.AzulDiputadoDistrital4;
            AzulDiputadoParlacen3 = Papeleta4.AzulDiputadoParlacen4;
            AzulNulo3 = Papeleta4.AzulNulo4;

            VerdePresiyVice3 = Papeleta4.VerdePresiyVice4;
            VerdeAlcalde3 = Papeleta4.VerdeAlcalde4;
            VerdeDiputadoNacional3 = Papeleta4.VerdeDiputadoNacional4;
            VerdeDiputadoDistrital3 = Papeleta4.VerdeDiputadoDistrital4;
            VerdeDiputadoParlacen3 = Papeleta4.VerdeDiputadoParlacen4;
            VerdeNulo3 = Papeleta4.AzulNulo4;

            RojoPresiyVice3 = Papeleta4.RojoPresiyVice4;
            RojoAlcalde3 = Papeleta4.RojoAlcalde4;
            RojoDiputadoNacional3 = Papeleta4.RojoDiputadoNacional4;
            RojoDiputadoDistrital3 = Papeleta4.RojoDiputadoDistrital4;
            RojoDiputadoParlacen3 = Papeleta4.RojoDiputadoParlacen4;
            RojoNulo3 = Papeleta4.RojoNulo4;

            NaranjaPresiyVice3 = Papeleta4.NaranjaPresiyVice4;
            NaranjaAlcalde3 = Papeleta4.NaranjaAlcalde4;
            NaranjaDiputadoNacional3 = Papeleta4.NaranjaDiputadoNacional4;
            NaranjaDiputadoDistrital3 = Papeleta4.NaranjaDiputadoDistrital4;
            NaranjaDiputadoParlacen3 = Papeleta4.NaranjaDiputadoParlacen4;
            NaranjaNulo3 = Papeleta4.NaranjaNulo4;

            AmarilloPresiyVice3 = Papeleta4.AmarilloPresiyVice4;
            AmarilloAlcalde3 = Papeleta4.AmarilloAlcalde4;
            AmarilloDiputadoNacional3 = Papeleta4.AmarilloDiputadoNacional4;
            AmarilloDiputadoDistrital3 = Papeleta4.AmarilloDiputadoDistrital4;
            AmarilloDiputadoParlacen3 = Papeleta4.AmarilloDiputadoParlacen4;
            AmarilloNulo3 = Papeleta4.AmarilloNulo4;

            Nulo3 = Papeleta4.Nulo4;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_4 Papeleta4 = new Papeleta_4();
            Papeleta4.Show();

            AzulDiputadoNacional3++;

            AzulPresiyVice3 = Papeleta4.AzulPresiyVice4;
            AzulAlcalde3 = Papeleta4.AzulAlcalde4;
            AzulDiputadoNacional3 = Papeleta4.AzulDiputadoNacional4;
            AzulDiputadoDistrital3 = Papeleta4.AzulDiputadoDistrital4;
            AzulDiputadoParlacen3 = Papeleta4.AzulDiputadoParlacen4;
            AzulNulo3 = Papeleta4.AzulNulo4;

            VerdePresiyVice3 = Papeleta4.VerdePresiyVice4;
            VerdeAlcalde3 = Papeleta4.VerdeAlcalde4;
            VerdeDiputadoNacional3 = Papeleta4.VerdeDiputadoNacional4;
            VerdeDiputadoDistrital3 = Papeleta4.VerdeDiputadoDistrital4;
            VerdeDiputadoParlacen3 = Papeleta4.VerdeDiputadoParlacen4;
            VerdeNulo3 = Papeleta4.AzulNulo4;

            RojoPresiyVice3 = Papeleta4.RojoPresiyVice4;
            RojoAlcalde3 = Papeleta4.RojoAlcalde4;
            RojoDiputadoNacional3 = Papeleta4.RojoDiputadoNacional4;
            RojoDiputadoDistrital3 = Papeleta4.RojoDiputadoDistrital4;
            RojoDiputadoParlacen3 = Papeleta4.RojoDiputadoParlacen4;
            RojoNulo3 = Papeleta4.RojoNulo4;

            NaranjaPresiyVice3 = Papeleta4.NaranjaPresiyVice4;
            NaranjaAlcalde3 = Papeleta4.NaranjaAlcalde4;
            NaranjaDiputadoNacional3 = Papeleta4.NaranjaDiputadoNacional4;
            NaranjaDiputadoDistrital3 = Papeleta4.NaranjaDiputadoDistrital4;
            NaranjaDiputadoParlacen3 = Papeleta4.NaranjaDiputadoParlacen4;
            NaranjaNulo3 = Papeleta4.NaranjaNulo4;

            AmarilloPresiyVice3 = Papeleta4.AmarilloPresiyVice4;
            AmarilloAlcalde3 = Papeleta4.AmarilloAlcalde4;
            AmarilloDiputadoNacional3 = Papeleta4.AmarilloDiputadoNacional4;
            AmarilloDiputadoDistrital3 = Papeleta4.AmarilloDiputadoDistrital4;
            AmarilloDiputadoParlacen3 = Papeleta4.AmarilloDiputadoParlacen4;
            AmarilloNulo3 = Papeleta4.AmarilloNulo4;

            Nulo3 = Papeleta4.Nulo4;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_4 Papeleta4 = new Papeleta_4();
            Papeleta4.Show();

            VerdeDiputadoNacional3++;

            AzulPresiyVice3 = Papeleta4.AzulPresiyVice4;
            AzulAlcalde3 = Papeleta4.AzulAlcalde4;
            AzulDiputadoNacional3 = Papeleta4.AzulDiputadoNacional4;
            AzulDiputadoDistrital3 = Papeleta4.AzulDiputadoDistrital4;
            AzulDiputadoParlacen3 = Papeleta4.AzulDiputadoParlacen4;
            AzulNulo3 = Papeleta4.AzulNulo4;

            VerdePresiyVice3 = Papeleta4.VerdePresiyVice4;
            VerdeAlcalde3 = Papeleta4.VerdeAlcalde4;
            VerdeDiputadoNacional3 = Papeleta4.VerdeDiputadoNacional4;
            VerdeDiputadoDistrital3 = Papeleta4.VerdeDiputadoDistrital4;
            VerdeDiputadoParlacen3 = Papeleta4.VerdeDiputadoParlacen4;
            VerdeNulo3 = Papeleta4.AzulNulo4;

            RojoPresiyVice3 = Papeleta4.RojoPresiyVice4;
            RojoAlcalde3 = Papeleta4.RojoAlcalde4;
            RojoDiputadoNacional3 = Papeleta4.RojoDiputadoNacional4;
            RojoDiputadoDistrital3 = Papeleta4.RojoDiputadoDistrital4;
            RojoDiputadoParlacen3 = Papeleta4.RojoDiputadoParlacen4;
            RojoNulo3 = Papeleta4.RojoNulo4;

            NaranjaPresiyVice3 = Papeleta4.NaranjaPresiyVice4;
            NaranjaAlcalde3 = Papeleta4.NaranjaAlcalde4;
            NaranjaDiputadoNacional3 = Papeleta4.NaranjaDiputadoNacional4;
            NaranjaDiputadoDistrital3 = Papeleta4.NaranjaDiputadoDistrital4;
            NaranjaDiputadoParlacen3 = Papeleta4.NaranjaDiputadoParlacen4;
            NaranjaNulo3 = Papeleta4.NaranjaNulo4;

            AmarilloPresiyVice3 = Papeleta4.AmarilloPresiyVice4;
            AmarilloAlcalde3 = Papeleta4.AmarilloAlcalde4;
            AmarilloDiputadoNacional3 = Papeleta4.AmarilloDiputadoNacional4;
            AmarilloDiputadoDistrital3 = Papeleta4.AmarilloDiputadoDistrital4;
            AmarilloDiputadoParlacen3 = Papeleta4.AmarilloDiputadoParlacen4;
            AmarilloNulo3 = Papeleta4.AmarilloNulo4;

            Nulo3 = Papeleta4.Nulo4;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_4 Papeleta4 = new Papeleta_4();
            Papeleta4.Show();

            RojoDiputadoNacional3++;

            AzulPresiyVice3 = Papeleta4.AzulPresiyVice4;
            AzulAlcalde3 = Papeleta4.AzulAlcalde4;
            AzulDiputadoNacional3 = Papeleta4.AzulDiputadoNacional4;
            AzulDiputadoDistrital3 = Papeleta4.AzulDiputadoDistrital4;
            AzulDiputadoParlacen3 = Papeleta4.AzulDiputadoParlacen4;
            AzulNulo3 = Papeleta4.AzulNulo4;

            VerdePresiyVice3 = Papeleta4.VerdePresiyVice4;
            VerdeAlcalde3 = Papeleta4.VerdeAlcalde4;
            VerdeDiputadoNacional3 = Papeleta4.VerdeDiputadoNacional4;
            VerdeDiputadoDistrital3 = Papeleta4.VerdeDiputadoDistrital4;
            VerdeDiputadoParlacen3 = Papeleta4.VerdeDiputadoParlacen4;
            VerdeNulo3 = Papeleta4.AzulNulo4;

            RojoPresiyVice3 = Papeleta4.RojoPresiyVice4;
            RojoAlcalde3 = Papeleta4.RojoAlcalde4;
            RojoDiputadoNacional3 = Papeleta4.RojoDiputadoNacional4;
            RojoDiputadoDistrital3 = Papeleta4.RojoDiputadoDistrital4;
            RojoDiputadoParlacen3 = Papeleta4.RojoDiputadoParlacen4;
            RojoNulo3 = Papeleta4.RojoNulo4;

            NaranjaPresiyVice3 = Papeleta4.NaranjaPresiyVice4;
            NaranjaAlcalde3 = Papeleta4.NaranjaAlcalde4;
            NaranjaDiputadoNacional3 = Papeleta4.NaranjaDiputadoNacional4;
            NaranjaDiputadoDistrital3 = Papeleta4.NaranjaDiputadoDistrital4;
            NaranjaDiputadoParlacen3 = Papeleta4.NaranjaDiputadoParlacen4;
            NaranjaNulo3 = Papeleta4.NaranjaNulo4;

            AmarilloPresiyVice3 = Papeleta4.AmarilloPresiyVice4;
            AmarilloAlcalde3 = Papeleta4.AmarilloAlcalde4;
            AmarilloDiputadoNacional3 = Papeleta4.AmarilloDiputadoNacional4;
            AmarilloDiputadoDistrital3 = Papeleta4.AmarilloDiputadoDistrital4;
            AmarilloDiputadoParlacen3 = Papeleta4.AmarilloDiputadoParlacen4;
            AmarilloNulo3 = Papeleta4.AmarilloNulo4;

            Nulo3 = Papeleta4.Nulo4;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_4 Papeleta4 = new Papeleta_4();
            Papeleta4.Show();

            NaranjaDiputadoNacional3++;

            AzulPresiyVice3 = Papeleta4.AzulPresiyVice4;
            AzulAlcalde3 = Papeleta4.AzulAlcalde4;
            AzulDiputadoNacional3 = Papeleta4.AzulDiputadoNacional4;
            AzulDiputadoDistrital3 = Papeleta4.AzulDiputadoDistrital4;
            AzulDiputadoParlacen3 = Papeleta4.AzulDiputadoParlacen4;
            AzulNulo3 = Papeleta4.AzulNulo4;

            VerdePresiyVice3 = Papeleta4.VerdePresiyVice4;
            VerdeAlcalde3 = Papeleta4.VerdeAlcalde4;
            VerdeDiputadoNacional3 = Papeleta4.VerdeDiputadoNacional4;
            VerdeDiputadoDistrital3 = Papeleta4.VerdeDiputadoDistrital4;
            VerdeDiputadoParlacen3 = Papeleta4.VerdeDiputadoParlacen4;
            VerdeNulo3 = Papeleta4.AzulNulo4;

            RojoPresiyVice3 = Papeleta4.RojoPresiyVice4;
            RojoAlcalde3 = Papeleta4.RojoAlcalde4;
            RojoDiputadoNacional3 = Papeleta4.RojoDiputadoNacional4;
            RojoDiputadoDistrital3 = Papeleta4.RojoDiputadoDistrital4;
            RojoDiputadoParlacen3 = Papeleta4.RojoDiputadoParlacen4;
            RojoNulo3 = Papeleta4.RojoNulo4;

            NaranjaPresiyVice3 = Papeleta4.NaranjaPresiyVice4;
            NaranjaAlcalde3 = Papeleta4.NaranjaAlcalde4;
            NaranjaDiputadoNacional3 = Papeleta4.NaranjaDiputadoNacional4;
            NaranjaDiputadoDistrital3 = Papeleta4.NaranjaDiputadoDistrital4;
            NaranjaDiputadoParlacen3 = Papeleta4.NaranjaDiputadoParlacen4;
            NaranjaNulo3 = Papeleta4.NaranjaNulo4;

            AmarilloPresiyVice3 = Papeleta4.AmarilloPresiyVice4;
            AmarilloAlcalde3 = Papeleta4.AmarilloAlcalde4;
            AmarilloDiputadoNacional3 = Papeleta4.AmarilloDiputadoNacional4;
            AmarilloDiputadoDistrital3 = Papeleta4.AmarilloDiputadoDistrital4;
            AmarilloDiputadoParlacen3 = Papeleta4.AmarilloDiputadoParlacen4;
            AmarilloNulo3 = Papeleta4.AmarilloNulo4;

            Nulo3 = Papeleta4.Nulo4;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_4 Papeleta4 = new Papeleta_4();
            Papeleta4.Show();

            AmarilloDiputadoNacional3++;

            AzulPresiyVice3 = Papeleta4.AzulPresiyVice4;
            AzulAlcalde3 = Papeleta4.AzulAlcalde4;
            AzulDiputadoNacional3 = Papeleta4.AzulDiputadoNacional4;
            AzulDiputadoDistrital3 = Papeleta4.AzulDiputadoDistrital4;
            AzulDiputadoParlacen3 = Papeleta4.AzulDiputadoParlacen4;
            AzulNulo3 = Papeleta4.AzulNulo4;

            VerdePresiyVice3 = Papeleta4.VerdePresiyVice4;
            VerdeAlcalde3 = Papeleta4.VerdeAlcalde4;
            VerdeDiputadoNacional3 = Papeleta4.VerdeDiputadoNacional4;
            VerdeDiputadoDistrital3 = Papeleta4.VerdeDiputadoDistrital4;
            VerdeDiputadoParlacen3 = Papeleta4.VerdeDiputadoParlacen4;
            VerdeNulo3 = Papeleta4.AzulNulo4;

            RojoPresiyVice3 = Papeleta4.RojoPresiyVice4;
            RojoAlcalde3 = Papeleta4.RojoAlcalde4;
            RojoDiputadoNacional3 = Papeleta4.RojoDiputadoNacional4;
            RojoDiputadoDistrital3 = Papeleta4.RojoDiputadoDistrital4;
            RojoDiputadoParlacen3 = Papeleta4.RojoDiputadoParlacen4;
            RojoNulo3 = Papeleta4.RojoNulo4;

            NaranjaPresiyVice3 = Papeleta4.NaranjaPresiyVice4;
            NaranjaAlcalde3 = Papeleta4.NaranjaAlcalde4;
            NaranjaDiputadoNacional3 = Papeleta4.NaranjaDiputadoNacional4;
            NaranjaDiputadoDistrital3 = Papeleta4.NaranjaDiputadoDistrital4;
            NaranjaDiputadoParlacen3 = Papeleta4.NaranjaDiputadoParlacen4;
            NaranjaNulo3 = Papeleta4.NaranjaNulo4;

            AmarilloPresiyVice3 = Papeleta4.AmarilloPresiyVice4;
            AmarilloAlcalde3 = Papeleta4.AmarilloAlcalde4;
            AmarilloDiputadoNacional3 = Papeleta4.AmarilloDiputadoNacional4;
            AmarilloDiputadoDistrital3 = Papeleta4.AmarilloDiputadoDistrital4;
            AmarilloDiputadoParlacen3 = Papeleta4.AmarilloDiputadoParlacen4;
            AmarilloNulo3 = Papeleta4.AmarilloNulo4;

            Nulo3 = Papeleta4.Nulo4;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Papeleta_4 Papeleta4 = new Papeleta_4();
            Papeleta4.Show();

            Nulo3 = AzulNulo3 + VerdeNulo3 + RojoNulo3 + NaranjaNulo3 + AmarilloNulo3;

            AzulPresiyVice3 = Papeleta4.AzulPresiyVice4;
            AzulAlcalde3 = Papeleta4.AzulAlcalde4;
            AzulDiputadoNacional3 = Papeleta4.AzulDiputadoNacional4;
            AzulDiputadoDistrital3 = Papeleta4.AzulDiputadoDistrital4;
            AzulDiputadoParlacen3 = Papeleta4.AzulDiputadoParlacen4;
            AzulNulo3 = Papeleta4.AzulNulo4;

            VerdePresiyVice3 = Papeleta4.VerdePresiyVice4;
            VerdeAlcalde3 = Papeleta4.VerdeAlcalde4;
            VerdeDiputadoNacional3 = Papeleta4.VerdeDiputadoNacional4;
            VerdeDiputadoDistrital3 = Papeleta4.VerdeDiputadoDistrital4;
            VerdeDiputadoParlacen3 = Papeleta4.VerdeDiputadoParlacen4;
            VerdeNulo3 = Papeleta4.AzulNulo4;

            RojoPresiyVice3 = Papeleta4.RojoPresiyVice4;
            RojoAlcalde3 = Papeleta4.RojoAlcalde4;
            RojoDiputadoNacional3 = Papeleta4.RojoDiputadoNacional4;
            RojoDiputadoDistrital3 = Papeleta4.RojoDiputadoDistrital4;
            RojoDiputadoParlacen3 = Papeleta4.RojoDiputadoParlacen4;
            RojoNulo3 = Papeleta4.RojoNulo4;

            NaranjaPresiyVice3 = Papeleta4.NaranjaPresiyVice4;
            NaranjaAlcalde3 = Papeleta4.NaranjaAlcalde4;
            NaranjaDiputadoNacional3 = Papeleta4.NaranjaDiputadoNacional4;
            NaranjaDiputadoDistrital3 = Papeleta4.NaranjaDiputadoDistrital4;
            NaranjaDiputadoParlacen3 = Papeleta4.NaranjaDiputadoParlacen4;
            NaranjaNulo3 = Papeleta4.NaranjaNulo4;

            AmarilloPresiyVice3 = Papeleta4.AmarilloPresiyVice4;
            AmarilloAlcalde3 = Papeleta4.AmarilloAlcalde4;
            AmarilloDiputadoNacional3 = Papeleta4.AmarilloDiputadoNacional4;
            AmarilloDiputadoDistrital3 = Papeleta4.AmarilloDiputadoDistrital4;
            AmarilloDiputadoParlacen3 = Papeleta4.AmarilloDiputadoParlacen4;
            AmarilloNulo3 = Papeleta4.AmarilloNulo4;

            Nulo3 = Papeleta4.Nulo4;

        }
    }
}
