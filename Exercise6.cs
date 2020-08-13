using System;

namespace arrays2 {
    class ExerciseSix {
        public static void Six(string[] args)
        {
            Console.WriteLine("Exercício 6.\nLer um vetor de 10 posições (aceitar somente números positivos).");
            Console.WriteLine("Escrever a seguir o valor do maior elemento de Q");
            Console.WriteLine("e a respectiva posição que ele ocupa no vetor.");
            
            int arrayLength = 3;
            var q = new double[arrayLength];
            double biggestValue = Double.MinValue;
            var input = "";

            for (int i = 0; i < arrayLength; i++) {
                var numberValid = false;
                while (!numberValid) {
                    Console.WriteLine($"Informe o {i + 1}º número positivo ou digite x para sair:");
                    if ((input == "x") && (input == "X")) break;
                    try {
                        var numberInformed = Double.Parse(Console.ReadLine());
                        if (numberInformed > 0) q[i] = numberInformed;
                        else i--;
                        break;
                    }
                    catch (System.Exception) {
                        Console.WriteLine("Por favor, informe um número válido.");
                    }
                }
            }

            var index = 0;

            for (int i = 0; i < arrayLength; i++) {
                if (q[i] > biggestValue) {
                    biggestValue = q[i];
                    index = i;
                }
            }

            Console.WriteLine("\n");
            foreach (int value in q) Console.Write($"{value}, ");
            Console.WriteLine($"\nO maior valor do array é {biggestValue} e sua posição no array é {index}");
            Console.ReadLine();
        }
    }
}