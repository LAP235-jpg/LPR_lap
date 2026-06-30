// 1. Namespace Import
using System;

// 2. Namespace Declaration
namespace MyFirstApp
{
    public struct Produto
    {
        public string nome;
        public int codigo;
        public double preco;
        public int quantidade;
    }
    // 3. Class Container
    class Program
    {
        // 4. Main Method (Entry Point)
        static void Main(string[] args)
        {
            // 5. Statements and Expressions
            Produto[] produto = new Produto[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                produto[i].nome = Console.ReadLine()?? "";
                Console.WriteLine("Digite o código do produto: ");
                produto[i].codigo = int.Parse(Console.ReadLine()?? "0");
                Console.WriteLine("Digite o preço do produto: ");
                produto[i].preco = double.Parse(Console.ReadLine()?? "0");
                Console.WriteLine("Digite a quantidade do produto: ");
                produto[i].quantidade = int.Parse(Console.ReadLine()?? "0");

                Console.WriteLine("Produto " + (i + 1) + ": " + produto[i].nome + " - " + produto[i].codigo + " - " + produto[i].preco + " - " + produto[i].quantidade);
            }

               Console.WriteLine($"Valor total do estoque: {produto[0].preco * produto[0].quantidade + produto[1].preco * produto[1].quantidade + produto[2].preco * produto[2].quantidade}");
        }
    }
}
