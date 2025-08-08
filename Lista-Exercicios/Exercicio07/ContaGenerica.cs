using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio07
{
    public class ContaGenerica(string? banco, int agencia, int conta, double saldo)
    {
        public string? Banco { get; set; } = banco;
        public int Agencia { get; set; } = agencia;
        public int Conta { get; set; } = conta;
        public double Saldo { get; set; } = saldo;

    }
}
