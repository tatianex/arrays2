using System;

namespace arrays2 {
    class ExerciseNine {
        public static void Nine(string[] args)
        {
            Console.Write("\nExercício 9.\nCrie um vetor de strings de 10 posições");
            Console.Write(" onde cada posição recebe uma letra do alfabeto.");
            Console.Write("\nNo final, imprima a string resultante da soma das strings");
            Console.Write(" que residem em índices pares.\n");

            const int arrayLength = 10;
            var letters = new string [arrayLength];
            var stringSum = "";

            for (int i = 0; i < arrayLength; i++) {
                Console.WriteLine("\nInforme uma letra do alfabeto: ");
                letters[i] = Console.ReadLine().ToUpper();                
            }

            for (int i = 0; i < arrayLength; i++) {
                if (i % 2 == 0) stringSum += letters[i];
            }

            Console.WriteLine($"\n{stringSum}");
        }
    }
}