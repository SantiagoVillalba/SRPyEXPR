using System;
using System.Text;

namespace Library
{
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

    }
}
