using Aula_03;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("******************************* Trabalhando com Listas *******************************");

        // Criando uma lista de strings
        List<string> lista = new List<string>();
        lista.Add("Maça"); // Adiona o item no final da lista
        lista.Add("Banana"); // Adiona o item no final da lista
        lista.Add("Goiaba"); // Adiona o item no final da lista
        lista.Add("Laranja"); // Adiona o item no final da lista

        Console.WriteLine("\nImprimindo os valores do 'List' na tela");
        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); // Imprimir item por item da lista
        }

        Console.WriteLine("\nImprimir um item na posição específica");
        Console.WriteLine($"Item na Posição 2: {lista[2]}");

        // Adicionar um item em uma posição específica
        Console.WriteLine("\nAdicionar um item na posição específica");
        lista.Insert(1, "Tangerina");

        Console.WriteLine("\nImprimindo os valores do 'List' na tela");
        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); // Imprimir item por item da lista
        }

        // Alterando um item da lista
        Console.WriteLine("\nAlterar um item da lista específico");
        lista[4] = "Melancia";

        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); // Imprimir item por item da lista
        }

        // Remover itens da Lista
        Console.WriteLine("\nRemover um item da lista por posição");
        lista.RemoveAt(3);
        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); // Imprimir item por item da lista
        }

        Console.WriteLine("\nRemover um item da lista buscando pelo conteudo");
        lista.Remove("Banana");
        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); // Imprimir item por item da lista
        }

        Console.WriteLine("\nRemover todos os itens da lista");
        lista.Clear();
        foreach (string item in lista) // Percorre toda a lista
        {
            Console.WriteLine(item); // Imprimir item por item da lista
        }



        Console.WriteLine("******************************* Trabalhando com Listas de Objetos *******************************");

        // Criando uma lista de Alunos
        List<Aluno> listaAlunos = new List<Aluno>();

        // Adiona o item no final da lista
        listaAlunos.Add(new Aluno(101, "Ana"));
        listaAlunos.Add(new Aluno(102, "Bia"));
        listaAlunos.Add(new Aluno(103, "Carlos"));

        Console.WriteLine("\nImprimindo os valores do 'List' de Alunos na tela");
        foreach (Aluno aluno in listaAlunos) // Percorre toda a lista
        {
            // Imprimir item por item da lista
            Console.WriteLine($"Código: {aluno.Codigo}, Nome: {aluno.Nome}");
        }

        //Remover um aluno específico por nome
        listaAlunos.RemoveAll(a => a.Nome == "Bia");
        Console.WriteLine("\nImprimindo os valores do 'List' de Alunos na tela");
        foreach (Aluno aluno in listaAlunos) // Percorre toda a lista
        {
            // Imprimir item por item da lista
            Console.WriteLine($"Código: {aluno.Codigo}, Nome: {aluno.Nome}");
        }


        Console.WriteLine("\n******************************* Trabalhando com Dicionário de Dados *******************************");

        // Criando um dicionário de dados
        Dictionary<int, string> dicionario = new Dictionary<int, string>();

        // Adicionando itens ao dicionário
        dicionario.Add(10, "Ka");
        dicionario.Add(20, "Fusca");
        dicionario.Add(30, "Civic");
        dicionario.Add(40, "Corolla");

        Console.WriteLine("\nImprimindo os valores do 'Dictionary' na tela com KeyValuePair()");
        foreach (KeyValuePair<int, string> item in dicionario)
        {
            // Imprimir chave e valor do dicionário
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }

        Console.WriteLine("\nImprimindo os valores do 'Dictionary' na tela com var");
        foreach (var item in dicionario)
        {
            // Imprimir chave e valor do dicionário
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }

        // Alterar valor de um item no dicionário
        Console.WriteLine("\nAlterando os valores do 'Dictionary'");
        dicionario[10] = "Corsa";
        foreach (var item in dicionario)
        {
            // Imprimir chave e valor do dicionário
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }

        // Pesquisando um item no dicionário por valor
        Console.WriteLine("\nPesquisando um item no dicionário por chave");
        string carro;

        bool carroExiste = dicionario.TryGetValue(30, out carro);

        if (carroExiste)
        {
            Console.WriteLine($"O valor encontrado para a chave 30 é: {carro}");
        }
        else
        {
            Console.WriteLine("A chave 30 não foi encontrada");
        }

        // Excluindo um item por Chave
        dicionario.Remove(30);
        foreach (var item in dicionario)
        {
            // Imprimir chave e valor do dicionário
            Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
        }

    }
}