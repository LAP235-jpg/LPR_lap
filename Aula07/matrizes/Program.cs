using System;
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            //criar a matriz 4x4
           int[,] numeros = new int[4,4] {

            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12},
            {13, 14, 15, 16}
           };
           Console.WriteLine("Matriz 4x4:");
           for (int i = 0; i < numeros.GetLength(0); i++)
           {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write(numeros[i, j] + "\t");
                }
                Console.WriteLine();
           }

           //digite um numero para mostrar a posição
            Console.WriteLine("digite um numero:");
            int linha = int.Parse(Console.ReadLine());
            Console.WriteLine("digite uma coluna:");
            int coluna = int.Parse(Console.ReadLine());
            
            Console.WriteLine("O numero na posição [" + linha + "," + coluna + "] é: " + numeros[linha, coluna]);   
            

        } 
    }
}