using System;
using System.Data.SqlClient;
using Models;

namespace Services
{
    public class ContatoServices
    {
        static string Caminho = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=Services\Banco\BancoContato.mdf;Integrated Security = True; Connect Timeout = 30";
        SqlConnection conexao = new(Caminho);
        
        public Contato InserirContato(Contato contato)
        {
            SqlCommand cmd;
            
            conexao.Open();

            cmd = new($"INSERT Contatos(Nome, Telefone) VALUES('{contato.Nome}', '{contato.Telefone}');", conexao);

            cmd.ExecuteNonQuery();

            conexao.Close();

            return contato;
        }
    }
}
