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
    public partial class votante : Form
    {
        public votante()
        {
            InitializeComponent();
        }
        public static PictureBox imagen = null;
        private void votante_Load(object sender, EventArgs e)
        {
            foreach (Partidos partido in Form1.partidosPoliticos)
            {
                cbPartidos.Items.Add(partido.NombredelPartido);
            }
            label2.Text = Form1.totalVotos.ToString() + " han votado";
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void btnVotarAleatorio_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(txtCantidadAleatorios.Text);
                int i = 0;
                Random random = new Random();
                int numero = 0;
                int cantidadPartidos = Form1.partidosPoliticos.Count;
                while (i < cantidad)
                {
                    Form1.totalVotos++;
                    numero = random.Next(0, Form1.partidosPoliticos.Count);
                    Form1.partidosPoliticos[numero].Presidente();

                    numero = random.Next(0, Form1.partidosPoliticos.Count);
                    Form1.partidosPoliticos[numero].Alcalde();

                    numero = random.Next(0, Form1.partidosPoliticos.Count);
                    Form1.partidosPoliticos[numero].Nacionales();

                    numero = random.Next(0, Form1.partidosPoliticos.Count);
                    Form1.partidosPoliticos[numero].Distritales();

                    numero = random.Next(0, Form1.partidosPoliticos.Count);
                    Form1.partidosPoliticos[numero].Parlacen();
                    i++;
                }
                label2.Text = Form1.totalVotos.ToString() + " han votado";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            while (i < Form1.partidosPoliticos.Count)
            {
                if (cbPartidos.SelectedItem.ToString() == Form1.partidosPoliticos[i].NombredelPartido)
                {
                    pictureBox1.BackgroundImage = System.Drawing.Image.FromFile(Form1.partidosPoliticos[i].Imagen);
                }
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = cbPartidos.SelectedItem.ToString();
            int largo = Form1.partidosPoliticos.Count;
            int i = 0;
            while (i < largo)
            {
                if (Form1.partidosPoliticos[i].NombredelPartido == nombre)
                {
                    Form1.partidosPoliticos[i].Presidente();
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = cbPartidos.SelectedItem.ToString();
            int largo = Form1.partidosPoliticos.Count;
            int i = 0;
            while (i < largo)
            {
                if (Form1.partidosPoliticos[i].NombredelPartido == nombre)
                {
                    Form1.partidosPoliticos[i].Alcalde();
                    button2.Enabled = false;
                    button3.Enabled = true;
                }
                i++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nombre = cbPartidos.SelectedItem.ToString();
            int largo = Form1.partidosPoliticos.Count;
            int i = 0;
            while (i < largo)
            {
                if (Form1.partidosPoliticos[i].NombredelPartido == nombre)
                {
                    Form1.partidosPoliticos[i].Nacionales();
                    button3.Enabled = false;
                    button4.Enabled = true;
                }
                i++;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string nombre = cbPartidos.SelectedItem.ToString();
            int largo = Form1.partidosPoliticos.Count;
            int i = 0;
            while (i < largo)
            {
                if (Form1.partidosPoliticos[i].NombredelPartido == nombre)
                {
                    Form1.partidosPoliticos[i].Distritales();
                    button4.Enabled = false;
                    button5.Enabled = true;
                }
                i++;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string nombre = cbPartidos.SelectedItem.ToString();
            int largo = Form1.partidosPoliticos.Count;
            int i = 0;
            while (i < largo)
            {
                if (Form1.partidosPoliticos[i].NombredelPartido == nombre)
                {
                    Form1.partidosPoliticos[i].Parlacen();
                    button5.Enabled = false;
                }
                i++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false)
            {
                panel1.Visible = false;
                button1.Enabled = true;
                Form1.totalVotos++;
                label2.Text = Form1.totalVotos.ToString() + " han votado";
            }
            else
            {
                MessageBox.Show("Debe realizar su voto por todas las modalidades.");
            }
        }
    }
}
