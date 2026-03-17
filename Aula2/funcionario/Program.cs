using System;

namespace funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            float ganho = 0.00f;

            Console.WriteLine("digite seu numero de funcionario");
            int fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite o numero de horas trabalhadas");
            int hor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("digite quanto ganha por hora");
            ganho = float.Parse(Console.ReadLine());

            Console.WriteLine($"NUMERO = {fnum}");
            Console.WriteLine();
            Console.WriteLine($"SALARY = {hor * ganho}");
        }
    }
}