using System;
using PPilha.Entities;

namespace PPilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Print();

            Book book = new Book("Mar Profundo", 1234, "Juvenal Antena");
            myStack.Push(book);

            myStack.Push(new Book("Poeira em alto mar", 1322, "George Juvenal"));

            myStack.Print();
            
            myStack.Pop();
            myStack.Print();

            myStack.Pop();
            myStack.Print();

            myStack.Pop();
            myStack.Print();

        }
    }
}
