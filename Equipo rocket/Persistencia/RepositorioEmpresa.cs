using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioEmpresa: IRepositorioEmpresa
    {
        
        private readonly AplicacionContext _appContext;

        public RepositorioEmpresa(AplicacionContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Empresa AddEmpresa(Empresa empresa)
        {    
            _appContext.Add(empresa);
            _appContext.SaveChanges();
            return empresa;
        }

        public void DeleteEmpresa(int IdEmpresa)
        {
            Empresa empresa_encontrado = _appContext.empresa.FirstOrDefault(
                p => p.Id == IdEmpresa);
            if(empresa_encontrado != null)
             {                          
                _appContext.Remove(empresa_encontrado);
                _appContext.SaveChanges();            
            }
        }

        public IEnumerable<Empresa> GetAllEmpresa()
        {
            return _appContext.empresa;
        }

        public Empresa UpdateEmpresa(Empresa empresa)
        {
            Empresa empresa_encontrado = _appContext.empresa.FirstOrDefault(
                p => p.Id == empresa.Id);
            if(empresa_encontrado != null)
            {
                empresa_encontrado.Id = empresa.Id;
                empresa_encontrado.Nombre = empresa.Nombre;
                empresa_encontrado.Nit = empresa.Nit;                
                _appContext.Update(empresa_encontrado);
                _appContext.SaveChanges();  
                return empresa_encontrado;
            }        
            return null;            
        }

        public Empresa GetEmpresa(int IdEmpresa)
        {
            return _appContext.empresa.FirstOrDefault(
                p => p.Id == IdEmpresa);
        }
    }
}  
    
