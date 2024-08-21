using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //TRABALHANDO OCM LISTA (LIST)
        //criando uma lista
        List<string> frutas = new List<string>();

        //Adicionar itens na lista
        frutas.Add("Morango");
        frutas.Add("Manga");
        frutas.Add("Goiaba");
        frutas.Add("Uva");

        //Imprimir os itens da lista
        Console.WriteLine("Minha lista de frutas:");
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine("===========================================================");

        //Imprimir elemento na posição especifica
        Console.WriteLine("Fruta no indice 2: " + frutas[2]);

        Console.WriteLine("===================================e");


        //Inserir um elemento no indice especifico
        frutas.Insert(1, "Maracuja");
        Console.WriteLine("Minha lista de frutas:");
        frutas.ForEach(Console.WriteLine);

        Console.WriteLine("==============================e");

        //Alterar um elemento no indice espefico
        frutas[4] = "Pêra";

        Console.WriteLine("");
        Console.WriteLine("Minha lista de frutas:");
        frutas.ForEach(Console.WriteLine);


        //remover elementos da lista
        frutas.RemoveAt(3);

        frutas.Remove("Morango");

        Console.WriteLine("");
        Console.WriteLine("Minha lista de frutas:");
        frutas.ForEach(Console.WriteLine);


        //Apagar todos os elementos da lista
        frutas.Clear();


        //Dicionary

        Dictionary<int, string> carros = new Dictionary<int, string>();

        //add dados no dicionario

        carros.Add(5, "Corsa");
        carros.Add(10, "Fusca");
        carros.Add(2, "Ford Ka");

        //imprimindo um dicionario de dados
        foreach (var carro in carros)
        {
            Console.WriteLine($"{carro.Key} - {carro.Value}");
        }

        Console.WriteLine("");
        Console.WriteLine("====================================");
        Console.WriteLine("");


        //trabalhando com fila
        //Criar uma fila (Queue)
        Queue<string> filaBanco = new Queue<string>();

        filaBanco.Enqueue("André");
        filaBanco.Enqueue("Cleito");
        filaBanco.Enqueue("Jorjin");
        filaBanco.Enqueue("Neneca");

        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        //retirar um elemento da fila
        filaBanco.Dequeue();

        Console.WriteLine("");
        Console.WriteLine("====================================");
        Console.WriteLine("");
        foreach (var pessoa in filaBanco)
        {
            Console.WriteLine(pessoa);
        }

        //verificar se existe um elemento na fila

        bool achou = filaBanco.Contains("Neneca");
        if (achou == true)
        {
            Console.WriteLine("A pessoa está na fila");
        }
        else
        {
            Console.WriteLine("A pessoa não esta na fila");
        }


        Console.WriteLine("");
        Console.WriteLine("====================================");
        Console.WriteLine("");

        //trabalhando com pilha (stack)
        //criando uma pilha
        Stack<string> livros = new Stack<string>();

        //add elementos em uma pilha

        livros.Push("supernatural");
        livros.Push("chapeu azul");
        livros.Push("guerra na terra");

        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

        Console.WriteLine("");
        Console.WriteLine("====================================");
        Console.WriteLine("");

        livros.Pop();
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }

    }
}
