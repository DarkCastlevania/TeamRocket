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
    public class EditProductoModel : PageModel
    {
         private readonly IRepositorioProducto _repo;
        public Producto producto { get; set;}
        public EditProductoModel(IRepositorioProducto repo)
        {
            _repo = repo;
        }
         public void OnPost(Producto producto)
        {             
            _repo.UpdateProducto(producto);
        }
        public void OnGet(int id)
        {
            producto = _repo.GetProducto(id);
        }
    }
}

