using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PBancoM.Entities
{
    public class Pagamento 
    {
        public DateTime DataTransacoes { get; set; }
        public string TipoOperacao { get; set; }
        public double Valor { get; set; }

        public Pagamento(DateTime dataTransacoes, string tipoOperacao, double valor)
        {
            DataTransacoes = dataTransacoes;
            TipoOperacao = tipoOperacao;
            Valor = valor;
        }
    }
}
