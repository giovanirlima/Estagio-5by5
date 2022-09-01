using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilha.Entities
{
    public class Book
    {
        public string Titulo { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }
        public Book Anterior { get; set; }

        public Book()
        {
        }

        public Book(string titulo, int iSBN, string autor)
        {
            Titulo = titulo;
            ISBN = iSBN;
            Autor = autor;
            Anterior = null;
        }

        public override string ToString()
        {
            return $"\nDADOS DO LIVRO\n\nTitulo: {Titulo}\nAutor: {Autor}\nISBN: {ISBN}\n";
        }
    }
}
