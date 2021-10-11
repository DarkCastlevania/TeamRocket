using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class DeleteDirectivoModel : PageModel
    {
        private readonly IRepositorioDirectivo _repo;
        public Directivo directivo { get; set;}

        public DeleteDirectivoModel(IRepositorioDirectivo repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            _repo.DeleteDirectivo(id);
        }
    }
}
