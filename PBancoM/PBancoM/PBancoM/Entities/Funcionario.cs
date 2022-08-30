using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBancoM.Entities
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public bool Tipo { get; set; }
        Agencia Agencia { get; set; }

        public Funcionario()
        {
        }
        public Funcionario(string nome, int matricula, Agencia agencia)
        {
            Nome = nome;
            Matricula = matricula;
            Agencia = agencia;
        }

        public Cliente[] CadastrarCliente(int contador)
        {
            Cliente[] cliente = new Cliente[contador];
            Gerente gerente = new Gerente();
            //Cliente[] cliente = new Cliente[contador];

            Console.WriteLine("Olá senhor cliente, vamos iniciar seu cadastro");
            
            Console.Write("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Informe seu CPF: ");
            string cpf = Console.ReadLine();

            Console.Write("Informe sua data de nascimento: ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe seu Telefone: ");
            string telefone = Console.ReadLine();

            Endereco endereco = new Endereco();

            endereco.CadastrarEndereco();

            Console.Write("Informe sua renda mensal: ");
            double renda = double.Parse(Console.ReadLine());

            bool resposta = gerente.AprovarConta(nome, cpf, nascimento, telefone, endereco, renda);

            if (resposta)
            {
                return cliente[contador] = new Cliente (nome, cpf, nascimento, telefone, endereco, renda);
            }
            else
            {

            }
        }
    }
}
