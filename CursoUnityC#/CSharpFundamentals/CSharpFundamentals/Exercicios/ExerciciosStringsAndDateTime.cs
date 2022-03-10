using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Exercicios
{
    class ExerciciosStringsAndDateTime
    {
        public static void Exercicio1()
        {
            Console.WriteLine("Enter a sequence of numbers separede by \"-\": ");
            var input = Console.ReadLine();
           // var arrayInputSplit = input.Split("-");
            var numbers = new List<int>();
            var consePosi = true;
            var conseNega = true;

            foreach (var numberString in input.Split("-"))
                numbers.Add(Convert.ToInt32(numberString));


            for (int i = 0; i < (numbers.Count - 1); i++)
            {
                if (numbers[i] == (numbers[i + 1] + 1))
                    continue;

                else { consePosi = false; break; }               
            }

            for (int i = 0; i < (numbers.Count - 1); i++)
            {
                if (numbers[i] == (numbers[i + 1] - 1))
                    continue;

                else { conseNega = false; break; }
            }

            if(consePosi == true || conseNega == true)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");





        }
        public static void Exercicio2()
        {
            // Da pra fazer usando duas listas para comparar a duplicada em vez de usar dois loops.
            Console.WriteLine("Enter a number separeted by \"-\" eg(1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;
            var listNumbers = new List<int>();

            foreach (var number in input.Split("-"))
                listNumbers.Add(Convert.ToInt32(number));

            for (int i = 0; i < listNumbers.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < listNumbers.Count; j++)
                {
                    if (listNumbers[i] == listNumbers[j])
                        count++;
                    if (count >= 2)
                        break;
                }
                if (count >= 2)
                {
                    Console.WriteLine("Duplicate");
                    break;
                }
            }           

            

        }
        public static void Exercicio3()
        {
            Console.Write("Enter a time in 24 hours format eg(19:00): ");
            var input = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            if (input.Split(":").Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var arrayTimes = new int[2];
            for (int i = 0; i < 2; i++)
            {
                arrayTimes[i] = Convert.ToInt32(input.Split(":")[i]);
            }

            if(arrayTimes[0] < 00 || arrayTimes[0] > 24 || arrayTimes[1] < 00 || arrayTimes[1] > 59)
                Console.WriteLine("Invalid Time");
            else
                Console.WriteLine("Ok");         
                  
        }
        public static void Exercicio4()
        {
            Console.WriteLine("Enter a few words separetade by space: ");
            var input = Console.ReadLine();
            var arrayWords = input.Split(" ");

            for (int i = 0; i < arrayWords.Length; i++)
                arrayWords[i] = char.ToUpper(arrayWords[i].First()) + arrayWords[i].Substring(1).ToLower();

            Console.WriteLine(String.Join("", arrayWords));
        }
        public static void Exercicio5()
        {
            Console.Write("Enter a English word: ");
            var input = Console.ReadLine().ToLower();

            var arrayVowels = new char[] {'a', 'e','i','o','u'};
            var count = 0;

            foreach (var letter in input)
            {
                for (int i = 0; i < arrayVowels.Length; i++)
                    if (letter == arrayVowels[i]) {count++; break;}                                  
            }
            Console.WriteLine(count);
        }
    }
}
