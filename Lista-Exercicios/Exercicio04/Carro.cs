using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio04
{
    public class Carro
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            //this.Velocidade = this.Velocidade + 1;
            this.Velocidade++;
        }

        public void Desacelerar()
        {
            if (this.Velocidade > 0)
            {
                this.Velocidade--;
            }
        }

        public Carro(string marca, string modelo, int velocidade)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Velocidade = velocidade;
        }

    }
}
