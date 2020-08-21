using System;
using System.Collections.Generic;

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

            var respondents = new List<(string Gender, string Answer)> {};            
            
            int positiveAnswers = 0;
            int negativeAnswers = 0;
            int totalWomem = 0;
            int totalWomemYes = 0;
            int totalMen = 0;
            int totalMenNo = 0;

            const int totalRespondents = 6;


            for (int i = 0; i < totalRespondents; i++) {
                var gender = "";
                var answer = "";
                while (true) {
                    Console.WriteLine($"\nRESPONDENTE {i + 1}");

                    Console.WriteLine("Informe seu gênero F/M: ");
                    gender = Console.ReadLine().ToUpper();
                    if (gender == "F") {
                        totalWomem++;
                        break;
                    }
                    else if (gender == "M") {
                        totalMen++;
                        break;
                    }
                }
                while (true) {
                    Console.WriteLine("Informe sua resposta S/N: ");
                    answer = Console.ReadLine().ToUpper();
                    if (answer == "S") {
                        positiveAnswers++;
                        break;
                    }
                    else if (answer == "N") {
                        negativeAnswers++;
                        break;
                    }
                }
                respondents.Add((gender, answer));
            }

            Console.WriteLine("\nRESPOSTAS");

            for (int i = 0; i < respondents.Count; i++) 
                Console.WriteLine($"Gênero: {respondents[i].Gender}, Resposta: {respondents[i].Answer}");

            /* for (int i = 0; i < respondents.Count; i++) {
                if (respondents[i].Answer == "S")
                    positiveAnswers++;
                else if (respondents[i].Answer == "N")
                    negativeAnswers++;
            } */

            for (int i = 0; i < respondents.Count; i++) {
                if ((respondents[i].Gender == "F") && (respondents[i].Answer == "S"))
                    totalWomemYes++;
                if ((respondents[i].Gender == "M") && (respondents[i].Answer == "N"))
                    totalMenNo++;
            }

            double percentageWY = ((Convert.ToDouble(totalWomemYes * 100) / totalWomem));
            double percentageMN = ((Convert.ToDouble(totalMenNo * 100) / totalMen));

            Console.WriteLine("\nESTATÍSTICAS");
            Console.WriteLine($"\n\nObtivemos {positiveAnswers} respostas positivas.");
            Console.WriteLine($"Obtivemos {negativeAnswers} respostas negativas.");
            Console.WriteLine(String.Format("{0:0.00}% de mulheres responderam sim.", percentageWY));
            Console.WriteLine(String.Format("{0:0.00}% de homens responderam não.", percentageMN));

            Console.ReadLine();
        }
    }
}