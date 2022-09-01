using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha.Entities
{
    public class PilhaDeLivros
    {
        public Livro TOPO { get; set; }

        public PilhaDeLivros()
        {
            TOPO = null;
            // Console.WriteLine("Pilha criada com sucesso");
        }

        public int Push(Livro aux, int contador)
        {
            contador++;
            if (Vazia())
            {
                TOPO = aux;
            }
            else
            {
                aux.Anterior = TOPO;
                TOPO = aux;
            }
            return contador;
        }

        private bool Vazia()
        {
            if (TOPO == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Stack vazio");
            }

            else
            {
                Livro aux = TOPO;
                do
                {
                    Console.WriteLine(aux.ToString());

                    aux = aux.Anterior;

                } while (aux != null);

                Console.WriteLine("FIM DA IMPRESSÃO");

            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Stack vazio");
            }
            else
            {
                TOPO = TOPO.Anterior;
            }


        }

        public void LocalizarLivro(string titulo)
        {
            bool validacao = false;

            if (Vazia())
            {
                Console.WriteLine("Stack vazio");
            }

            else
            {
                Livro aux = TOPO;
                do
                {
                    if (aux.Titulo == titulo)
                    {
                        Console.WriteLine("Livro localizado!");
                        validacao = true;
                    }
                    
                    aux = aux.Anterior;

                } while (aux != null);

                if (!validacao)
                {
                    Console.WriteLine("Livro não localizado!");
                }
                

            }
        }
    }
}
