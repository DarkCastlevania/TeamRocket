using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CreateClienteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente { get; set;}
        public void OnGet()
        {
        }
        public void OnPost()
        {
            _repo.AddCliente(cliente);
        }
    }
}
