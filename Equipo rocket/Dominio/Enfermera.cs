using System.Runtime.CompilerServices;
using System.Globalization;
using System;
namespace Dominio
{
    public class Enfermera : Persona
    {
        public string Horario {get; set; }
        public string Control {get; set; }        
        public Enfermera(int id, string nombre, int edad, int tipoDocumento, int documento, string horario, string control):base(id, nombre, edad, tipoDocumento, documento)
        {
            this.Horario = horario;
            this.Control = control;
   
        }
                
    }
}