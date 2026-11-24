using System;
namespace atividades_POO
{

class aluno 
{
    public string nome;
    public int idade;
    public int matricula;
    public int nota1;
    public int nota2;
    public int trabalho;



    public void media()
    {
        double media = (2.5 * (nota1 + nota2) + 2 * trabalho) / 3.0;
        Console.WriteLine($"A média do aluno {nome} é: {media}");
    }
    public void situacao()
    {
        double media = (2.5 * (nota1 + nota2) + 2 * trabalho) / 3.0;
        if (media >= 60)
        {
            Console.WriteLine($"O aluno {nome} está aprovado.");
        }
        else
        {
            Console.WriteLine($"O aluno {nome} precisa de {60 - media} para ser aprovado.");
        }
    }
}

class Program
{
	static void Main(string[] args)
	{
	  aluno aluno1 = new aluno();
        Console.WriteLine("Digite o nome do aluno:");
        aluno1.nome = Console.ReadLine();

        Console.WriteLine("Digite a idade do aluno:");
        aluno1.idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a matrícula do aluno:");
        aluno1.matricula = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 1 do aluno:");
        aluno1.nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2 do aluno:");
        aluno1.nota2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite a nota do trabalho do aluno:");
        aluno1.trabalho = int.Parse(Console.ReadLine());

        aluno1.media();
        aluno1.situacao();
	}
}
}