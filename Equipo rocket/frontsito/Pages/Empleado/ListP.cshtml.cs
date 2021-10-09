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
    public class ListPModel : PageModel
    {
        private readonly IRepositorioEmpleado _repo;
        public IEnumerable<Empleado> Empleados { get; set;}
        public ListPModel(IRepositorioEmpleado RepositorioEmpleado)
        {
            _repo = RepositorioEmpleado;
        }

        

        public void OnGet()
        {            
            Empleados = _repo.GetAllEmpleado();
        }
        public void OnPost(int id)
        {
            _repo.DeleteEmpleado(id);
        }
    }
}
