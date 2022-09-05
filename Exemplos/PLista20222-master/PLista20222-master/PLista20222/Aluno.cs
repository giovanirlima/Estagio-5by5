using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLista20222
{
    internal class Aluno
    {
        public int RA { get; set; }
        public string Nome{ get; set; }
        public int Idade { get; set; }
        public string Curso { get; set; }
        public Aluno Proximo { get; set; }

        public Aluno(int RA, string Nome, int Idade, String Curso)
        {
            this.RA = RA;
            this.Nome = Nome;
            this.Idade = Idade; 
            this.Curso = Curso;
            this.Proximo = null;
        }

        public override string ToString()
        {
            return "\nDados do Aluno:\nRA:" + RA + "\nNome:" + Nome + "\nIdade:" + Idade + "\nCurso:" + Curso;
        }
    }
}
