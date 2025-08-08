using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio10
{
    public class Galinha10 : Animal10
    {
        public string? Nome { get; set; }
        public Galinha10(string especie, string nome)
        {
            this.Especie = especie;
            this.Nome = nome;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"A galinha da espécie {Especie} chamada {Nome} está cacarejando.");
        }
    }
}
