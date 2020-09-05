using System;
using Library;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor Jero = new Doctor("Jero","Cirujano");
            Paciente Santiago = new Paciente("Santiago","19","5.146.871-4","22925593");
            DateTime hoy = DateTime.Now ; 
            AppointmentService nuevo1= new AppointmentService(hoy,"Hospital Militar",Santiago,Jero);






        }
    }
}
