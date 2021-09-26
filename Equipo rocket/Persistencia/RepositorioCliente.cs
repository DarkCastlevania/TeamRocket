namespace Persistencia
{
    public class RepositorioCliente : IRepositoriosCliente
    
        private readonly AplicacionContext _appContext;
        public RepositorioCliente(AplicacionContext appContext)
        {
            _appContext = appContext;
            
        }


    }
}