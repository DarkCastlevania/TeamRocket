namespace Dominio
{
    public class Directivo : Persona
    {
        public int GrupoEmpleados {get; set; }
        public int Categoria {get; set; }
        public Directivo(int id, string nombre, int edad, int tipoDocumento, int documento, int grupoEmpleados, int categoria) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.TipoDocumento = tipoDocumento;
            this.Documento = documento;
            this.GrupoEmpleados = grupoEmpleados;
            this.Categoria = categoria;                               
        }
    }
}