using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp {
    class Program {
		//Método Main é o método inicial do aplicativo
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
				// Fundamentos
				{ "Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
				{"Comentários - Fundamentos", Comentarios.Executar},
				{"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
				{"Inferência - Fundamentos", Inferencia.Executar},
				{"Interpolação - Fundamentos", Interpolacao.Executar},
				{"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
				{"Formatando Número - Fundamentos", FormatandoNumero.Executar},
				{"Conversões - Fundamentos", Conversoes.Executar},
				{"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
				{"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
				{"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
				{"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
				{"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
				{"Operador Ternário - Fundamentos", OperadorTernario.Executar},

				// Estruturas de Controle
				{ "Estrutura If - Estruturas de Contole", EstruturaIf.Executar},
				{ "Estrutura Switch - Estruturas de Contole", EstruturaSwitch.Executar},
				{ "Estrutura While - Estruturas de Contole", EstruturaWhile.Executar},
				{ "Estrutura Do While - Estruturas de Contole", EstruturaDoWhile.Executar},
				{ "Estrutura For - Estruturas de Contole", EstruturaFor.Executar},
				{ "Estrutura ForEach - Estruturas de Contole", EstruturaForEach.Executar},

				// Classe e Métodos
				{ "Membros - Classes e Métodos", Membros.Executar},
			});

            central.SelecionarEExecutar();
        }
    }
}