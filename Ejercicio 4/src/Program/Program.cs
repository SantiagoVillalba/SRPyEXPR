using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Archivo primer = new Archivo("../../nuevo.txt");
            
            //Tablero tablero = new Tablero(primer.Board);
            Imprimir.MostrarTablero(primer.Board);

        }
    }
}
