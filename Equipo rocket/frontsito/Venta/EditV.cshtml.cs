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
    public class EditVModel : PageModel
    {
       private readonly IRepositorioVenta _repo;
        public Venta venta { get; set;}
        public EditVModel(IRepositorioVenta repo)
        {
            _repo = repo;
        }
         public void OnPost(Venta venta)
        {             
            _repo.UpdateVenta(venta);
        }
        public void OnGet(int id)
        {
            venta = _repo.GetVenta(id);
        }
    }
}

