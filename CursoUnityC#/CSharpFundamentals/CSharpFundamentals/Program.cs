using System;
using CSharpFundamentals.Math;
using CSharpFundamentals.Exercicios;
using CSharp1Exercises.ArraysAndLists;
using System.Collections.Generic;
using CSharpFundamentals.ExerciciosV2;

namespace CSharpFundamentals
{
    public enum ShippingMethod 
    {
        RegularMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicios V2

            // If and Else

            //ExerciciosV2.ExercicioV2_If_Else.ExercicioV2_1();
            //ExerciciosV2.ExercicioV2_If_Else.ExercicioV2_2();
            //ExerciciosV2.ExercicioV2_If_Else.ExercicioV2_3();
            //ExerciciosV2.ExercicioV2_If_Else.ExercicioV2_4();

            // Loop and Random

            //ExerciciosV2.ExercicioV2_Loop_Random.ExercicioV2_1();
            //ExerciciosV2.ExercicioV2_Loop_Random.ExercicioV2_2();
            //ExerciciosV2.ExercicioV2_Loop_Random.ExercicioV2_3();
            //ExerciciosV2.ExercicioV2_Loop_Random.ExercicioV2_4();
            //ExerciciosV2.ExercicioV2_Loop_Random.ExercicioV2_5();

            // Arrays and Lists

            //ExerciciosV2.Array_and_Lists.ExercicioV2_1();
            //ExerciciosV2.Array_and_Lists.ExercicioV2_2();
            //ExerciciosV2.Array_and_Lists.ExercicioV2_3();
            //ExerciciosV2.Array_and_Lists.ExercicioV2_3();
            //ExerciciosV2.Array_and_Lists.ExercicioV2_4();
            //ExerciciosV2.Array_and_Lists.ExercicioV2_5();

            //Strings

            //ExerciciosV2.ExercicioV2_Strings.ExercicioV2_1();
            //ExerciciosV2.ExercicioV2_Strings.ExercicioV2_2();
            //ExerciciosV2.ExercicioV2_Strings.ExercicioV2_3();
            //ExerciciosV2.ExercicioV2_Strings.ExercicioV2_4();
            //ExerciciosV2.ExercicioV2_Strings.ExercicioV2_5();

            //Files
            //ExerciciosV2.ExercicioV2_Files.ExercicioV2_1();
            ExerciciosV2.ExercicioV2_Files.ExercicioV2_2();




            //Debuggin Learning










            //var exercicio = new Lists();
            // Exercicios 1 Conditionals
            // Exercicios.ExerciciosConditionals.Exercicio1();
            // Exercicios.ExerciciosConditionals.Exercicio2();
            // Exercicios.ExerciciosConditionals.Exercicio3();
            // Exercicios.ExerciciosConditionals.Exercicio4();

            // Exercicios 2 Array and Lists
            // Exercicios.ExerciciosLoops.Exercicio1();
            // Exercicios.ExerciciosLoops.Exercicio2();
            // Exercicios.ExerciciosLoops.Exercicio3();
            // Exercicios.ExerciciosLoops.Exercicio4();
            // Exercicios.ExerciciosLoops.Exercicio5();

            // Exercicios 3 Loops
            //Exercicios.ExerciciosArrayAndLists.Exercicio1();
            //Exercicios.ExerciciosArrayAndLists.Exercicio2();
            // Exercicios.ExerciciosArrayAndLists.Exercicio3Extra();
            //Exercicios.ExerciciosArrayAndLists.Exercicio3();
            //Exercicios.ExerciciosArrayAndLists.Exercicio4();
            //Exercicios.ExerciciosArrayAndLists.Exercicio5();
            //exercicio.Exercise5();

            // Exercicios 4 String and Date Time
            // Exercicios.ExerciciosStringsAndDateTime.Exercicio1();
            // Exercicios.ExerciciosStringsAndDateTime.Exercicio2();
            // Exercicios.ExerciciosStringsAndDateTime.Exercicio3();
            // Exercicios.ExerciciosStringsAndDateTime.Exercicio4();
            // Exercicios.ExerciciosStringsAndDateTime.Exercicio5();

            // Exercicios 5 File and Directories
            // Exercicios.ExerciciosFilesAndDirectories.Exercicio1();
            // Exercicios.ExerciciosFilesAndDirectories.Exercicio2();








            // Anotaçoes modulo 1
            /*
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a:{0}  b:{1}",a,b));
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array1[0] = 0;
            Console.WriteLine(string.Format("array1[0]:{0} array2[0]:{1}",array1[0],array2[0]));



            /*var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            Console.WriteLine(method.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);





            /*
            string firstName = "Mosh";
            var lastName = "Hamedani";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("My name is {0} {1}",firstName,lastName);

            var names = new string[3] {"John","Jack","Mary"};
            var formattedNames = string.Join(",",names);
           

            var text = "Hi John \nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(text);

            /*int[] numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            var names = new string[3] {"Jack","John","Mary"};

            /*Person john = new();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

            Calculator calculator = new();
            var result = calculator.Add(1,2);
            Console.WriteLine(result);*/
        }
    }
}
