namespace Dominio
{
    public class Paciente : Persona 
    {
        public string Diagnostico {get; set; }
        public string Medicamentos {get; set; }
        public string Tratamiento {get; set; }
    }
}