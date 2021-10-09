namespace Dominio
{
    public class Directivo : Persona
    {
        public int GrupoEmpleados {get; set; }
        public int Categoria {get; set; }
       /* public Directivo(int id, string nombre, int edad, int tipoDocumento, int documento, int grupoEmpleados, int categoria):base(id, nombre, edad, tipoDocumento, documento)
        {
            this.GrupoEmpleados = grupoEmpleados;
            this.Categoria = categoria;                               
        }*/
    }
}