using System;

namespace arrays2 {
    class ExerciseSix {
        public static void Six(string[] args)
        {
            Console.WriteLine("Exercício 6.\nLer um vetor de 10 posições (aceitar somente números positivos).");
            Console.WriteLine("Escrever a seguir o valor do maior elemento de Q");
            Console.WriteLine("e a respectiva posição que ele ocupa no vetor.");
            
            int[] q = new int[10];
            int biggestValue = 0;
            int index = 0;
            int i = 0;
            int numberInformed = 0;

            while (i < 10) {
                Console.WriteLine($"Informe o {i + 1}º número positivo ou digite 0 para sair:");
                numberInformed = Convert.ToInt32(Console.ReadLine());
                if (numberInformed == 0) break;
                if (numberInformed > 0) {
                    q[i] = numberInformed;
                    i++;
                }
            }

            for (int j = 0; j < 10; j++){
                if (q[j] > biggestValue) {
                    biggestValue = q[j];
                    index = j;
                }
            }

            Console.WriteLine("\n");
            foreach (int value in q) Console.Write($"{value}, ");
            Console.WriteLine($"\nO maior valor do array é {biggestValue} e sua posição no array é {index}");
            Console.ReadLine();
        }
    }
}