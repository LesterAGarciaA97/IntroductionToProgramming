using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7STARS_Ver._1
{
    class Modificar_Tablero
    {
        public int[,] Iniciar_matrix(int[,] Tablero_Star7)
        {
            Random RND = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int A = 0; A < 5; A++)
                {
                    Tablero_Star7[i, A] = RND.Next(1, 4);
                }
            }
            return Tablero_Star7;
        }
        public bool Adjacent_DOWN(int x, int y, int[,] Tablero_Star7)
        {
            bool AdjacentDown = false;

            if (Tablero_Star7[x, y] == Tablero_Star7[x + 1, y])
            {
                AdjacentDown = true;
            }
            return AdjacentDown;
        }
        public bool Adjacent_UP(int x, int y, int[,] Tablero_Star7)
        {
            bool AdjacentUP = false;

            {
                if (Tablero_Star7[x, y] == Tablero_Star7[x - 1, y])
                {
                    AdjacentUP = true;
                }
            }
            return AdjacentUP;
        }
        public bool Adjacent_LEFT(int x, int y, int[,] Tablero_Star7)
        {
            bool AdjacentLEFT = false;

            {
                if (Tablero_Star7[x, y] == Tablero_Star7[x, y-1])
                {
                    AdjacentLEFT = true;
                }
            }
            return AdjacentLEFT;
        }
        public bool Adjacent_RIGHT(int x, int y, int[,] Tablero_Star7)
        {
            bool AdjacentRIGHT = false;

            {
                if (Tablero_Star7[x, y] == Tablero_Star7[x , y + 1])
                {
                    AdjacentRIGHT = true;
                }
            }
            return AdjacentRIGHT;
        }
        public int Find_Max(int[,] Tablero_Star7)
        {
            int MAX = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Tablero_Star7[i, j] > MAX)
                        MAX = Tablero_Star7[i, j];
                }
            }
            return MAX;
        }
        public int Generate_NewRandom(int Max_Num)
        {
            int NewRandom = 0;
            Random RND = new Random();
            NewRandom = RND.Next(1, Max_Num +1);
            return NewRandom;
        }
    }
}
