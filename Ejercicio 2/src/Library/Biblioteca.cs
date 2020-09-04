using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace SRP
{
    public class Biblioteca
    {
        //public ArrayList Libros{get; set;}
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
