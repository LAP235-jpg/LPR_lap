using System;

class Program5{
    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros pares:");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                Console.WriteLine(numeros[i]);
            }
        }

        Console.WriteLine("\nNúmeros ímpares:");
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] % 2 != 0)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}
