using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Exercicios
{
    class ExerciciosArrayAndLists
    {
        public static void Exercicio1()
        {
            var listOfFriends = new List<string>();
            while (true)
            {
                Console.Write("Enter a name of a Friend or enter empty to finish: ");
                var input = Console.ReadLine();
                if (input == "")
                {
                    switch (listOfFriends.Count)
                    {
                        case 0:
                            break;
                        case 1:
                            Console.WriteLine("Your Friend: " + listOfFriends[0] + " liked your photo.");
                            break;
                        case 2:
                            Console.WriteLine("Your Friends: " + listOfFriends[0] + " and " + listOfFriends[1] + " liked your photo.");
                            break;
                        case > 2:
                            Console.WriteLine("Your Friends: " + listOfFriends[0] + " , " + listOfFriends[1] + " and another " + (listOfFriends.Count - 2) + " Friends" + " liked your photo.");
                            break;
                    }
                    break;
                }
                listOfFriends.Add(input);
            }
        }

        public static void Exercicio2()
        {

            Console.Write("Enter your Name: ");
            var input = Console.ReadLine();
            var nameReverse = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
                nameReverse[i] = input[i];

            Array.Reverse(nameReverse);
            string nameReversed = new(nameReverse);
            Console.WriteLine("Your name reversed is: {0}", nameReversed);


        }
        public static void Exercicio3Extra()
        {
            bool whileRight = true;
            var arrayNumbers = new int[5];
            while (whileRight == true)
            {
                Console.Write("Enter Five Unique numbers: ");
                var numbers = Convert.ToInt32(Console.ReadLine());
                var newNumbers = numbers;

                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    arrayNumbers[i] = newNumbers % 10;
                    newNumbers = newNumbers / 10;
                }
                Array.Reverse(arrayNumbers);              
                for (int i = 0; i < arrayNumbers.Length; i++)
                {
                    int count = 0;
                    for (int j = 0; j < arrayNumbers.Length; j++)
                    {
                        if (arrayNumbers[i] == arrayNumbers[j])
                        {
                            count++;
                            if (count == 2)
                            {
                                Console.WriteLine("You Entered Not all Unique Numbers re-enter the numbers!!");
                                whileRight = true;
                                break;
                            }
                        }
                    }
                    if (count == 2)
                        break;
                    whileRight = false;
                }             
            }
            Array.Sort(arrayNumbers);
            foreach (var item in arrayNumbers)
            {
                Console.WriteLine(item);
            }
        }
        public static void Exercicio3()
        {
            var listNumeros = new List<int>();
            while (true) //(listNumeros.Count < 5)
            {
                Console.Write("Enter a number: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (listNumeros.Contains(input))
                    Console.WriteLine("You already entered this number try again ");
                     //continue;
                else 
                    listNumeros.Add(input);

                if (listNumeros.Count == 5)
                    break;
            }
            listNumeros.Sort();
            foreach (var item in listNumeros)
            {
                Console.WriteLine(item);
            }

        }
        public static void Exercicio4()
        {
            // Daria para fazer criando uma segunda lista em vez de remover na primeira
            var input = "";
            var listNumbers = new List<int>();
            while (true)
            {
                Console.Write("Enter a number or enter \"Quit\" to finish: ");
                input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                else
                {
                    if (listNumbers.Contains(Convert.ToInt32(input)))
                    {
                        for (int i = 0; i < listNumbers.Count; i++)
                        {
                            if (listNumbers[i] == Convert.ToInt32(input))
                                listNumbers.Remove(Convert.ToInt32(input));
                        }
                        continue;
                    }

                    else
                        listNumbers.Add(Convert.ToInt32(input));
                }
            }
            Console.WriteLine("Your Unique Numbers: ");
            foreach (var item in listNumbers)
            {
                Console.Write(item+" ");
            }
        }
        public static void Exercicio5()
        {
            while (true)
            {
              var listNums = new List<int>();
              Console.Write("Write a list of numbers separeted by comma (minimum of 5 numbers): ");
              var input = Console.ReadLine();
              var arrayNums = input.Split(",");
                if (String.IsNullOrEmpty(input) || arrayNums.Length < 5)
                {
                    Console.WriteLine("Invalid List!!!");
                    continue;
                }

              foreach (var item in arrayNums)
                    listNums.Add(Convert.ToInt32(item));
              
                listNums.Sort();
                Console.Write("The tree Smallest numbers are: ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(listNums[i]+" ");
                }
                Console.WriteLine("");
                break;
            }

        }
    }
}
