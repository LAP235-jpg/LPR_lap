using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
             int interador = 0;
          Console.WriteLine("Digite a quantidade de numeros que serão digitados");
          int i = Convert.ToInt32(Console.ReadLine());
          double soma = 0;
            while (interador < i)
            {
                Console.WriteLine("Digite um numero de cada vez");
                int numero = Convert.ToInt32(Console.ReadLine());
                if(numero%2 == 0)
                {
                    soma = soma + numero;
                    interador++;
                    
                }
                else
                {
                    Console.WriteLine("O numero digitado é impar, digite um numero par");
                }
            }
            double media = soma / i;
            Console.WriteLine($"A media dos numeros digitados é {media}");


        }
    }
}