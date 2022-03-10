using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.ExerciciosV2
{
    class ExercicioV2_If_Else
    {
        public static void ExercicioV2_1()
        {

            Console.WriteLine("Enter a number between 1 and 10");
            var number = Int32.Parse(Console.ReadLine());

            if (number <= 10 && number >=1)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

        }

        public static void ExercicioV2_2()
        {
            Console.WriteLine("Enter your first Number: ");
            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your second Number: ");
            var number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
                Console.WriteLine(string.Format("The Firs number {0} is maximum", number1));
            else if (number2 > number1)
                Console.WriteLine(string.Format("The second number {0} is maximum", number2));
            else
                Console.WriteLine(string.Format("The First Number {0} and the Second Number {1} are equal", number1,number2));

        }

        public static void ExercicioV2_3()
        {
            Console.WriteLine("Enter the width of your image: ");
            var width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height  of your image: ");
            var height = int.Parse(Console.ReadLine());

           if (width > height)
                Console.WriteLine("Your image is a Landscape.");
           if (height > width)
                Console.WriteLine("Your image is a Portrait.");
        }

        public static void ExercicioV2_4()
        {
            Console.WriteLine("Enter the speed limit:");
            var spdLimit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car: ");
            var spd = int.Parse(Console.ReadLine());

            if(spd < spdLimit)
                Console.WriteLine("Ok");
            else
            {
                var dmPoints = 1 + ((spd - spdLimit) / 5);

                if(dmPoints <= 12)
                    Console.WriteLine(string.Format("You now have {0} demerit points be aware!!!",dmPoints));
                else
                    Console.WriteLine("License Suspended");
            }



        }
    }
}
