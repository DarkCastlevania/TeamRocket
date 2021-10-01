namespace Dominio
{
    public class Familiar : Persona
    {
        public int IdPaciente {get; set; }
        public string Permiso {get; set; }        
        public Familiar(int id, string nombre, int edad, int tipoDocumento, int documento, int idPaciente, string permiso)         
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.TipoDocumento = tipoDocumento;
            this.Documento = documento;
            this.IdPaciente = idPaciente;
            this.Permiso = permiso;
               
        }
                
    }
}