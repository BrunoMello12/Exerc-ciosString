internal class Program
{
    private static void Main(string[] args)
    {
        string alfabeto = "ABCDEFGHIJKQLMNOPQRSTUVWXYZ";
        char[] alfabetoLetras = alfabeto.ToCharArray();
        Console.WriteLine("Informe quantas posições quer pular: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe a palavra: ");
        string palavraAux = Console.ReadLine();
        int j = 0;
        char[] palavra = palavraAux.ToUpper().ToCharArray();

        while (true)
        {
            for (int i = 0; i < alfabetoLetras.Length - x && j < palavra.Length; i++)
            {

                if (palavra[j] == alfabetoLetras[i])
                {
                    palavra[j] = alfabetoLetras[i + x];
                    Console.WriteLine(palavra[j]);
                    j++;
                }
            }
        }





    }
}