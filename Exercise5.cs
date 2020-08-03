using System;

namespace arrays2 {
    class ExerciseFive {
        public static void Five(string[] args)
        {
            Console.WriteLine("Exercício 5.\nContar quantos valores de um vetor de 10 posições são positivos.\n");

            int[] a = new int[10] {-15, 10, -4, 48, -57, 9, -23, -31, 21, -6};

            foreach (int value in a) Console.Write($"{value}, ");

            int totalPositive = 0;
            foreach (int value in a) {
                if (value > 0) totalPositive++;
            }
            Console.Write($"\nO array contém {totalPositive} números positivos.");
            Console.ReadLine();
        }
    }
}