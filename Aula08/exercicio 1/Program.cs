// 1. Namespace Import
using System;

// 2. Namespace Declaration
namespace MyFirstApp
{
           public struct Filme{
             public string nome;
             public string diretor;
            public int ano;
           }
    // 3. Class Container
    class Program
    {
        // 4. Main Method (Entry Point)
        static void Main(string[] args)
        {
            Filme filme;
            Filme filme2;
            Filme filme3;

            Console.WriteLine("Digite o nome do filme: ");
            filme.nome = Console.ReadLine();
            Console.WriteLine("Digite o diretor do filme: ");
            filme.diretor = Console.ReadLine();
            Console.WriteLine("Digite o ano do filme: ");
            filme.ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do filme2: ");
            filme2.nome = Console.ReadLine();
            Console.WriteLine("Digite o diretor do filme2: ");
            filme2.diretor = Console.ReadLine();
            Console.WriteLine("Digite o ano do filme2: ");
            filme2.ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do filme3: ");
            filme3.nome = Console.ReadLine();
            Console.WriteLine("Digite o diretor do filme3: ");
            filme3.diretor = Console.ReadLine();
            Console.WriteLine("Digite o ano do filme3: ");
            filme3.ano = int.Parse(Console.ReadLine());
        
            Console.WriteLine("Filme 1: " + filme.nome + " - " + filme.diretor + " - " + filme.ano);
            Console.WriteLine("Filme 2: " + filme2.nome + " - " + filme2.diretor + " - " + filme2.ano);
            Console.WriteLine("Filme 3: " + filme3.nome + " - " + filme3.diretor + " - " + filme3.ano);

        }
    }
}