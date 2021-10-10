using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public interface IRepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleado();
        Empleado AddEmpleado(Empleado empleado);
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(int IdEmpleado);
        Empleado GetEmpleado(int IdEmpleado);  
    }
}