using System;
using System.Text;

namespace Library
{
    /* Una clase que se encarga de tener la responsabilidad de conocer al Doctor y 
    verificar sus datos. Con un metodo de clase para verificar otras instancias de la 
    clase Doctor. */
    public class Doctor
    {
        public string Name {get;set;}
        public string Especialidad{get;set;}
        public Doctor(string name, string especialidad)
        {
            if(!string.IsNullOrEmpty(name))
            {
                this.Name=name;
            }
            if(!string.IsNullOrEmpty(especialidad))
            {
                this.Especialidad=especialidad;
            }
        }
        public static bool DoctorValido(Doctor doctor)
        {
            if(string.IsNullOrEmpty(doctor.Name) || string.IsNullOrEmpty(doctor.Especialidad))
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
