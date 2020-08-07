using System;
using System.Linq;

namespace arrays2 {
    class ExerciseTwo {
        public static void Two(string[] args)
        {
            Console.Write("\nExercício 2.\nDado um vetor qualquer com 10 números,");
            Console.WriteLine("faça um programa que informa se há ou não números repetidos nesse vetor.");

            const int arrayLenght = 10;

            var x = new double[arrayLenght];

            for (int i = 0; i < arrayLenght; i++) {
                Console.WriteLine($"Informe o {i + 1} número");
                x[i] = Double.Parse(Console.ReadLine());
            }

            if (x.Length != x.Distinct().Count()) Console.WriteLine("Este array contém números repetidos.");
            else Console.WriteLine("Este array não contém números repetidos.");

        }
    }
}