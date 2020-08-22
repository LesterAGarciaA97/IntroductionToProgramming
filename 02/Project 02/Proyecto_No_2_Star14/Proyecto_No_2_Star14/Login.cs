using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_No_2_Star14
{
    public partial class Login : Form
    {
        string NombreJugador;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

         void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((textBox1.Text != "") && (textBox2.Text != ""))
                {
                    NombreJugador = textBox1.Text + " " + textBox2.Text;
                    MessageBox.Show("Bienvenido/a  " + NombreJugador, "★ Star_14 ★", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    Juego Jugar = new Juego(NombreJugador);
                    Jugar.Show();
                }
                else
                {
                    MessageBox.Show("Ingresa todos tus datos para poder jugar", "★ Star_14 ★", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
