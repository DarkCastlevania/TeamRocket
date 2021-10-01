namespace Dominio
{
    public class Cliente : Persona 
    {        
        public string NumeroTelefono {get; set; }

        public Cliente(int id, string nombre, int edad, int tipoDocumento, int documento, string numeroTelefono):base(id, nombre, edad, tipoDocumento, documento)
        {        
            this.NumeroTelefono = numeroTelefono;               
        }                
    }
}