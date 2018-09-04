using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
	class FormatandoNumero
	{
		public static void Executar()
		{
			double valor = 15.175;
			Console.WriteLine(valor.ToString("F1")); // 1 digito decimal
			Console.WriteLine(valor.ToString("C")); // moeda corrente
			Console.WriteLine(valor.ToString("P"));
			Console.WriteLine(valor.ToString("#.##"));

			CultureInfo cultura = new CultureInfo("pt-BR");
			Console.WriteLine(valor.ToString("C0", cultura)); // moeda corrente 0 decimal

			int inteiro = 256;
			Console.WriteLine(inteiro.ToString("D10"));
		}
	}
}
