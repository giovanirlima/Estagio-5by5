using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca
{
    internal class Moto : Veiculo
    {
        int Cilindradas;
        bool Partida_Eletrica;

        public Moto(string marca, string modelo, int rodas, int capacidade, float preco, string cor, int cilindradas, bool partida_eletrica) 
            : base( marca,  modelo,  rodas,  capacidade,  preco,  cor)
        {
            Cilindradas = cilindradas;
            Partida_Eletrica = partida_eletrica;
        }

        public override string ToString()
        {
            string mensagem;
            if (Partida_Eletrica)
                mensagem = "Sim";
            else 
                mensagem = "Não";
            //return "Marca: "+getMarca()+"\nModelo: "+Modelo+"\nCilindradas: " + Cilindradas + "\nPartida Eletrica: "+mensagem;
            return base.ToString() + "\nCilindradas: " + Cilindradas + "\nPartida Eletrica: " + mensagem; 
            
        }
    }
}
