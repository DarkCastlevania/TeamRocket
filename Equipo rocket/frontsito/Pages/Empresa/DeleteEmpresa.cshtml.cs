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
    public class DeleteEmpresaModel : PageModel
    {
        private readonly IRepositorioEmpresa _repo;
        public Empresa empresa { get; set; }

        public DeleteEmpresaModel(IRepositorioEmpresa repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            _repo.DeleteEmpresa(id);
        }
    }
}

