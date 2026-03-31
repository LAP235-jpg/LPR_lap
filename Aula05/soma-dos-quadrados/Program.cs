using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("soma dos quadrados");
        Console.WriteLine("Digite o número:");
        int numero = Convert.ToInt32(Console.ReadLine());
        int somaQuadrados = numero * numero;
int soma = somaQuadrados
    .ToString()
    .Sum(c => int.Parse(c.ToString()));

Console.WriteLine($"Soma dos algarismos: {soma}");


    }
}