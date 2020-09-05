using System;
using System.Text;

namespace Library
{
    /* Una clase que se encarga de tener la responsabilidad de conocer al Paciente y 
    verificar sus datos. Con un metodo de clase para verificar otras instancias de la 
    clase Paciente. */
    public class Paciente
    {
        public string Name {get;set;}
        public string Edad{get;set;}
        public string Id{get;set;}
        public string Telefono{get;set;}
        public Paciente(string name, string edad, string id ,string telefono)
        {
            if(!string.IsNullOrEmpty(name))
            {
                this.Name=name;
            }
            if(!string.IsNullOrEmpty(edad))
            {
                this.Edad=edad;
            }
            if(!string.IsNullOrEmpty(id))
            {
                this.Id=id;
            }
            if(!string.IsNullOrEmpty(telefono))
            {
                this.Telefono=telefono;
            }

        }
        public static bool PacienteValido(Paciente paciente)
        {
            if(string.IsNullOrEmpty(paciente.Name) || string.IsNullOrEmpty(paciente.Edad)|| string.IsNullOrEmpty(paciente.Id)|| string.IsNullOrEmpty(paciente.Telefono))
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
