namespace Dominio
{
    public class Cliente : Persona 
    {        
        public string NumeroTelefono {get; set; }

        public Cliente(int id, string nombre, int edad, int tipoDocumento, int documento, string numeroTelefono):base(this.id, this.nombre, this.edad, this.tipoDocumento, this.Documento)
        {        
            this.NumeroTelefono = numeroTelefono;               
        }                
    }
}