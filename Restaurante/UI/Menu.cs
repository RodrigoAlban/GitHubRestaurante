using System;

namespace Restaurante.OO.UI;

public class Menu
{
    public static string Show(){

        Console.WriteLine("\n");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Bem-Vindo ao Restaurante XXX");
        Console.WriteLine("----------------------------");
        Console.WriteLine("Informe o seu papel:");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Cliente");
        Console.WriteLine("2 - Gerente");
        Console.WriteLine("--------------------\n");
        Console.Write("Opção: ");

        return Console.ReadLine();
    }
}
