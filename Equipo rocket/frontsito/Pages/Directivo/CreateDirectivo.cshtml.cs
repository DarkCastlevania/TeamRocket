using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Persistencia;
using Dominio;

namespace MyApp.Namespace
{
    public class CreateDirectivoModel : PageModel
    {
        private readonly IRepositorioDirectivo _repo;
        public Directivo directivo { get; set;}

        public CreateDirectivoModel(IRepositorioDirectivo repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
         }
        public void OnPost(Directivo directivo)
        {             
            _repo.AddDirectivo(directivo);
        }
        public void Prueba()
        {
            Console.WriteLine(directivo.Nombre);
        }
    }
}

