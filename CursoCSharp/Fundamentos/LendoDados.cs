using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
	class LendoDados
	{
		public static void Executar()
		{
			Console.Write("Qual é o seu nome? ");
			string nome = Console.ReadLine();

			Console.Write("Qual é a sua idade? ");
			int idade = int.Parse(Console.ReadLine());
			// pega o resultado de Console.ReadLine, que é string, e converte em inteiro

			Console.Write("Qual é o se salário? ");
			double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			// 'Culture..' para não ter problema se utilizar ponto no decimal

			Console.WriteLine($"{nome} {idade} R${salario}");

		}
	}
}
