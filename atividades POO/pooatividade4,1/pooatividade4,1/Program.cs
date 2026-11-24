using System;

namespace Untitled
{

    class mfs
    {
        private string marca;
        private string modelo;
        private int ano;

        private int velocidade;

        public mfs(string marca, string modelo, int ano, int velocidade)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.velocidade = velocidade;
        }
    }
        

    internal class Program
    {
        static void Main(string[] args)
        {
            mfs aviao1 = new mfs("Boeing", "747", 2020, 900);
            mfs aviao2 = new mfs("Airbus", "A380", 2019, 950);
            Console.WriteLine("A velocidade do avião 1 é: " + aviao1.velocidade + " km/h");
            Console.WriteLine("A velocidade do avião 2 é: " + aviao2.velocidade + " km/h");
            
            Console.WriteLine("coloque nova velocidade do avião 1");
            aviao1.velocidade = int.Parse(Console.ReadLine());

            Console.WriteLine("coloque nova velocidade do avião 2");
            aviao2.velocidade = int.Parse(Console.ReadLine());

            Console.WriteLine("A nova velocidade do avião 1 é: " + aviao1.velocidade + " km/h");
            Console.WriteLine("A nova velocidade do avião 2 é: " + aviao2.velocidade + " km/h");

        }
    }
}
