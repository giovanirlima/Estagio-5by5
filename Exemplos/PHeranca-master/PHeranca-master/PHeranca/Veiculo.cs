using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca
{
    internal class Veiculo
    {
        String Marca;
        protected String Modelo;
        int Rodas;
        int Capacidade;
        float Preco;
        String Cor;

        public Veiculo(string marca, string modelo, int rodas, int capacidade, float preco, string cor)
        {
            Marca = marca;
            Modelo = modelo;
            Rodas = rodas;
            Capacidade = capacidade;
            Preco = preco;
            Cor = cor;
        }

        public String getMarca()
        {
            return Marca;
        }
        public override string ToString()
        {
            return "Marca: " + Marca + "\nModelo: " + Modelo + "\nRodas: " + Rodas + 
                "\nCapacidade: " + Capacidade + "\nCor: " + Cor + "\nPreço: " + Preco;
        }
    }
}
