using Dominio;
using System.Collections.Generic;
using System.Linq; 

namespace Persistencia
{
    public interface IRepositorioCliente
    {
        IEnumerable<Cliente> GetAllCliente();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int IdCliente);
        Cliente GetCliente(int IdCliente);
    }
}