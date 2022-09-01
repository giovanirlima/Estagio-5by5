using System;
using PPilha.Entities;

namespace PPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            int contadorDeLivros = 0;
            PilhaDeLivros myStack = new PilhaDeLivros();



            do
            {
                Console.Clear();

                Console.WriteLine("Olá usuário!\n");

                Console.WriteLine("MENU DE OPÇÕES\n");
                Console.WriteLine("1 - Inserir livro na pilha de livros");
                Console.WriteLine("2 - Remover livro da ilha de livros");
                Console.WriteLine("3 - Imprimir ilha de livros");
                Console.WriteLine("4 - Imprimir quantidade de livros na pilha");
                Console.WriteLine("5 - Localizar um livro na pilha de livros");
                Console.WriteLine("\n0 - Sair");
                Console.Write("\nOpção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {                    
                    case 1:
                        Console.Clear();
                        Console.Write("Informe o titulo do livro: ");
                        string titulo = Console.ReadLine();
                        Console.Write("Informe o autor do livro: ");
                        string autor = Console.ReadLine();
                        Console.Write("Informe o ISBN do livro: ");
                        int ISBM = int.Parse(Console.ReadLine());
                        contadorDeLivros = myStack.Push(new Livro(titulo, ISBM, autor), contadorDeLivros);
                        Console.WriteLine("Inserido com sucesso!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        myStack.Pop();
                        Console.WriteLine("Livro retirado com sucesso");
                        Console.ReadKey();

                        break;

                    case 3:
                        Console.Clear();
                        myStack.Print();
                        Console.ReadKey();
                        
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine($"A pilha de livros possue: {contadorDeLivros} empilhados");
                        Console.ReadKey();
                        
                        break;

                    case 5:
                        Console.Clear();

                        Console.Write("Informe o titulo do livro: ");
                        titulo = Console.ReadLine();

                        myStack.LocalizarLivro(titulo);

                        Console.ReadKey();

                        break;

                    case 0:
                        Console.WriteLine("Até!");

                        break;
                }
                
            } while (opc != 0);














            /*myStack.Print();

            Livro book = new Livro("Mar Profundo", 1234, "Juvenal Antena");
            myStack.Push(book);

            myStack.Push(new Livro("Poeira em alto mar", 1322, "George Juvenal"));

            myStack.Print();
            
            myStack.Pop();
            myStack.Print();

            myStack.Pop();
            myStack.Print();

            myStack.Pop();
            myStack.Print();*/

        }
    }
}
