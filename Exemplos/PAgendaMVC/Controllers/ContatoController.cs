using System;
using Models;
using Services;

namespace Controllers
{
    public class ContatoController
    {

        public Contato InserirContato(Contato contato)
        {
            new ContatoServices().InserirContato(contato);
            return contato;
        }





    }
}
