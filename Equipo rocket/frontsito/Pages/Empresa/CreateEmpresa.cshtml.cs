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
    public class CreateEmpresaModel : PageModel
    {
       private readonly IRepositorioEmpresa _repo;
        public Empresa empresa { get; set;}

        public CreateEmpresaModel(IRepositorioEmpresa repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
         }
        public void OnPost(Empresa empresa)
        {             
            _repo.AddEmpresa(empresa);
        }
        public void Prueba()
        {
            Console.WriteLine(empresa.Nombre);
        }
    }
}


