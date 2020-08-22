using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_Lester_García_1003115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo, Mi primer programa");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_inciso2.Text, "Mi primer programa");
        }
    }
}
