using Aula_02;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Criando um Objeto");

        // Instanciando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa();  // Objeto vazio
        pessoa1.Nome = "João";
        pessoa1.CPF = 123456789;
        pessoa1.DataNascimento = new DateOnly(1990, 1, 1);

        // Apresentando o objeto pessoa1
        pessoa1.Apresentar();

        // Instanciando um objeto da classe Pessoa usando o construtor com parâmetros
        Pessoa pessoa2 = new Pessoa("Maria", 987654321, new DateOnly(1995, 5, 15));
        pessoa2.Apresentar();

        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine("Criando um Objeto Aluno Herdado de Pessoa");
        Aluno aluno1 = new Aluno();
        aluno1.Nome = "Carlos";
        aluno1.CPF = 123456789;
        aluno1.DataNascimento = new DateOnly(2000, 1, 1);
        aluno1.Curso = "Engenharia";
        aluno1.Matricula = 2021001;

        // Apresentando o objeto aluno1
        aluno1.Apresentar();

    }

}