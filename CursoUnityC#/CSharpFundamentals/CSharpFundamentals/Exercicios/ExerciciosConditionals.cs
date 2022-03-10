using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Exercicios
{
    class ExerciciosConditionals
    {
        public static void Exercicio1()
        {
            Console.WriteLine("Write a number between 1 and 10: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0 && num < 11 )
            {
                Console.WriteLine("\nValid");
            }
            else
            {
                Console.WriteLine("\nInvalid");
            }
        }

        public static void Exercicio2()
        {
            Console.WriteLine("Write two numbers.");
            float num1 = Convert.ToInt32(Console.ReadLine());
            float num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("\n O Primeiro Numero " + num1 + " e maior que o Segundo Numero "+num2+".");
            }
            else
            {
                Console.WriteLine("\n O Segundo Numero " + num2 + " e maior que o Primeiro Numero " + num1 + ".");
            }

        }
        public static void Exercicio3()
        {
            Console.WriteLine("Write the width of the image: ");
            float width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write the heigth of the image: ");
            float height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("\n The image with this width and height is a Landscape.");
            }
            else if (height > width)
            {
                Console.WriteLine("\n The image with this width and height is a Portrait.");
            }

        }
        public static void Exercicio4()
        {
            int demeritPoints;
            Console.WriteLine("What is the limit speed in m/s ? ");
            float limitSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the car speed in m/s ? ");
            float carSpeed = Convert.ToInt32(Console.ReadLine());

            if(carSpeed <= limitSpeed)
            {
                Console.WriteLine("\nOk");

            }
            else
            {
                demeritPoints = (int)(carSpeed - limitSpeed)/5;

                if(demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("You recevied "+ demeritPoints +" Demerit Points."+"\nBe aware, if you have a toltal of 13 your license will be suspended.");
                }
            }
        }

    }

}
