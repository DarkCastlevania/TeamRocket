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
    public class ListVModel : PageModel
    {
       private readonly IRepositorioVenta _repo;
        public IEnumerable<Venta> venta { get; set;}
        public ListVModel(IRepositorioVenta RepositorioVenta)
        {
            _repo = RepositorioVenta;
        }

        

        public void OnGet()
        {            
            venta = _repo.GetAllVenta();
        }
        public void OnPost(int id)
        {
            _repo.DeleteVenta(id);
        }
    }
}
