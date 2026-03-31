using System;

class Program
{
    static void Main()
    {
       Console.WriteLine("digite a quantidade de herois que você quer adicionar (de 1 a 5)");
         int quantidade = int.Parse(Console.ReadLine());
         for (int i = 0; i < quantidade; i++)
         {
            Console.WriteLine($"Cadastro do heroi {i + 1}");
            CadastroHeroi();
         }
    }
    static void CadastroHeroi()
    {
       
    }
}