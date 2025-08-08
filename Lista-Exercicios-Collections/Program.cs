internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("********************************************* Atividade 01 - Lista de Tarefas *********************************************\n");

        List<string> tarefas = new List<string>();

        tarefas.Add("Lavar a louça");
        tarefas.Add("Lavar o banheiro");
        tarefas.Add("Tirar o lixo");
        tarefas.Add("Fazer o almoço");
        tarefas.Add("Dormir");

        tarefas.Insert(2, "Passar pano na casa");

        tarefas[4] = "Fazer a janta";

        bool achou = tarefas.Contains("Lavar o banheiro");

        if (achou)
            Console.WriteLine("\nA tarefa existe");
        else
            Console.WriteLine("\nA tarefa não existe");

        tarefas.Remove("Lavar o banheiro");

        foreach (string item in tarefas)
        {
            Console.WriteLine(item);
        }


        Console.WriteLine("********************************************* Atividade 02 - Agenda Telefonica *********************************************");


        Dictionary<string, string> agenda = new Dictionary<string, string>();

        agenda.Add("Maria", "123456789");
        agenda.Add("João", "987654321");
        agenda.Add("Ana", "456789123");
        agenda.Add("Pedro", "789123456");
        agenda.Add("Lucas", "321654987");


        agenda["Ana"] = "111222333";

        bool encontrou = agenda.ContainsKey("Pedro");
        if (encontrou)
            Console.WriteLine("\nO contato existe");
        else
            Console.WriteLine("\nO contato não existe");

        agenda.Remove("João");

        foreach (var contato in agenda)
        {
            Console.WriteLine($"Nome: {contato.Key} - Telefone: {contato.Value}");
        }


        Console.WriteLine("******************************************** Atividade 03 - Fila de Atendimento ********************************************");

        Queue<string> fila = new Queue<string>();

        fila.Enqueue("André");
        fila.Enqueue("Bruna");
        fila.Enqueue("Carlos");
        fila.Enqueue("Diana");
        fila.Enqueue("Eduardo");

        Console.WriteLine($"\nPróximo da fila: {fila.Peek()}");

        string atendido = fila.Dequeue();
        Console.WriteLine($"\nAtendido: {atendido}");

        bool existe = fila.Contains("Carlos");
        if (existe)
            Console.WriteLine("\nA pessoa está na fila");
        else
            Console.WriteLine("\nA pessoa não está na fila");

        Console.WriteLine("\nFila atual:");
        foreach (string pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }


        Console.WriteLine("*************************************** Atividade 04 - Histórico de Páginas Visitadas ***************************************");

        Stack<string> historico = new Stack<string>();

        historico.Push("www.google.com");
        historico.Push("www.github.com");
        historico.Push("www.stackoverflow.com");
        historico.Push("www.microsoft.com");
        historico.Push("www.reddit.com");

        Console.WriteLine($"\nPágina atual: {historico.Peek()}");

        string paginaAnterior = historico.Pop();
        Console.WriteLine($"\nVoltando para a página: {paginaAnterior}");

        bool visitou = historico.Contains("www.github.com");
        if (visitou)
            Console.WriteLine("\nA página foi visitada");
        else
            Console.WriteLine("\nA página não foi visitada");

        Console.WriteLine("\nHistórico atual:");
        foreach (string pagina in historico)
        {
            Console.WriteLine(pagina);
        }

    }
}