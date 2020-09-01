using System;

namespace Expert_SRP
{
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}

        public double PrecioAlfajor()
        {
            double precio = 0;
            precio = this.PrecioDulce +this.PrecioMasa;
            return precio;
        }
    }
}