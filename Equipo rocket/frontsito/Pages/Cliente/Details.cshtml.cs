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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public DetailsModel(IRepositorioCliente repo)
        {
            _repo = repo;
        }
        public 

        public void OnGet()
        {
        }
    }
}