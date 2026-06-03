using System;
using System.Security.Cryptography;

class Program

{
    static void Main()

    {
        int a;
        int b;
        int indice = 1;
      

        Console.WriteLine("Digite o valor de a: ");
        a = int.Parse(Console.ReadLine());

        b = a - 6;
        int contador = b + 2;

        Console.WriteLine("a\tb\tindice\tvetor\tcontador\tb<a");

        while (true)
        {
            int vetor = contador + a;
            string condicao = contador < a ? "V" : "F";

            Console.WriteLine($"{a}\t{b}\t{indice}\t{vetor}\t{contador}\t\t{condicao}");

            if (contador >= a)
                break;

            contador += 2;
            indice++;
        }


    }




}
