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
    public class ListModel : PageModel
    {
        private readonly IRepositorioCliente _repo;
        public IEnumerable<Cliente> Clientes { get; set;}
        public ListModel(IRepositorioCliente repositorioCliente)
        {
            _repo = repositorioCliente;
        }

       /*  public DeleteModel(IRepositorioCliente repo)
        {
            _repo=repo;
        } */

        public void OnGet()
        {            
            Clientes = _repo.GetAllCliente();
        }
        public void OnPost(int id)
        {
            _repo.DeleteCliente(id);
        }
    }
}
