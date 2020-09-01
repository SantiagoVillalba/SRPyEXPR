using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioAlfajor();
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            Moneda mo = new Moneda();
            return mo.ConvertirAPesos(dinero,moneda);
        }
    }
}