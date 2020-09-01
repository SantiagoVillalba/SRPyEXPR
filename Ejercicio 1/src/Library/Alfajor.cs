using System;

namespace Expert_SRP
{
    // Para mi se aplica el SRP, ya que este solo tiene la responsabilidad de 
    //de conocerse a si mismo, al alfajor en si.
    public class Alfajor 
    {
        public Alfajor(double precioMasa, double precioDulce)
        {
            this.PrecioDulce = precioDulce;
            this.PrecioMasa = precioMasa;
        }
        public Double PrecioDulce {get;set;}
        public Double PrecioMasa {get; set;}
    }
}