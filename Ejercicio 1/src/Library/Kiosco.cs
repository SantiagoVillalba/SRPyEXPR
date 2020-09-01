using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Moneda mo = new Moneda();
            Double pesos =  mo.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioAlfajor();
        }
       
    }
}