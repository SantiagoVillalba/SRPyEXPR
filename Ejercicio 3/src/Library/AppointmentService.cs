using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /* En esta clase me encargo de conocer las cosas necesarias para poder hacer una 
        consulta , como el Codigo de la consulta , la fecha, el lugar de la consulta
        y por ultimo el Doctor y el Paciente. Estos son objetos de otras clases Doctor y 
        Paciente respectivamente, esto hace que se pueda cumplir el patron SRP ya que 
        en esta clase solo tenemos lo respectivo a la Consulta o Appointment, abstrayendonos
        de los demas objetos y sus responsabilidades, asi cumpliendo con la encapsulacion, y 
        en el caso de que se quieran cambiar las otras clases esta no se va a ver afectada,
        ya que tiene solo una razon de cambio.
        Tambien cumple con el patron Expert ya que esta clase solo se encarga de conocer
        lo necesario de la Consulta y es experta en ello. */

        // Esta variable estatica se usa para que cada vez que se instancie un nuevo Appointment
        // esta funcione como contador, y el codigo unico va a tomar el valor de esta variable,
        // de esta manera todas los objetos instanciados de esta clase, tienen un identificador 
        // unico.
        private static int codigo=0;
        public int CodigoUnico{get;}
        public DateTime Date{get;set;}

        public Paciente Paciente{get;set;}
        public Doctor Doctor{get;set;}
        public string AppointmentPlace{get;set;}

        public AppointmentService(DateTime date, string appoinmentPlace,Paciente paciente, Doctor doctor)
        {
            if (CreateAppointment(date,appoinmentPlace,paciente,doctor))
            {
                codigo++;
                this.CodigoUnico=codigo;
                this.Date=date;
                this.AppointmentPlace=appoinmentPlace;
                this.Paciente=paciente;
                this.Doctor=doctor;
            }
            


        }

        // En vez de usar un metodo para anotar un appointment , que en realidad solo devolvia
        // un string sin hacer ningun appointment , uso este metodo en el constructor, asi poder 
        // crear realmente un objeto por cada consulta, tambien sin perder ese string, que nos 
        // decia cual era el fallo que habia en la creacion.
        public static bool CreateAppointment(DateTime date, string appoinmentPlace,Paciente paciente, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }
            if (Paciente.PacienteValido(paciente))
            {
                stringBuilder.Append("Unable to schedule appointment,the Pacient is invalid\n");
                isValid = false;
            }
            if (Doctor.DoctorValido(doctor))
            {
                stringBuilder.Append("Unable to schedule appointment,the Doctor is invalid\n");
                isValid = false;
            }
            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            Console.WriteLine(stringBuilder.ToString());
            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
            

            
        }

    }
}
