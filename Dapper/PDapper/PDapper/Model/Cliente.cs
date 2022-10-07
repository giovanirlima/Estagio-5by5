using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDapper.Model
{
    public class Cliente
    {
        #region Constant
        public readonly static string INSERT = "INSERT INTO TB_CLIENTE(Nome, Telefone) VALUES (@Nome, @Telefone)";
        public readonly static string SELECT = "SELECT Id, Nome, Telefone FROM TB_CLIENTE";
        #endregion

        #region Propriedade
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        #endregion

        #region Metodo
        public override string ToString()
        {
            return $"Id: {Id}\nNome: {Nome}\nTelefone: {Telefone}\n";
        }
        #endregion
    }
}
