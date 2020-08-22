using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_Lester_Garcia_1003115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox1.Text)
            {
                MessageBox.Show("Contraseña correcta");
                MessageBox.Show("Bienvenido");
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
                MessageBox.Show("Inténtelo de nuevo");
            }
        }
    }
}
