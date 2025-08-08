using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio08
{
    public class ContaGenerica2(string? banco, int agencia, int conta, double saldo)
    {
        private string? Banco { get; set; } = banco;
        private int Agencia { get; set; } = agencia;
        private int Conta { get; set; } = conta;
        private double Saldo { get; set; } = saldo;
        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
                Console.WriteLine($"Depósito de {valor:C} realizado com sucesso. Saldo atual: {this.Saldo:C}");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }
        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= this.Saldo)
            {
                this.Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso. Saldo atual: {this.Saldo:C}");
            }
            else
            {
                Console.WriteLine("Valor de saque inválido ou saldo insuficiente.");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual da conta {this.Conta} no banco {this.Banco}: {this.Saldo:C}");
        }
    }
}
