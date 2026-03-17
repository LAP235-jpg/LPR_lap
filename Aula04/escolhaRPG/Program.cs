using System;

namespace MyFirstApp
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("====== RPG =====");
            Console.WriteLine("escolha a sua classe");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Arqueiro");
            int classe = Convert.ToInt32(Console.ReadLine());
            switch (classe)  
            {
                case 1:
                    Console.WriteLine("Você escolheu a classe Guerreiro!");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a classe Mago!");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a classe Arqueiro!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
