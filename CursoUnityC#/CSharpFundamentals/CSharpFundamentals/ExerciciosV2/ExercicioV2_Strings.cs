using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ExerciciosV2
{
    class ExercicioV2_Strings
    {

        public static void ExercicioV2_1()
        {
            Console.WriteLine("Enter a few numbers separated by hyphen.");
            var input = Console.ReadLine();

            var array = input.Split("-");

            var arrayInt = new int[array.Length];

            for (int i = 0; i < arrayInt.Length; i++)           
                arrayInt[i] = Convert.ToInt32(array[i]);

            Array.Sort(arrayInt);
            var consecutive = false;

            for (int i = 0; i < arrayInt.Length -1; i++)
            {
                if (arrayInt[i] + 1 == arrayInt[i + 1])
                    consecutive = true;
                else
                {
                    consecutive = false;
                    break;
                }
            }

            if (consecutive == true)
                Console.WriteLine("Consecutive");
            else
                Console.WriteLine("Not Consecutive");        
        }

        public static void ExercicioV2_2()
        {
            Console.WriteLine("Enter a few numbers separated by hyphen.");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
                return;
            var array = input.Split("-");
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                count = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        count++;

                    if (count >= 2)
                        break;                   
                }
                if (count >= 2)
                   break;
            }

            if (count >= 2)
                Console.WriteLine("Duplicate"); 

            else
                Console.WriteLine("Not Duplicate");
        }
        public static void ExercicioV2_3()
        {
            Console.WriteLine("Enter a time value in a 24 hours format (E.g 19:00)");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input) || input.Split(":").Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var numbers = new List<int>();

            foreach (var item in input.Split(":"))
                numbers.Add(Convert.ToInt32(item));
            
            var isTimeValid = false;

            if (numbers[0] <= 23 && numbers[0] >= 00 && numbers[1] <= 59 && numbers[1] >= 00)
                isTimeValid = true;

            if(isTimeValid == true)
                Console.WriteLine("Ok");
            else
                Console.WriteLine("Invalid Time");
        }

        public static void ExercicioV2_4()
        {
            Console.WriteLine("Enter words separeted by space");
            var input = Console.ReadLine().ToLower().Trim();

            var array = input.Split(" ");
            var list = new List<string>();          

            for (int i = 0; i < array.Length; i++)
            {
                var charArray = array[i].ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);

                list.Add(new string(charArray));
            }

            var final = string.Join("", list);
            Console.WriteLine(final);
        }

        public static void ExercicioV2_5()
        {
            Console.WriteLine("Enter a english word.");
            var input = Console.ReadLine().ToLower();

            var charArray = input.ToCharArray();
            var count = 0;
            var vogals = new char[] {'a','e','i','o','u'};

            for (int i = 0; i < charArray.Length; i++)
            {
                for (int j = 0; j < vogals.Length; j++)
                {
                    if (charArray[i] == vogals[j])
                        count++;
                }
            }

            Console.WriteLine("Your word have {0} vogals", count);


        }


    }
}
