using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Pessoa
    {
        //public Pessoa() { }

        public Pessoa(string nome) 
        { 
            Nome = nome;
        }

        public string Nome { get;  set; }

        public string Sobrenome { get; set; } = "Borges";

    }
}
