using System;
using System.Net.Http;
using Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Persistencia
{
    public class RepositorioEmpleado: IRepositorioEmpleado
    {
      private readonly AplicacionContext _appContext;

        public RepositorioEmpleado(AplicacionContext appContext)
        {
            _appContext = appContext;            
        }
        
        public Empleado AddEmpleado(Empleado empleado)
        {    
            _appContext.Add(empleado);
            _appContext.SaveChanges();
            return empleado;
        }

        public void DeleteEmpleado(int IdEmpleado)
        {
            Empleado empleado_encontrado = _appContext.empleado.FirstOrDefault(
                p => p.Id == IdEmpleado);
            if(empleado_encontrado != null)
             {                          
                _appContext.Remove(empleado_encontrado);
                _appContext.SaveChanges();            
            }
        }

        public IEnumerable<Empleado> GetAllEmpleado()
        {
            return _appContext.empleado;
        }

        public Empleado UpdateEmpleado(Empleado empleado)
        {
            Empleado empleado_encontrado = _appContext.empleado.FirstOrDefault(
                p => p.Id == empleado.Id);
            if(empleado_encontrado != null)
            {
                empleado_encontrado.Nombre = empleado.Nombre;
                empleado_encontrado.Edad = empleado.Edad;
                empleado_encontrado.TipoDocumento = empleado.TipoDocumento;
                empleado_encontrado.Documento = empleado.Documento;                 
                empleado_encontrado.SueldoBruto = empleado.SueldoBruto;
                empleado_encontrado.Grupo = empleado.Grupo;
                empleado_encontrado.Cargo = empleado.Cargo;
                _appContext.Update(empleado_encontrado);
                _appContext.SaveChanges();  
                return empleado_encontrado;
            }        
            return null;            
        }

        public Empleado GetEmpleado(int IdEmpleado)
        {
            return _appContext.empleado.FirstOrDefault(
                p => p.Id == IdEmpleado);
        }
    }
}  
    
