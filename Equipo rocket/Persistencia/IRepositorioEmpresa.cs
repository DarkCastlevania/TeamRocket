using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public interface IRepositorioEmpresa
    {
        IEnumerable<Empresa> GetAllEmpresa();
        Empresa AddEmpresa(Empresa empresa);
        Empresa UpdateEmpresa(Empresa empresa);
        void DeleteEmpresa(int IdEmpresa);
        Empresa GetEmpresa(int IdEmpresa);   
    }
}