using Internal;
using System;
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

<<<<<<< HEAD
        public static void addCliente(){
            var cliente = new Cliente(
                Nombre = "Jessie",
                Edad = 17,
                Documento= 1806467748,
                TipoDocumento = 6,
                NumeroTelefono = 3214564215
            );
            repoCliente.AddCliente(cliente);            
=======
        public static void addCliente()
        {
            // var cliente = new Cliente(
            //     Nombre = "Jessie",
            //     Edad = 17,
            //     Documento= 1806467748,
            //     TipoDocumento = 6,
            //     NumeroTelefono = 3214564215
            // );
            // repoCliente.AddCliente(cliente);
            
>>>>>>> 3f1533c6fa2ad121ea01928a24c72a6509507b1a
        }

        public static void getCliente(int idCliente){
            var cliente = repoCliente.getCliente(idCliente);
            if(cliente == null) return;
            Console.writeLine(cliente.Nombre);    
        }

        public static void updateCliente(int idCliente){
            var cliente = repoCliente.getCliente(idCliente);
            cliente.Nombre = "James";                
            repoCliente.UpdateCliente(cliente);
            Console.writeLine(cliente.Nombre);    
        }

        public static void deleteCliente(int idCliente)
        {
            repoCliente.deleteCliente(idCliente);
        }


    }
}
