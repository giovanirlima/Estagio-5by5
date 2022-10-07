using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using PDapper.Config;
using PDapper.Model;

namespace PDapper.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private string _conexao;

        public ClienteRepositorio()
        {
            _conexao = BancoConfigurado.Get();
        }

        public bool Add(Cliente cliente)
        {        
            using (var db = new SqlConnection(_conexao))
            {
                db.Open();
                db.Execute(Cliente.INSERT, cliente);
                return true;
            }

           return false;
        }

        public List<Cliente> GetAll()
        {
            using (var db = new SqlConnection(_conexao))
            {
                db.Open();
                var clientes = db.Query<Cliente>(Cliente.SELECT);
                return (List<Cliente>)clientes;
            }
        }
    }
}
