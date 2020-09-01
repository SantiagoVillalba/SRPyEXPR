using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        // Aplica el principio de EXPERT ya que la clase alfajor 
        // solo tiene la responsabilidad de conocer los precios de la
        // masa y el dulce. Y es lo unico que hace. 
        
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}