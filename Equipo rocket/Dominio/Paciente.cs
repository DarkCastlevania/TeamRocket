namespace Dominio
{
    public class Paciente : Persona 
    {
        public string Diagnostico {get; set; }
        public string Medicamentos {get; set; }
        public string Tratamiento {get; set; }
/*
        public Paciente(int id, string nombre, int edad, int tipoDocumento, int documento, string diagnostico, string medicamentos, string tratamiento):base(id,nombre,edad,tipoDocumento,documento)
        {          
            this.Diagnostico = diagnostico;
            this.Medicamentos = medicamentos;
            this.Tratamiento = tratamiento;               
        }
            */    
    }
}