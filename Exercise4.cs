using System;

namespace arrays2 {
    class ExerciseFour {
        public static void Four(string[] args)
        {
            Console.WriteLine("Exercício 4.\nDesenvolver um programa que efetue a leitura de cinco elementos de uma matriz");
            Console.WriteLine("A do tipo vetor. No final, apresente o total da soma de todos os elementos que sejam impares");

            int[] a = new int[5] {45, 9, 14, 6, 29};

            foreach (int value in a) Console.Write($"{value}, ");

            int sum = 0;
            foreach(int value in a){
                if (value % 2 != 0) sum += value;
            }
            Console.WriteLine($"\nA soma dos números ímpares do vetor é igual a {sum}");

            Console.ReadLine();
        }
    }
}