using System.Collections.Generic;
using PDapper.Model;

namespace PDapper.Repositorio
{
    public interface IClienteRepositorio
    {
        bool Add(Cliente cliente);
        List<Cliente> GetAll();
    }
}
