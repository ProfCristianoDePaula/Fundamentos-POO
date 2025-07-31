using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula_01
{
    public class Gato : Animal
    {
        public string? Raca { get; set; }
        public string? CorPelo { get; set; }

        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} está miando.");
        }
    }
}
