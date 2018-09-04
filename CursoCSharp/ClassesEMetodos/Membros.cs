using System;

namespace CursoCSharp.ClassesEMetodos
{
	class Membros
	{
		public static void Executar()
		{
			Pessoa fulano = new Pessoa();
			fulano.Nome = "Renato";
			fulano.Idade = 21;

			//Console.WriteLine($"{fulano.Nome} tem {fulano.Idade} anos.");
			fulano.ApresentarNoConsole();

			var sicrano = new Pessoa();
			sicrano.Nome = "Beto";
			sicrano.Idade = 18;

			var apresentacaoDoSicrano = sicrano.Apresentar();
			Console.WriteLine(apresentacaoDoSicrano);

		}
	}
}
