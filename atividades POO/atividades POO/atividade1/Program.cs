using System;
namespace atividades_POO
{
class funcionario
{
    public string nome;
    public int salario;
    public int inposto;

   public void calcularImposto()
    {
        if (salario <= 1000)
        {
            inposto = 0;
        }
        else if (salario > 1000 && salario <= 2000)
        {
            inposto = (int)(salario * 0.1);
        }
        else if 
(salario > 2000 && salario <= 3000)
        {
            inposto = (int)(salario * 0.15);
        }
        else
        {
            inposto = (int)(salario * 0.2);
        }
    }
  
}
class Program
{
	static void Main(string[] args)
	{
	  funcionario f = new funcionario();
      Console.WriteLine("Digite o nome do funcionário: ");
      f.nome = Console.ReadLine();
      Console.WriteLine("Digite o salário do funcionário: ");
      f.salario = int.Parse(Console.ReadLine());
      f.calcularImposto();
      Console.WriteLine($"O imposto do funcionário {f.nome} é: {f.inposto}");
	}
}
}