using System;
using System.ComponentModel.Design;

class Program

{
    static void Main()

    // a = 10
    // b = 20
    // c = (a + b) / 2
    // c = c-40
    // v [3] = a+b+c


    {
        int a;
        int b;
        int c;
        int[] v = new int[4];
        int i = 0;
        int indice = 0;

        Console.WriteLine("Qual o valor de a?");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Qual o valor de b?");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine("valor de c:");
        c = (a + b) / 2;

        Console.WriteLine(c);

        Console.WriteLine("valor de c depois de subtrair 40:");
        c = c - 40;

        Console.WriteLine(c);

        Console.WriteLine("valor do vetor:");
        v[3] = a + b + c;

        Console.WriteLine(v[3]);


        bool resultado = (indice >= 0 && indice >= 3);
        Console.WriteLine("o valor é menor que 3?: " + resultado);
    }

}
    

