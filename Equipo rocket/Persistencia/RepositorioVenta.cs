using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioVenta: IRepositorioVenta
    {
        
        private readonly AplicacionContext _appContext;

        public RepositorioVenta(AplicacionContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Venta AddVenta(Venta venta)
        {    
            _appContext.Add(venta);
            _appContext.SaveChanges();
            return venta;
        }

        public void DeleteVenta(int IdVenta)
        {
            Venta venta_encontrado = _appContext.venta.FirstOrDefault(
                p => p.Id == IdVenta);
            if(venta_encontrado != null)
             {                          
                _appContext.Remove(venta_encontrado);
                _appContext.SaveChanges();            
            }
        }

        public IEnumerable<Venta> GetAllVenta()
        {
            return _appContext.venta;
        }

        public Venta UpdateVenta(Venta venta)
        {
            Venta venta_encontrado = _appContext.venta.FirstOrDefault(
                p => p.Id == venta.Id);
            if(venta_encontrado != null)
            {
                venta_encontrado.Id = venta.Id;
                venta_encontrado.IdCliente = venta.IdCliente;
                venta_encontrado.IdProducto = venta.IdProducto;
                venta_encontrado.Cantidad = venta.Cantidad; 
                venta_encontrado.Fecha = venta.Fecha;
                _appContext.Update(venta_encontrado);
                _appContext.SaveChanges();  
                return venta_encontrado;
            }        
            return null;            
        }

        public Venta GetVenta(int IdVenta)
        {
            return _appContext.venta.FirstOrDefault(
                p => p.Id == IdVenta);
        }
    }
}  
    
