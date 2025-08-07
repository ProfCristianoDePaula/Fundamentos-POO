using POO_Aula_01;

internal class Program
{
    private static void Main(string[] args)
    {
        Animal cachorro = new Animal
        {
            Nome = "Rex",
            Idade = 5,
            Especie = "Cachorro"
        };

        Cachorro cachorro2 = new Cachorro
        {
            Nome = "Totó",
            Idade = 2,
            Especie = "Cachorro",
            Raca = "Labrador",
            TipoAlimentacao = "Ração"
        };

        Console.WriteLine($"Animal: {cachorro.Nome}, Idade: {cachorro.Idade}, Espécie: {cachorro.Especie}");

        //Console.WriteLine($"Cachorro: {cachorro2.Nome}, Idade: {cachorro2.Idade}, Espécie: {cachorro2.Especie}, Raça: {cachorro2.Raca}, Tipo de Alimentação: {cachorro2.TipoAlimentacao}");

        cachorro2.ExibirInformacoes();
        cachorro2.Idade = 3; // Alterando a idade do cachorro
        cachorro2.ExibirInformacoes(); // Exibindo as informações atualizadas

        cachorro2.FazerSom(); // Chamando o método FazerSom do cachorro


        Gato gato = new Gato
        {
            Nome = "Mia",
            Idade = 3,
            Especie = "Gato",
            Raca = "Siamês",
            CorPelo = "Branco"
        };

        Gato gato2 = new Gato("Luna", 4, "Gato", "Persa", "Cinza");


        Console.WriteLine($"Gato: {gato.Nome}, Idade: {gato.Idade}, Espécie: {gato.Especie}, Raça: {gato.Raca}, Cor do Pelo: {gato.CorPelo}");
        gato.FazerSom(); // Chamando o método FazerSom do gato
    }
}