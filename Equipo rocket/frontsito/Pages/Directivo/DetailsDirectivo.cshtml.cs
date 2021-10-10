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
    public class DetailsDirectivoModel : PageModel
    {

        private readonly IRepositorioDirectivo _repo;
        public Directivo directivo { get; set;}
        public DetailsDirectivoModel(IRepositorioDirectivo repo)
        {
            _repo = repo;
        }
         

        public void OnGet(int id)
        {
            directivo = _repo.GetDirectivo(id);
        }
    }
}