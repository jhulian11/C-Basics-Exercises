using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpFundamentals.ExerciciosV2
{
    class ExercicioV2_Files
    {
        public static void ExercicioV2_1()
        {
            var path = @"C:\Users\jhuli\Desktop\Teste_Prog.TXT";
            var text = File.ReadAllText(path);

            var arrayText = text.Trim('.').Split(' ');

            Console.WriteLine("The text is: {0} \nand it has {1} words.",text,arrayText.Length);
        }

        public static void ExercicioV2_2()
        {
            var path = @"C:\Users\jhuli\Desktop\Teste_Prog.TXT";
            var text = File.ReadAllText(path);

            var arrayText = text.Trim('.').Split(' ');
            var longestWord = arrayText[0];

            foreach (var item in arrayText)
            {
                if (item.Length > longestWord.Length)
                { 
                    longestWord = item;
                }
            }

            Console.WriteLine("The text is: {0} " +
                "\nand his longest word is {1} with {2} letters.", text, longestWord,longestWord.Length);
        }
    }
    
}
