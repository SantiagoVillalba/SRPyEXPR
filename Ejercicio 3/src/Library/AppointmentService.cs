using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        private static int codigoUnico;

        public AppointmentService()
        {
            codigoUnico++;
        }
        public static string CreateAppointment(DateTime date, string appoinmentPlace,Paciente paciente, Doctor doctor)
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
                stringBuilder.Append("Unable to schedule appointment, Pacient is invalid\n");
                isValid = false;
            }
            if (Doctor.DoctorValido(doctor))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor is invalid\n");
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
