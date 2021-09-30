using Dominio;
using System.Collections.Generic;
using System.Linq; 

namespace Persistencia
{
    public interface IRepositorioDirectivo
    {
        IEnumerable<Directivo> GetAllDirectivo();
        Directivo AddDirectivo(Directivo directivo);
        Directivo UpdateDirectivo(Directivo directivo);
        void DeleteDirectivo(int IdDirectivo);
        Directivo GetDirectivo(int IdDirectivo);    
    }
}