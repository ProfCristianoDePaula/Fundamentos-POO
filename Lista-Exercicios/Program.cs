using Lista_Exercicios.Exercicio02;
using Lista_Exercicios.Exercicio03;
using Lista_Exercicios.Exercicio01;
using Lista_Exercicios.Exercicio04;
using Lista_Exercicios.Exercicio05;
using Lista_Exercicios.Exercicio06;
using Lista_Exercicios.Exercicio07;
using Lista_Exercicios.Exercicio08;
using Lista_Exercicios.Exercicio09;
using Lista_Exercicios.Exercicio11;
using Lista_Exercicios.Exercicio10;

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

        Console.WriteLine("\nExercício 04");

        Carro carro1 = new Carro("Jeep", "Renegade", 70);
        Console.WriteLine($"1. Velocidade Atual: {carro1.Velocidade}");
        carro1.Acelerar();
        Console.WriteLine($"1. Velocidade Atual: {carro1.Velocidade}");
        carro1.Desacelerar();
        carro1.Desacelerar();
        carro1.Desacelerar();
        Console.WriteLine($"1. Velocidade Atual: {carro1.Velocidade}");

        Carro carro2 = new Carro("Fiat", "Uno", 50);
        Console.WriteLine($"\n2. Velocidade Atual: {carro2.Velocidade}");
        carro2.Acelerar();
        carro2.Acelerar();
        carro2.Acelerar();
        Console.WriteLine($"2. Velocidade Atual: {carro2.Velocidade}");
        carro2.Desacelerar();
        Console.WriteLine($"2. Velocidade Atual: {carro2.Velocidade}");

        Carro carro3 = new Carro("Volkswagen", "Gol", 60);
        Console.WriteLine($"\n3. Velocidade Atual: {carro3.Velocidade}");
        carro3.Acelerar();
        carro3.Acelerar();
        Console.WriteLine($"3. Velocidade Atual: {carro3.Velocidade}");
        carro3.Desacelerar();
        carro3.Desacelerar();
        Console.WriteLine($"3. Velocidade Atual: {carro3.Velocidade}");


        Console.WriteLine("\n===========================================================================");

        Console.WriteLine("\nExercício 05");

        Funcionario funcionario1 = new Funcionario("Ana", 30, "Professora");
        funcionario1.Envelhecer(5); // Envelhece 5 anos

        Funcionario funcionario2 = new Funcionario("Bruno", 25, "Engenheiro");
        funcionario2.Envelhecer(3); // Envelhece 3 anos

        Funcionario funcionario3 = new Funcionario("Carla", 28, "Médica");
        funcionario3.Envelhecer(2); // Envelhece 2 anos


        Console.WriteLine("\n===========================================================================");

        Console.WriteLine("\nExercício 06");

        Gato gato = new Gato("Gato", "Mingau");
        gato.EmitirSom();

        Galinha galinha = new Galinha("Galinha", "Clara");
        galinha.EmitirSom();

        Porco porco = new Porco("Porco", "Porky");
        porco.EmitirSom();


        Console.WriteLine("\n===========================================================================");

        Console.WriteLine("\nExercício 07");

        ContaCorrente conta1 = new ContaCorrente("Banco do Brasil", 1234, 56789, 1000.00, 1000);
        conta1.ExibirSaldo();
        conta1.Depositar(500.00);
        conta1.Sacar(200.00);
        conta1.ExibirSaldo();

        ContaCorrente conta2 = new ContaCorrente("Caixa Econômica", 4321, 98765, 2000.00, 2000);
        conta2.ExibirSaldo();
        conta2.Depositar(1000.00);
        conta2.Sacar(300.00);
        conta2.ExibirSaldo();

        ContaCorrente conta3 = new ContaCorrente("Santander", 5678, 12345, 1500.00, 750);
        conta3.ExibirSaldo();
        conta3.Depositar(700.00);
        conta3.Sacar(400.00);
        conta3.ExibirSaldo();


        Console.WriteLine("\n===========================================================================");
        Console.WriteLine("\nExercício 08");

        ContaGenerica2 contaGenerica1 = new ContaGenerica2("Banco do Brasil", 1234, 56789, 1000.00);
        contaGenerica1.ExibirSaldo();
        contaGenerica1.Depositar(500.00);
        contaGenerica1.Sacar(200.00);

        Console.WriteLine("\n===========================================================================");
        Console.WriteLine("\nExercício 09");

        Personagem personagem1 = new Personagem("Merlin", "Mago", 10, 25, 85, 100, 100);
        Personagem personagem2 = new Personagem("Arthur", "Guerreiro", 12, 90, 75, 70, 80);
        Personagem personagem3 = new Personagem("Lancelot", "Cavaleiro", 11, 100, 68, 35, 90);

        personagem1.ExibirStatus();
        personagem2.ExibirStatus();
        personagem3.ExibirStatus();

        Console.WriteLine("\n===========================================================================");
        Console.WriteLine("\nExercício 10");

        Animal10 galinha10 = new Galinha10("Galinha", "Clara");
        Animal10 porco10 = new Porco10("Porco", "Porky");
        Animal10 gato10 = new Gato10("Cachorro", "Rex");
        galinha10.EmitirSom();
        porco10.EmitirSom();
        gato10.EmitirSom();


        Console.WriteLine("\n===========================================================================");
        Console.WriteLine("\nExercício 11");

        Forma forma1 = new Retangulo(5, 3);
        Forma forma2 = new Circulo(4);

        var areaRetangulo = forma1.CalcularArea();

        // Aplicando polimorfismo
        Console.WriteLine($"Área do Retângulo: {areaRetangulo}");
        Console.WriteLine($"Área do Círculo: {forma2.CalcularArea():F2}");
    }
}