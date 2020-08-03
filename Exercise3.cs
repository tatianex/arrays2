using System;

namespace arrays2 {
    class ExerciseThree {
        public static void Three(string[] args)
        {
            Console.WriteLine(String.Join(
                Environment.NewLine,
                "Exercício 3.\nUma certa empresa fez uma pesquisa para saber se as pessoas gostaram",
                "ou não de um novo produto lançado no mercado.",
                "Para isso, forneceu-se o sexo do entrevistado e a sua resposta (sim ou não).",
                "Sabendo-se que foram entrevistadas 10 pessoas,",
                "fazer um algoritmo que calcule e escreva:",
                "O número de pessoas que responderam sim;",
                "O número de pessoas que responderam não;",
                "A percentagem de pessoas do sexo feminino que responderam sim;",
                "A percentagem de pessoas do sexo masculino que responderam não;"
            ));

            string[,] poll = new string[10,2] {
                {"F", "S"}, 
                {"M", "S"}, 
                {"F", "N"},
                {"M", "N"},
                {"F", "S"},
                {"M", "S"},
                {"F", "N"},
                {"F", "N"},
                {"F", "S"},
                {"M", "S"}
            };
            
            int positiveAnswers = 0;
            int negativeAnswers = 0;
            int totalWomemYes = 0;
            int totalMenNo = 0;

            for (int i = 0; i < 10; i++) {
                if (poll[i, 1] == "S") positiveAnswers++;
                else negativeAnswers++;
            }

            for (int i = 0; i < 10; i++) {
                if ((poll[i, 0] == "F") && (poll[i, 1] == "S")) totalWomemYes++;
                if ((poll[i, 0] == "M") && (poll[i, 1] == "N")) totalMenNo++;
            }

            double percentageWY = ((Convert.ToDouble(totalWomemYes) / 10) * 100);
            double percentageMN = ((Convert.ToDouble(totalMenNo) / 10) * 100);

            Console.WriteLine($"\n\nObtivemos {positiveAnswers} respostas positivas.");
            Console.WriteLine($"Obtivemos {negativeAnswers} respostas negativas.");
            Console.WriteLine($"{percentageWY}% de mulheres responderam sim.");
            Console.WriteLine($"{percentageMN}% de homens responderam não.");

            Console.ReadLine();
        }
    }
}