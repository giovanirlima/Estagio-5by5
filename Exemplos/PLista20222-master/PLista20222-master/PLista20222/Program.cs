using System;
using System.Collections.Generic;

namespace PLista20222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaAluno minhalista = new ListaAluno();
            minhalista.Push(new Aluno(123, "Baratão", 34, "Turismo"));
            minhalista.Push(new Aluno(124, "Baratão", 44, "Engenharia Civil"));
            minhalista.Push(new Aluno(444, "Celso Xaropinho", 33, "Telemarketing"));
            minhalista.Push(new Aluno(345, "Moranguinho", 27, "Agronomia"));
            minhalista.Push(new Aluno(777, "Artur", 84, "Administração"));
            minhalista.Push(new Aluno(555, "Mussarela", 22, "Veterinária"));
            minhalista.Push(new Aluno(145, "Alexandre", 55, "Elétrica"));
            minhalista.Push(new Aluno(444, "Celso Xaropinho", 66, "Pós - Telemarketing"));
            minhalista.Remover();           
            minhalista.Buscar();
            Console.Clear();
            minhalista.Print();
                        
        }
    }
}
