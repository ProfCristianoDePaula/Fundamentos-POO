using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio_03
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public void ValorEstoque()
        {
            Console.WriteLine($"Valor total em estoque: {Preco * Estoque}");
        }
    }
}
