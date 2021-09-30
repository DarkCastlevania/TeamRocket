
using Dominio;
using System.Collections.Generic;
using System.Linq; 
namespace Persistencia
{
    public interface IRepositorioProducto
    {
        IEnumerable<Producto> GetAllProducto();
        Producto AddProducto(Producto producto);
        Producto UpdateProducto(Producto producto);
        void DeleteProducto(int IdProducto);
        Producto GetProducto(int IdProducto); 
    }
}