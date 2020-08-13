using System;

namespace arrays2 {
    class ExerciseFour {
        public static void Four(string[] args)
        {
            Console.WriteLine("\nExercício 4.\nDesenvolver um programa que efetue a leitura de cinco elementos de uma matriz A do tipo vetor.");
            Console.WriteLine("No final, apresente o total da soma de todos os elementos que sejam impares\n");


            const int arrayLenght = 5;

            var x = new double[arrayLenght];

            for (int i = 0; i < arrayLenght; i++) {
                Console.WriteLine($"Informe o {i + 1}º número da matriz");
                try {
                    x[i] = Double.Parse(Console.ReadLine());
                }
                catch (System.Exception) {
                    Console.WriteLine("Por favor informe um número válido.");
                }
            }

            Console.WriteLine("\nA matriz contém os seguintes valores: ");
            foreach (int value in x) Console.Write($"{value}, ");

            int sum = 0;
            foreach(int value in x){
                if (value % 2 != 0) sum += value;
            }
            Console.WriteLine($"\nA soma dos números ímpares do vetor é igual a {sum}");

            Console.ReadLine();
        }
    }
}