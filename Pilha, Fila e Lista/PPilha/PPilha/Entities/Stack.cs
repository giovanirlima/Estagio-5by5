using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha.Entities
{
    public class Stack
    {
        public Book TOPO { get; set; }

        public Stack()
        {
            TOPO = null;
            Console.WriteLine("Pilha criada com sucesso");
        }

        public void Push(Book aux)
        {
            if (Vazia())
            {
                TOPO = aux;
            }
            else
            {
                aux.Anterior = TOPO;
                TOPO = aux;
            }
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
                Book aux = TOPO;
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


    }
}
