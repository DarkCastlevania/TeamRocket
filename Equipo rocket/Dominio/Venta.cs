namespace Dominio
{
    public class Venta
    {
        public int Id {get; set; }
        public int IdProducto {get; set; }
        public int IdCliente {get; set; }
        public int Cantidad {get; set; }
        public string Fecha {get; set; }
    }
}