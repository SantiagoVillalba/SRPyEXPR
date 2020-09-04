using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace SRP
{
    /* Esta clase , es la clase biblioteca que se encarga de conocer los sectores y los estantes de cada libro, a traves de un diccionario. Para asi con el uso de este diccionario poder asignarle a un libro
    un sector y un estante, por cada libro. Esto tiene sentido ya que el ejercicio o problema propuesto no nos define mucha cosa, y al por ejemplo no saber cuantos libros puede tener un estante , no podemos
    hacer una lista de sectores, que dentro tengan listas de estantes, que a su vez dentro tengan libros. Ya que por ejemplo tampoco sabemos cuantos estantes hay en un sector. Por lo tanto al saber que se 
    le asigna a cada libro un sector y un estante, el diccionario nos sirve, para cumplir con esta tarea, siendo la Key una instancia del objeto libro , y el Value una lista que dentro tiene el sector y el estante
    (ambos en String). Teniendo esta clase biblioteca se cumple con el principio SRP ya que la biblioteca si el libro cambia o agrega propiedades o etc, esta abstraida de el libro en si, 
    y solo se encarga de conocer el sector y estante. Y tambien cumple con el patron Expert ya que la biblioteca es la que tiene la responsabilidad de conocer el estante y el sector, y no asi el libro,
    ya que con este no tiene nada que ver.Con esta aplicacion y las relaciones entre clases, podemos desde la biblioteca buscar pasando por parametro un libro y este nos devolvera su ubicacion
    con el metodo DevolverSectorYEstante, que esto tiene mas sentido que el libro fuera el que tuviera estas responsabilidades. */

    public class Biblioteca
    {
        public Dictionary<Libro,ArrayList> Libros{get;set;}
        public Biblioteca()
        {
            this.Libros= new Dictionary<Libro,ArrayList>();
        }
        public void AlmacenarLibro(Libro libro,String sector, String estante)
        {
            ArrayList lista  =  new ArrayList();
            lista.Add(sector);
            lista.Add(estante);
            this.Libros.Add(libro,lista);
        }
        public string DevolverSectorYEstante(Libro libro)
        {
            StringBuilder conversion = new StringBuilder();
            ArrayList sectorYestante= this.Libros[libro];
            foreach (String palabra in sectorYestante)
            {
                conversion.Append(palabra+" ");
            }

            return conversion.ToString();

        }


    }
}
