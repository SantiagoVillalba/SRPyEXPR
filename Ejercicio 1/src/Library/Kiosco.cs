using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        // El puede comprar tiene sentido en kiosko ya que este es el que vende el alfajor,
        // entonces por el principio EXPERT, este deberia de saber los precios de los
        // alfajores y la plata que tiene la persona para pagar los alfajores.\
        // por esto mismo tambien tiene sentido que ConvertirAPesos se encargue de la
        // conversion de la moneda.
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}