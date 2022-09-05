using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjOrientacaoObjetos
{
    internal class Pessoas
    {
        String Nome;
        DateTime DataNasc;
        String Cpf;
        long Telefone;

        public Pessoas()
        {

        }

        public Pessoas(string nome, DateTime dataNasc, string cpf, long telefone)
        {
            this.Nome = nome;
            this.DataNasc = dataNasc;
            this.Cpf = cpf;
            this.Telefone = telefone;
        }

        public Pessoas(string nome, DateTime dataNasc, string cpf)
        {
            this.Nome = nome;
            this.DataNasc = dataNasc;
            this.Cpf = cpf;
        }

        private void setNome()
        {
            Console.Write("Informe o nome: ");
            this.Nome = Console.ReadLine();
        }

        public void getNome()
        {
            Console.Write("Nome: "+this.Nome);
        }

        public void setDataNasc()
        {
            Console.Write("Informe o Data de Nascimento: ");
            this.DataNasc = DateTime.Parse(Console.ReadLine());
        }

        public void getDataNasc()
        {
            Console.Write("\nData de Nascimento: " + this.DataNasc.ToShortDateString());
        }

        public void setCpf()
        {
            Console.Write("Informe o CPF: ");
            this.Cpf = Console.ReadLine();
        }

        public void getCpf()
        {
            Console.Write("\nCPF: " + this.Cpf);
        }

        public void setTelefone()
        {
            Console.Write("Informe o Telefone: ");
            this.Telefone = long.Parse(Console.ReadLine());
        }

        public void getTelefone()
        {
            Console.Write("\nTelefone: " + this.Telefone);
        }

        public string ImprimirCadastro()
        {
            return "\nNome: "+this.Nome+"\nData de Nascimento: "+this.DataNasc.ToLongDateString()+
                    "\nCPF: "+this.Cpf+"\nTelefone: "+this.Telefone;
        }

        public void CadastrarPessoa()
        {
            setNome();
            setDataNasc();
            setCpf();
            setTelefone();
        }
    }
}
