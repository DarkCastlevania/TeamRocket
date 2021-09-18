namespace Dominio
{
    public class Empleado : Persona 
    {
        public Empleado(int sueldoBruto) 
        {
            this.SueldoBruto = sueldoBruto;    
        }
        public int SueldoBruto {get; set; }
        public int Grupo {get; set; }
        public string Cargo {get; set; }
    }
}
