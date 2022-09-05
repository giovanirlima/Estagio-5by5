using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLista20222
{
    internal class ListaAluno
    {
        public Aluno HEAD { get; set; }
        public Aluno TAIL { get; set; }

        public ListaAluno()
        {
            HEAD = TAIL = null;
        }

        private bool Vazia()
        {
            if ((HEAD == null) && (TAIL == null))
                return true;
            else
                return false;
        }

        public void Print()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossível Imprimir, LISTA VAZIA!");
            }
            else
            {
                Aluno aux = HEAD;
                Console.WriteLine("DADOS DA LISTA DE ALUNOS: ");
                do
                {
                    Console.WriteLine(aux.ToString() + "\n");
                    aux = aux.Proximo;
                } while (aux != null);
                Console.WriteLine("FIM DA IMPRESSÃO");
            }
            Console.ReadKey();
        }

        public void Push(Aluno aux)
        {
            //Lembrando que a Inserção DEVE seguir uma ORDENAÇÃO
            //Neste exemplo faremos a Ordem Alfabética por Nome do Aluno

            //INSERÇÃO LISTA VAZIA
            if (Vazia())
            {
                this.HEAD = this.TAIL = aux;
            }
            else
            {
                //INSERÇÂO APÓS A TAIL (Novo Último Elemento)
                if (aux.Nome.CompareTo(TAIL.Nome) >= 0)
                {
                    TAIL.Proximo = aux; //Inserido o novo objeto como último - Encadeamento
                    TAIL = aux; //Ajustando a TAIL para o novo último elemento
                }
                else
                {   //INSERÇÂO ANTES DA HEAD (Novo Primeiro Elemento)
                    if (aux.Nome.CompareTo(HEAD.Nome) < 0)
                    {
                        aux.Proximo = HEAD; //Faço o encadeamento do Novo 1o. Elemento na LISTA
                        HEAD = aux; //Ajustando a HEAD para o novo 1o. Elemento da LISTA
                    }
                    else //INSERÇÃO "NO MEIO DA LISTA"
                    {
                        Aluno aux1, aux2;
                        aux1 = this.HEAD;
                        aux2 = this.HEAD;
                        //bool sair = false;
                        do
                        {
                            if (aux.Nome.CompareTo(aux1.Nome) >= 0)
                            {   // Procurando a posição para Inserir o Novo Objeto
                                aux2 = aux1; //Controlar o "anterior"
                                aux1 = aux1.Proximo; //Controlar o "proximo"
                            }
                            else
                            {
                                //Posso Inserir o Novo Objeto na LISTA
                                aux2.Proximo = aux; //Encadeamento do objeto anterior
                                aux.Proximo = aux1; //Encademento do objeto proximo
                                //sair = true;
                                //return;
                                break;
                            }
                        } while (true);
                    }
                }
            }
        }

        public void Buscar()
        {
            bool validacao = true;

            if (Vazia())
            {
                Console.WriteLine("Impossível Buscas, LISTA VAZIA!");
            }

            else
            {
                Console.Write("Informe o nome para buscar :");
                string nome = Console.ReadLine();

                Aluno aux = HEAD;
                do
                {
                    if (aux.Nome == nome)
                    {
                        Console.WriteLine(aux.ToString());
                        validacao = false;
                    }

                    aux = aux.Proximo;

                } while (aux != null);

                if (validacao)
                {
                    Console.WriteLine("\nNome não localizado!\n");
                }

                Console.WriteLine("FIM DA IMPRESSÃO");
            }

            Console.ReadKey();
        }

        public void Remover()
        {
            if (Vazia())
            {
                Console.WriteLine("Lista Vazia! Impossivel remover.");
            }           

            else
            {
                Console.Write("Informe o nome que deseja remover: ");
                string nome = Console.ReadLine();

                if (HEAD.Nome == nome)
                {
                    HEAD = HEAD.Proximo;
                    Console.WriteLine($"Aluno: {nome} removido!");
                }
                else
                {
                    Aluno aux1, aux2;
                    aux1 = HEAD;
                    aux2 = HEAD;
                    do
                    {
                        if (aux1.Nome != nome)
                        {
                            aux2 = aux1;
                            aux1 = aux1.Proximo;

                            if (aux1 == null)
                            {
                                Console.WriteLine("nome nao encontrado.");
                                break;
                            }
                        }
                        else
                        {
                            if (aux1 == TAIL)
                            {
                                TAIL = aux2;
                                Console.WriteLine($"Aluno: {nome} removido!");
                                break;
                            }
                            else
                            {
                                aux2.Proximo = aux1.Proximo;
                                Console.WriteLine($"Aluno: {nome} removido!");
                                break;
                            }
                        }
                    } while (true);
                }
            }

            Console.ReadKey();
        }
    }
}
