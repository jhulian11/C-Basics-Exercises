using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Exercicios
{
    class ExerciciosLoops
    {
        public static void Exercicio1()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) count++;
            }
            Console.WriteLine(count);
        }

        public static void Exercicio2()
        {
            var count = 0f;
            while(true)
            {
                Console.WriteLine("Enter a number or enter \"ok\" to finish the program: ");
                var input = Console.ReadLine();
                if (input == "ok") break;
                count += Convert.ToSingle(input);
            }
            Console.WriteLine(count);
        }
        public static void Exercicio3()
        {
            Console.Write("Enter a integer number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var input0 = input;

            for (int i = input - 1; i > 0 ; i--) input *= i;
                 
            Console.WriteLine("The Factorial of "+input0+" is "+ input);

        }
        public static void Exercicio4()
        {
            var random = new Random();
            int chances = 4;
            int numRand = random.Next(1,10);
            int numGuess;
            Console.WriteLine(numRand);
            Console.WriteLine("Try to guess te random number between 1 and 10!!");
            for (int i = 1; i <= chances; i++)
            {
                Console.Write("Enter your guess: ");
                numGuess = Convert.ToInt32(Console.ReadLine());

                if (numGuess == numRand)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                if (i == chances)
                {
                    Console.WriteLine("You Lost");
                }
            }
        }
        public static void Exercicio5()
        {
            Console.WriteLine("Enter a series of numbers separated by comma: ");
            var input = Console.ReadLine();

            var nums = input.Split(",");
            var numMax = Convert.ToInt32(nums[0]);

            foreach (var number in nums)
            {
                if (Convert.ToInt32(number) >= numMax) numMax = Convert.ToInt32(number);
            }

            Console.WriteLine("The Maximum number of your series is "+numMax);

        }
    }
}
