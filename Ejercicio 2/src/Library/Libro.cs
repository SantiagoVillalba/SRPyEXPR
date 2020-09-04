using System;

namespace SRP
{   
    /* En la solucion lo unico que en la clase Libro es eliminar la responsabilidad de conocer el estante y el sector en el que esta ubicado 
    dicho libro, ya que estos no tienen sentidos encontrarlos en la clase Libro, y el metodo almacenar libro, que no tiene sentido alguno que un libro se almacene a si mismo. */

    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        //public Biblioteca Biblioteca {get ; set;}
        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
        

    }
}
