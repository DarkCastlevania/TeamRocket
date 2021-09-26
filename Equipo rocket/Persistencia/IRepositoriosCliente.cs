using Dominio;
using System.Collections.Generic;

namespace Persistencia
{
    public interface IRepositoriosCliente
    {
        IEnumerable<Cliente> GetAllClient();
        Cliente AddCliente(Cliente cliente);
        Cliente UpdateCliente(Cliente cliente);
        void DeleteCliente(int IdCliente);
        Cliente GetCliente(int IdCliente);

    }

}