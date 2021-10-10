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
    public class EditDirectivoModel : PageModel
    {
         private readonly IRepositorioDirectivo _repo;
        public Directivo directivo { get; set;}
        public EditDirectivoModel(IRepositorioDirectivo repo)
        {
            _repo = repo;
        }
         public void OnPost(Directivo directivo)
        {             
            _repo.UpdateDirectivo(directivo);
        }
        public void OnGet(int id)
        {
            directivo = _repo.GetDirectivo(id);
        }
    }
}

