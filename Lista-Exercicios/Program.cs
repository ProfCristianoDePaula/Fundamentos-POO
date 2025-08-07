using Lista_Exercicios.Exercicio_02;
using Lista_Exercicios.Exercicio_03;
using Lista_Exercicios.Exercicio01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*************************** Lista de Exercícios ***************************");
        Console.WriteLine("\nExercício 01");

        Livro livro1 = new Livro();
        livro1.Titulo = "O Senhor dos Anéis";
        livro1.Autor = "J.R.R. Tolkien";
        livro1.Editora = "HarperCollins";
        livro1.AnoLancamento = 1954;

        Livro livro2 = new Livro();
        livro2.Titulo = "1984";
        livro2.Autor = "George Orwell";
        livro2.Editora = "Secker & Warburg";
        livro2.AnoLancamento = 1949;

        Livro livro3 = new Livro();
        livro3.Titulo = "Dom Quixote";
        livro3.Autor = "Miguel de Cervantes";
        livro3.Editora = "Francisco de Robles";
        livro3.AnoLancamento = 1605;

        Console.WriteLine("Lista de Livros:");
        Console.WriteLine($"1. {livro1.Titulo} - {livro1.Autor} ({livro1.AnoLancamento}) - Editora: {livro1.Editora}");
        Console.WriteLine($"2. {livro2.Titulo} - {livro2.Autor} ({livro2.AnoLancamento}) - Editora: {livro2.Editora}");
        Console.WriteLine($"3. {livro3.Titulo} - {livro3.Autor} ({livro3.AnoLancamento}) - Editora: {livro3.Editora}");

        Console.WriteLine("\n===========================================================================");
        Console.WriteLine("\nExercício 02");

        Aluno aluno1 = new Aluno();
        aluno1.RM = 123456;
        aluno1.Nome = "João Silva";
        aluno1.Nascimento = new DateOnly(2000, 5, 15);
        aluno1.Email = "joao@aluno.com";

        Aluno aluno2 = new Aluno();
        aluno2.RM = 654321;
        aluno2.Nome = "Maria Oliveira";
        aluno2.Nascimento = new DateOnly(1999, 8, 22);
        aluno2.Email = "maria@aluno.com";

        Aluno aluno3 = new Aluno();
        aluno3.RM = 789012;
        aluno3.Nome = "Carlos Pereira";
        aluno3.Nascimento = new DateOnly(2001, 3, 10);
        aluno3.Email = "carlos@aluno.com";

        Console.WriteLine("Lista de Alunos:");
        Console.WriteLine($"1. RM: {aluno1.RM}, Nome: {aluno1.Nome}, Nascimento: {aluno1.Nascimento}, Email: {aluno1.Email}");
        Console.WriteLine($"2. RM: {aluno2.RM}, Nome: {aluno2.Nome}, Nascimento: {aluno2.Nascimento}, Email: {aluno2.Email}");
        Console.WriteLine($"3. RM: {aluno3.RM}, Nome: {aluno3.Nome}, Nascimento: {aluno3.Nascimento}, Email: {aluno3.Email}");
        Console.WriteLine("\n===========================================================================");

        Console.WriteLine("\nExercício 03");

        Produto produto1 = new Produto();
        produto1.Codigo = 101;
        produto1.Nome = "Notebook";
        produto1.Preco = 2500.00;
        produto1.Estoque = 10;
        produto1.ValorEstoque();

        Produto produto2 = new Produto();
        produto2.Codigo = 102;
        produto2.Nome = "Smartphone";
        produto2.Preco = 1500.00;
        produto2.Estoque = 20;
        produto2.ValorEstoque();

        Produto produto3 = new Produto();
        produto3.Codigo = 103;
        produto3.Nome = "Tablet";
        produto3.Preco = 800.00;
        produto3.Estoque = 15;
        produto3.ValorEstoque();

        Console.WriteLine("\n===========================================================================");

    }
}