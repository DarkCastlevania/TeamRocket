using System;
using System.Collections.Generic;
using Persistencia;
using Dominio;

namespace Aplicacion
{
    class Program
    {
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            addCliente();
        }

        public static void addCliente(){
            var cliente = new Cliente
            {
                Nombre = "Jessie",
                Edad = 17,
                Documento= 1806467748,
                TipoDocumento = 6,
                NumeroTelefono = "3214564215"
            };
            repoCliente.AddCliente(cliente);            
        }

        public static void getCliente(int idCliente){
            var cliente = repoCliente.GetCliente(idCliente);
            if(cliente == null) return;
            Console.WriteLine(cliente.Nombre);    
        }

        public static void updateCliente(int idCliente){
            var cliente = repoCliente.GetCliente(idCliente);
            cliente.Nombre = "James";                
            repoCliente.UpdateCliente(cliente);
            Console.WriteLine(cliente.Nombre);    
        }

        public static void deleteCliente(int idCliente)
        {
            repoCliente.DeleteCliente(idCliente);
        }


    }
}
