using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7STARS_Ver._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Max_Num = 0, PlayerTotalScore = 0;
        int[,] Tablero_Star7 = new int[5, 5];

        Modificar_Tablero Mod_Tab = new Modificar_Tablero();
        private void Jugar_button_Click(object sender, EventArgs e)
        {
            Mod_Tab.Iniciar_matrix(Tablero_Star7);
            llenar_Tablero();

            Give_color();

            }
        private void Reiniciar_button_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //--Ordenar Tablero------------------------------------
        public void llenar_Tablero()
        {
            

            label1.Text = Convert.ToString(Tablero_Star7[0, 0]);
            label2.Text = Convert.ToString(Tablero_Star7[0, 1]);
            label3.Text = Convert.ToString(Tablero_Star7[0, 2]);
            label4.Text = Convert.ToString(Tablero_Star7[0, 3]);
            label5.Text = Convert.ToString(Tablero_Star7[0, 4]);
            label6.Text = Convert.ToString(Tablero_Star7[1, 0]);
            label7.Text = Convert.ToString(Tablero_Star7[1, 1]);
            label8.Text = Convert.ToString(Tablero_Star7[1, 2]);
            label9.Text = Convert.ToString(Tablero_Star7[1, 3]);
            label10.Text = Convert.ToString(Tablero_Star7[1, 4]);
            label11.Text = Convert.ToString(Tablero_Star7[2, 0]);
            label12.Text = Convert.ToString(Tablero_Star7[2, 1]);
            label13.Text = Convert.ToString(Tablero_Star7[2, 2]);
            label14.Text = Convert.ToString(Tablero_Star7[2, 3]);
            label15.Text = Convert.ToString(Tablero_Star7[2, 4]);
            label16.Text = Convert.ToString(Tablero_Star7[3, 0]);
            label17.Text = Convert.ToString(Tablero_Star7[3, 1]);
            label18.Text = Convert.ToString(Tablero_Star7[3, 2]);
            label19.Text = Convert.ToString(Tablero_Star7[3, 3]);
            label20.Text = Convert.ToString(Tablero_Star7[3, 4]);
            label21.Text = Convert.ToString(Tablero_Star7[4, 0]);
            label22.Text = Convert.ToString(Tablero_Star7[4, 1]);
            label23.Text = Convert.ToString(Tablero_Star7[4, 2]);
            label24.Text = Convert.ToString(Tablero_Star7[4, 3]);
            label25.Text = Convert.ToString(Tablero_Star7[4, 4]);

            Give_color();
        }
        public void Give_color()
        {

            Give_Max();
            Generar_Nums();
            Bajar();

            foreach (Control IndexPlace in tableLayoutPanel1.Controls)
            {
                Label labelNUM = IndexPlace as Label;
               

                if (labelNUM.Text == "0")
                {
                    labelNUM.BackColor = Color.Transparent;

                }
                if (labelNUM.Text == "1")
                {
                    labelNUM.BackColor = Color.LightGreen;

                }
                if (labelNUM.Text == "2")
                {
                    labelNUM.BackColor = Color.LightBlue;
                }
                if (labelNUM.Text == "3")
                {
                    labelNUM.BackColor = Color.LightYellow;
                }
                if (labelNUM.Text == "4")
                {
                    labelNUM.BackColor = Color.SandyBrown;
                }
                if (labelNUM.Text == "5")
                {
                    labelNUM.BackColor = Color.OrangeRed;
                }
                if (labelNUM.Text == "6")
                {
                    labelNUM.BackColor = Color.Pink;
                }
                if (labelNUM.Text == "7")
                {
                    labelNUM.BackColor = Color.Gold;
                    
                }




            }
        }
        public void Clear_color()
        {
            foreach (Control IndexPlace in tableLayoutPanel1.Controls)
            {
                Label labelNUM = IndexPlace as Label;

                labelNUM.BackColor = Color.Transparent;

            }
        }
        public void SyncTable_and_Array()
        {
            Tablero_Star7[0, 0] = Convert.ToInt32(label1.Text);
            Tablero_Star7[0, 1] = Convert.ToInt32(label2.Text);
            Tablero_Star7[0, 2] = Convert.ToInt32(label3.Text);
            Tablero_Star7[0, 3] = Convert.ToInt32(label4.Text);
            Tablero_Star7[0, 4] = Convert.ToInt32(label5.Text);

            Tablero_Star7[1, 0] = Convert.ToInt32(label6.Text);
            Tablero_Star7[1, 1] = Convert.ToInt32(label7.Text);
            Tablero_Star7[1, 2] = Convert.ToInt32(label8.Text);
            Tablero_Star7[1, 3] = Convert.ToInt32(label9.Text);
            Tablero_Star7[1, 4] = Convert.ToInt32(label10.Text);

            Tablero_Star7[2, 0] = Convert.ToInt32(label11.Text);
            Tablero_Star7[2, 1] = Convert.ToInt32(label12.Text);
            Tablero_Star7[2, 2] = Convert.ToInt32(label13.Text);
            Tablero_Star7[2, 3] = Convert.ToInt32(label14.Text);
            Tablero_Star7[2, 4] = Convert.ToInt32(label15.Text);

            Tablero_Star7[3, 0] = Convert.ToInt32(label16.Text);
            Tablero_Star7[3, 1] = Convert.ToInt32(label17.Text);
            Tablero_Star7[3, 2] = Convert.ToInt32(label18.Text);
            Tablero_Star7[3, 3] = Convert.ToInt32(label19.Text);
            Tablero_Star7[3, 4] = Convert.ToInt32(label20.Text);

            Tablero_Star7[4, 0] = Convert.ToInt32(label21.Text);
            Tablero_Star7[4, 1] = Convert.ToInt32(label22.Text);
            Tablero_Star7[4, 2] = Convert.ToInt32(label23.Text);
            Tablero_Star7[4, 3] = Convert.ToInt32(label24.Text);
            Tablero_Star7[4, 4] = Convert.ToInt32(label25.Text);
        }
        public void Give_Max()
        {
            Max_Num = Mod_Tab.Find_Max(Tablero_Star7);
            
        }
        public void Generar_Nums()
        {

        

            if (Tablero_Star7[0, 0] == 0)
                {
                    Tablero_Star7[0, 0] = Mod_Tab.Generate_NewRandom(Max_Num);
                label1.Text = Convert.ToString(Tablero_Star7[0, 0]);
            }
                if (Tablero_Star7[0, 1] == 0)
                {
                    Tablero_Star7[0, 1] = Mod_Tab.Generate_NewRandom(Max_Num);
                label2.Text = Convert.ToString(Tablero_Star7[0, 1]);
            }
                if (Tablero_Star7[0, 2] == 0)
               {
                Tablero_Star7[0, 2] = Mod_Tab.Generate_NewRandom(Max_Num);
                label3.Text = Convert.ToString(Tablero_Star7[0, 2]);
            }
            if (Tablero_Star7[0, 3] == 0)
            {
                Tablero_Star7[0, 3] = Mod_Tab.Generate_NewRandom(Max_Num);
                label4.Text = Convert.ToString(Tablero_Star7[0, 3]);
            }
            if (Tablero_Star7[0, 4] == 0)
            {
                Tablero_Star7[0, 4] = Mod_Tab.Generate_NewRandom(Max_Num);
                label5.Text = Convert.ToString(Tablero_Star7[0, 4]);
            }

          
           
            
            
           

            
        }
        public void Bajar()
        {
            for (int i = 0; i < 4; i++)
            {
                if (Tablero_Star7[i + 1, 0] == 0)
                {
                    Tablero_Star7[i + 1, 0] = Tablero_Star7[i, 0];
                    Tablero_Star7[i, 0] = 0;
                    llenar_Tablero();
                }
            }


            for (int i = 0; i < 4; i++)
            {
                if (Tablero_Star7[i + 1, 1] == 0)
                {
                    Tablero_Star7[i + 1, 1] = Tablero_Star7[i, 1];
                    Tablero_Star7[i, 1] = 0;
                    llenar_Tablero();
                }
            }


            for (int i = 0; i < 4; i++)
            {
                if (Tablero_Star7[i + 1, 2] == 0)
                {
                    Tablero_Star7[i + 1, 2] = Tablero_Star7[i, 2];
                    Tablero_Star7[i, 2] = 0;
                    llenar_Tablero();
                }
            }


            for (int i = 0; i < 4; i++)
            {
                if (Tablero_Star7[i + 1, 3] == 0)
                {
                    Tablero_Star7[i + 1, 3] = Tablero_Star7[i, 3];
                    Tablero_Star7[i, 3] = 0;
                    llenar_Tablero();
                }
            }


            for (int i = 0; i < 4; i++)
            {
                if (Tablero_Star7[i + 1, 4] == 0)
                {
                    Tablero_Star7[i + 1, 4] = Tablero_Star7[i, 4];
                    Tablero_Star7[i, 4] = 0;
                    llenar_Tablero();
                }
            }
            
        }
        public void Ganador()
        {
            if (Max_Num == 7)
            {
                MessageBox.Show("Ganador");
            }
        }

        //--Ordenar Tablero------------------------------------


            //---Buscar Adyacentes-------------------------------
        public void Cell_1()
        {
            int x = 0, y = 0;
            x = 0;
            y = 0;

            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label1.BackColor = Color.MediumPurple;
                label6.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label1.BackColor = Color.MediumPurple;
                label2.BackColor = Color.MediumPurple;
            }
           
        }
        public void Cell_2()
        {
            int x = 0, y = 0;
            x = 0;
            y = 1;
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label2.BackColor = Color.MediumPurple;
                label7.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label2.BackColor = Color.MediumPurple;
                label1.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label2.BackColor = Color.MediumPurple;
                label3.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_3()
        {
            int x = 0, y = 0;
            x = 0;
            y = 2;
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label3.BackColor = Color.MediumPurple;
                label8.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label3.BackColor = Color.MediumPurple;
                label2.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label3.BackColor = Color.MediumPurple;
                label4.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_4()
        {
            int x = 0, y = 0;
            x = 0;
            y = 3;
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label4.BackColor = Color.MediumPurple;
                label9.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label4.BackColor = Color.MediumPurple;
                label3.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label4.BackColor = Color.MediumPurple;
                label5.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_5()
        {
            int x = 0, y = 0;
            x = 0;
            y = 4;

            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label5.BackColor = Color.MediumPurple;
                label10.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label5.BackColor = Color.MediumPurple;
                label4.BackColor = Color.MediumPurple;
            }

        }
        public void Cell_6()
        {
            int x = 0, y = 0;
            x = 1;
            y = 0;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label6.BackColor = Color.MediumPurple;
                label1.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label6.BackColor = Color.MediumPurple;
                label11.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label6.BackColor = Color.MediumPurple;
                label7.BackColor = Color.MediumPurple;
            }

        }
        public void Cell_7()
        {
            int x = 0, y = 0;
            x = 1;
            y = 1;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label7.BackColor = Color.MediumPurple;
                label2.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label7.BackColor = Color.MediumPurple;
                label12.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label7.BackColor = Color.MediumPurple;
                label6.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label7.BackColor = Color.MediumPurple;
                label8.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_8()
        {
            int x = 0, y = 0;
            x = 1;
            y = 2;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label8.BackColor = Color.MediumPurple;
                label3.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label8.BackColor = Color.MediumPurple;
                label13.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label8.BackColor = Color.MediumPurple;
                label7.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label8.BackColor = Color.MediumPurple;
                label9.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_9()
        {
            int x = 0, y = 0;
            x = 1;
            y = 3;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label9.BackColor = Color.MediumPurple;
                label4.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label9.BackColor = Color.MediumPurple;
                label14.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label9.BackColor = Color.MediumPurple;
                label8.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label9.BackColor = Color.MediumPurple;
                label10.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_10()
        {
            int x = 0, y = 0;
            x = 1;
            y = 4;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label10.BackColor = Color.MediumPurple;
                label5.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label10.BackColor = Color.MediumPurple;
                label15.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label10.BackColor = Color.MediumPurple;
                label9.BackColor = Color.MediumPurple;
            }

        }
        public void Cell_11()
        {
            int x = 0, y = 0;
            x = 2;
            y = 0;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label11.BackColor = Color.MediumPurple;
                label6.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label11.BackColor = Color.MediumPurple;
                label16.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label11.BackColor = Color.MediumPurple;
                label12.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_12()
        {
            int x = 0, y = 0;
            x = 2;
            y = 1;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label12.BackColor = Color.MediumPurple;
                label7.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label12.BackColor = Color.MediumPurple;
                label17.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label12.BackColor = Color.MediumPurple;
                label11.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label12.BackColor = Color.MediumPurple;
                label13.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_13()
        {
            int x = 0, y = 0;
            x = 2;
            y = 2;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label13.BackColor = Color.MediumPurple;
                label8.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label13.BackColor = Color.MediumPurple;
                label18.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label13.BackColor = Color.MediumPurple;
                label12.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label13.BackColor = Color.MediumPurple;
                label14.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_14()
        {
            int x = 0, y = 0;
            x = 2;
            y = 3;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label14.BackColor = Color.MediumPurple;
                label9.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label14.BackColor = Color.MediumPurple;
                label19.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label14.BackColor = Color.MediumPurple;
                label13.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label14.BackColor = Color.MediumPurple;
                label15.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_15()
        {
            int x = 0, y = 0;
            x = 2;
            y = 4;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label15.BackColor = Color.MediumPurple;
                label10.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label15.BackColor = Color.MediumPurple;
                label20.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label15.BackColor = Color.MediumPurple;
                label14.BackColor = Color.MediumPurple;
            }

        }
        public void Cell_16()
        {
            int x = 0, y = 0;
            x = 3;
            y = 0;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label16.BackColor = Color.MediumPurple;
                label11.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label16.BackColor = Color.MediumPurple;
                label21.BackColor = Color.MediumPurple;
            }

            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label16.BackColor = Color.MediumPurple;
                label17.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_17()
        {
            int x = 0, y = 0;
            x = 3;
            y = 1;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label17.BackColor = Color.MediumPurple;
                label12.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label17.BackColor = Color.MediumPurple;
                label22.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label17.BackColor = Color.MediumPurple;
                label16.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label17.BackColor = Color.MediumPurple;
                label18.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_18()
        {

            int x = 0, y = 0;
            x = 3;
            y = 2;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label18.BackColor = Color.MediumPurple;
                label13.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label18.BackColor = Color.MediumPurple;
                label23.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label18.BackColor = Color.MediumPurple;
                label17.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label18.BackColor = Color.MediumPurple;
                label19.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_19()
        {
            int x = 0, y = 0;
            x = 3;
            y = 3;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label19.BackColor = Color.MediumPurple;
                label14.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label19.BackColor = Color.MediumPurple;
                label24.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label19.BackColor = Color.MediumPurple;
                label18.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label19.BackColor = Color.MediumPurple;
                label20.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_20()
        {
            int x = 0, y = 0;
            x = 3;
            y = 4;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label20.BackColor = Color.MediumPurple;
                label15.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_DOWN(x, y, Tablero_Star7) == true)
            {
                label20.BackColor = Color.MediumPurple;
                label25.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label20.BackColor = Color.MediumPurple;
                label19.BackColor = Color.MediumPurple;
            }

        }
        public void Cell_21()
        {
            int x = 0, y = 0;
            x = 4;
            y = 0;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label21.BackColor = Color.MediumPurple;
                label16.BackColor = Color.MediumPurple;
            }


            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label21.BackColor = Color.MediumPurple;
                label22.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_22()
        {
            int x = 0, y = 0;
            x = 4;
            y = 1;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label22.BackColor = Color.MediumPurple;
                label17.BackColor = Color.MediumPurple;
            }

            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label22.BackColor = Color.MediumPurple;
                label21.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label22.BackColor = Color.MediumPurple;
                label23.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_23()
        {
            int x = 0, y = 0;
            x = 4;
            y = 2;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label23.BackColor = Color.MediumPurple;
                label18.BackColor = Color.MediumPurple;
            }

            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label23.BackColor = Color.MediumPurple;
                label22.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label23.BackColor = Color.MediumPurple;
                label24.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_24()
        {
            int x = 0, y = 0;
            x = 4;
            y = 3;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label24.BackColor = Color.MediumPurple;
                label19.BackColor = Color.MediumPurple;
            }

            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label24.BackColor = Color.MediumPurple;
                label23.BackColor = Color.MediumPurple;
            }
            if (Mod_Tab.Adjacent_RIGHT(x, y, Tablero_Star7) == true)
            {
                label24.BackColor = Color.MediumPurple;
                label25.BackColor = Color.MediumPurple;
            }
        }
        public void Cell_25()
        {
            int x = 0, y = 0;
            x = 4;
            y = 4;
            if (Mod_Tab.Adjacent_UP(x, y, Tablero_Star7) == true)
            {
                label25.BackColor = Color.MediumPurple;
                label20.BackColor = Color.MediumPurple;
            }

            if (Mod_Tab.Adjacent_LEFT(x, y, Tablero_Star7) == true)
            {
                label25.BackColor = Color.MediumPurple;
                label24.BackColor = Color.MediumPurple;
            }

        }
        //---Buscar Adyacentes---------------------------------



        //---Click en posicion---------------------------------------------------
        private void Form1_Click(object sender, EventArgs e)
        {

            Give_color();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_1();

        }
        private void label2_Click(object sender, EventArgs e)
        {

            Give_color();
            Cell_2();

        }
        private void label3_Click(object sender, EventArgs e)
        {

            Give_color();
            Cell_3();
        }
        private void label4_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_4();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_5();
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_6();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_7();
        }
        private void label8_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_8();
        }
        private void label9_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_9();
        }
        private void label10_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_10();
        }
        private void label11_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_11();
        }
        private void label12_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_12();
        }
        private void label13_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_13();
        }
        private void label14_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_14();
        }
        private void label15_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_15();
        }
        private void label16_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_16();
        }
        private void label17_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_17();
        }
        private void label18_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_18();
        }
        private void label19_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_19();
        }
        private void label20_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_20();
        }
        private void label21_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_21();
        }
        private void label22_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_22();
        }
        private void label23_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_23();
        }
        private void label24_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_24();
        }
        private void label25_Click(object sender, EventArgs e)
        {
            Give_color();
            Cell_25();
        }
        //---Click en posicion---------------------------------------------------

        //---Selecionar Bloques igaules-----------------------------------------
        private void label1_BackColorChanged(object sender, EventArgs e)
        {
            if (label1.BackColor == Color.MediumPurple)
            {
                Cell_1();
            }
        }

        private void label2_BackColorChanged(object sender, EventArgs e)
        {
            if (label2.BackColor == Color.MediumPurple)
            {
                Cell_2();
            }
        }

        private void label3_BackColorChanged(object sender, EventArgs e)
        {
            if (label3.BackColor == Color.MediumPurple)
            {
                Cell_3();
            }
        }

        private void label4_BackColorChanged(object sender, EventArgs e)
        {
            if (label4.BackColor == Color.MediumPurple)
            {
                Cell_4();
            }
        }

        private void label5_BackColorChanged(object sender, EventArgs e)
        {
            if (label5.BackColor == Color.MediumPurple)
            {
                Cell_5();
            }
        }


        private void label6_BackColorChanged(object sender, EventArgs e)
        {
            if (label6.BackColor == Color.MediumPurple)
            {
                Cell_6();
            }
        }

        private void label7_BackColorChanged(object sender, EventArgs e)
        {
            if (label7.BackColor == Color.MediumPurple)
            {
                Cell_7();
            }
        }

        private void label8_BackColorChanged(object sender, EventArgs e)
        {
            if (label8.BackColor == Color.MediumPurple)
            {
                Cell_8();
            }
        }

        private void label9_BackColorChanged(object sender, EventArgs e)
        {
            if (label9.BackColor == Color.MediumPurple)
            {
                Cell_9();
            }
        }

        private void label10_BackColorChanged(object sender, EventArgs e)
        {
            if (label10.BackColor == Color.MediumPurple)
            {
                Cell_10();
            }
        }


        private void label11_BackColorChanged(object sender, EventArgs e)
        {
            if (label11.BackColor == Color.MediumPurple)
            {
                Cell_11();
            }
        }

        private void label12_BackColorChanged(object sender, EventArgs e)
        {
            if (label12.BackColor == Color.MediumPurple)
            {
                Cell_12();
            }
        }

        private void label13_BackColorChanged(object sender, EventArgs e)
        {
            if (label13.BackColor == Color.MediumPurple)
            {
                Cell_13();
            }
        }

        private void label14_BackColorChanged(object sender, EventArgs e)
        {
            if (label14.BackColor == Color.MediumPurple)
            {
                Cell_14();
            }
        }

        private void label15_BackColorChanged(object sender, EventArgs e)
        {
            if (label15.BackColor == Color.MediumPurple)
            {
                Cell_15();
            }
        }


        private void label16_BackColorChanged(object sender, EventArgs e)
        {
            if (label16.BackColor == Color.MediumPurple)
            {
                Cell_16();
            }
        }

        private void label17_BackColorChanged(object sender, EventArgs e)
        {
            if (label17.BackColor == Color.MediumPurple)
            {
                Cell_17();
            }
        }

        private void label18_BackColorChanged(object sender, EventArgs e)
        {
            if (label18.BackColor == Color.MediumPurple)
            {
                Cell_18();
            }
        }

        private void label19_BackColorChanged(object sender, EventArgs e)
        {
            if (label19.BackColor == Color.MediumPurple)
            {
                Cell_19();
            }
        }

        private void label20_BackColorChanged(object sender, EventArgs e)
        {
            if (label20.BackColor == Color.MediumPurple)
            {
                Cell_20();
            }
        }


        private void label21_BackColorChanged(object sender, EventArgs e)
        {
            if (label21.BackColor == Color.MediumPurple)
            {
                Cell_21();
            }
        }

        private void label22_BackColorChanged(object sender, EventArgs e)
        {
            if (label22.BackColor == Color.MediumPurple)
            {
                Cell_22();
            }
        }

        private void label23_BackColorChanged(object sender, EventArgs e)
        {
            if (label23.BackColor == Color.MediumPurple)
            {
                Cell_23();
            }
        }

        private void label24_BackColorChanged(object sender, EventArgs e)
        {
            if (label24.BackColor == Color.MediumPurple)
            {
                Cell_24();
            }
        }

        private void label25_BackColorChanged(object sender, EventArgs e)
        {
            if (label25.BackColor == Color.MediumPurple)
            {
                Cell_25();
            }
        }


        //---Colisionar Numeros agrupados----------------------------------------
        private void label1_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label1.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label1.Text);
                label1.Text = Convert.ToString(Tablero_Star7[0, 0] + 1);
                label1.BackColor = Color.Beige;

                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                        
                    }
                  
                    
                }
                
            }
           
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label2.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label2.Text);
                label2.Text = Convert.ToString(Tablero_Star7[0, 1] + 1);
                label2.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
           
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label3.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label3.Text);
                label3.Text = Convert.ToString(Tablero_Star7[0, 2] + 1);
                label3.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);

            Ganador();
        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;

            if (label4.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label4.Text);
                label4.Text = Convert.ToString(Tablero_Star7[0, 3] + 1);
                label4.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label5.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label5.Text);
                label5.Text = Convert.ToString(Tablero_Star7[0, 4] + 1);
                label5.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }




        private void label6_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label6.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label6.Text);
                label6.Text = Convert.ToString(Tablero_Star7[1, 0] + 1);
                label6.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label7_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label7.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label7.Text);
                label7.Text = Convert.ToString(Tablero_Star7[1,1] + 1);
                label7.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label8_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label8.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label8.Text);
                label8.Text = Convert.ToString(Tablero_Star7[1, 2] + 1);
                label8.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label9_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label9.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label9.Text);
                label9.Text = Convert.ToString(Tablero_Star7[1, 3] + 1);
                label9.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label10_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label10.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label10.Text);
                label10.Text = Convert.ToString(Tablero_Star7[1, 4] + 1);
                label10.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }





        private void label11_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label11.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label11.Text);
                label11.Text = Convert.ToString(Tablero_Star7[2, 0] + 1);
                label11.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label12_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label12.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label12.Text);
                label12.Text = Convert.ToString(Tablero_Star7[2, 1] + 1);
                label12.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label13_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label13.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label13.Text);
                label13.Text = Convert.ToString(Tablero_Star7[2, 2] + 1);
                label13.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();

            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label14_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label14.BackColor == Color.MediumPurple)
            {
                
                CellValue = Convert.ToInt32(label14.Text);
                label14.Text = Convert.ToString(Tablero_Star7[2, 3] + 1);
                label14.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();

            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label15_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label15.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label15.Text);
                label15.Text = Convert.ToString(Tablero_Star7[2, 4] + 1);
                label15.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);

            Ganador();
        }





        private void label16_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label16.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label16.Text);
                label16.Text = Convert.ToString(Tablero_Star7[3, 0] + 1);
                label16.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label17_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label17.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label17.Text);
                label17.Text = Convert.ToString(Tablero_Star7[3, 1] + 1);
                label17.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label18_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label18.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label18.Text);
                label18.Text = Convert.ToString(Tablero_Star7[3, 2] + 1);
                label18.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label19_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label19.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label19.Text);
                label19.Text = Convert.ToString(Tablero_Star7[3, 3] + 1);
                label19.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label20_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label20.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label20.Text);
                label20.Text = Convert.ToString(Tablero_Star7[3, 4] + 1);
                label20.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }





        private void label21_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label21.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label21.Text);
                label21.Text = Convert.ToString(Tablero_Star7[4, 0] + 1);
                label21.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();

            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label22_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label22.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label22.Text);
                label22.Text = Convert.ToString(Tablero_Star7[4, 1] + 1);
                label22.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();

            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label23_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label23.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label23.Text);
                label23.Text = Convert.ToString(Tablero_Star7[4, 2] + 1);
                label23.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();

                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label24_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label24.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label24.Text);              
                label24.Text = Convert.ToString(Tablero_Star7[4, 3] + 1);
                
                label24.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }

        private void label25_DoubleClick(object sender, EventArgs e)
        {
            int Grouped = 1, CellValue = 0;
            if (label25.BackColor == Color.MediumPurple)
            {
                CellValue = Convert.ToInt32(label25.Text);
                label25.Text = Convert.ToString(Tablero_Star7[4, 4] + 1);
                label25.BackColor = Color.Beige;


                foreach (Control IndexPlace in tableLayoutPanel1.Controls)
                {
                    Label labelNUM = IndexPlace as Label;

                    if (labelNUM.BackColor == Color.MediumPurple)
                    {
                        labelNUM.Text = "0";
                        SyncTable_and_Array();
                        Grouped++;
                        labelNUM.BackColor = Color.Transparent;
                    }

                }
            }
            Give_color();
            PlayerTotalScore = PlayerTotalScore + (Grouped * CellValue);
            PlayerScore_label.Text = Convert.ToString(PlayerTotalScore);
            Ganador();
        }


        //---Colisionar Numeros agrupados----------------------------------------

        
        

    }
}

