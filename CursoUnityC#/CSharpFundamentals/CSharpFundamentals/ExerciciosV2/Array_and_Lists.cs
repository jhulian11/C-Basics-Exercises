using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ExerciciosV2
{
    class Array_and_Lists
    {
        public static void ExercicioV2_1()
        {
            var people = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter a Name or enter blank to end the program : ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))                
                    break;
                
                people.Add(input);
            }

            switch (people.Count)
            {
                case 0:
                    Console.WriteLine("No one likes u");
                    break;

                case 1:
                    Console.WriteLine(people[0] + " likes your post.");
                    break;

                case 2:
                    Console.WriteLine(people[0] + " and "+ people[1] + " like your post.");
                    break;

                case >2:
                    Console.WriteLine(people[0] + "," + people[1] + " and "+ (people.Count-2)+" others like your post.");
                    break;
            }
        }

        public static void ExercicioV2_2()
        {
            Console.WriteLine("Enter Your Name: ");
            var name = Console.ReadLine();
            var nameArray = new char[name.Length];

            for (int i = 0; i < name.Length; i++)
                nameArray[i] = name[i];

            Array.Reverse(nameArray);

            var nameReverse = new String(nameArray);
            Console.WriteLine(nameReverse);           
        }

        public static void ExercicioV2_3()
        {
            var numbers = new List<int>();
            while (numbers.Count < 5)
            {
                Console.WriteLine("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine("Error, number already in, try another!!!");
                    continue;
                }
                numbers.Add(number);            
            }

            numbers.Sort();
            Console.WriteLine();

            foreach (var item in numbers)
                Console.WriteLine(item);
        }

        public static void ExercicioV2_4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a number or type \"Quit\" to exit. ");
                var numberString = Console.ReadLine();

                if (numberString.ToLower() == "quit" || string.IsNullOrEmpty(numberString))
                    break;

                var number = Convert.ToInt32(numberString);
                numbers.Add(number);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                var count = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if(numbers[i] == numbers[j])
                    {
                        count++;
                        if (count > 1)
                        {
                            numbers.Remove(numbers[j]);
                            count = 1;
                        }
                    }
                }
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

        }

        public static void ExercicioV2_5()
        {
            

            while (true)
            {
                Console.WriteLine("Enter a list o at least 5 numbers separetade by comma: ");
                var listString = Console.ReadLine();
                
                if (String.IsNullOrWhiteSpace(listString))
                {
                    Console.WriteLine("Invalid List");
                    Console.WriteLine();
                    continue;
                }

                var arrayString = listString.Split(",");

                if (arrayString.Length < 5)
                {
                    Console.WriteLine("Invalid List");
                    Console.WriteLine();
                    continue;
                }

                var arrayInt = new int[arrayString.Length];

                for (int i = 0; i < arrayString.Length; i++)
                {
                    arrayInt[i] = Convert.ToInt32(arrayString[i]);
                }

                Array.Sort(arrayInt);

                Console.WriteLine("The 3 smallests numbers are {0}, {1} and {2}.",arrayInt[0],arrayInt[1],arrayInt[2]);
                break;
            }

        }


    }
}
