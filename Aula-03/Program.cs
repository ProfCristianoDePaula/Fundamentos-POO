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

    }
}