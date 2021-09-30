using System.Runtime.InteropServices;
using Dominio;
using System.Collections.Generic;
using System.Linq; 

namespace Persistencia
{
    public class RepositorioDirectivo: IRepositorioDirectivo
    {
         private readonly AplicacionContext _appContext;

        public RepositorioDirectivo(AplicacionContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Directivo AddDirectivo(Directivo directivo)
        {    
            _appContext.Add(directivo);
            _appContext.SaveChanges();
            return directivo;
        }

        public void DeleteDirectivo(int IdDirectivo)
        {
            var Directivo_encontrado = _appContext.directivo.FirstOrDefault(
                p => p.Id == IdDirectivo);
            if(Directivo_encontrado == null)
                return ;
            _appContext.Remove(Directivo_encontrado);
            _appContext.SaveChanges();            
        }

        public IEnumerable<Directivo> GetAllDirectivo()
        {
            return _appContext.directivo;
        }

        public Directivo UpdateDirectivo(Directivo directivo)
        {
            Directivo Directivo_encontrado = _appContext.directivo.FirstOrDefault(
                p => p.Id == directivo.Id);
            if(Directivo_encontrado != null)
            {
                Directivo_encontrado.Nombre = directivo.Nombre;
                Directivo_encontrado.Edad = directivo.Edad;
                Directivo_encontrado.TipoDocumento = directivo.TipoDocumento;
                Directivo_encontrado.Documento = directivo.Documento;
                Directivo_encontrado.GrupoEmpleados = directivo.GrupoEmpleados;
                Directivo_encontrado.Categoria = directivo.Categoria;

                _appContext.Update(Directivo_encontrado);
                _appContext.SaveChanges();  
                return Directivo_encontrado;
            }        
            return null;
        }

        public Directivo GetDirectivo(int IdDirectivo)
        {
            return _appContext.directivo.FirstOrDefault(
                p => p.Id == IdDirectivo);
        }
    }
}