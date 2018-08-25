using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
	class VariaveisEConstantes
	{
		public static void Executar()
		{
			// área da circunferência
			double raio = 4.5;
			const double PI = 3.14;

			raio = 5.5;
			// PI = 3.1415;

			double area = PI * raio * raio;
			Console.WriteLine(area);
			Console.WriteLine("Área é " + area);

			// Tipos internos

			bool estaChovendo = true;
			Console.WriteLine("Está chovendo" + estaChovendo);

			byte idade = 45;
			Console.WriteLine("Idade" + idade);

			sbyte mostraMenorValorDoByte = sbyte.MinValue;
			Console.WriteLine("MinValue mostra o menor valor do tipo; menor valor de sbyte é " + mostraMenorValorDoByte);

			short maximoDeShort = short.MaxValue;
			Console.WriteLine("short máximo é " + maximoDeShort);

			int maximoDeInt = int.MaxValue;	//mais usado dos inteiros
			Console.WriteLine("int máximo é " + maximoDeInt);

			long maximoDeLong = long.MaxValue;
			Console.WriteLine("long máximo é " + maximoDeLong);

			uint intPositivo = uint.MaxValue; //inteiro sem sinal, somente positivo
			Console.WriteLine("int máximo " + intPositivo);

			uint populacaoBrasileira = 207_600_600;
			Console.WriteLine("População brasileira: " + populacaoBrasileira);

			long menorValorLong = long.MinValue;
			Console.WriteLine("long mínimo " + menorValorLong);

			ulong populacaoMundial = 7_600_000_000;
			Console.WriteLine("População mundial: " + populacaoMundial);

			float precoComputador = 1299.99f; //f ao final obrigatório para definir numeral do tipo float
			Console.WriteLine("Preço do computador: " + precoComputador);

			double valorDeMercadoDaApple = 1000000000000.99; //Mais usado dos reais!
			Console.WriteLine("Apple: " + valorDeMercadoDaApple);

			decimal distanciaEstrelas = decimal.MaxValue;
			Console.WriteLine("Estrelas: " + distanciaEstrelas);

			char letra = 'b';
			Console.WriteLine("Letra " + letra);

			string texto = "Seja bem vindo ao Curso de C#!";
			Console.WriteLine(texto);
		}
	}
}
