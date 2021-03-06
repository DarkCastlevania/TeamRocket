using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.EntityFrameworkCore;


namespace Persistencia
{
    public class RepositorioCliente: IRepositorioCliente
    {
        private readonly AplicacionContext _appContext;

        public RepositorioCliente(AplicacionContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Cliente AddCliente(Cliente cliente)
        {    
            var new_cliente=_appContext.cliente.Add(cliente);
            _appContext.SaveChanges();
            return new_cliente.Entity;
        }

        public void DeleteCliente(int IdCliente)
        {
            Cliente cliente_encontrado = _appContext.cliente.FirstOrDefault(
                p => p.Id == IdCliente);
            if(cliente_encontrado != null)
             {                          
                _appContext.Remove(cliente_encontrado);
                _appContext.SaveChanges();            
            }
        }

        public IEnumerable<Cliente> GetAllCliente()
        {
            return _appContext.cliente;
            /* return _appContext.cliente.AsNoTracking();sino no se requiere en cache */
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            Cliente cliente_encontrado = _appContext.cliente.FirstOrDefault(
                p => p.Id == cliente.Id);
            if(cliente_encontrado != null)
            {
                cliente_encontrado.Nombre = cliente.Nombre;
                cliente_encontrado.Edad = cliente.Edad;
                cliente_encontrado.TipoDocumento = cliente.TipoDocumento;
                cliente_encontrado.Documento = cliente.Documento; 
                cliente_encontrado.NumeroTelefono = cliente.NumeroTelefono;
                _appContext.Update(cliente_encontrado);
                _appContext.SaveChanges();  
                return cliente_encontrado;
            }        
            return null;            
        }

        public Cliente GetCliente(int IdCliente)
        {
            return _appContext.cliente.FirstOrDefault(
                p => p.Id == IdCliente);
        }
    }
}