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
    public class DeleteVModel : PageModel
    {
        private readonly IRepositorioVenta _repo;
        public Venta venta { get; set;}

        public DeleteVModel(IRepositorioVenta repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            _repo.DeleteVenta(id);
        }
    }
}

