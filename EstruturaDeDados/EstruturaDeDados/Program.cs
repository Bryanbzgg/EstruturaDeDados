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
    }
}
