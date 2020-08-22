using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea7_Lester_Garcia_1003115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Num1;
            int Num2;
            int Num3;
            Num1 = Convert.ToInt32((textBox1.Text));
            Num2 = Convert.ToInt32((textBox2.Text));
            Num3 = Convert.ToInt32((textBox2.Text));

            try
            {
                if ((Num1 != Num2) || (Num2 != Num3) || (Num3 != Num1))
                {
                    MessageBox.Show("Todos los valores son diferentes");
                }
                else
                {
                    MessageBox.Show("Cambie el valor repetido");
                }
            }
            catch
            {
                MessageBox.Show("ERROR, Ingrese todos los valores que se le solicitan");
            }
        }
    }
}
