using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
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
