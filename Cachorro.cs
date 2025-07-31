using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Aula_01
{
    public class Cachorro : Animal
    {
        // Atributos específicos da classe Cachorro
        public string? Raca { get; set; }
        public string? TipoAlimentacao { get; set; }

        // Metodo para exibir informações do cachorro
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Cachorro: {Nome}, Idade: {Idade}, Espécie: {Especie}, Raça: {Raca}, Tipo de Alimentação: {TipoAlimentacao}");
        }

        public override void FazerSom()
        {
            Console.WriteLine($"{Nome} está latindo.");
        }
    }
}
