using System;

namespace arrays2 {
    class ExerciseOne {
        public static void One(string[] args)
        {
            Console.WriteLine("\nExercício 1.\nPopule dois vetores com 10 valores cada.");
            Console.WriteLine("Após esta operação troque o valor dos vetores.\n");

            const int arraysLenght = 10;

            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];

            for (int i = 0; i < arraysLenght; i++) {
                Console.WriteLine($"Informe o {i + 1}º número da primeira lista");
                a[i] = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (int i = 0; i < arraysLenght; i++) {
                Console.WriteLine($"Informe o {i + 1} número da segunda lista");
                b[i] = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nO primeiro array tem os seguintes elementos: ");
            foreach (double i in a) Console.Write($"{i}, ");

            Console.WriteLine("\n");

            Console.WriteLine("O segundo array tem os seguintes elementos: ");
            foreach (double i in b) Console.Write($"{i}, ");

            Console.Write("\n");

            for (int i = 0; i < arraysLenght; i++) c[i] = a[i];
            for (int j = 0; j < arraysLenght; j++) a[j] = b[j];
            for (int k = 0; k < arraysLenght; k++) b[k] = c[k];

            Console.WriteLine("\nAgora o primeiro array tem os seguintes elementos: ");
            foreach (double i in a) Console.Write($"{i}, ");

            Console.WriteLine("\n");

            Console.WriteLine("Agora o segundo array tem os seguintes elementos: ");
            foreach (double i in b) Console.Write($"{i}, ");

            Console.Write("\n");

            Console.ReadLine();
        }
    }
}