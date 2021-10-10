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
    public class CreateVentaModel : PageModel
    {
        private readonly IRepositorioVenta _repo;
        public Venta venta { get; set;}

        public CreateVentaModel(IRepositorioVenta repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
         }
        public void OnPost(Venta venta )
        {             
            _repo.AddVenta(venta);
        }
        public void Prueba()
        {
            Console.WriteLine(venta.Id);
        }
    }
}


