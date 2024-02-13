using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__DIO.Classes
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int idade { get; set; }

        public void Apresentar()
        {
            Nome = "Alice";
            Console.WriteLine(Nome);
        }
    }
}