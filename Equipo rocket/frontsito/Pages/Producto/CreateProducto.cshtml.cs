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
    public class CreateProductoModel : PageModel
    {
       private readonly IRepositorioProducto _repo;
        public Producto producto { get; set;}

        public CreateProductoModel(IRepositorioProducto repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
         }
        public void OnPost(Producto producto)
        {             
            _repo.AddProducto(producto);
        }
        public void Prueba()
        {
            Console.WriteLine(producto.Nombre);
        }
    }
}


