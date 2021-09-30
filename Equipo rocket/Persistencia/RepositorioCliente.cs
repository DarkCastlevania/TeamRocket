using Dominio;
using System.Collections.Generic;
using System.Linq; 

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
            Cliente nuevo_cliente = _appContext.Add(cliente);
            _appContext.SaveChanges();
            return nuevo_cliente.entity;
        }

        public void DeleteCliente(int IdCliente)
        {
            var cliente_encontrado = _appContext.Cliente.FirstOrDefault(
                p => p.Id == IdCliente);
            if(cliente_encontrado == null)
                return ;
            _appContext.Remove(cliente_encontrado);
            _appContext.SaveChanges();            
        }

        public IEnumerable<Cliente> GetAllClient()
        {
            return _appContext.Cliente;
        }

        public Cliente UpdateCliente(Cliente cliente)
        {
            var cliente_encontrado = _appContext.Cliente.FirstOrDefault(
                p => p.Id == cliente.Id);
            if(cliente_encontrado != null)
            {
                cliente_encontrado.Nombre = cliente.Nombre;
                cliente_encontrado.Edad = cliente.Edad;
                cliente_encontrado.TipoDocumento = cliente.TipoDocumento;
                cliente_encontrado.Documento = cliente.Documento;
                
                    return ;
                _appContext.Remove(cliente_encontrado);
                _appContext.SaveChanges();  
            }        
            
        }

        public Cliente GetCliente(int IdCliente)
        {
            return _appContext.Cliente.FirstOrDefault(
                p => p.Id == IdCliente);
        }

    }
}