using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int select = 0;
             int[] numeros = new int[10];
             int[] numeros2 = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
         



           Console.WriteLine("Digite qual numero você deseja achar");
           select = int.Parse(Console.ReadLine());
              for (int i = 0; i < numeros2.Length; i++)
              {
                if (numeros2[i] == select)
                {
                     Console.WriteLine("O numero " + select + " foi encontrado na posição " + i);
                     break;
                }
              }

        }
    }
}