internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Escreva uma frase: ");
        string frase = Console.ReadLine();
        string[] palavras = frase.Split(' ');
        int ContaPalavras = 0;

        for(int i = 0; i < palavras.Length; i++)
        {
            if (palavras[i] == " ")
                continue;
            else
                ContaPalavras++;
        }

        Console.WriteLine(ContaPalavras);

    }
}