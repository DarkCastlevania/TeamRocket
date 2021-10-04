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
    public class DeleteModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public Cliente cliente { get; set;}

        public DeleteModel(IRepositorioCliente repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            _repo.DeleteCliente(id);
        }
    }
}
