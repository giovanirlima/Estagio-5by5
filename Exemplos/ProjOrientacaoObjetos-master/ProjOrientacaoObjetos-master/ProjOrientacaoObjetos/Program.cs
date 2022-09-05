using System;

namespace ProjOrientacaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas();

            p1.CadastrarPessoa();

            Console.WriteLine(p1.ImprimirCadastro());
            Console.ReadKey();

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Data de Nascimento: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            long telefone = long.Parse(Console.ReadLine());

            Pessoas p2 = new Pessoas(nome, data, cpf, telefone);

            Console.WriteLine(p2.ImprimirCadastro());
            Console.ReadKey();

            Console.WriteLine("Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Data de Nascimento: ");
            data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("CPF: ");
            cpf = Console.ReadLine();

            Pessoas p3 = new Pessoas(nome, data, cpf);
            
            p3.ImprimirCadastro();
            Console.ReadKey();

            p3.setTelefone();

            Console.WriteLine(p3.ImprimirCadastro());

            /*Pessoas p2 = new Pessoas();
            Pessoas p3 = new Pessoas();

            p1.setNome();
            p1.setDataNasc();
            p1.setCpf();
            p1.setTelefone();

            p1.getNome();
            p1.getDataNasc();
            p1.getCpf();
            p1.getTelefone();

            p2.setNome();
            p2.setDataNasc();
            p2.setCpf();
            p2.setTelefone();

            p2.getNome();
            p2.getDataNasc();
            p2.getCpf();
            p2.getTelefone();

            p3.setNome();
            p3.setDataNasc();
            p3.setCpf();
            p3.setTelefone();

            p3.getNome();
            p3.getDataNasc();
            p3.getCpf();
            p3.getTelefone();*/


        }
    }
}
