using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_Lester_Garcia_1003115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Cantidad;
            Cantidad = Convert.ToInt32(maskedTextBox1.Text);
            int Billetes100;
            int Billetes50;
            int Billetes20;
            int Billetes10;
            int Billetes5;
            int Monedas1;
            string Billete100 = " Billetes de 100";
            string Billete50 = " Billetes de 50";
            string Billete20 = " Billetes de 20";
            string Billete10 = " Billetes de 10";
            string Billete5 = " Billetes de 5";
            string Moneda1 = " Monedas de Q.1";
            Billetes100 = Cantidad / 100;
            listBox1.Items.Add((Billetes100.ToString()) + Billete100);
            Billetes50 = (Cantidad % 100) / 50;
            listBox1.Items.Add((Billetes50.ToString()) + Billete50);
            Billetes20 = ((Cantidad % 100) % 50) / 20;
            listBox1.Items.Add((Billetes20.ToString()) + Billete20);
            Billetes10 = (((Cantidad % 100) % 50) % 20) / 10;
            listBox1.Items.Add((Billetes10.ToString()) + Billete10);
            Billetes5 = ((((Cantidad % 100) % 50) % 20) % 10) / 5;
            listBox1.Items.Add((Billetes5.ToString()) + Billete5);
            Monedas1 = (((((Cantidad % 100) % 50) % 20) % 10) % 5) / 1;
            listBox1.Items.Add((Monedas1.ToString()) + Moneda1); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            listBox1.Items.Clear();
        }
    }
}
