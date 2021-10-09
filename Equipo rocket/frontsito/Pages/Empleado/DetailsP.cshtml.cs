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
    public class DetailsPModel : PageModel
    {

        private readonly IRepositorioEmpleado _repo;
        public Empleado empleado { get; set;}
        public DetailsPModel(IRepositorioEmpleado repo)
        {
            _repo = repo;
        }
         

        public void OnGet(int id)
        {
            cliente = _repo.GetEmpleado(id);
        }
    }
}