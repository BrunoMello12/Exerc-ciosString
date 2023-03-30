internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();
        string[] palavras = frase.Split(" ");
        Console.WriteLine(frase.ToUpper());
        Console.WriteLine(frase.ToLower());
        Console.WriteLine(frase.Count());
        Console.WriteLine(palavras[0].ToString());
        Console.WriteLine(palavras[palavras.Length-1]);
    }
}