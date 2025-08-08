using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio07
{
    public class ContaCorrente : ContaGenerica
    {

        public ContaCorrente(string? banco, int agencia, int conta, double saldo, double limite)
            : base(banco, agencia, conta, saldo)
        {
            this.Limite = limite;
        }
        public double Limite { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Conta Corrente - Banco: {Banco}, Agência: {Agencia}, Conta: {Conta}, Saldo: {Saldo:C}");
        }

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
            if (valor > 0 && valor <= (this.Saldo + this.Limite))
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
            Console.WriteLine($"Saldo atual da conta {this.Conta} no banco {this.Banco}: {this.Saldo:C}, com limite especial de {Limite}.");
        }
    }
}
