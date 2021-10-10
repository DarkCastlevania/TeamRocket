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
    public class CreateEmpleadoModel : PageModel
    {
        private readonly IRepositorioEmpleado _repo;
        public Empleado empleado { get; set;}

        public CreateEmpleadoModel(IRepositorioEmpleado repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
         }
        public void OnPost(Empleado empleado)
        {             
            _repo.AddEmpleado(empleado);
        }
        public void Prueba()
        {
            Console.WriteLine(empleado.Nombre);
        }
    }
}

