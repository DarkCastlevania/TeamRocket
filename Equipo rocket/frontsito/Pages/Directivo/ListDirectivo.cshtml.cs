using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;
namespace MyApp.Namespace
{
    public class ListDirectivoModel : PageModel
    {
        private readonly IRepositorioDirectivo _repo;
        public IEnumerable<Directivo> Directivos { get; set;}
        public ListDirectivoModel(IRepositorioDirectivo repositorioDirectivo)
        {
            _repo = repositorioDirectivo;
        }

        

        public void OnGet()
        {            
            Directivos = _repo.GetAllDirectivo();
        }
        public void OnPost(int id)
        {
            _repo.DeleteDirectivo(id);
        }
    }
}
