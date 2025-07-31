using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula_01
{
    public class Animal
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }
        public string? Especie { get; set; }

        public virtual void FazerSom()
        {
            Console.WriteLine($"{Nome} está fazendo som.");
        }
    }
}
