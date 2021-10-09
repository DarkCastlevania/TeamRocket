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
    public class DeletePModel : PageModel
    {
        private readonly IRepositorioProducto _repo;
        public Producto producto { get; set;}

        public DeletePModel(IRepositorioProducto repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            _repo.DeleteProducto(id);
        }
    }
}

