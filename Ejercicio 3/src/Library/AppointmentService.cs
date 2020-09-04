using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {

        public static string CreateAppointment(DateTime date, string appoinmentPlace)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
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
