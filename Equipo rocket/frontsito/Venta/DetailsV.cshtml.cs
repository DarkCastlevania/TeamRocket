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
    public class DetailsVModel : PageModel
    {
       private readonly IRepositorioVenta _repo;
        public Venta venta { get; set;}
        public DetailsVModel(IRepositorioVenta repo)
        {
            _repo = repo;
        }
         

        public void OnGet(int id)
        {
            venta = _repo.GetVenta(id);
        }
    }
}