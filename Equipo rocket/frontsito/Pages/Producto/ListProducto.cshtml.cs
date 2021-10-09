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
    public class ListProductoModel : PageModel
    {
        private readonly IRepositorioProducto _repo;
        public IEnumerable<Producto> Productos { get; set;}
        public ListProductoModel(IRepositorioProducto RepositorioProducto)
        {
            _repo = RepositorioProducto;
        }

        

        public void OnGet()
        {            
            Productos = _repo.GetAllProducto();
        }
        public void OnPost(int id)
        {
            _repo.DeleteProducto(id);
        }
    }
}
