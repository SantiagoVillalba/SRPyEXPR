using System;

namespace SRP
{
    /* Sobre el patron Expert, me parece que esta clase esta bien ,ya que un libro
    debe de conocer , el titulo , su autor y su codigo , pero el sector de la biblioteca
    y el estante en el que esta este libro no es parte del libro en si, no lo define, 
    por esto me parece que estos datos deberian ser alojados en una clase llamada Biblioteca
    la cual se encargue de conocer estos datos. Y sobre el principio de SRP me parece que la
    responsabilidad de almacenar no deberia de estar en la clase libro, sino que tambien 
    deberia de estar en una clase Biblioteca, ya que en este caso tendria dos responsabilidades,
    conocer el libro y donde se almacena este, y en caso de que la biblioteca cambie su manera
    de almacenar los libros, vas a tener que cambiar la clase libro, en cambio
    con una clase Biblioteca no. */
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
