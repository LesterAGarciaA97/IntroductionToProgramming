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
    public partial class Form2 : Form
    {
        int i;
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 200)
            {
                this.Dispose();
                Login A = new Login();
                A.Show();
            }
            else
            {
                i++;
            }
        }
    }
}
