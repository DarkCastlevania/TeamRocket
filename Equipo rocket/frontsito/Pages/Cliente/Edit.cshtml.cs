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
    public class EditModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente { get; set;}
        public EditModel(IRepositorioCliente repo)
        {
            _repo = repo;
        }
         public void OnPost(Cliente cliente)
        {             
            _repo.UpdateCliente(cliente);
        }
        public void OnGet(int id)
        {
            cliente = _repo.GetCliente(id);
        }
    }
}
