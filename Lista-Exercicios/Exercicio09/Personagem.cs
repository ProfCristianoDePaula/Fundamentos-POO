using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Exercicios.Exercicio09
{
    public class Personagem
    {
        private string? Nome { get; set; }
        private string? Categoria { get; set; }
        private int Nivel { get; set; }
        private int Forca { get; set; }
        private int Agilidade { get; set; }
        private int Inteligencia { get; set; }
        private int Vida { get; set; }

        public Personagem(string nome, string categoria, int nivel, int forca, int agilidade, int inteligencia, int vida)
        {
            this.Nome = nome;
            this.Categoria = categoria;
            this.Nivel = nivel;
            this.Forca = forca;
            this.Agilidade = agilidade;
            this.Inteligencia = inteligencia;
            this.Vida = vida;
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"Nome: {this.Nome}, Categoria: {this.Categoria}, Nivel: {this.Nivel}, Força: {this.Forca}, Inteligencia: {this.Inteligencia}, Vida: {this.Vida}");
        }
    }
}
