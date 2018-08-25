using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
		//Método Main é o método inicial do aplicativo
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
				{"Comentários - Fundamentos", Comentarios.Executar},
				{"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
				{"Inferência - Fundamentos", Inferencia.Executar},
				{"Interpolação - Fundamentos", Interpolacao.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}