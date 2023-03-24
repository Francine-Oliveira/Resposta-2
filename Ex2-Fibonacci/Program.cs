namespace Ex2_Fibonacci;
class Program
{
    static void Main(string[] args)
    {
        int termo1 = 0, termo2 = 1;
        int termo3 = 0;
        string str = new('=', 28);

        Console.WriteLine(str);
        Console.WriteLine(" * Sequência de Fibonacci *");
        Console.WriteLine(str);
        Console.Write("Digite um número: ");
        int valor = Convert.ToInt32(Console.ReadLine());

        while (valor > termo3)
        {
            termo3 = termo1 + termo2;
            termo1 = termo2;
            termo2 = termo3;
        }
        if (valor == 0 || valor == 1 || valor == termo3)
        {
            Console.WriteLine("O número {0} faz parte da sequência de Fibonacci.", valor);
        }
        else
        {
            Console.WriteLine("O número {0} não faz parte da sequência de Fibonacci.", valor);
        }

        Console.ReadKey();
    }
}

