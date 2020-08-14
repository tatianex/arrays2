using System;
using System.Collections.Generic;

namespace arrays2 {
    class ExerciseSeven {
        public static void Seven(string[] args)
        {
            Console.WriteLine("Exercício 7.\nCrie e popule um vetor A.");
            Console.WriteLine("e imprima na tela o número de vezes que existe um número");
            Console.WriteLine("residindo na mesma posição do vetor que seu valor numérico.");

            List<double> numbers = new List<double>();

            string input = "";
            int numbersRepeated = 0;

            while (true) {
                Console.WriteLine("Informe um valor ou digite X para sair");
                input = Console.ReadLine().ToUpper();
                if (input != "X") {
                    try {
                        double number = Double.Parse(input);
                        numbers.Add(number);
                        if (numbers.IndexOf(number) == number) {
                            numbersRepeated++;
                        }
                    }
                    catch (System.Exception) {
                        Console.WriteLine("Por favor informe um número válido.");
                    }
                }        
                else break;    
            }
            Console.WriteLine($"\n{numbersRepeated} vezes o número digitado foi igual ao seu index no vetor.");
        }
    }
}