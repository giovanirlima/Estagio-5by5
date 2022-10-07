using System.Collections.Generic;
using PDapper.Model;
using PDapper.Repositorio;

namespace PDapper.Services
{
    public class ClienteServices
    {
        private IClienteRepositorio _clienteRepositorio;

        public ClienteServices()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }

        public bool Add(Cliente cliente)
        {
            return _clienteRepositorio.Add(cliente);
        }

        public List<Cliente> GetAll()
        {
            return _clienteRepositorio.GetAll();
        }
    }
}
