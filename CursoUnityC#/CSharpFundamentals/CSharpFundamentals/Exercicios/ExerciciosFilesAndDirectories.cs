using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFundamentals.Exercicios
{
    class ExerciciosFilesAndDirectories
    {
        public static void Exercicio1()
        {
            var path = @"D:\C#FundamentalsExerciseFilesAndFolders\C#Text.TXT";
            var text = File.ReadAllText(path);

            Console.WriteLine(text);
            Console.WriteLine("\nThis Text have {0} words in it.", text.Split(" ").Length);
            
        }
        public static void Exercicio2()
        {
            var path = @"D:\C#FundamentalsExerciseFilesAndFolders\C#Text.TXT";
            var text = File.ReadAllText(path);

            var arrayWords = text.Split(" ");
            string longestWord = "";

            foreach (var word in arrayWords)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine(text);
            Console.WriteLine("\nThe Longest word in this text is \"{0}\".", longestWord);

        }

    }
}
