using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        // El principio de SRP en esta clase esta mal, ya que a pesar de ser el 
        // experto en datos para tener estas responsabilidades, en esta clase hay 2 razones
        // de cambio, por ejemplo el poder comprar, tiene sentido en el kiosko, y que sea su
        // responsabilidad, pero ConvertirAPesos quedaria mejor en una clase de por ejemplo
        // moneda, y asi tambien podrias saber si los alfajores estan en otra moneda, sin 
        // tener que modificar ninguna de las clases. 

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