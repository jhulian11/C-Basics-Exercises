using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ExerciciosV2
{
    class ExercicioV2_Loop_Random
    {
        public static void ExercicioV2_1()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }               
            }

            Console.WriteLine(count);
        }

        public static void ExercicioV2_2()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or type \"ok\" to end it:  ");
                var numString = Console.ReadLine();
              
                if (numString.ToLower() == "ok")              
                    break;

                var num = Convert.ToInt32(numString);
                sum += num;
            }

            Console.WriteLine(sum);
        }

        public static void ExercicioV2_3()
        {
            Console.WriteLine("Enter a number: ");
            var num = Convert.ToInt32(Console.ReadLine());
            var numFact = num;

            for (int i = num-1 ; i > 0; i--)
            {
                numFact *= i;
            }

            Console.WriteLine(string.Format("{0}! = {1}",num,numFact));
        }

        public static void ExercicioV2_4()
        {
            var random = new Random();
            var randNum = random.Next(1,10);
            var chances = 4;
            Console.WriteLine(randNum);

            while (true)
            {
                Console.WriteLine("Pick a number between 1 and 10 ");
                var num = Convert.ToInt32(Console.ReadLine());

                if (num == randNum)
                {
                    Console.WriteLine("You won !!!!");
                    break;
                }
                else 
                {
                    if (chances <= 0)
                    {
                        Console.WriteLine("You lost");
                        break;
                    }
                  
                    Console.WriteLine("Wrong Number !!!! Try again (You have "+ chances +" left)");
                    chances--;

                }
            }

        }
        public static void ExercicioV2_5()
        {
            Console.WriteLine("Enter a series of numbers separeted by comma.");
            var numberString = Console.ReadLine();
            var arrayString = numberString.Split(",");
            var numMax = Convert.ToInt32(arrayString[0]);

            foreach (var item in arrayString)
            {
                if (Convert.ToInt32(item) > numMax)
                {
                    numMax = Convert.ToInt32(item);
                }
            }

            Console.WriteLine(numMax);
        }



    }
}
