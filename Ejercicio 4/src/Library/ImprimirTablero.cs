using System;
using System.Text;
namespace PII_Game_Of_Life
{
    public class Imprimir
    {
        public static void MostrarTablero(bool [,] board)
        {
            //bool[,] b //variable que representa el tablero
            int width = board.GetLength(0); //variabe que representa el ancho del tablero
            int height = board.GetLength(1); //variabe que representa altura del tablero
            While (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<height;y++)
                {
                    for (int x = 0; x<width; x++)
                    {
                        if(board[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================
                Thread.Sleep(300);
            }
        }

    }
}
