using System;
namespace arrays {
    class arrays {
        public static void Main(string[] args)
        {
            int choice = 0;

            while(true){

                Console.WriteLine("\nEste projeto contém 6 Exercícios. \nDigite um número para ver a solução. \nDigite 0 para sair.\n");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice){
                    case 1:
                        ExerciseOne.One(null);
                        break;
                    case 2:
                        ExerciseTwo.Two(null);
                        break;
                     case 3:
                        ExerciseThree.Three(null);
                        break;
                    case 4:
                        ExerciseFour.Four(null);
                        break;
                    case 5:
                        ExerciseFive.Five(null);
                        break;
                    case 6:
                        ExerciseSix.Six(null);
                        break;
                    default:
                        break;
                }
                if(choice == 0){
                    break;
                }
            }
        }
    }
}