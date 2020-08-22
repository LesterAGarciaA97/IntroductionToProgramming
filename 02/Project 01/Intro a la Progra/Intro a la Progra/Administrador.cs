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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            
            try
            {
                int vueltas = Form1.partidosPoliticos.Count;
                double porcentaje = 0;
                int t = 0;
                while (t < (vueltas))
                {
                    porcentaje += Form1.partidosPoliticos[t].getPresidente();
                    t++;
                }
                porcentaje = 100 / porcentaje;
                Bitmap imagen = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics g = Graphics.FromImage(imagen);
                Pen lapiz = null;
                int y = 0;
                int posX = 0;
                Label label = null;
                int ypos = 42;
                
                while (y < vueltas)
                {
                    lapiz = new Pen(Form1.partidosPoliticos[y].Color);
                    Brush pincel = new SolidBrush(Form1.partidosPoliticos[y].Color);
                    label = new Label();
                    label.Location = new Point(ypos, 60);
                    g.DrawRectangle(lapiz, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getPresidente() * porcentaje)));
                    g.FillRectangle(pincel, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getPresidente() * porcentaje)));
                    label.Text = (Math.Round(Form1.partidosPoliticos[y].getPresidente() * porcentaje)).ToString() + " %";
                    posX += 40;
                    ypos += 40;
                    tbpgraficas.Controls.Add(label);
                    label.BringToFront();
                    y++;
                }
                pictureBox2.Image = imagen;

                y = 0;
                posX = 0;
                ypos = 531;
                imagen = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                g = Graphics.FromImage(imagen);
                while (y < vueltas)
                {
                    lapiz = new Pen(Form1.partidosPoliticos[y].Color);
                    Brush pincel = new SolidBrush(Form1.partidosPoliticos[y].Color);
                    label = new Label();
                    label.Location = new Point(ypos, 60);
                    g.DrawRectangle(lapiz, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getAlcalde() * porcentaje)));
                    g.FillRectangle(pincel, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getAlcalde() * porcentaje)));
                    label.Text = (Math.Round(Form1.partidosPoliticos[y].getAlcalde() * porcentaje)).ToString() + " %";
                    posX += 40;
                    ypos += 40;
                    tbpgraficas.Controls.Add(label);
                    label.BringToFront();
                    y++;
                }
                pictureBox3.Image = imagen;
                
                y = 0;
                posX = 0;
                ypos = 42;
                imagen = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                g = Graphics.FromImage(imagen);
                while (y < vueltas)
                {
                    lapiz = new Pen(Form1.partidosPoliticos[y].Color);
                    Brush pincel = new SolidBrush(Form1.partidosPoliticos[y].Color);
                    label = new Label();
                    label.Location = new Point(ypos, 235);
                    g.DrawRectangle(lapiz, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getNacionales() * porcentaje)));
                    g.FillRectangle(pincel, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getNacionales() * porcentaje)));
                    label.Text = (Math.Round(Form1.partidosPoliticos[y].getNacionales() * porcentaje)).ToString() + " %";
                    posX += 40;
                    ypos += 40;
                    tbpgraficas.Controls.Add(label);
                    label.BringToFront();
                    y++;
                }
                pictureBox4.Image = imagen;

                y = 0;
                posX = 0;
                ypos = 531;
                imagen = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                g = Graphics.FromImage(imagen);
                while (y < vueltas)
                {
                    lapiz = new Pen(Form1.partidosPoliticos[y].Color);
                    Brush pincel = new SolidBrush(Form1.partidosPoliticos[y].Color);
                    label = new Label();
                    label.Location = new Point(ypos, 235);
                    g.DrawRectangle(lapiz, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getDistritales() * porcentaje)));
                    g.FillRectangle(pincel, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getDistritales() * porcentaje)));
                    label.Text = (Math.Round(Form1.partidosPoliticos[y].getDistritales() * porcentaje)).ToString() + " %";
                    posX += 40;
                    ypos += 40;
                    tbpgraficas.Controls.Add(label);
                    label.BringToFront();
                    y++;
                }
                pictureBox5.Image = imagen;

                y = 0;
                posX = 0;
                ypos = 42;
                imagen = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                g = Graphics.FromImage(imagen);
                while (y < vueltas)
                {
                    lapiz = new Pen(Form1.partidosPoliticos[y].Color);
                    Brush pincel = new SolidBrush(Form1.partidosPoliticos[y].Color);
                    label = new Label();
                    label.Location = new Point(ypos, 418);
                    g.DrawRectangle(lapiz, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getParlacen() * porcentaje)));
                    g.FillRectangle(pincel, new Rectangle(posX, 0, 20, Convert.ToInt32(Form1.partidosPoliticos[y].getParlacen() * porcentaje)));
                    label.Text = (Math.Round(Form1.partidosPoliticos[y].getParlacen() * porcentaje)).ToString() + " %";
                    posX += 40;
                    ypos += 40;
                    tbpgraficas.Controls.Add(label);
                    label.BringToFront();
                    y++;
                }
                pictureBox6.Image = imagen;
                
            }
            catch
            {

            }
            try
            {
                lblhanvotado.Text = "Se han creado " + (Form1.posicionesLlenas).ToString() + " partidos.";
                foreach (Partidos partido in Form1.partidosPoliticos)
                {
                    cbPartidos.Items.Add(partido.NombredelPartido);
                }
                int largo = Form1.partidosPoliticos.Count;
                int i = 0;
                while (i < largo)
                {
                    Form1.totalVotos += Form1.partidosPoliticos[i].getPresidente();
                    i++;
                }
            }
            catch
            {

            }
        }

        private void btCrearPartido_Click(object sender, EventArgs e)
        {
            try
            {
                if (Form1.posicionesLlenas <= 10 && txtColorPartido.Text != null && pictureBox1.BackColor != Color.Silver && pictureBox7.BackgroundImage != null)
                {

                    Form1.partidosPoliticos.Add(new Partidos(txtColorPartido.Text, pictureBox1.BackColor, openFileDialog1.FileName.ToString()));
                    Form1.posicionesLlenas++;
                    lblhanvotado.Text = "Se han creado " + (Form1.posicionesLlenas).ToString() + " partidos.";
                    cbPartidos.Items.Clear();
                    foreach (Partidos partido in Form1.partidosPoliticos)
                    {
                        cbPartidos.Items.Add(partido.NombredelPartido);
                    }

                    MessageBox.Show("El partido se creo con éxito.");
                    txtColorPartido.Clear();
                    pictureBox7.BackgroundImage = null;
                    pictureBox1.BackColor = Color.Silver;
                }
                else
                {
                    MessageBox.Show("No se pueden crear mas paridos o no se han llenado todos los campos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre = cbPartidos.SelectedItem.ToString();
            int largo = Form1.partidosPoliticos.Count;
            int i = 0;
            while (i < largo)
            {
                if (Form1.partidosPoliticos[i].NombredelPartido == nombre)
                {
                    lblpVotos.Text = Form1.partidosPoliticos[i].getPresidente().ToString();
                    lblAVotos.Text = Form1.partidosPoliticos[i].getAlcalde().ToString();
                    lbldlnVotos.Text = Form1.partidosPoliticos[i].getNacionales().ToString();
                    lblddVotos.Text = Form1.partidosPoliticos[i].getDistritales().ToString();
                    lbldpVotos.Text = Form1.partidosPoliticos[i].getParlacen().ToString();
                    lblpPorcentaje.Text = Math.Round(100 / Form1.totalVotos * Form1.partidosPoliticos[i].getPresidente(), 2).ToString() + " %";
                    lblaPorcentaje.Text = Math.Round(100 / Form1.totalVotos * Form1.partidosPoliticos[i].getAlcalde(), 2).ToString() + " %";
                    lbldlnPorcentaje.Text = Math.Round(100 / Form1.totalVotos * Form1.partidosPoliticos[i].getNacionales(), 2).ToString() + " %";
                    lblddPorcentaje.Text = Math.Round(100 / Form1.totalVotos * Form1.partidosPoliticos[i].getDistritales(), 2).ToString() + " %";
                    lbldpPorcentaje.Text = Math.Round(100 / Form1.totalVotos * Form1.partidosPoliticos[i].getParlacen(), 2).ToString() + " %";
                }
                i++;
            }
        }
        
        private void btnGanadorP_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                int vueltas = Form1.partidosPoliticos.Count;
                double porcentaje = 0;
                int t = 0;
                while (t < (vueltas))
                {
                    porcentaje += Form1.partidosPoliticos[t].getPresidente();
                    t++;
                }
                porcentaje = 100 / porcentaje;
                int i = 0;
                double temp = 0;
                lblModalidad.Text = "Presidente y Vicepresidente";
                while (i < Form1.partidosPoliticos.Count)
                {
                    if (Form1.partidosPoliticos[i].getPresidente() > temp)
                    {
                        temp = Form1.partidosPoliticos[i].getPresidente();
                        lblPartido.Text = Form1.partidosPoliticos[i].NombredelPartido;
                        lblVotos.Text = Form1.partidosPoliticos[i].getPresidente().ToString();
                        lblPorcentaje.Text = (Form1.partidosPoliticos[i].getPresidente() * porcentaje).ToString();
                        pbLogo.Image = System.Drawing.Image.FromFile(Form1.partidosPoliticos[i].Imagen);
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
        }

        private void Administrador_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnDistribución_Click(object sender, EventArgs e)
        {

            try
            {
                double suma = 0;
                int i = 1;
                double porcentaje = 0;
                double ganador = 0;
                string curulesNacional = "";
                string curulesDistrital = "";
                double temp = 0;
                double temp2 = 0;
                double temp3 = 0;
                int n1 = 13;
                int n2 = 5;
                while (i < Form1.partidosPoliticos.Count)
                {
                    porcentaje += Form1.partidosPoliticos[i].getDistritales();
                    suma += Form1.partidosPoliticos[i].getNacionales();

                    if (Form1.partidosPoliticos[i].getNacionales() > temp)
                    {
                        temp = Form1.partidosPoliticos[i].getNacionales();
                    }

                    if (Form1.partidosPoliticos[i].getDistritales() > ganador)
                    {
                        ganador = Form1.partidosPoliticos[i].getDistritales();
                    }
                    i++;
                }
                porcentaje = 100 / porcentaje;
                i = 1;
                double cant1 = 0;
                temp2 = temp / n1;
                temp3 = ganador / n2;
                while (i < Form1.partidosPoliticos.Count)
                {
                    if ((Form1.partidosPoliticos[i].getNacionales() * porcentaje) > 5)
                    {
                        cant1 += Convert.ToInt32(Form1.partidosPoliticos[i].getNacionales() / Math.Floor(temp2));
                        curulesNacional += "El partido " + Form1.partidosPoliticos[i].NombredelPartido + " tiene " + Math.Floor((Form1.partidosPoliticos[i].getNacionales() / Math.Floor(temp2))).ToString() + " curules" + " / n";
                    }
                    if (Math.Floor(cant1) < 90 || Math.Floor(cant1) > 100 && i == (Form1.partidosPoliticos[i].getNacionales() * porcentaje) - 1)
                    {
                        i = 0;
                        n1++;
                        temp2 = temp / n1;
                        curulesNacional = "";
                    }
                    i++;
                }
                i = 1;
                while (i < Form1.partidosPoliticos.Count)
                {
                    if ((Form1.partidosPoliticos[i].getNacionales() * porcentaje) > 5)
                    {
                        cant1 += Convert.ToInt32(Form1.partidosPoliticos[i].getDistritales() / Math.Floor(temp3));
                        curulesDistrital += "El partido " + Form1.partidosPoliticos[i].NombredelPartido + " tiene " + Math.Floor((Form1.partidosPoliticos[i].getDistritales() / Math.Floor(temp3))).ToString() + " curules" + "/n";
                    }
                    if (Math.Floor(cant1) < 58 || Math.Floor(cant1) > 68 && i == (Form1.partidosPoliticos[i].getDistritales() * porcentaje) - 1)
                    {
                        i = 0;
                        n2++;
                        temp3 = ganador / n2;
                        curulesDistrital = "";
                    }
                    i++;
                }
                MessageBox.Show(curulesNacional, "Curules de Diputados Nacionales");
                MessageBox.Show(curulesDistrital, "Curules de Diputados Distritales");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGanadorA_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                int vueltas = Form1.partidosPoliticos.Count;
                double porcentaje = 0;
                int t = 0;
                while (t < (vueltas))
                {
                    porcentaje += Form1.partidosPoliticos[t].getAlcalde();
                    t++;
                }
                porcentaje = 100 / porcentaje;
                int i = 0;
                double temp = 0;
                lblModalidad.Text = "Alcalde";
                while (i < Form1.partidosPoliticos.Count)
                {
                    if (Form1.partidosPoliticos[i].getPresidente() > temp)
                    {
                        temp = Form1.partidosPoliticos[i].getPresidente();
                        lblPartido.Text = Form1.partidosPoliticos[i].NombredelPartido;
                        lblVotos.Text = Form1.partidosPoliticos[i].getAlcalde().ToString();
                        lblPorcentaje.Text = (Form1.partidosPoliticos[i].getAlcalde() * porcentaje).ToString();
                        pbLogo.Image = System.Drawing.Image.FromFile(Form1.partidosPoliticos[i].Imagen);
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGanadorDN_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                int vueltas = Form1.partidosPoliticos.Count;
                double porcentaje = 0;
                int t = 0;
                while (t < (vueltas))
                {
                    porcentaje += Form1.partidosPoliticos[t].getNacionales();
                    t++;
                }
                porcentaje = 100 / porcentaje;
                int i = 0;
                double temp = 0;
                lblModalidad.Text = "Diputados Listado Nacional";
                while (i < Form1.partidosPoliticos.Count)
                {
                    if (Form1.partidosPoliticos[i].getNacionales() > temp)
                    {
                        temp = Form1.partidosPoliticos[i].getNacionales();
                        lblPartido.Text = Form1.partidosPoliticos[i].NombredelPartido;
                        lblVotos.Text = Form1.partidosPoliticos[i].getNacionales().ToString();
                        lblPorcentaje.Text = (Form1.partidosPoliticos[i].getNacionales() * porcentaje).ToString();
                        pbLogo.Image = System.Drawing.Image.FromFile(Form1.partidosPoliticos[i].Imagen);
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGanadorDD_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                int vueltas = Form1.partidosPoliticos.Count;
                double porcentaje = 0;
                int t = 0;
                while (t < (vueltas))
                {
                    porcentaje += Form1.partidosPoliticos[t].getDistritales();
                    t++;
                }
                porcentaje = 100 / porcentaje;
                int i = 0;
                double temp = 0;
                lblModalidad.Text = "Diputados Distritales";
                while (i < Form1.partidosPoliticos.Count)
                {
                    if (Form1.partidosPoliticos[i].getPresidente() > temp)
                    {
                        temp = Form1.partidosPoliticos[i].getDistritales();
                        lblPartido.Text = Form1.partidosPoliticos[i].NombredelPartido;
                        lblVotos.Text = Form1.partidosPoliticos[i].getDistritales().ToString();
                        lblPorcentaje.Text = (Form1.partidosPoliticos[i].getDistritales() * porcentaje).ToString();
                        pbLogo.Image = System.Drawing.Image.FromFile(Form1.partidosPoliticos[i].Imagen);
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGanadorDP_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                int vueltas = Form1.partidosPoliticos.Count;
                double porcentaje = 0;
                int t = 0;
                while (t < (vueltas))
                {
                    porcentaje += Form1.partidosPoliticos[t].getParlacen();
                    t++;
                }
                porcentaje = 100 / porcentaje;
                int i = 0;
                double temp = 0;
                lblModalidad.Text = "Diputados al Parlacen";
                while (i < Form1.partidosPoliticos.Count)
                {
                    if (Form1.partidosPoliticos[i].getPresidente() > temp)
                    {
                        temp = Form1.partidosPoliticos[i].getParlacen();
                        lblPartido.Text = Form1.partidosPoliticos[i].NombredelPartido;
                        lblVotos.Text = Form1.partidosPoliticos[i].getParlacen().ToString();
                        lblPorcentaje.Text = (Form1.partidosPoliticos[i].getParlacen() * porcentaje).ToString();
                        pbLogo.Image = System.Drawing.Image.FromFile(Form1.partidosPoliticos[i].Imagen);
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                 openFileDialog1.ShowDialog();
                pictureBox7.BackgroundImage = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
