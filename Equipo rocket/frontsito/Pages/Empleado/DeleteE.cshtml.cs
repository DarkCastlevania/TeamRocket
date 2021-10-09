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
    public class DeleteEModel : PageModel
    {
        private readonly IRepositorioEmpleado _repo;
        public Empleado empleado { get; set;}

        public DeleteEModel(IRepositorioEmpleado repo)
        {
            _repo = repo;
        }

        public void OnGet()
        {
        }
        public void OnPost(int id)
        {
            _repo.DeleteEmpleado(id);
        }
    }
}
