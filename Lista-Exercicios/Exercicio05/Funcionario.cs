using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio05
{
    public class Funcionario : Pessoa
    {
        public Funcionario(string nome, int idade, string? cargo) : base(nome, idade)
        {
            this.Cargo = cargo;
        }

        public string? Cargo { get; set; }
    }
}
