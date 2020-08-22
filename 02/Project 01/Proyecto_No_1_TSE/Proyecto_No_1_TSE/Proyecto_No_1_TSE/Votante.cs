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
    public partial class Votante : Form
    {
        public int AzulPresiyVice, AzulAlcalde, AzulDiputadoNacional, AzulDiputadoDistrital, AzulDiputadoParlacen, AzulNulo;
        public int VerdePresiyVice, VerdeAlcalde, VerdeDiputadoNacional, VerdeDiputadoDistrital, VerdeDiputadoParlacen, VerdeNulo;
        public int RojoPresiyVice, RojoAlcalde, RojoDiputadoNacional, RojoDiputadoDistrital, RojoDiputadoParlacen, RojoNulo;
        public int NaranjaPresiyVice, NaranjaAlcalde, NaranjaDiputadoNacional, NaranjaDiputadoDistrital, NaranjaDiputadoParlacen, NaranjaNulo;
        public int AmarilloPresiyVice, AmarilloAlcalde, AmarilloDiputadoNacional, AmarilloDiputadoDistrital, AmarilloDiputadoParlacen, AmarilloNulo;
        public int Nulo;
        Int32 contador, num;

        public Votante()
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

            AzulPresiyVice = Login.AzulPresiyVice6;
            AzulAlcalde = Login.AzulAlcalde6;
            AzulDiputadoNacional = Login.AzulDiputadoNacional6;
            AzulDiputadoDistrital = Login.AzulDiputadoDistrital6;
            AzulDiputadoParlacen = Login.AzulDiputadoParlacen6;
            AzulNulo = Login.AzulNulo6;

            VerdePresiyVice = Login.VerdePresiyVice6;
            VerdeAlcalde = Login.VerdeAlcalde6;
            VerdeDiputadoNacional = Login.VerdeDiputadoNacional6;
            VerdeDiputadoDistrital = Login.VerdeDiputadoDistrital6;
            VerdeDiputadoParlacen = Login.VerdeDiputadoParlacen6;
            VerdeNulo = Login.AzulNulo6;

            RojoPresiyVice = Login.RojoPresiyVice6;
            RojoAlcalde = Login.RojoAlcalde6;
            RojoDiputadoNacional = Login.RojoDiputadoNacional6;
            RojoDiputadoDistrital = Login.RojoDiputadoDistrital6;
            RojoDiputadoParlacen = Login.RojoDiputadoParlacen6;
            RojoNulo = Login.RojoNulo6;

            NaranjaPresiyVice = Login.NaranjaPresiyVice6;
            NaranjaAlcalde = Login.NaranjaAlcalde6;
            NaranjaDiputadoNacional = Login.NaranjaDiputadoNacional6;
            NaranjaDiputadoDistrital = Login.NaranjaDiputadoDistrital6;
            NaranjaDiputadoParlacen = Login.NaranjaDiputadoParlacen6;
            NaranjaNulo = Login.NaranjaNulo6;

            AmarilloPresiyVice = Login.AmarilloPresiyVice6;
            AmarilloAlcalde = Login.AmarilloAlcalde6;
            AmarilloDiputadoNacional = Login.AmarilloDiputadoNacional6;
            AmarilloDiputadoDistrital = Login.AmarilloDiputadoDistrital6;
            AmarilloDiputadoParlacen = Login.AmarilloDiputadoParlacen6;
            AmarilloNulo = Login.AmarilloNulo6;

            Nulo = Login.Nulo6;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Papeleta_1 Papeleta1 = new Papeleta_1();
            Papeleta1.Show();

            AzulPresiyVice = Papeleta1.AzulPresiyVice1;
            AzulAlcalde = Papeleta1.AzulAlcalde1;
            AzulDiputadoNacional = Papeleta1.AzulDiputadoNacional1;
            AzulDiputadoDistrital = Papeleta1.AzulDiputadoDistrital1;
            AzulDiputadoParlacen = Papeleta1.AzulDiputadoParlacen1;
            AzulNulo = Papeleta1.AzulNulo1;

            VerdePresiyVice = Papeleta1.VerdePresiyVice1;
            VerdeAlcalde = Papeleta1.VerdeAlcalde1;
            VerdeDiputadoNacional = Papeleta1.VerdeDiputadoNacional1;
            VerdeDiputadoDistrital = Papeleta1.VerdeDiputadoDistrital1;
            VerdeDiputadoParlacen = Papeleta1.VerdeDiputadoParlacen1;
            VerdeNulo = Papeleta1.AzulNulo1;

            RojoPresiyVice = Papeleta1.RojoPresiyVice1;
            RojoAlcalde = Papeleta1.RojoAlcalde1;
            RojoDiputadoNacional = Papeleta1.RojoDiputadoNacional1;
            RojoDiputadoDistrital = Papeleta1.RojoDiputadoDistrital1;
            RojoDiputadoParlacen = Papeleta1.RojoDiputadoParlacen1;
            RojoNulo = Papeleta1.RojoNulo1;

            NaranjaPresiyVice = Papeleta1.NaranjaPresiyVice1;
            NaranjaAlcalde = Papeleta1.NaranjaAlcalde1;
            NaranjaDiputadoNacional = Papeleta1.NaranjaDiputadoNacional1;
            NaranjaDiputadoDistrital = Papeleta1.NaranjaDiputadoDistrital1;
            NaranjaDiputadoParlacen = Papeleta1.NaranjaDiputadoParlacen1;
            NaranjaNulo = Papeleta1.NaranjaNulo1;

            AmarilloPresiyVice = Papeleta1.AmarilloPresiyVice1;
            AmarilloAlcalde = Papeleta1.AmarilloAlcalde1;
            AmarilloDiputadoNacional = Papeleta1.AmarilloDiputadoNacional1;
            AmarilloDiputadoDistrital = Papeleta1.AmarilloDiputadoDistrital1;
            AmarilloDiputadoParlacen = Papeleta1.AmarilloDiputadoParlacen1;
            AmarilloNulo = Papeleta1.AmarilloNulo1;

            Nulo = Papeleta1.Nulo1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int a = r.Next(1, 6);
            int b = r.Next(1, 6);
            int c = r.Next(1, 6);
            int d = r.Next(1, 6);
            int f = r.Next(1, 6);
            int g = r.Next(1, 6);
            contador = Convert.ToInt32(txt1.Text);

            label3.Text = ("Han sido ingresados " + txt1.Text + " votos aleatorios");
            while (num <= contador)
            {
                switch (a)
                {
                    case 1:
                        AzulPresiyVice++;
                        break;
                    case 2:
                        AzulAlcalde++;
                        break;
                    case 3:
                        AzulDiputadoNacional++;
                        break;
                    case 4:
                        AzulDiputadoDistrital++;
                        break;
                    case 5:
                        AzulDiputadoParlacen++;
                        break;
                    case 6:
                        AzulNulo++;
                        break;
                }
                switch (b)
                {
                    case 1:
                        VerdePresiyVice++;
                        break;
                    case 2:
                        VerdeAlcalde++;
                        break;
                    case 3:
                        VerdeDiputadoNacional++;
                        break;
                    case 4:
                        VerdeDiputadoDistrital++;
                        break;
                    case 5:
                        VerdeDiputadoParlacen++;
                        break;
                    case 6:
                        VerdeNulo++;
                        break;
                }
                switch (c)
                {
                    case 1:
                        RojoPresiyVice++;
                        break;
                    case 2:
                        RojoAlcalde++;
                        break;
                    case 3:
                        RojoDiputadoNacional++;
                        break;
                    case 4:
                        RojoDiputadoDistrital++;
                        break;
                    case 5:
                        RojoDiputadoParlacen++;
                        break;
                    case 6:
                        RojoNulo++;
                        break;
                }
                switch (d)
                {
                    case 1:
                        NaranjaPresiyVice++;
                        break;
                    case 2:
                        NaranjaAlcalde++;
                        break;
                    case 3:
                        NaranjaDiputadoNacional++;
                        break;
                    case 4:
                        NaranjaDiputadoDistrital++;
                        break;
                    case 5:
                        NaranjaDiputadoParlacen++;
                        break;
                    case 6:
                        NaranjaNulo++;
                        break;
                }
                switch (f)
                {
                    case 1:
                        AmarilloPresiyVice++;
                        break;
                    case 2:
                        AmarilloAlcalde++;
                        break;
                    case 3:
                        AmarilloDiputadoNacional++;
                        break;
                    case 4:
                        AmarilloDiputadoDistrital++;
                        break;
                    case 5:
                        AmarilloDiputadoParlacen++;
                        break;
                    case 6:
                        AmarilloNulo++;
                        break;
                }
                switch (g)
                {
                    case 1:
                        Nulo++;
                        break;
                    
                }
                num++;
            }
        }
    }
}