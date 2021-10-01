namespace Dominio
{
    public class Persona
    {
        public int Id {get; set; }
        public string Nombre {get; set; }
        public int Edad {get; set; } 
        public int TipoDocumento {get; set; }
        public int Documento {get; set; }
        
        public Persona(int id, string nombre, int edad, int tipoDocumento, int documento) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.TipoDocumento = tipoDocumento;
            this.Documento = documento;
               
        }
        
    }
}