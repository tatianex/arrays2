using System;

namespace arrays2 {
    class ExerciseFive {
        public static void Five(string[] args)
        {
            Console.WriteLine("\nExercício 5.\nContar quantos valores de um vetor de 10 posições são positivos.\n");

            const int arrayLenght = 10;

            var x = new double[arrayLenght];

            for (int i = 0; i < arrayLenght; i++) {
                Console.WriteLine($"Informe o {i + 1}º número do vetor");
                try {
                    x[i] = Double.Parse(Console.ReadLine());
                }
                catch (System.Exception) {
                    Console.WriteLine("Por favor infome um valor válido.");
                }
            }

            Console.WriteLine("\n");

            foreach (int value in x) Console.Write($"{value}, ");

            double totalPositive = 0d;
            foreach (int value in x) {
                if (value > 0) totalPositive++;
            }
            Console.Write($"\nO array contém {totalPositive} número(s) positivo(s).");
            Console.ReadLine();
        }
    }
}