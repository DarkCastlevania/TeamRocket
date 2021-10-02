namespace Dominio
{
    public class Familiar : Persona
    {
        public int IdPaciente {get; set; }
        public string Permiso {get; set; }        
        public Familiar(int id, string nombre, int edad, int tipoDocumento, int documento, int idPaciente, string permiso):base(id, nombre, edad, tipoDocumento, documento)       
        {
        
            this.IdPaciente = idPaciente;
            this.Permiso = permiso;              
        }
                
    }
}