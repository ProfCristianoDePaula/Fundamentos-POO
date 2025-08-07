using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio05
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
        public void Envelhecer(int anos)  // Método para envelhecer com parametro de anos
        {
            if (anos > 0) // Verifica se o número de anos é positivo
            {
                this.Idade += anos; // Incrementa a idade da pessoa
            }
            Console.WriteLine($"{this.Nome} agora tem {this.Idade} anos."); // Exibe a nova idade da pessoa
        }
    }
}
