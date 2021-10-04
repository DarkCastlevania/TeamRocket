using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public interface IRepositorioVenta
    {
        IEnumerable<Venta> GetAllVenta();
        Venta AddVenta(Venta venta);
        Venta UpdateVenta(Venta venta);
        void DeleteVenta(int IdVenta);
        Venta GetVenta(int IdVenta);   
    }
}