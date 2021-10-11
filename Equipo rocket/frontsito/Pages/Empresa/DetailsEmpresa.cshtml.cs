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
    public class DetailsEmpresaModel : PageModel
    {
       private readonly IRepositorioEmpresa _repo;
        public Empresa empresa { get; set;}
        public DetailsEmpresaModel(IRepositorioEmpresa repo)
        {
            _repo = repo;
        }
         

        public void OnGet(int id)
        {
            empresa = _repo.GetEmpresa(id);
        }
    }
}