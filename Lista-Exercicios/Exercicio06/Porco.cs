using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio06
{
    public class Porco : Animal
    {
        public string? Nome { get; set; }
        public Porco(string especie, string nome)
        {
            this.Especie = especie;
            this.Nome = nome;
        }
    }
}
