using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio10
{
    public class Porco10 : Animal10
    {
        public string? Nome { get; set; }
        public Porco10(string especie, string nome)
        {
            this.Especie = especie;
            this.Nome = nome;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"O porco da espécie {Especie} chamado {Nome} está grunhindo.");
        }
    }
}
