using System;

class Program
{
    static void Main()
    {
        //Informa se o ano é bissexto ou não.
        Console.WriteLine("Digite o ano que você deseja verificar:");
        int ano = int.Parse(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
        {
            Console.WriteLine($"{ano} é um ano bissexto.");
        }
        else
        {
            Console.WriteLine($"{ano} não é um ano bissexto.");
        }
    }
}
