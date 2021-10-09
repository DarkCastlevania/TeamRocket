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
    public class EditPModel : PageModel
    {
         private readonly IRepositorioEmpleado _repo;
        public Empleado empleado { get; set;}
        public EditPModel(IRepositorioEmpleado repo)
        {
            _repo = repo;
        }
         public void OnPost(Empleado empleado)
        {             
            _repo.UpdateEmpleado(empleado);
        }
        public void OnGet(int id)
        {
            cliente = _repo.GetEmpleado(id);
        }
    }
}

