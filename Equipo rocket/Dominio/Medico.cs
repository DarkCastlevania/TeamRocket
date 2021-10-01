namespace Dominio
{
    public class Medico : Persona
    {
        public string Especialidad {get; set; }
        public int Registro  {get; set; }        

        public Medico(int id, string nombre, int edad, int tipoDocumento, int documento, string especialidad, int registro) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.TipoDocumento = tipoDocumento;
            this.Documento = documento;
            this.Especialidad = especialidad;
            this.Registro = registro;               
        }
                
    }
}