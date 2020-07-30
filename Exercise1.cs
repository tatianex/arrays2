using System;

namespace arrays2 {
    class ExerciseOne {
        public static void One(string[] args)
        {
            Console.WriteLine("Exercício 1.\nPopule dois vetores com 10 valores cada.");
            Console.WriteLine("Após esta operação troque o valor dos vetores.\n");

            double[] a = new double[10] {7.0, 8.5, 9, 9.5, 8, 10, 7.8, 7.5, 9.5, 10};
            double[] b = new double[10] {6.0, 6.5, 8, 7.5, 8, 8.5, 7.8, 7.5, 9, 9.5};
            double[] c = new double[10];

            Console.WriteLine("O primeiro array tem os seguintes elementos: ");
            foreach (double i in a) Console.Write($"{i}, ");
            Console.WriteLine("\n");
            Console.WriteLine("O segundo array tem os seguintes elementos: ");
            foreach (double i in b) Console.Write($"{i}, ");
            Console.Write("\n");

            for (int i = 0; i < 10; i++) c[i] = a[i];
            for (int j = 0; j < 10; j++) a[j] = b[j];
            for (int k = 0; k < 10; k++) b[k] = c[k];

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