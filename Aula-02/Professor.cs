using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    // Classe Professor que herda da Classe Pessoa
    public class Professor : Pessoa
    {
        public string? Especialidade { get; set; }
        public int Registro { get; set; }
        public double Salario { get; set; }

        // Sobrecarga do método Apresentar da classe Pessoa (Polimorfismo)
        public override void Apresentar()  // Override faz a sobrecarga em classes filhas
        {
            base.Apresentar();  // Chama o método Apresentar da classe base (Pessoa)
            Console.WriteLine($"Sou especialista em {Especialidade}, meu registro é {Registro} e meu salário é {Salario}."); // Adiciona informações específicas do Professor
        }
    }
}
