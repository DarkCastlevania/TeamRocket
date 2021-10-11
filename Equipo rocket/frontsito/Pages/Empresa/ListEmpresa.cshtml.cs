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
    public class ListEmpresaModel : PageModel
    {
        private readonly IRepositorioEmpresa _repo;
        public IEnumerable<Empresa> Empresas { get; set;}
        public ListEmpresaModel(IRepositorioEmpresa RepositorioEmpresa)
        {
            _repo = RepositorioEmpresa;
        }

        

        public void OnGet()
        {            
            Empresas = _repo.GetAllEmpresa();
        }
        public void OnPost(int id)
        {
            _repo.DeleteEmpresa(id);
        }
    }
}
