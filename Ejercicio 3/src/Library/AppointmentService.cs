using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /* Segun el principio SRP este codigo esta mal, ya que una consulta solo deberia de saber la fecha y el lugar de la consulta
        , pero como vemos en este codigo sabe tanto datos del paciente, como del doctor, cosas que deberian de estar en otras clases, conociendo
        sus propios datos. Esta clase presentada en el codigo deberia de ser cambiada varias veces, en el caso de que queramos cambiar datos tanto
        del paciente como del doctor, por lo tanto no cumple con el principio SRP. Sobre el patron Expert este codigo tambien esta mal, ya que los datos tanto 
        del paciente como del doctor, la clase AppointmentService no es la experta en estos datos, por eso no lo cumple el patron. Para arreglar este codigo
        deberiamos agregar una clase Doctor y una clase Persona, para asi que cada una se encargue de conocer los datos de ellos mismos.  */

        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
