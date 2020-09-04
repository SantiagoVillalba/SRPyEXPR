using System;
using System.Collections;
using System.Collections.Generic;
namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca= new Biblioteca();
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            biblioteca.AlmacenarLibro(libro1,"A","7");
            biblioteca.AlmacenarLibro(libro2,"B","3");
            Console.WriteLine(biblioteca.DevolverSectorYEstante(libro1));
            Console.WriteLine(biblioteca.DevolverSectorYEstante(libro2));
        }
    }
}
