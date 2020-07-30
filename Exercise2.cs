using System;
using System.Linq;

namespace arrays2 {
    class ExerciseTwo {
        public static void Two(string[] args)
        {
            Console.Write("Exercício 2.\nDado um vetor qualquer com 10 números,");
            Console.WriteLine("faça um programa que informa se há ou não números repetidos nesse vetor.");

            int[] ages = new int[10] {28, 44, 43, 55, 10, 58, 67, 63, 10, 71};

            if (ages.Length != ages.Distinct().Count()) Console.WriteLine("Contém duplicatas.");
            else Console.WriteLine("Não contém duplicatas.");

        }
    }
}