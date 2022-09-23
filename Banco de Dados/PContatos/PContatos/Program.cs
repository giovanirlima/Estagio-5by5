using System;
using System.Data.SqlClient;

namespace AgendaTelefoneBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Criar novo contato
            Console.WriteLine("Adicionar novo contato: ");
            Console.Write("\nNome: ");
            string n = Console.ReadLine();

            Console.Write("Apelido: ");
            string a = Console.ReadLine();

            Console.Write("Telefone: ");
            string t = Console.ReadLine();

            Console.Write("Email: ");
            string e = Console.ReadLine();

            #endregion

            #region Conexao com o Banco
            Banco conn = new Banco();
            SqlConnection conexaosql = new SqlConnection(conn.Caminho());
            conexaosql.Open();
            #endregion

            #region Inserir na tabela
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO Contatos(Nome, Telefone, Apelido, Email) VALUES (@Nome, @Telefone, @Apelido, @Email);";

            cmd.Parameters.Add(new SqlParameter("@Nome", n));
            cmd.Parameters.Add(new SqlParameter("@Telefone", t));
            cmd.Parameters.Add(new SqlParameter("@Apelido", a));
            cmd.Parameters.Add(new SqlParameter("@Email", e));
                   
            cmd.Connection = conexaosql;
            cmd.ExecuteNonQuery();

            conexaosql.Close();
            #endregion

            #region Imprimir Tabela
            conexaosql.Open();
            cmd = new SqlCommand();

            cmd.CommandText = "SELECT ID, Nome, Telefone, Apelido, Email FROM Contatos";

            cmd.Connection = conexaosql;

            Console.Clear();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Contato ID: {reader.GetInt32(0)}");
                    Console.WriteLine($"Nome: {reader.GetString(1)}");
                    Console.WriteLine($"Telefone: {reader.GetString(2)}");
                    Console.WriteLine($"Apelido: {reader.GetString(3)}");
                    Console.WriteLine($"Email: {reader.GetString(4)}\n");
                }
            }
            conexaosql.Close();
            #endregion

            #region Update tabela
            conexaosql.Open();

            cmd = new SqlCommand();

            Console.Write("\nInforme o id para alteração: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o novo nome: ");
            n = Console.ReadLine();

            cmd.CommandText = "UPDATE Contatos SET Nome = @Nome WHERE ID = @ID";

            cmd.Parameters.Add(new SqlParameter("@ID", id));
            cmd.Parameters.Add(new SqlParameter("@Nome", n));

            cmd.Connection = conexaosql;
            cmd.ExecuteNonQuery();

            conexaosql.Close();
            #endregion

            #region Imprimir Tabela
            conexaosql.Open();
            cmd = new SqlCommand();

            cmd.CommandText = "SELECT ID, Nome, Telefone, Apelido, Email FROM Contatos";

            cmd.Connection = conexaosql;

            Console.Clear();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Contato ID: {reader.GetInt32(0)}");
                    Console.WriteLine($"Nome: {reader.GetString(1)}");
                    Console.WriteLine($"Telefone: {reader.GetString(2)}");
                    Console.WriteLine($"Apelido: {reader.GetString(3)}");
                    Console.WriteLine($"Email: {reader.GetString(4)}\n");
                }
            }
            conexaosql.Close();
            #endregion

            #region Delete registro tabela
            conexaosql.Open();

            cmd = new SqlCommand();

            Console.Write("informe o id do contato que deseja apagar: ");
            int id = int.Parse(Console.ReadLine());

            SqlParameter ID;

            cmd.CommandText = "DELETE from Contatos WHERE ID = @ID";

            cmd.Parameters.Add(ID = new SqlParameter("@ID", id));

            cmd.Connection = conexaosql;
            cmd.ExecuteNonQuery();

            conexaosql.Close();
            #endregion

            #region Imprimir Tabela
            conexaosql.Open();
            cmd = new SqlCommand();

            cmd.CommandText = "SELECT ID, Nome, Telefone, Apelido, Email FROM Contatos";

            cmd.Connection = conexaosql;

            Console.Clear();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"Contato ID: {reader.GetInt32(0)}");
                    Console.WriteLine($"Nome: {reader.GetString(1)}");
                    Console.WriteLine($"Telefone: {reader.GetString(2)}");
                    Console.WriteLine($"Apelido: {reader.GetString(3)}");
                    Console.WriteLine($"Email: {reader.GetString(4)}\n");
                }
            }
            conexaosql.Close();
            #endregion

        }
    }
}