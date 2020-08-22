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
            double MontoCompra;
            MontoCompra = Convert.ToDouble(textBox1.Text);

            if ((MontoCompra > 0) && (MontoCompra < 500))
            {
                textBox2.Text = Convert.ToString("0%");
                textBox3.Text = Convert.ToString(MontoCompra);
            }
            else if ((MontoCompra >= 500) && (MontoCompra <= 1000))
            {
                textBox2.Text = Convert.ToString("5%");
                textBox3.Text = Convert.ToString(MontoCompra - (MontoCompra * 0.05));
            }
            else if ((MontoCompra > 1000) && (MontoCompra <= 7000))
            {
                textBox2.Text = Convert.ToString("11%");
                textBox3.Text = Convert.ToString(MontoCompra - (MontoCompra * 0.11));
            }
            else if ((MontoCompra > 7000) && (MontoCompra <= 15000))
            {
                textBox2.Text = Convert.ToString("18%");
                textBox3.Text = Convert.ToString(MontoCompra - (MontoCompra * 0.18));
            }
            else if (MontoCompra > 15000)
            {
                textBox2.Text = Convert.ToString("25%");
                textBox3.Text = Convert.ToString(MontoCompra - (MontoCompra * 0.25));
            }

        }
    }
}
