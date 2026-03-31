using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int tentativa = 0;
          Console.WriteLine("algoritimo de adivinhação");
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);
            Console.WriteLine("digite um numero para a maquina verificar");
            do
            {
                
                tentativa = Convert.ToInt32(Console.ReadLine());
                if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("o numero secreto é maior");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("o numero secreto é menor");
                }
                else
                {
                    Console.WriteLine("parabens voce acertou o numero secreto");
                }

            }while( numeroSecreto != tentativa );

        
        }
    }
}