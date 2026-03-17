using System;

namespace raul
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor1 = 0.00f;
            float valor2 = 0.00f;

            Console.WriteLine("digite o numero da peça");
            int peca = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a quantidade de peças");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor unico da peça");
            valor1 = float.Parse(Console.ReadLine());

             Console.WriteLine("digite o numero da 2¨ peça");
            int peca2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a quantidade de peças");
            int quantidade2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor unico da peça");
            valor2 = float.Parse(Console.ReadLine());

            Console.WriteLine("o valor total a ser pago é: " + ((quantidade * valor1) + (quantidade2 * valor2)));

            


        }
    }
}