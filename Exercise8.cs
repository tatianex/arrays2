using System;

namespace arrays2 {
    class ExerciseEight {
        public static void Eigth(string[] args)
        {
            Console.Write("\nExercício 8.\nCrie um vetor de strings de 10 posições");
            Console.Write("onde cada posição recebe uma letra do alfabeto.");
            Console.WriteLine("No final, imprima quantas destas são vogais");

            const int arrayLength = 10;
            var letters = new string [arrayLength];
            var vowels = 0;

            for (int i = 0; i < arrayLength; i++) {
                Console.WriteLine("Informe uma letra do alfabeto: ");
                letters[i] = Console.ReadLine().ToUpper();
                if ((letters[i] == "A") || 
                    (letters[i] == "E") ||
                    (letters[i] == "I") ||
                    (letters[i] == "O") ||
                    (letters[i] == "U")
                ) vowels++;
            }

            Console.WriteLine($"{vowels} letras do array são vogais.");
            Console.ReadLine();
        }
    }
}