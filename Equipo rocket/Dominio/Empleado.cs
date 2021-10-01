namespace Dominio
{
    public class Empleado : Persona 
    {
        public int SueldoBruto {get; set; }
        public int Grupo {get; set; }
        public string Cargo {get; set; }

        public Empleado(int id, string nombre, int edad, int tipoDocumento, int documento, int sueldoBruto, int grupo, string cargo) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.TipoDocumento = tipoDocumento;
            this.Documento = documento;
            this.SueldoBruto = sueldoBruto;    
            this.Grupo = grupo;
            this.Cargo = cargo;            
        }
        
    }
}
