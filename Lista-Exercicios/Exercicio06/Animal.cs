using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio06
{
    public class Animal
    {
        public string? Especie { get; set; }
        public void EmitirSom()
        {
            Console.WriteLine($"O animal da espécie {Especie} está emitindo um som.");
        }
    }
}
