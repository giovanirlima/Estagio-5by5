using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefoneBD
{
    internal class Banco
    {
        string Conexao = "Data Source=localhost; Initial Catalog=Agenda; User Id=sa; Password=227126993";

        public Banco()
        {

        }
        public string Caminho()
        {
            return Conexao;
        }
    }
}