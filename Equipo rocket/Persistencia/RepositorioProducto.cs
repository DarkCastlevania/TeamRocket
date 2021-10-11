using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioProducto: IRepositorioProducto
    {
        
        private readonly AplicacionContext _appContext;

        public RepositorioProducto(AplicacionContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Producto AddProducto(Producto producto)
        {    
            _appContext.Add(producto);
            _appContext.SaveChanges();
            return producto;
        }

        public void DeleteProducto(int IdProducto)
        {
            Producto producto_encontrado = _appContext.producto.FirstOrDefault(
                p => p.Id == IdProducto);
            if(producto_encontrado != null)
             {                          
                _appContext.Remove(producto_encontrado);
                _appContext.SaveChanges();            
            }
        }

        public IEnumerable<Producto> GetAllProducto()
        {
            return _appContext.producto;
        }

        public Producto UpdateProducto(Producto producto)
        {
            Producto producto_encontrado = _appContext.producto.FirstOrDefault(
                p => p.Id == producto.Id);
            if(producto_encontrado != null)
            {
                producto_encontrado.Id = producto.Id;
                producto_encontrado.Nombre = producto.Nombre;
                producto_encontrado.Precio = producto.Precio;                
                _appContext.Update(producto_encontrado);
                _appContext.SaveChanges();  
                return producto_encontrado;
            }        
            return null;            
        }

        public Producto GetProducto(int IdProducto)
        {
            return _appContext.producto.FirstOrDefault(
                p => p.Id == IdProducto);
        }
    }
}  
    
