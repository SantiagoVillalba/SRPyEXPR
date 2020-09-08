using System;

namespace PII_Game_Of_Life
{
    public class Tablero
    {
        public bool [,] Board {get;set;}

        public Tablero (bool [,] board)
        {
            this.Board=board;
        }
        
        public void ActualizarTablero()
        {
            this.Board= Logica.Actualizar(this.Board);
        }
    }
}
