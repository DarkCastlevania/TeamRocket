using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq; 
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class RepositorioDirectivo: IRepositorioDirectivo 

    {
        private readonly AplicacionContext _appContext;

        public RepositorioDirectivo(AplicacionContext appContext){

            _appContext = appContext; 

       }
        
        public Directivo AddDirectivo(Directivo directivo)
        {    
            var new_directivo=_appContext.directivo.Add(directivo);
            _appContext.SaveChanges();
            return new_directivo.Entity;
        }

        public void DeleteDirectivo(int IdDirectivo)
        {
           Directivo directivo_encontrado = _appContext.directivo.FirstOrDefault(
                p => p.Id == IdDirectivo);
            if(directivo_encontrado == null)
                return ;
            _appContext.Remove(directivo_encontrado);
            _appContext.SaveChanges();            
        }

        public IEnumerable<Directivo> GetAllDirectivo()
        {
            return _appContext.directivo;
        }

        public Directivo UpdateDirectivo(Directivo directivo)
        {
            var directivo_encontrado = _appContext.directivo.FirstOrDefault(
                p => p.Id == directivo.Id);
           if(directivo_encontrado != null)
            {
                directivo_encontrado.Nombre = directivo.Nombre;
                directivo_encontrado.Edad = directivo.Edad;
                directivo_encontrado.TipoDocumento = directivo.TipoDocumento;
                directivo_encontrado.Documento = directivo.Documento; 
                directivo_encontrado.Id = directivo.Id;
                _appContext.Update(directivo_encontrado);
                _appContext.SaveChanges();  
                return directivo_encontrado;
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