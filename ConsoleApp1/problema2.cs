using System;
using System.Security.Cryptography;

class Program

{
    static void Main()

    {
        int a;
        int[] v = new int[5];

        Console.WriteLine("Digite o valor de a: "); 
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Valor do vetor: " + 10 * a);

        Console.WriteLine("Valor do contador: " + (a + 1));

        bool resultado = (a < 6);

        Console.WriteLine("O valor de a é menor que 6? : " + resultado);

    }



}
