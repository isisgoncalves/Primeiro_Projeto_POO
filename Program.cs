class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();

        int idade = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome, idade);

        Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}"); 

    }
}
