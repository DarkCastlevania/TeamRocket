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
    public class DetailsProductoModel : PageModel
    {
       private readonly IRepositorioProducto _repo;
        public Producto producto { get; set;}
        public DetailsProductoModel(IRepositorioProducto repo)
        {
            _repo = repo;
        }
         

        public void OnGet(int id)
        {
            producto = _repo.GetProducto(id);
        }
    }
}