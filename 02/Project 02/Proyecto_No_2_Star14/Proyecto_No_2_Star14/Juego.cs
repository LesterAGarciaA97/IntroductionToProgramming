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
    public partial class Juego : Form
    {
        string nombre = "";

        public Juego(string Nombre)
        {
            nombre = Nombre;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Juego_Load(object sender, EventArgs e)
        {
            textBox1.Text = nombre;
            this.Matriz();
        }

        public void Matriz()
        {
            int[,] Matriz = new int[5, 5];
            Random R = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Matriz[i, j] = R.Next(2,7);

                    //Ponerle un color de fondo a cada posición de la Matriz
                    button1.Text = Convert.ToString(Matriz[0, 0]); button1.BackColor = color(Convert.ToInt32(button1.Text));
                    button2.Text = Convert.ToString(Matriz[0, 1]); button2.BackColor = color(Convert.ToInt32(button2.Text));
                    button3.Text = Convert.ToString(Matriz[0, 2]); button3.BackColor = color(Convert.ToInt32(button3.Text));
                    button4.Text = Convert.ToString(Matriz[0, 3]); button4.BackColor = color(Convert.ToInt32(button4.Text));
                    button5.Text = Convert.ToString(Matriz[0, 4]); button5.BackColor = color(Convert.ToInt32(button5.Text));

                    button6.Text = Convert.ToString(Matriz[1, 0]); button6.BackColor = color(Convert.ToInt32(button6.Text));
                    button7.Text = Convert.ToString(Matriz[1, 1]); button7.BackColor = color(Convert.ToInt32(button7.Text));
                    button8.Text = Convert.ToString(Matriz[1, 2]); button8.BackColor = color(Convert.ToInt32(button8.Text));
                    button9.Text = Convert.ToString(Matriz[1, 3]); button9.BackColor = color(Convert.ToInt32(button9.Text));
                    button10.Text = Convert.ToString(Matriz[1, 4]); button10.BackColor = color(Convert.ToInt32(button10.Text));

                    button11.Text = Convert.ToString(Matriz[2, 0]); button11.BackColor = color(Convert.ToInt32(button11.Text));
                    button12.Text = Convert.ToString(Matriz[2, 1]); button12.BackColor = color(Convert.ToInt32(button12.Text));
                    button13.Text = Convert.ToString(Matriz[2, 2]); button13.BackColor = color(Convert.ToInt32(button13.Text));
                    button14.Text = Convert.ToString(Matriz[2, 3]); button14.BackColor = color(Convert.ToInt32(button14.Text));
                    button15.Text = Convert.ToString(Matriz[2, 4]); button15.BackColor = color(Convert.ToInt32(button15.Text));

                    button16.Text = Convert.ToString(Matriz[3, 0]); button16.BackColor = color(Convert.ToInt32(button16.Text));
                    button17.Text = Convert.ToString(Matriz[3, 1]); button17.BackColor = color(Convert.ToInt32(button17.Text));
                    button18.Text = Convert.ToString(Matriz[3, 2]); button18.BackColor = color(Convert.ToInt32(button18.Text));
                    button19.Text = Convert.ToString(Matriz[3, 3]); button19.BackColor = color(Convert.ToInt32(button19.Text));
                    button20.Text = Convert.ToString(Matriz[3, 4]); button20.BackColor = color(Convert.ToInt32(button20.Text));

                    button21.Text = Convert.ToString(Matriz[4, 0]); button21.BackColor = color(Convert.ToInt32(button21.Text));
                    button22.Text = Convert.ToString(Matriz[4, 1]); button22.BackColor = color(Convert.ToInt32(button22.Text));
                    button23.Text = Convert.ToString(Matriz[4, 2]); button23.BackColor = color(Convert.ToInt32(button23.Text));
                    button24.Text = Convert.ToString(Matriz[4, 3]); button24.BackColor = color(Convert.ToInt32(button24.Text));
                    button25.Text = Convert.ToString(Matriz[4, 4]); button25.BackColor = color(Convert.ToInt32(button25.Text));
                }
            }
        }

             //Asignarle un color específico a cada número aleatorio que salga en el tablero
             public Color color(int C)
                {
                    if (C == 2)
                    {
                        return Color.Green;
                    }
                    else if (C == 4)
                    {
                        return Color.Purple;
                    }
                    else if (C == 6)
                    {
                        return Color.MidnightBlue;
                    }
                    else if (C == 8)
                    {
                        return Color.DarkOrange;
                    }
                    else if (C == 10)
                    {
                        return Color.Firebrick;
                    }
                    else if (C == 12)
                    {
                        return Color.HotPink;
                    }
                    else if (C == 14)
                    {
                        return Color.Gold;
                    }
                    else
                    {
                        return Color.White;
                    }
        }
    }
}
