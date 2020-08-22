using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_Lester_Garcia_1003115
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_problema1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1;
                int n2;
                int n3;

                n1 = Convert.ToInt32(txt_num1.Text);
                n2 = Convert.ToInt32(txt_num2.Text);
                n3 = Convert.ToInt32(txt_num3.Text);


                if (n1 > 0)
                {
                    if (n2 > 0)
                    {
                        if (n3 > 0)
                        {
                            if (n1 > n2)
                            {
                                if (n1 > n3)
                                {
                                    txt_resultado.Text = Convert.ToString(n1 + " es el mayor");
                                }
                                else
                                {
                                    if (n1 == n3)
                                    {
                                        txt_resultado.Text = Convert.ToString(n1 + " , " + n3 + " son los mayores");
                                    }
                                    else
                                    {
                                        txt_resultado.Text = Convert.ToString(n3 + " es el mayor");
                                    }
                                }


                            }
                            else
                            {
                                if (n1 == n2)
                                {
                                    if (n1 > n3)
                                    {
                                        txt_resultado.Text = Convert.ToString(n1 + " , " + n2 + " son los mayores");
                                    }
                                    else
                                    {
                                        if (n1 == n3)
                                        {
                                            txt_resultado.Text = Convert.ToString(n1 + " , " + n2 + " , " + n3 + " son los mayores");
                                        }
                                        else
                                        {
                                            txt_resultado.Text = Convert.ToString(n3 + " es el mayor");
                                        }
                                    }
                                }
                                else
                                {
                                    if (n2 > n3)
                                    {
                                        txt_resultado.Text = Convert.ToString(n2 + " es el mayor");
                                    }
                                    else
                                    {
                                        if (n2 == n3)
                                        {
                                            txt_resultado.Text = Convert.ToString(n2 + " , " + n3 + " son los mayores");
                                        }
                                        else
                                        {
                                            txt_resultado.Text = Convert.ToString(n3 + " es el mayor");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch
            {
                MessageBox.Show("Complete todos los espacios que se le solicitan");

            }
        }
        private void btn_resultado2_Click(object sender, EventArgs e)
        {
            double NumNatural;
            NumNatural = Convert.ToInt32(txt_entero.Text);
            try
            {
                if (NumNatural > 0)
                {
                    txt_ResultadoEntero.Text = ("El número es positivo");
                }
                if (NumNatural < 0)
                {
                    txt_ResultadoEntero.Text = ("El número es negativo");
                }
                if (NumNatural == 0)
                {
                    txt_ResultadoEntero.Text = ("El número es 0");
                }
            }

            catch
            {
                MessageBox.Show("ERROR, Favor ingrese un número");
            }
        }

        private void txt_ResultadoEntero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}