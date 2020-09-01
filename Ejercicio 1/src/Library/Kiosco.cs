using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        // El puede comprar tiene sentido en kiosko ya que este es el que vende el alfajor,
        // entonces por el principio EXPERT,pero este no deberia de saber los precios de los
        // alfajores, pero si la plata que tiene la persona para pagar los alfajores, seria mejor
        // si calcular el precio del alfajor se lo pusieramos al alfajor mismo.
        // Por esto mismo tambien tiene sentido que ConvertirAPesos se encargue de la
        // conversion de la moneda ya que es la clase que sabe la moneda que esta el dinero.
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