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
    public class EditEmpresaModel : PageModel
    {
         private readonly IRepositorioEmpresa _repo;
        public Empresa empresa { get; set;}
        public EditEmpresaModel(IRepositorioEmpresa repo)
        {
            _repo = repo;
        }
         public void OnPost(Empresa empresa)
        {             
            _repo.UpdateEmpresa(empresa);
        }
        public void OnGet(int id)
        {
            empresa = _repo.GetEmpresa(id);
        }
    }
}

