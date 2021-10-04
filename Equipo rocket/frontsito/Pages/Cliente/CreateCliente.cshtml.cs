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
    public class CreateClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente { get; set;}
        
        public CreateClienteModel(IRepositorioCliente repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            _repo.AddCliente(cliente);
        }
    }
}
